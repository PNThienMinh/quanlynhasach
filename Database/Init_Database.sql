CREATE TABLE TAIKHOAN
(
	ID int identity(10000,1),
	TenDangNhap varchar(255) NOT NULL,
	MatKhau varchar(255) NOT NULL,

	constraint PK_TAIKHOAN primary key (ID)
)

CREATE TABLE CHUCVU
(
	MaCV int identity(10000,1),
	TenChucVu nvarchar(255) NOT NULL,
	Mota nvarchar(255),

	constraint PK_CHUCVU primary key (MaCV)

)

CREATE TABLE NHANVIEN
(
	MaNV int identity(10000,1),
	HoTen nvarchar(100) NOT NULL,
	GioiTinh nvarchar(100) NOT NULL,
	NgaySinh datetime NOT NULL,
	CMND varchar(20) NOT NULL,
	Email varchar(100) NOT NULL,
	SDT varchar(15) NOT NULL,
	ID int NOT NULL,
	MaCV int NOT NULL,

	constraint PK_NHANVIEN primary key (MaNV),
	constraint FK_NHANVIEN_TAIKHOAN foreign key (ID) references TAIKHOAN(ID),
	constraint FK_NHANVIEN_CHUCVU foreign key (MaCV) references CHUCVU(MaCV)

)

CREATE TABLE TACGIA
(
	MaTG int identity(10000,1),
	TenTG nvarchar(100) NOT NULL,
	ThongTinTG nvarchar(1000),

	constraint PK_TACGIA primary key (MaTG)
)

CREATE TABLE NHAXUATBAN
(
	MaNXB int identity(10000,1),
	TenNXB nvarchar(100) NOT NULL,
	ThongTinNXB nvarchar(1000),

	constraint PK_NHAXUATBAN primary key (MaNXB)
)

CREATE TABLE SACH
(
	MaSach int identity(1000,1),
	TenSach nvarchar(255) NOT NULL,
	TheLoai nvarchar(100) NOT NULL,
	NgayXuatBan datetime NOT NULL,
	DonGiaNhap money NOT NULL,
	MaTG int NOT NULL,
	MaNXB int NOT NULL,

	constraint PK_SACH primary key (MaSach),
	constraint FK_SACH_TACGIA foreign key (MaTG) references TACGIA(MaTG),
	constraint FK_SACH_NHAXUATBAN foreign key (MaNXB) references NHAXUATBAN(MaNXB)
)

CREATE TABLE THONGTINTONKHO
(
	MaChiTietTon int identity(1000,1),
	ThoiGian datetime NOT NULL,
	TonDau int NOT NULL,
	TonPhatSinh int NOT NULL,
	TonCuoi int NOT NULL,
	MaSach int NOT NULL,

	constraint PK_THONGTINTONKHO primary key (MaChiTietTon),
	constraint FK_THONGTINTONKHO foreign key (MaSach) references SACH(MaSach)
)

CREATE TABLE KHACHHANG
(
	MaKH int identity(1000,1),
	HoTen nvarchar(100) NOT NULL,
	GioiTinh nvarchar(15) NOT NULL,
	DiaChi nvarchar(250) NOT NULL,
	Email nvarchar(100) NOT NULL,
	SDT varchar(15),

	constraint PK_KHACHHANG primary key (MaKH)
)

CREATE TABLE THONGTINNO
(
	MaChiTietNo int identity(1000,1),
	NgayNo datetime NOT NULL,
	NoDau money NOT NULL,
	NoPhatSinh money NOT NULL,
	NoCuoi money NOT NULL,
	MaKH int NOT NULL,

	constraint PK_THONGTINNO primary key (MaChiTietNo),
	constraint FK_THONGTINNO_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH)
)

CREATE TABLE HOADON
(
	SoHD int identity(1000,1),
	NgayLap datetime NOT NULL,
	TongTien money NOT NULL,
	MaNV int NOT NULL,
	MaKH int NOT NULL,

	constraint PK_HOADON primary key (SoHD),
	constraint FK_HOADON_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV),
	constraint FK_HOADON_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH)
)

CREATE TABLE CTHD
(
	MaCTHD int identity(100,1),
	SoHD int,
	MaSach int,
	SoLuong int NOT NULL,

	constraint PK_CTHD primary key (MaCTHD, SoHD, MaSach)
)

CREATE TABLE PHIEUTHU
(
	MaPhieuThu int identity(1000,1),
	NgayThu datetime NOT NULL,
	SoTienThu money NOT NULL,
	MaKH int NOT NULL,
	MaNV int NOT NULL,

	constraint PK_PHIEUTHU primary key(MaPhieuThu),
	constraint FK_PHIEUTHU_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH),
	constraint FK_PHIEUTHU_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV)
)

CREATE TABLE PHIEUNHAP
(
	MaPhieuNhap int identity(1000,1),
	NgayNhap datetime NOT NULL,
	SoLuongNhap int NOT NULL,
	MaNV int NOT NULL,

	constraint PK_PHIEUNHAP primary key (MaPhieuNhap),
	constraint FK_PHIEUNHAP_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV)
)

CREATE TABLE CTPN
(
	MaCTPN int identity(1000,1),
	MaSach int,
	MaPhieuNhap int,
	SoLuong int NOT NULL,

	constraint PK_CTPN primary key (MaCTPN, MaSach, MaPhieuNhap)
)

CREATE TABLE THAMSOQUYDINH
(
	SoLuongNhapItNhat int NOT NULL,
	SoLuongTonToiDaTruocNhap int NOT NULL,
	SoLuongTonSauToiThieu int NOT NULL,
	SoTienNoToiDa money NOT NULL,
	QuyDinhThuTienKhachHang bit NOT NULL
)