USE [master]
GO
/****** Object:  Database [BM]    Script Date: 7/2/2018 11:36:30 PM ******/
CREATE DATABASE [BM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BM] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BM] SET ARITHABORT OFF 
GO
ALTER DATABASE [BM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BM] SET RECOVERY FULL 
GO
ALTER DATABASE [BM] SET  MULTI_USER 
GO
ALTER DATABASE [BM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BM', N'ON'
GO
ALTER DATABASE [BM] SET QUERY_STORE = OFF
GO
USE [BM]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BM]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 7/2/2018 11:36:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](255) NOT NULL,
	[Mota] [nvarchar](255) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaCTHD] [int] IDENTITY(1,1) NOT NULL,
	[SoHD] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC,
	[SoHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MaCTPN] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [int] NOT NULL,
	[MaPhieuNhap] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MaCTPN] ASC,
	[MaSach] ASC,
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[TongTien] [money] NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](15) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NULL,
	[SoTienNo] [int] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NULL,
	[CMND] [varchar](20) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[ID] [int] NOT NULL,
	[MaCV] [int] NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [int] IDENTITY(1,1) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[ThongTinNXB] [nvarchar](1000) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[MaNV] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHU]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHU](
	[MaPhieuThu] [int] IDENTITY(1,1) NOT NULL,
	[NgayThu] [datetime] NOT NULL,
	[SoTienThu] [money] NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaNV] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUTHU] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](max) NULL,
	[TheLoai] [nvarchar](max) NULL,
	[NgayXuatBan] [datetime] NOT NULL,
	[DonGiaNhap] [money] NOT NULL,
	[MaTG] [int] NOT NULL,
	[MaNXB] [int] NOT NULL,
	[MaDinhDanh] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTG] [int] IDENTITY(1,1) NOT NULL,
	[TenTG] [nvarchar](100) NOT NULL,
	[ThongTinTG] [nvarchar](1000) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](255) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAMSOQUYDINH]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSOQUYDINH](
	[SoLuongNhapItNhat] [int] NOT NULL,
	[SoLuongTonToiDaTruocNhap] [int] NOT NULL,
	[SoLuongTonSauToiThieu] [int] NOT NULL,
	[SoTienNoToiDa] [money] NOT NULL,
	[QuyDinhThuTienKhachHang] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINNO]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINNO](
	[MaChiTietNo] [int] IDENTITY(1,1) NOT NULL,
	[NgayNo] [date] NOT NULL,
	[NoDau] [money] NOT NULL,
	[NoPhatSinh] [money] NOT NULL,
	[NoCuoi] [money] NOT NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_THONGTINNO] PRIMARY KEY CLUSTERED 
