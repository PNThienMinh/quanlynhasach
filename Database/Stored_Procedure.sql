-- check if 'TAIKHOAN' is exists
CREATE PROC validateAccount
@Username varchar(255) = NULL
AS 
SELECT * FROM TAIKHOAN WHERE TenDangNhap = @Username


-- create new 'NHANVIEN' with the given infomation
CREATE PROC createStaff
@Name nvarchar(100),
@Sex nvarchar(100),
@Birth date,
@NID varchar(20),
@Email varchar(100),
@PhoneNum varchar(15),
@IDFunc int,
@Username varchar(255),
@Password varchar(255)
AS
BEGIN
	DECLARE	@NewAccountID int;
	SELECT @NewAccountID = TAIKHOAN.ID FROM TAIKHOAN WHERE TAIKHOAN.TenDangNhap = @Username
	IF (@NewAccountID IS NULL)
		BEGIN INSERT INTO TAIKHOAN VALUES (@Username, @Password)
		SELECT @NewAccountID = SCOPE_IDENTITY();
		END

		INSERT INTO NHANVIEN VALUES (@Name, @Sex, @Birth, @NID, @Email, @PhoneNum, @NewAccountID, @IDFunc)
END



-- get User with username and password input
CREATE PROC getUser
@Username varchar(255),
@Password varchar(255)
AS
BEGIN
	SELECT S.HoTen, S.GioiTinh, S.NgaySinh, S.CMND, S.Email, S.SDT, F.MaCV, F.TenChucVu, S.MaNV
	FROM (NHANVIEN S INNER JOIN TAIKHOAN A ON S.ID = A.ID) INNER JOIN CHUCVU F ON F.MaCV = S.MaCV
	WHERE TenDangNhap = @Username  AND MatKhau = @Password
END


-- get all 'NHANVIEN' infomation
CREATE PROC getAllUsers
AS
BEGIN
		SELECT S.HoTen, S.GioiTinh, S.NgaySinh, S.CMND, S.Email, S.SDT, F.MaCV, F.TenChucVu, A.TenDangNhap, A.MatKhau, S.MaNV
	FROM (NHANVIEN S INNER JOIN TAIKHOAN A ON S.ID = A.ID) INNER JOIN CHUCVU F ON F.MaCV = S.MaCV
END





-- delete staff with @username
CREATE PROC deleteUser
@username varchar(255)
AS
BEGIN
	DELETE FROM NHANVIEN WHERE (SELECT ID FROM TAIKHOAN WHERE TenDangNhap = @username) = NHANVIEN.ID;
	DELETE FROM TAIKHOAN WHERE TenDangNhap = @username
END

CREATE PROC getAllFunc
AS
BEGIN
	SELECT * FROM CHUCVU
END

-- update staff's information
CREATE PROC updateUser
@userID int,
@name nvarchar(100),
@sex nvarchar(15),
@birth date,
@email varchar(100),
@UID varchar(20),
@phone varchar(15),
@funcId int,
@username varchar(255),
@password varchar(255)
AS
BEGIN
	
	UPDATE NHANVIEN
	SET HoTen = @name, GioiTinh = @sex, NgaySinh = @birth, CMND = @UID, Email = @email, SDT = @phone, MaCV = @funcId
	WHERE MaNV = @userID
	IF (@password != '')
	BEGIN
	UPDATE TAIKHOAN 
	SET MatKhau = @password
	WHERE TenDangNhap = @username
	END
END

-- 


CREATE PROC addBook
@bookId int,
@bookName nvarchar(MAX),
@bookType nvarchar(MAX),
@datePublished datetime,
@price money,
@authorName nvarchar(100),
@publisher nvarchar(100)
AS
BEGIN

DECLARE	@NewPublisherId int,
		@NewAuthorId int;
		
	SELECT @NewPublisherId = NHAXUATBAN.MaNXB FROM NHAXUATBAN WHERE NHAXUATBAN.TenNXB = @publisher
	IF (@NewPublisherId IS NULL)
		BEGIN INSERT INTO NHAXUATBAN VALUES (@publisher, null)
		SELECT @NewPublisherId = SCOPE_IDENTITY();
		END

	SELECT @NewAuthorId = TACGIA.MaTG FROM TACGIA WHERE TACGIA.TenTG = @authorName
	IF (@NewAuthorId IS NULL)
		BEGIN INSERT INTO TACGIA VALUES (@authorName, null)
		SELECT @NewAuthorId = SCOPE_IDENTITY();
		END

		
		INSERT INTO SACH (TenSach, TheLoai, NgayXuatBan, DonGiaNhap, MaTG, MaNXB, MaDinhDanh)
		VALUES (@bookName, @bookType, @datePublished, @price, @NewAuthorId, @NewPublisherId, @bookId)
		
END

CREATE PROC getAllBooks
AS
BEGIN
	SELECT TenSach, TheLoai, NgayXuatBan, DonGiaNhap, MaDinhDanh, TenTG, TenNXB, SoLuongTon
	FROM SACH, TACGIA, NHAXUATBAN 
	WHERE SACH.MaTG = TACGIA.MaTG AND SACH.MaNXB = NHAXUATBAN.MaNXB
END

CREATE PROC getStockContract
AS
BEGIN
SELECT SoLuongNhapItNhat, SoLuongTonToiDaTruocNhap
FROM THAMSOQUYDINH
END

CREATE PROC changeStockContract
@minImport int,
@maxInventory int
AS
BEGIN
UPDATE THAMSOQUYDINH
SET SoLuongNhapItNhat = @minImport, SoLuongTonToiDaTruocNhap = @maxInventory
END
