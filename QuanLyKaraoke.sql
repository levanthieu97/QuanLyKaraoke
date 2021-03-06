USE [master]
GO
/****** Object:  Database [QuanLyKaraoke]    Script Date: 27/11/2017 11:00:10 PM ******/
CREATE DATABASE [QuanLyKaraoke]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKaraoke', FILENAME = N'E:\Quanlykaraoke (1)\DATA\DATA\QuanLyKaraoke.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKaraoke_log', FILENAME = N'E:\Quanlykaraoke (1)\DATA\DATA\QuanLyKaraoke_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyKaraoke] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKaraoke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKaraoke] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKaraoke] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKaraoke] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKaraoke] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKaraoke] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKaraoke] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKaraoke] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKaraoke] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyKaraoke] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyKaraoke]
GO
/****** Object:  Table [dbo].[DATPHONG]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATPHONG](
	[IDDatPhong] [int] IDENTITY(1,1) NOT NULL,
	[IDPhongHat] [nvarchar](50) NOT NULL,
	[ThoiGianVao] [datetime] NULL,
	[ThoiGianRa] [datetime] NULL,
	[NgayDat] [datetime] NULL,
 CONSTRAINT [PK_DATPHONG] PRIMARY KEY CLUSTERED 
(
	[IDDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[IDHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[IDDatPhong] [int] NOT NULL,
	[NgayGioTao] [datetime] NULL,
	[TienGio] [decimal](18, 0) NULL,
	[TienDichVu] [decimal](18, 0) NULL,
	[TongTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONSP]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONSP](
	[IDHoaDon] [int] NOT NULL,
	[IDSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[TinhTien] [int] NULL,
 CONSTRAINT [PK_HOADONSP] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIPHONGHAT]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONGHAT](
	[IDLoaiPhong] [int] NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[Gia] [money] NULL,
 CONSTRAINT [PK_LOAIPHONGHAT] PRIMARY KEY CLUSTERED 
(
	[IDLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOGIN](
	[IDUser] [int] NOT NULL,
	[UserName] [varchar](50) NULL,
	[PassWord] [varchar](50) NULL,
 CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongHat]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHat](
	[IDPhongHat] [nvarchar](50) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[IDLoaiPhong] [int] NULL,
	[TrangThai] [text] NULL,
 CONSTRAINT [PK_PhongHat] PRIMARY KEY CLUSTERED 
(
	[IDPhongHat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[IDSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[Gia] [int] NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[IDSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DATPHONG] ON 

INSERT [dbo].[DATPHONG] ([IDDatPhong], [IDPhongHat], [ThoiGianVao], [ThoiGianRa], [NgayDat]) VALUES (52, N'1003', CAST(N'2017-11-27 22:19:00.000' AS DateTime), NULL, CAST(N'2017-11-27 22:19:56.107' AS DateTime))
SET IDENTITY_INSERT [dbo].[DATPHONG] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([IDHoaDon], [IDDatPhong], [NgayGioTao], [TienGio], [TienDichVu], [TongTien]) VALUES (10, 52, CAST(N'2017-11-27 22:19:00.000' AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
INSERT [dbo].[HOADONSP] ([IDHoaDon], [IDSanPham], [SoLuong], [TinhTien]) VALUES (10, 2, 10, 200000)
INSERT [dbo].[HOADONSP] ([IDHoaDon], [IDSanPham], [SoLuong], [TinhTien]) VALUES (10, 3, 10, 200000)
INSERT [dbo].[HOADONSP] ([IDHoaDon], [IDSanPham], [SoLuong], [TinhTien]) VALUES (10, 4, 9, 270000)
INSERT [dbo].[LOAIPHONGHAT] ([IDLoaiPhong], [TenLoaiPhong], [Gia]) VALUES (1, N'Thường', 50000.0000)
INSERT [dbo].[LOAIPHONGHAT] ([IDLoaiPhong], [TenLoaiPhong], [Gia]) VALUES (2, N'Vip', 100000.0000)
INSERT [dbo].[LOGIN] ([IDUser], [UserName], [PassWord]) VALUES (1, N'admin', N'123456')
INSERT [dbo].[LOGIN] ([IDUser], [UserName], [PassWord]) VALUES (2, N'nhanvien', N'123')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1001', N'P.101     ', 1, N'0')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1002', N'P.102     ', 1, N'0')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1003', N'P.103     ', 2, N'0')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1004', N'P.104     ', 2, N'1')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1005', N'P.105', 1, N'1')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1006', N'P.106', 2, N'1')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1007', N'P.107', 2, N'1')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1008', N'P.108', 1, N'0')
INSERT [dbo].[PhongHat] ([IDPhongHat], [TenPhong], [IDLoaiPhong], [TrangThai]) VALUES (N'1009', N'P.109', 1, N'1')
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (1, N'Nước Suối', 100, 150000)
INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (2, N'Sting', 100, 20000)
INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (3, N'Coca', 100, 20000)
INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (4, N'Bò Húc', 100, 30000)
INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (5, N'Sinh Tố ', 100, 30000)
INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (6, N'Cafe', 100, 20000)
INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (7, N'Nước ép', 100, 30000)
INSERT [dbo].[SANPHAM] ([IDSanPham], [TenSanPham], [SoLuong], [Gia]) VALUES (8, N'Trà Sữa', 100, 25000)
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
ALTER TABLE [dbo].[DATPHONG]  WITH CHECK ADD  CONSTRAINT [FK_DATPHONG_PhongHat] FOREIGN KEY([IDPhongHat])
REFERENCES [dbo].[PhongHat] ([IDPhongHat])
GO
ALTER TABLE [dbo].[DATPHONG] CHECK CONSTRAINT [FK_DATPHONG_PhongHat]
GO
ALTER TABLE [dbo].[HOADONSP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONSP_HOADON] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HOADON] ([IDHoaDon])
GO
ALTER TABLE [dbo].[HOADONSP] CHECK CONSTRAINT [FK_HOADONSP_HOADON]
GO
ALTER TABLE [dbo].[HOADONSP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONSP_SANPHAM] FOREIGN KEY([IDSanPham])
REFERENCES [dbo].[SANPHAM] ([IDSanPham])
GO
ALTER TABLE [dbo].[HOADONSP] CHECK CONSTRAINT [FK_HOADONSP_SANPHAM]
GO
ALTER TABLE [dbo].[PhongHat]  WITH CHECK ADD  CONSTRAINT [FK_PhongHat_LOAIPHONGHAT] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LOAIPHONGHAT] ([IDLoaiPhong])
GO
ALTER TABLE [dbo].[PhongHat] CHECK CONSTRAINT [FK_PhongHat_LOAIPHONGHAT]
GO
/****** Object:  StoredProcedure [dbo].[DatPhongHat]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DatPhongHat]
@IDPhongHat text,
@Thoigianvao datetime,
@NgayDat datetime
as
BEGIN
	insert into DATPHONG values(@IDPhongHat,@Thoigianvao,null,@NgayDat)
	UPDATE PHONGHAT SET TrangThai ='0' where IDPhongHat like @IDPhongHat
END
GO
/****** Object:  StoredProcedure [dbo].[DichVu_Delete]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DichVu_Delete]
@IDSanPham int
AS
BEGIN
	delete SANPHAM where IDSanPham = @IDSanPham
END

GO
/****** Object:  StoredProcedure [dbo].[DichVu_HienThi]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DichVu_HienThi]
AS
BEGIN	
	select * from SANPHAM
END

GO
/****** Object:  StoredProcedure [dbo].[DichVu_Insert]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DichVu_Insert]
@TenSanPham nvarchar(50),
@SoLuong int,
@Gia money
AS
BEGIN
	insert into SANPHAM values(@TenSanPham,@SoLuong,@gia)
END

GO
/****** Object:  StoredProcedure [dbo].[DichVu_Update]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DichVu_Update]
@IDSanPham int,
@TenSanPham nvarchar(50),
@SoLuong int,
@Gia money
AS
BEGIN
	update SanPham set  TenSanPham = @TenSanPham,SoLuong = @SoLuong, Gia = @Gia where IDSanPham = @IDSanPham
END

GO
/****** Object:  StoredProcedure [dbo].[DoiPhong]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DoiPhong]
@IDPhong nvarchar,
@IDPhongDoi nvarchar
AS
declare @Thoigianvao datetime
declare @NgayDat datetime
BEGIN
  Set @Thoigianvao = (select Thoigianvao from DatPhong where IDPhongHat=@IDPhong)
  Set @NgayDat = (select NgayDat from DatPhong where IDPhongHat=@IDPhong)
  insert into DATPHONG values(@IDPhongDoi,@Thoigianvao,null,@NgayDat)
  UPDATE PHONGHAT SET TrangThai ='0' where IDPhongHat like @IDPhongDoi
  Delete from DATPHONG where IDPhongHat like @IDPhong
   UPDATE PHONGHAT SET TrangThai ='1' where IDPhongHat like @IDPhong
END

GO
/****** Object:  StoredProcedure [dbo].[getGiaTien]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getGiaTien]
@tensanpham varchar(50),
@ketqua varchar(50) OUTPUT
AS
BEGIN
	
	set @ketqua = (select GIA from SANPHAM where TenSanPham=@tensanpham);
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[getIDHoaDon]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getIDHoaDon]
@IDPhongHat varchar(50),
@ketqua varchar(50) OUTPUT
AS
declare @IDDatPhong varchar(50)
BEGIN
	set @IDDatPhong = (select IDDatPhong from DATPHONG where IDPhongHat like @IDPhongHat)
	set @ketqua = (select IDHoaDon from HoaDon where IDDatPhong=@IDDatPhong);
	

END

GO
/****** Object:  StoredProcedure [dbo].[KiemTraDangNhap]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[KiemTraDangNhap]
	@username varchar(50),
	@password varchar(50),
	@ketqua varchar(50) OUTPUT
AS

BEGIN
	if exists(select * from LOGIN where username=@username and password=@password)
	set @ketqua = 1;
	else
	set @ketqua = 0;
END
	
GO
/****** Object:  StoredProcedure [dbo].[Load_DatPhong]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Load_DatPhong]
AS
BEGIN
	select * from DATPHONG
END

GO
/****** Object:  StoredProcedure [dbo].[Load_DichVu]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Load_DichVu]
@IDHoaDon nvarchar(50)
AS
BEGIN
	select * from HOADONSP where IDHoaDon like @IDHoaDon
END

GO
/****** Object:  StoredProcedure [dbo].[LoadDanhSachDichVu]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LoadDanhSachDichVu]
AS
BEGIN
	 Select TenSanPham from SANPHAM where SoLuong > 0 ;
END

GO
/****** Object:  StoredProcedure [dbo].[LoadDanhSachPhongTrong]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LoadDanhSachPhongTrong]
AS
BEGIN
	 Select IDPhongHat from PHONGHAT where TrangThai like '1';
END

GO
/****** Object:  StoredProcedure [dbo].[LoaiPhong_HienThi]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LoaiPhong_HienThi]
AS
BEGIN
	select TenLoaiPhong from LOAIPHONGHAT
END

GO
/****** Object:  StoredProcedure [dbo].[LoaiPhong_Update]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LoaiPhong_Update]
@IDLoaiPhong int,
@TenLoaiPhong nvarchar(50),
@Gia money
AS
BEGIN
	update LOAIPHONGHAT set TenLoaiPhong = @TenLoaiPhong,Gia = @Gia where IDLoaiPhong = @IDLoaiPhong
END

GO
/****** Object:  StoredProcedure [dbo].[NhanSu_Delete]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NhanSu_Delete]
@ID int
as
begin
	delete NHANVIEN where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[NhanSu_Hienthi]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NhanSu_Hienthi]

AS
BEGIN
	select * from NHANVIEN
END

GO
/****** Object:  StoredProcedure [dbo].[NhanSu_Insert]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NhanSu_Insert]
@TenNhanVien nvarchar(50),
@GioiTinh nvarchar(50),
@SoDienThoai nvarchar(50),
@DiaChi nvarchar(50)
AS
BEGIN
	insert into NHANVIEN values(@TenNhanVien,@GioiTinh,@SoDienThoai,@DiaChi)
END

GO
/****** Object:  StoredProcedure [dbo].[NhanSu_Update]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NhanSu_Update]
@ID int,
@TenNhanVien nvarchar(50),
@GioiTinh nvarchar(50),
@SoDienThoai nvarchar(50),
@DiaChi	nvarchar(50)
AS
BEGIN
	update NHANVIEN set TenNhanVien=@TenNhanVien,GioiTinh=@GioiTinh,SoDienThoai=@SoDienThoai,DiaChi=@DiaChi where ID=@ID
END

GO
/****** Object:  StoredProcedure [dbo].[TaoHoaDon]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TaoHoaDon]
@IDPhongHat nvarchar(50),
@Thoigianvao datetime
as
declare @IDDatPhong nvarchar(50)
BEGIN
	set @IDDatPhong = (select IDDatPhong from DATPHONG where IDPhongHat like @IDPhongHat)
	insert into HOADON values(@IDDatPhong,@Thoigianvao,null,null,null);
end

GO
/****** Object:  StoredProcedure [dbo].[ThemDichVu]    Script Date: 27/11/2017 11:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ThemDichVu]
@IDHoaDon int ,
@TenSanPham nvarchar(50),
@Soluong nvarchar (50),
@ThanhTien nvarchar (50)
as
declare @IDSanPham nvarchar (50)
BEGIN
	SET @IDSanPham = (SELECT IDSanPham from SANPHAM where TenSanPham=@TenSanPham)
	insert into HoaDonSP values(@IDHoaDon,@IDSanPham,@Soluong,@ThanhTien)
end


GO
USE [master]
GO
ALTER DATABASE [QuanLyKaraoke] SET  READ_WRITE 
GO