(
	[MaChiTietNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINTONKHO]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINTONKHO](
	[MaChiTietTon] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [date] NOT NULL,
	[TonDau] [int] NOT NULL,
	[TonPhatSinh] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
 CONSTRAINT [PK_THONGTINTONKHO] PRIMARY KEY CLUSTERED 
(
	[MaChiTietTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SACH] ADD  DEFAULT ((0)) FOR [SoLuongTon]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TAIKHOAN] FOREIGN KEY([ID])
REFERENCES [dbo].[TAIKHOAN] ([ID])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_TAIKHOAN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_NHANVIEN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TACGIA] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TACGIA] ([MaTG])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TACGIA]
GO
ALTER TABLE [dbo].[THONGTINNO]  WITH CHECK ADD  CONSTRAINT [FK_THONGTINNO_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[THONGTINNO] CHECK CONSTRAINT [FK_THONGTINNO_KHACHHANG]
GO
ALTER TABLE [dbo].[THONGTINTONKHO]  WITH CHECK ADD  CONSTRAINT [FK_THONGTINTONKHO] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[THONGTINTONKHO] CHECK CONSTRAINT [FK_THONGTINTONKHO]
GO
/****** Object:  StoredProcedure [dbo].[addBook]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[addBook]
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
GO
/****** Object:  StoredProcedure [dbo].[addBookIntoBooksReceiptNote]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addBookIntoBooksReceiptNote]
@bookId int,
@count int,
@dateCreate date
AS
BEGIN
	DECLARE @booksReceiptNoteId int;
			
	SELECT TOP 1 @booksReceiptNoteId = MaPhieuNhap FROM PHIEUNHAP ORDER BY MaPhieuNhap DESC

	INSERT INTO CTPN (MaSach, MaPhieuNhap, SoLuong)
	VALUES (@bookId, @booksReceiptNoteId, @count)

	DECLARE @inventoryReceiptIdLastMonth int,
			@inventoryEarlyThisMonth int;
	SELECT TOP 1 @inventoryReceiptIdLastMonth = MaChiTietTon
	FROM THONGTINTONKHO t
	WHERE t.MaSach = @bookId AND ThoiGian >= ALL (SELECT ThoiGian FROM THONGTINTONKHO b WHERE t.MaSach = b.MaSach)
	IF (@inventoryReceiptIdLastMonth IS NULL)
		SELECT @inventoryEarlyThisMonth = 0
	ELSE
		SELECT @inventoryEarlyThisMonth = TonCuoi FROM THONGTINTONKHO WHERE MaChiTietTon = @inventoryReceiptIdLastMonth

	DECLARE @inventoryInfoId int;
	EXEC @inventoryInfoId = getInventoryInfo @dateCreate, @bookId

	IF (@inventoryInfoId = 0)
	BEGIN
	INSERT INTO THONGTINTONKHO (ThoiGian, TonDau, TonPhatSinh, TonCuoi, MaSach)
	VALUES (@dateCreate, @inventoryEarlyThisMonth, 0, 0, (SELECT TOP 1 MaSach FROM SACH WHERE MaSach = @bookId))

	DECLARE @inventoryCount int;
	SELECT TOP 1 @inventoryCount = SoLuongTon FROM SACH WHERE MaSach = @bookId

	IF (@inventoryCount = @inventoryEarlyThisMonth)
	BEGIN
	UPDATE THONGTINTONKHO SET TonPhatSinh = 0, TonCuoi = @inventoryCount WHERE MaChiTietTon = SCOPE_IDENTITY()
	END
	
	UPDATE THONGTINTONKHO SET TonPhatSinh = TonPhatSinh + @count, TonCuoi = TonCuoi + @count WHERE MaChiTietTon = SCOPE_IDENTITY()
	UPDATE SACH SET SoLuongTon = SoLuongTon + @count WHERE MaSach = @bookId
	END

	ELSE
	BEGIN
	
	UPDATE THONGTINTONKHO
	SET TonPhatSinh = TonPhatSinh + @count, TonCuoi = TonCuoi + @count
	WHERE MaChiTietTon = @inventoryInfoId

	UPDATE SACH
	SET SoLuongTon = SoLuongTon + @count
	WHERE MaSach = @bookId;
	END

END
GO
/****** Object:  StoredProcedure [dbo].[addBookToBill]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addBookToBill]
@bookId int,
@count int,
@dateCreate date
AS
BEGIN
	DECLARE @billId int;
			
	SELECT TOP 1 @billId = SoHD FROM HOADON ORDER BY SoHD DESC

	INSERT INTO CTHD (SoHD, MaSach, SoLuong)
	VALUES (@billId, @bookId, @count)

	DECLARE @inventoryReceiptIdLastMonth int,
			@inventoryEarlyThisMonth int;
	SELECT TOP 1 @inventoryReceiptIdLastMonth = MaChiTietTon
	FROM THONGTINTONKHO t
	WHERE t.MaSach = @bookId AND ThoiGian >= ALL (SELECT ThoiGian FROM THONGTINTONKHO b WHERE t.MaSach = b.MaSach)
	IF (@inventoryReceiptIdLastMonth IS NULL)
		SELECT @inventoryEarlyThisMonth = 0
	ELSE
		SELECT @inventoryEarlyThisMonth = TonCuoi FROM THONGTINTONKHO WHERE MaChiTietTon = @inventoryReceiptIdLastMonth

	DECLARE @inventoryInfoId int;
	EXEC @inventoryInfoId = getInventoryInfo @dateCreate, @bookId

	IF (@inventoryInfoId = 0)
	BEGIN
	INSERT INTO THONGTINTONKHO (ThoiGian, TonDau, TonPhatSinh, TonCuoi, MaSach)
	VALUES (@dateCreate, @inventoryEarlyThisMonth, 0, 0, (SELECT TOP 1 MaSach FROM SACH WHERE MaSach = @bookId))

	DECLARE @inventoryCount int;
	SELECT TOP 1 @inventoryCount = SoLuongTon FROM SACH WHERE MaSach = @bookId

	IF (@inventoryCount = @inventoryEarlyThisMonth)
	BEGIN
	UPDATE THONGTINTONKHO SET TonPhatSinh = 0, TonCuoi = @inventoryCount WHERE MaChiTietTon = SCOPE_IDENTITY()
	END
	
	UPDATE THONGTINTONKHO SET TonPhatSinh = TonPhatSinh - @count WHERE MaChiTietTon = SCOPE_IDENTITY()
	UPDATE SACH SET SoLuongTon = SoLuongTon - @count WHERE MaSach = @bookId
	UPDATE THONGTINTONKHO SET TonCuoi = (SELECT SoLuongTon FROM SACH WHERE MaSach = @bookId) WHERE MaChiTietTon = SCOPE_IDENTITY()
	END

	ELSE
	BEGIN
	
	UPDATE THONGTINTONKHO
	SET TonPhatSinh = TonPhatSinh - @count
	WHERE MaChiTietTon = @inventoryInfoId

	UPDATE SACH
	SET SoLuongTon = SoLuongTon - @count
	WHERE MaSach = @bookId

	UPDATE THONGTINTONKHO SET TonCuoi = (SELECT SoLuongTon FROM SACH WHERE MaSach = @bookId) WHERE MaChiTietTon = @inventoryInfoId
	END

END
GO
/****** Object:  StoredProcedure [dbo].[addIndebtednessInfo]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addIndebtednessInfo]
@customerId int,
@dateCreate date,
@due money
AS
BEGIN
DECLARE		@indebtednessIdLastMonth int,
			@indebtednessEarlyThisMonth money;
	SELECT TOP 1 @indebtednessIdLastMonth = MaChiTietNo
	FROM THONGTINNO t
	WHERE t.MaKH = @customerId AND NgayNo >= ALL (SELECT NgayNo FROM THONGTINNO b WHERE t.MaKH = b.MaKH)
	IF (@indebtednessIdLastMonth IS NULL)
		SELECT @indebtednessEarlyThisMonth = 0
	ELSE
		SELECT @indebtednessEarlyThisMonth = NoCuoi FROM THONGTINNO WHERE MaChiTietNo = @indebtednessIdLastMonth

	DECLARE @indebtednessInfoId int;
	EXEC @indebtednessInfoId = getIndebtednessInfo @dateCreate, @customerId

	IF (@indebtednessInfoId = 0)
	BEGIN
	INSERT INTO THONGTINNO(NgayNo, NoDau, NoPhatSinh, NoCuoi, MaKH)
	VALUES (@dateCreate, @indebtednessEarlyThisMonth, 0, 0, (SELECT TOP 1 MaKH FROM KHACHHANG WHERE MaKH = @customerId))

	DECLARE @indebtednessCount money;
	SELECT TOP 1 @indebtednessCount = SoTienNo FROM KHACHHANG WHERE MaKH = @customerId

	IF (@indebtednessCount = @indebtednessEarlyThisMonth)
	BEGIN
	UPDATE THONGTINNO SET NoPhatSinh = 0, NoCuoi = @indebtednessCount WHERE MaChiTietNo = SCOPE_IDENTITY()
	END
	UPDATE THONGTINNO SET NoPhatSinh = NoPhatSinh + @due, NoCuoi = NoCuoi + @due WHERE MaChiTietNo = SCOPE_IDENTITY()
	UPDATE KHACHHANG SET SoTienNo = SoTienNo + @due WHERE MaKH = @customerId
	END

	ELSE
	BEGIN
	
	UPDATE THONGTINNO
	SET NoPhatSinh = NoPhatSinh + @due, NoCuoi = NoCuoi + @due
	WHERE MaChiTietNo = @indebtednessInfoId

	UPDATE KHACHHANG
	SET SoTienNo = SoTienNo + @due
	WHERE MaKH = @customerId;
	END

END
GO
/****** Object:  StoredProcedure [dbo].[addNewBill]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addNewBill]
@dateCreate datetime,
@total int,
@staffId int,
@customerId int
AS
BEGIN
INSERT INTO HOADON (NgayLap, TongTien, MaNV, MaKH) VALUES (@dateCreate, @total, (SELECT MaNV FROM NHANVIEN WHERE MaNV = @staffId), (SELECT MaKH FROM KHACHHANG WHERE MaKH = @customerId))
DECLARE @billId int;
SELECT @billId = SCOPE_IDENTITY();
return @billId;
END
GO
/****** Object:  StoredProcedure [dbo].[addNewCustomer]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addNewCustomer]
@name nvarchar(MAX),
@sex nvarchar(15),
@addr nvarchar(MAX),
@email nvarchar(MAX),
@phoneno nvarchar(15)
AS
BEGIN
	INSERT INTO KHACHHANG (HoTen, GioiTinh, DiaChi, Email, SDT, SoTienNo) 
	VALUES (@name, @sex, @addr, @email, @phoneno, 0) 
END

GO
/****** Object:  StoredProcedure [dbo].[changeRule]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[changeRule]
@minImport int,
@maxInventory int,
@minInventory int,
@maxIndebtedness money
AS
BEGIN
	UPDATE THAMSOQUYDINH SET SoLuongNhapItNhat = @minImport, SoLuongTonSauToiThieu = @minInventory,
	SoLuongTonToiDaTruocNhap = @maxInventory, SoTienNoToiDa = @maxIndebtedness 
END
GO
/****** Object:  StoredProcedure [dbo].[changeStockContract]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[changeStockContract]
@minImport int,
@maxInventory int
AS
BEGIN
UPDATE THAMSOQUYDINH
SET SoLuongNhapItNhat = @minImport, SoLuongTonToiDaTruocNhap = @maxInventory
END
GO
/****** Object:  StoredProcedure [dbo].[createBooksReceiptNote]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[createBooksReceiptNote]
@dateCreate datetime,
@staffName nvarchar(MAX)
AS
BEGIN
INSERT INTO PHIEUNHAP (NgayNhap, MaNV) VALUES (@dateCreate, (SELECT MaNV FROM NHANVIEN WHERE HoTen = @staffName))
DECLARE @receiptNoteId int;
SELECT @receiptNoteId = SCOPE_IDENTITY();
return @receiptNoteId;
END
GO
/****** Object:  StoredProcedure [dbo].[createStaff]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[createStaff]
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
GO
/****** Object:  StoredProcedure [dbo].[deleteBookWithId]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteBookWithId]
@bookId int
AS
BEGIN
	DELETE FROM SACH WHERE MaSach = @bookId
END
GO
/****** Object:  StoredProcedure [dbo].[deleteCustomer]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteCustomer]
@cusId int
AS
BEGIN
	DELETE FROM THONGTINNO WHERE MaChiTietNo = (SELECT TOP 1 MaChiTietNo FROM THONGTINNO WHERE MaKH = @cusId)
	DELETE FROM KHACHHANG WHERE MaKH = (SELECT TOP 1 MaKH FROM KHACHHANG WHERE MaKH =@cusId)
END
GO
/****** Object:  StoredProcedure [dbo].[deleteUser]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteUser]
@username varchar(255)
AS
BEGIN
	DELETE FROM NHANVIEN WHERE (SELECT ID FROM TAIKHOAN WHERE TenDangNhap = @username) = NHANVIEN.ID;
	DELETE FROM TAIKHOAN WHERE TenDangNhap = @username
END
GO
/****** Object:  StoredProcedure [dbo].[getAllBooks]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAllBooks]
AS
BEGIN
	SELECT MaSach, TenSach, TheLoai, NgayXuatBan, DonGiaNhap, MaDinhDanh, TenTG, TenNXB, SoLuongTon
	FROM SACH, TACGIA, NHAXUATBAN 
	WHERE SACH.MaTG = TACGIA.MaTG AND SACH.MaNXB = NHAXUATBAN.MaNXB
END
GO
/****** Object:  StoredProcedure [dbo].[getAllCustomers]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAllCustomers]
AS
BEGIN
SELECT * FROM KHACHHANG
END
GO
/****** Object:  StoredProcedure [dbo].[getAllFunc]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[getAllFunc]
AS
BEGIN
	SELECT * FROM CHUCVU
END
GO
/****** Object:  StoredProcedure [dbo].[getAllPublishers]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAllPublishers]
AS
BEGIN
SELECT * FROM NHAXUATBAN
END
GO
/****** Object:  StoredProcedure [dbo].[getAllUsers]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAllUsers]
AS
BEGIN
	SELECT S.HoTen, S.GioiTinh, S.NgaySinh, S.CMND, S.Email, S.SDT, F.MaCV, F.TenChucVu, A.TenDangNhap, A.MatKhau, S.MaNV
	FROM (NHANVIEN S INNER JOIN TAIKHOAN A ON S.ID = A.ID) INNER JOIN CHUCVU F ON F.MaCV = S.MaCV
END
GO
/****** Object:  StoredProcedure [dbo].[getBooksQuantitiesSold]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getBooksQuantitiesSold]
@date date
AS
BEGIN
SELECT SUM(r.SL) SL FROM (
SELECT c.MaSach, SUM(c.SoLuong) SL FROM HOADON h INNER JOIN CTHD c ON h.SoHD = c.SoHD
WHERE MONTH(h.NgayLap) = MONTH(@date) AND YEAR(h.NgayLap) = YEAR(@date)
GROUP BY c.MaSach) r
END
GO
/****** Object:  StoredProcedure [dbo].[getCustomer]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getCustomer]
@name nvarchar(MAX)
AS
BEGIN
SELECT * FROM KHACHHANG WHERE HoTen = @name
END
GO
/****** Object:  StoredProcedure [dbo].[getDueOfCustomer]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getDueOfCustomer]
@customerId int
AS
BEGIN
SELECT SoTienNo FROM KHACHHANG WHERE MaKH = @customerId
END
GO
/****** Object:  StoredProcedure [dbo].[getIndebtednessInfo]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIndebtednessInfo]
@time date,
@customerId int
AS
BEGIN
	DECLARE @indebtednessInfoId int;
	SELECT TOP 1 @indebtednessInfoId = MaChiTietNo FROM THONGTINNO WHERE MaKH = @customerId
	 AND MONTH(NgayNo) = MONTH(@time) AND YEAR(NgayNo) = YEAR(@time)
	IF (@indebtednessInfoId IS NULL)
		return 0;
	ELSE
		return @indebtednessInfoId;
END
GO
/****** Object:  StoredProcedure [dbo].[getIndebtednessReport]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIndebtednessReport]
@date date
AS
BEGIN
		SELECT THONGTINNO.MaKH, KHACHHANG.HoTen, NoDau, NoPhatSinh, NoCuoi 
		FROM THONGTINNO INNER JOIN KHACHHANG ON THONGTINNO.MaKH = KHACHHANG.MaKH
		WHERE MONTH(NgayNo) = MONTH(@date) AND YEAR(NgayNo) = YEAR(@date)
		
END
GO
/****** Object:  StoredProcedure [dbo].[getIndebtednessReportLastest]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIndebtednessReportLastest]
@date date
AS
BEGIN
SELECT t.MaKH, s.HoTen, NoDau, NoPhatSinh, NoCuoi FROM THONGTINNO t INNER JOIN KHACHHANG s ON t.MaKH = s.MaKH
WHERE t.MaKH IN (SELECT MaKH FROM KHACHHANG WHERE SoTienNo > 0)
AND NgayNo < @date
ORDER BY NgayNo DESC
END
GO
/****** Object:  StoredProcedure [dbo].[getInventoryInfo]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getInventoryInfo]
@time date,
@bookId int
AS
BEGIN
	DECLARE @inventoryInfoId int;
	SELECT TOP 1 @inventoryInfoId = MaChiTietTon FROM THONGTINTONKHO WHERE MaSach = @bookId AND MONTH(ThoiGian) = MONTH(@time) AND YEAR(ThoiGian) = YEAR(@time)
	IF (@inventoryInfoId IS NULL)
		return 0;
	ELSE
		return @inventoryInfoId;
END
GO
/****** Object:  StoredProcedure [dbo].[getInventoryReport]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getInventoryReport]
@date date
AS
BEGIN
		SELECT SACH.MaDinhDanh, SACH.TenSach, TonDau, TonPhatSinh, TonCuoi 
		FROM THONGTINTONKHO INNER JOIN SACH ON THONGTINTONKHO.MaSach = SACH.MaSach
		WHERE MONTH(ThoiGian) = MONTH(@date) AND YEAR(ThoiGian) = YEAR(@date)
		
END
GO
/****** Object:  StoredProcedure [dbo].[getInventoryReportLastest]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getInventoryReportLastest]
@date date
AS
BEGIN
SELECT s.MaDinhDanh, s.TenSach, TonDau, TonPhatSinh, TonCuoi FROM THONGTINTONKHO t INNER JOIN SACH s ON t.MaSach = s.MaSach
WHERE t.MaSach IN (SELECT MaSach FROM SACH WHERE SoLuongTon > 0)
AND ThoiGian < @date
ORDER BY ThoiGian DESC
END
GO
/****** Object:  StoredProcedure [dbo].[getMaxDue]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getMaxDue]
AS
BEGIN
SELECT SoTienNoToiDa FROM THAMSOQUYDINH
END
GO
/****** Object:  StoredProcedure [dbo].[getMinInventory]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getMinInventory]
AS
BEGIN
SELECT SoLuongTonSauToiThieu FROM THAMSOQUYDINH
END
GO
/****** Object:  StoredProcedure [dbo].[getQuantitiesBookInStock]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getQuantitiesBookInStock]
AS
BEGIN
SELECT SUM(SoLuongTon) SL FROM SACH
END
GO
/****** Object:  StoredProcedure [dbo].[getRevenue]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getRevenue]
@date date
AS
BEGIN
SELECT SUM(TongTien) AS DoanhThu FROM HOADON
WHERE MONTH(@date) = MONTH(NgayLap) AND YEAR(@date) = YEAR(NgayLap)
END
GO
/****** Object:  StoredProcedure [dbo].[getRule]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getRule]
AS
BEGIN
SELECT * FROM THAMSOQUYDINH
END
GO
/****** Object:  StoredProcedure [dbo].[getStockContract]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getStockContract]
AS
BEGIN
SELECT SoLuongNhapItNhat, SoLuongTonToiDaTruocNhap
FROM THAMSOQUYDINH
END
GO
/****** Object:  StoredProcedure [dbo].[getSumsBooksInventories]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getSumsBooksInventories]
@date date
AS
BEGIN
SELECT SUM(r.SL) SL FROM (
SELECT c.MaSach, SUM(c.SoLuong) SL FROM PHIEUNHAP h INNER JOIN CTPN c ON h.MaPhieuNhap = c.MaPhieuNhap
WHERE MONTH(h.NgayNhap) = MONTH(@date) AND YEAR(h.NgayNhap) = YEAR(@date)
GROUP BY c.MaSach) r
END
GO
/****** Object:  StoredProcedure [dbo].[getUser]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getUser]
@Username varchar(255),
@Password varchar(255)
AS
BEGIN
	SELECT S.HoTen, S.GioiTinh, S.NgaySinh, S.CMND, S.Email, S.SDT, F.MaCV, F.TenChucVu, S.MaNV
	FROM (NHANVIEN S INNER JOIN TAIKHOAN A ON S.ID = A.ID) INNER JOIN CHUCVU F ON F.MaCV = S.MaCV
	WHERE TenDangNhap = @Username  AND MatKhau = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[receiveIndebtedness]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[receiveIndebtedness]
@dateCreate date,
@customerId int,
@receive money
AS
BEGIN
DECLARE		@indebtednessIdLastMonth int,
			@indebtednessEarlyThisMonth money;
	SELECT TOP 1 @indebtednessIdLastMonth = MaChiTietNo
	FROM THONGTINNO t
	WHERE t.MaKH = @customerId AND NgayNo >= ALL (SELECT NgayNo FROM THONGTINNO b WHERE t.MaKH = b.MaKH)
	IF (@indebtednessIdLastMonth IS NULL)
		SELECT @indebtednessEarlyThisMonth = 0
	ELSE
		SELECT @indebtednessEarlyThisMonth = NoCuoi FROM THONGTINNO WHERE MaChiTietNo = @indebtednessIdLastMonth

	DECLARE @indebtednessInfoId int;
	EXEC @indebtednessInfoId = getIndebtednessInfo @dateCreate, @customerId

	IF (@indebtednessInfoId = 0)
	BEGIN
	INSERT INTO THONGTINNO(NgayNo, NoDau, NoPhatSinh, NoCuoi, MaKH)
	VALUES (@dateCreate, @indebtednessEarlyThisMonth, 0, 0, (SELECT TOP 1 MaKH FROM KHACHHANG WHERE MaKH = @customerId))

	DECLARE @indebtednessCount money;
	SELECT TOP 1 @indebtednessCount = SoTienNo FROM KHACHHANG WHERE MaKH = @customerId

	IF (@indebtednessCount = @indebtednessEarlyThisMonth)
	BEGIN
	UPDATE THONGTINNO SET NoPhatSinh = 0, NoCuoi = @indebtednessCount WHERE MaChiTietNo = SCOPE_IDENTITY()
	END
	UPDATE THONGTINNO SET NoPhatSinh = NoPhatSinh - @receive, NoCuoi = NoCuoi - @receive WHERE MaChiTietNo = SCOPE_IDENTITY()
	UPDATE KHACHHANG SET SoTienNo = SoTienNo - @receive WHERE MaKH = @customerId
	END

	ELSE
	BEGIN
	
	UPDATE THONGTINNO
	SET NoPhatSinh = NoPhatSinh - @receive, NoCuoi = NoCuoi - @receive
	WHERE MaChiTietNo = @indebtednessInfoId

	UPDATE KHACHHANG
	SET SoTienNo = SoTienNo - @receive
	WHERE MaKH = @customerId;
	END

END
GO
/****** Object:  StoredProcedure [dbo].[updateBookInfo]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateBookInfo]
@bookId int,
@cost money
AS
BEGIN
	UPDATE SACH SET DonGiaNhap = @cost WHERE MaSach = @bookId
END
GO
/****** Object:  StoredProcedure [dbo].[updateCustomer]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateCustomer]
@cusId int,
@name nvarchar(MAX),
@sex nvarchar(5),
@addr nvarchar(MAX),
@email nvarchar(MAX),
@phoneno nvarchar(MAX)
AS
BEGIN
	UPDATE KHACHHANG SET HoTen = @name, GioiTinh = @sex, DiaChi = @addr, Email = @email, SDT = @phoneno
	WHERE MaKH = @cusId
END
GO
/****** Object:  StoredProcedure [dbo].[updateUser]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateUser]
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
GO
/****** Object:  StoredProcedure [dbo].[validateAccount]    Script Date: 7/2/2018 11:36:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[validateAccount]
@Username varchar(255)
AS 
SELECT * FROM TAIKHOAN WHERE TenDangNhap = @Username
GO
USE [master]
GO
ALTER DATABASE [BM] SET  READ_WRITE 
GO

-- generate data to test

INSERT INTO [BM].[dbo].[TAIKHOAN] VALUES ('admin', 'admin')
INSERT INTO [BM].[dbo].[CHUCVU] (TenChucVu) VALUES (N'Quản lý')
INSERT INTO [BM].[dbo].[CHUCVU] (TenChucVu) VALUES (N'Nhân viên')
INSERT INTO [BM].[dbo].[NHANVIEN] VALUES (N'Nguyễn Văn Sỹ', N'Nam', '03/06/1991', '216869226', 'syvn_bb@gmail.com', '0976008269', 1, 1)
INSERT INTO [BM].[dbo].THAMSOQUYDINH VALUES (1, 1, 1, 0, 1)

INSERT INTO [BM].[dbo].[TAIKHOAN] VALUES ('user1', 'user')
INSERT INTO [BM].[dbo].[NHANVIEN] VALUES (N'Trần Nguyên Khôi', N'Nam', '08/03/1989', '214758741', 'khoint77@gmail.com', '01694546325', 2, 2)
INSERT INTO [BM].[dbo].[TAIKHOAN] VALUES ('user2', 'user')
INSERT INTO [BM].[dbo].[NHANVIEN] VALUES (N'Nguyễn Hồng Hạnh', N'Nữ', '07/05/1996', '128745639', 'hhpehanh@gmail.com', '0968741258', 3, 2)
INSERT INTO [BM].[dbo].[TAIKHOAN] VALUES ('user3', 'user')
INSERT INTO [BM].[dbo].[NHANVIEN] VALUES (N'Dương Thị Kim Cúc', N'Nữ', '09/01/1994', '254741856', 'kft.795@gmail.com', '01677414789', 4, 2)
INSERT INTO [BM].[dbo].[TAIKHOAN] VALUES ('user4', 'user')
INSERT INTO [BM].[dbo].[NHANVIEN] VALUES (N'Tăng Thanh Hà', N'Nữ', '02/09/1994', '141172968', 'hatran_oo@gmail.com', '0965258741', 5, 2)

INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Nguyễn Hữu Minh Quý', N'Nam', N'Quận 5-TP HCM', 'quynttk@gmail.com', '01687414759', 0)
INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Phan Văn Cảnh', N'Nam', N'Láng Hạ-Ninh Bình', 'canh_pikachu@gmail.com', '0968741258', 0)
INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Lê Thị Minh Nguyệt', N'Nữ', N'Phù Cát-Bình Định', 'copehondoi@gmail.com', '01632581478', 0)
INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Nguyễn Kim Thanh', N'Nữ', N'Việt Trì-Phú Thọ', 'nkcopp_87@gmail.com', '0968741236', 0)
INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Phạm Trọng Hiếu', N'Nam', N'Phú Châu-Quảng Ngãi', 'hieu.uit_64@gmail.com', '01632587415', 0)
INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Nguyễn Long Nhật', N'Nam', N'Pleiku-Gia Lai', 'boycaonguyen@gmail.com', '0978145125', 0)
INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Phạm Thị Thanh Trúc', N'Nữ', N'Quận 7-TP HCM', 'trucpham7755@gmail.com', '01231471596', 0)
INSERT INTO [BM].[dbo].[KHACHHANG] VALUES (N'Nguyễn Thị Y Phụng', N'Nữ', N'Thành Châu-Thanh Hoá', 'peheokute@gmail.com', '0968745369', 0)

