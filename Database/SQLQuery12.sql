USE [BookstoreManager]
GO
/****** Object:  StoredProcedure [dbo].[addBookIntoBooksReceiptNote]    Script Date: 5/15/2018 11:30:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[addBookIntoBooksReceiptNote]
@identifier int,
@count int,
@dateCreate datetime,
@inventoryCount int
AS
BEGIN
	DECLARE @booksReceiptNoteId int,
			@bookId int;

	SELECT @bookId = MaSach FROM SACH WHERE MaDinhDanh = @identifier

	SELECT @booksReceiptNoteId = SCOPE_IDENTITY();

	INSERT INTO CTPN (MaSach, MaPhieuNhap, SoLuong)
	VALUES ((SELECT MaSach FROM SACH WHERE MaDinhDanh = @identifier), @booksReceiptNoteId, @count)

	DECLARE @inventoryReportMonth datetime
	SELECT @inventoryReportMonth = ThoiGian FROM THONGTINTONKHO WHERE (MONTH(ThoiGian) = MONTH(@dateCreate)) AND (YEAR(ThoiGian) = YEAR(@dateCreate)) AND MaSach = @bookId
	IF (@inventoryReportMonth IS NULL)
	BEGIN

	INSERT INTO THONGTINTONKHO (ThoiGian, TonDau, TonPhatSinh, TonCuoi, MaSach)
	VALUES (@dateCreate, 0, 0, 0, (SELECT MaSach FROM SACH WHERE MaDinhDanh = @identifier))

	DECLARE @inventoryOfLastMonth int
	SELECT DISTINCT @inventoryOfLastMonth = TonCuoi FROM THONGTINTONKHO
	WHERE ThoiGian = (SELECT MAX(ThoiGian) FROM THONGTINTONKHO WHERE @bookId = MaSach)

	IF (@inventoryOfLastMonth IS NOT NULL)
		UPDATE THONGTINTONKHO
		SET TonDau = @inventoryOfLastMonth
		WHERE MaSach = @bookId;

	IF (((@inventoryCount = 0) AND @inventoryOfLastMonth IS NULL) OR @inventoryCount = @inventoryOfLastMonth)
		UPDATE THONGTINTONKHO 
		SET TonPhatSinh = 0, TonCuoi = @inventoryCount
		WHERE MaChiTietTon = SCOPE_IDENTITY();

	UPDATE THONGTINTONKHO
	SET TonPhatSinh = TonPhatSinh + @count, TonCuoi = TonCuoi + @count
	WHERE MaChiTietTon = SCOPE_IDENTITY();

	UPDATE SACH
	SET SoLuongTon = SoLuongTon + @count
	WHERE MaDinhDanh = @identifier;
	END

	ELSE
	BEGIN
	DECLARE @inventoryReportId int
	SELECT @inventoryReportId = MaChiTietTon FROM THONGTINTONKHO
	WHERE (MONTH(ThoiGian) = MONTH(@dateCreate)) AND (YEAR(ThoiGian) = YEAR(@dateCreate)) AND MaSach = @bookId

	UPDATE THONGTINTONKHO
	SET TonPhatSinh = TonPhatSinh + @count, TonCuoi = TonCuoi + @count
	WHERE MaChiTietTon = @inventoryReportId

	UPDATE SACH
	SET SoLuongTon = SoLuongTon + @count
	WHERE MaDinhDanh = @identifier;
	END
	
END

EXEC addBookIntoBooksReceiptNote @identifier = 1015, @count = 15, @dateCreate = '11/2/2016', @inventoryCount = 10