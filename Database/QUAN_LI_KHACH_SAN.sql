USE [master]
GO
/****** Object:  Database [QUAN_LY_KHACH_SAN]    Script Date: 5/28/2018 8:51:19 PM ******/
CREATE DATABASE [QUAN_LY_KHACH_SAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ALTP_data', FILENAME = N'D:\QUAN_LY_KHACH_SAN.mdf' , SIZE = 102400KB , MAXSIZE = 512000KB , FILEGROWTH = 50%)
 LOG ON 
( NAME = N'ALTP_log', FILENAME = N'D:\QUAN_LY_KHACH_SAN.ldf' , SIZE = 51200KB , MAXSIZE = 102400KB , FILEGROWTH = 20480KB )
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUAN_LY_KHACH_SAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET RECOVERY FULL 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET  MULTI_USER 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUAN_LY_KHACH_SAN', N'ON'
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET QUERY_STORE = OFF
GO
USE [QUAN_LY_KHACH_SAN]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
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
USE [QUAN_LY_KHACH_SAN]
GO
/****** Object:  Table [dbo].[BAOCAO_DOANHTHUTHEOLOAIPHONG]    Script Date: 5/28/2018 8:51:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAO_DOANHTHUTHEOLOAIPHONG](
	[MaBCDoanhThu] [int] NOT NULL,
	[ThangBaoCao] [int] NOT NULL,
 CONSTRAINT [P_BAOCAO_DOANHTHUTHEOLOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MaBCDoanhThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAOCAO_MATDOSUDUNGPHONG]    Script Date: 5/28/2018 8:51:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAO_MATDOSUDUNGPHONG](
	[MaBCMatDoSuDung] [int] NOT NULL,
	[ThangBaoCao] [int] NOT NULL,
 CONSTRAINT [P_BAOCAO_MATDOSUDUNGPHONG] PRIMARY KEY CLUSTERED 
(
	[MaBCMatDoSuDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHI_TIET_HOA_DON]    Script Date: 5/28/2018 8:51:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_HOA_DON](
	[MaChiTietHD] [int] NOT NULL,
	[MaHoaDon] [int] NOT NULL,
	[SoNgayThue] [int] NOT NULL,
	[DonGia] [money] NULL,
	[ThanhTien] [money] NULL,
	[NgayThanhToan] [date] NULL,
	[MaPhong] [int] NOT NULL,
 CONSTRAINT [P_CHI_TIET_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHI_TIET_PHIEU_THUE]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_PHIEU_THUE](
	[MaChiTietPT] [int] NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[MaPhieuThue] [int] NOT NULL,
 CONSTRAINT [P_CHI_TIET_PHIEU_THUE] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPT] ASC,
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIET_BAOCAODOANHTHU]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_BAOCAODOANHTHU](
	[MaBCCTDoanhThu] [int] NOT NULL,
	[MaLoaiPhong] [nvarchar](10) NOT NULL,
	[MaBCDoanhThu] [int] NOT NULL,
	[DoanhThuThang] [money] NULL,
	[TiLe] [char](10) NULL,
 CONSTRAINT [P_CHITIET_BAOCAODOANHTHU] PRIMARY KEY CLUSTERED 
(
	[MaBCCTDoanhThu] ASC,
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIET_BAOCAOMATDOSUDUNG]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_BAOCAOMATDOSUDUNG](
	[MaBCCTMatDoSuDung] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[MaBCMatDoSuDung] [int] NOT NULL,
	[SoNgayThue] [int] NULL,
	[TiLe] [char](10) NULL,
 CONSTRAINT [P_CHITIET_BAOCAOMATDOSUDUNG] PRIMARY KEY CLUSTERED 
(
	[MaBCCTMatDoSuDung] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANG_KI_DICH_VU]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANG_KI_DICH_VU](
	[MaDangKi] [int] NOT NULL,
	[MaDichVu] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDangKi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANH_MUC]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANH_MUC](
	[DMLoaiPhong] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICH_VU]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICH_VU](
	[MaDichVu] [int] NOT NULL,
	[TenDichVu] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](50) NOT NULL,
	[DonGia] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[MaHoaDon] [int] NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[TriGia] [money] NULL,
 CONSTRAINT [P_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[MaKhachHang] [int] NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[CMND] [nvarchar](15) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[MaLoaiKhach] [nvarchar](10) NOT NULL,
 CONSTRAINT [P_KHACH_HANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_KHACH_HANG]    Script Date: 5/28/2018 8:51:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_KHACH_HANG](
	[MaLoaiKhach] [nvarchar](10) NOT NULL,
	[TenLoaiKhach] [nvarchar](50) NOT NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [P_LOAI_KHACH_HANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_PHONG]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_PHONG](
	[MaLoaiPhong] [nvarchar](10) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[DonGia] [money] NULL,
 CONSTRAINT [P_LOAI_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOI_DUNG]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOI_DUNG](
	[MaTaiKhoan] [int] NOT NULL,
	[TenTaiKhoan] [char](50) NOT NULL,
	[MatKhau] [char](20) NOT NULL,
 CONSTRAINT [P_NGUOI_DUNG] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEU_THUE_PHONG]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_THUE_PHONG](
	[MaPhieuThue] [int] NOT NULL,
	[NgayBatDauThue] [date] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[NgayTraPhongDK] [date] NULL,
 CONSTRAINT [P_PHIEU_THUE_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [int] NOT NULL,
	[TinhTrang] [nvarchar](10) NOT NULL,
	[MaLoaiPhong] [nvarchar](10) NOT NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [P_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAM_SO]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAM_SO](
	[SoKhachToiDa] [int] NOT NULL,
	[PhuThu] [float] NOT NULL,
	[HeSo] [float] NOT NULL,
	[SoNgayThue] [int] NULL,
	[PhuThuKhachThu] [int] NULL,
	[SLKhachNuocNgoai] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[BAOCAO_DOANHTHUTHEOLOAIPHONG] ([MaBCDoanhThu], [ThangBaoCao]) VALUES (1, 5)
INSERT [dbo].[BAOCAO_DOANHTHUTHEOLOAIPHONG] ([MaBCDoanhThu], [ThangBaoCao]) VALUES (2, 5)
INSERT [dbo].[BAOCAO_DOANHTHUTHEOLOAIPHONG] ([MaBCDoanhThu], [ThangBaoCao]) VALUES (3, 4)
INSERT [dbo].[BAOCAO_DOANHTHUTHEOLOAIPHONG] ([MaBCDoanhThu], [ThangBaoCao]) VALUES (4, 4)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (1, 5, 1, 150000.0000, 150000.0000, CAST(N'2018-05-16' AS Date), 9)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (2, 6, 1, 170000.0000, 255000.0000, CAST(N'2018-05-17' AS Date), 30)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (3, 7, 1, 170000.0000, 255000.0000, CAST(N'2018-05-17' AS Date), 1)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (4, 8, 1, 150000.0000, 225000.0000, CAST(N'2018-05-17' AS Date), 9)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (5, 9, 1, 200000.0000, 200000.0000, CAST(N'2018-05-17' AS Date), 5)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (6, 10, 1, 150000.0000, 150000.0000, CAST(N'2018-05-17' AS Date), 19)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (7, 11, 1, 200000.0000, 200000.0000, CAST(N'2018-05-17' AS Date), 11)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (8, 14, 1, 170000.0000, 170000.0000, CAST(N'2018-05-17' AS Date), 7)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (9, 15, 1, 150000.0000, 150000.0000, CAST(N'2018-05-17' AS Date), 9)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (10, 15, 1, 150000.0000, 150000.0000, CAST(N'2018-05-17' AS Date), 14)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (11, 15, 1, 200000.0000, 200000.0000, CAST(N'2018-05-17' AS Date), 10)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (12, 16, 1, 150000.0000, 150000.0000, CAST(N'2018-05-17' AS Date), 9)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (13, 17, 1, 170000.0000, 170000.0000, CAST(N'2018-05-17' AS Date), 7)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (14, 18, 1, 200000.0000, 200000.0000, CAST(N'2018-05-17' AS Date), 10)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (15, 19, 4, 170000.0000, 725000.0000, CAST(N'2018-05-21' AS Date), 1)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (16, 20, 4, 170000.0000, 680000.0000, CAST(N'2018-05-21' AS Date), 30)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (17, 27, 1, 150000.0000, 1170000.0000, CAST(N'2018-05-21' AS Date), 9)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (18, 28, 1, 150000.0000, 450000.0000, CAST(N'2018-05-21' AS Date), 14)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (19, 29, 1, 150000.0000, 451386.0000, CAST(N'2018-05-21' AS Date), 19)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (20, 30, 1, 150000.0000, 1170000.0000, CAST(N'2018-05-22' AS Date), 9)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (21, 31, 3, 200000.0000, 645000.0000, CAST(N'2018-05-25' AS Date), 26)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (22, 32, 1, 150000.0000, 427500.0000, CAST(N'2018-04-11' AS Date), 9)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (24, 34, 2, 200000.0000, 400000.0000, CAST(N'2018-05-27' AS Date), 10)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaChiTietHD], [MaHoaDon], [SoNgayThue], [DonGia], [ThanhTien], [NgayThanhToan], [MaPhong]) VALUES (26, 37, 3, 160000.0000, 750000.0000, CAST(N'2018-05-28' AS Date), 19)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([MaChiTietPT], [MaKhachHang], [MaPhieuThue]) VALUES (3, 5, 3)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([MaChiTietPT], [MaKhachHang], [MaPhieuThue]) VALUES (3, 6, 3)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([MaChiTietPT], [MaKhachHang], [MaPhieuThue]) VALUES (3, 7, 3)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([MaChiTietPT], [MaKhachHang], [MaPhieuThue]) VALUES (4, 8, 4)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([MaChiTietPT], [MaKhachHang], [MaPhieuThue]) VALUES (5, 9, 5)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([MaChiTietPT], [MaKhachHang], [MaPhieuThue]) VALUES (5, 10, 5)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([MaChiTietPT], [MaKhachHang], [MaPhieuThue]) VALUES (5, 11, 5)
INSERT [dbo].[CHITIET_BAOCAODOANHTHU] ([MaBCCTDoanhThu], [MaLoaiPhong], [MaBCDoanhThu], [DoanhThuThang], [TiLe]) VALUES (1, N'LP001', 1, 4466386.0000, N'53.61%    ')
INSERT [dbo].[CHITIET_BAOCAODOANHTHU] ([MaBCCTDoanhThu], [MaLoaiPhong], [MaBCDoanhThu], [DoanhThuThang], [TiLe]) VALUES (1, N'LP002', 1, 2765000.0000, N'33.19%    ')
INSERT [dbo].[CHITIET_BAOCAODOANHTHU] ([MaBCCTDoanhThu], [MaLoaiPhong], [MaBCDoanhThu], [DoanhThuThang], [TiLe]) VALUES (1, N'LP003', 1, 1100000.0000, N'13.20%    ')
INSERT [dbo].[CHITIET_BAOCAODOANHTHU] ([MaBCCTDoanhThu], [MaLoaiPhong], [MaBCDoanhThu], [DoanhThuThang], [TiLe]) VALUES (2, N'LP001', 4, 427500.0000, N'100%      ')
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (1, 1, 1, 3)
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (2, 1, 9, 2)
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (3, 2, 19, 2)
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (4, 1, 9, 14)
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (5, 1, 26, 1)
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (6, 1, 26, 1)
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (7, 1, 26, 1)
INSERT [dbo].[DANG_KI_DICH_VU] ([MaDangKi], [MaDichVu], [MaPhong], [SoLuong]) VALUES (8, 1, 3, 3)
INSERT [dbo].[DANH_MUC] ([DMLoaiPhong]) VALUES (N'LP001')
INSERT [dbo].[DANH_MUC] ([DMLoaiPhong]) VALUES (N'LP002')
INSERT [dbo].[DANH_MUC] ([DMLoaiPhong]) VALUES (N'LP003')
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (1, N'Gà Rán KFC', N'Cái', 15000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (2, N'CocaCola', N'Lon', 10000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (3, N'Sữa TH True Milk', N'Lốc', 32000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (4, N'Khoai tây chiên', N'Phần', 100000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (5, N'Karaoke', N'Giờ', 20000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (6, N'Bia 333', N'Lon', 12000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (7, N'Rượu nếp', N'Lít', 79000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (8, N'Sting', N'Chai', 8000.0000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (9, N'BCS Durex', N'Hộp 12 cái', 160000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (1, N'Lý Thị B', 684150000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (2, N'Đào Văn C', 323800000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (3, N'ầdsf', 300000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (4, N'CVBN', 200000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (5, N'213123', 150000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (6, N'asđiaa', 765000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (7, N'kakka', 255000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (8, N'huydeptrai', 225000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (9, N'hfjdhgfh', 200000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (10, N'ádsadá', 150000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (11, N'huy', 200000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (12, N'huýad', 150000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (13, N'huýad', 150000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (14, N'23123', 170000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (15, N'dhfghfg', 500000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (16, N'sađá', 150000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (17, N'huy', 170000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (18, N'hytafds', 200000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (19, N'12', 725000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (20, N'fxgfsfgs', 680000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (21, N'Leesin', 451386.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (22, N'yasuo', 540000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (23, N'Leesin', 451386.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (24, N'huy', 450000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (25, N'Leesin', 451386.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (26, N'yasuo', 718614.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (27, N'yasuo', 1170000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (28, N'huy', 0.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (29, N'Leesin', 451386.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (30, N'huyprozzz', 1170000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (31, N'gdfgdf', 645000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (32, N'Nguyễn Xuân Vịnh', 427500.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (34, N'Nguyễn Thị Thơ', 400000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (36, N'Shinzo Abe', 750000.0000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [TenKhachHang], [TriGia]) VALUES (37, N'Shinzo Abe', 750000.0000)
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [CMND], [DiaChi], [MaLoaiKhach]) VALUES (5, N'Võ Quốc Huy', N'221456714', N'Tuy Hòa, Phú Yên', N'LK001')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [CMND], [DiaChi], [MaLoaiKhach]) VALUES (6, N'Võ Minh Hoàng', N'221456789', N'Tuy Hòa,Phú Yên', N'LK001')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [CMND], [DiaChi], [MaLoaiKhach]) VALUES (7, N'Nguyễn Thị Phò', N'221456482', N'Phú Yên', N'LK001')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [CMND], [DiaChi], [MaLoaiKhach]) VALUES (8, N'Ahrri', N'225656748', N'Lào', N'LK002')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [CMND], [DiaChi], [MaLoaiKhach]) VALUES (9, N'Nguyễn Thị Lý', N'1234678', N'Phú Thọ', N'LK001')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [CMND], [DiaChi], [MaLoaiKhach]) VALUES (10, N'Nguyễn Thị Con', N'235645212', N'Phú Thọ', N'LK001')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [CMND], [DiaChi], [MaLoaiKhach]) VALUES (11, N'Nguyễn Thị Bé', N'123456552', N'Phú Thọ', N'LK001')
INSERT [dbo].[LOAI_KHACH_HANG] ([MaLoaiKhach], [TenLoaiKhach], [GhiChu]) VALUES (N'LK001', N'Nội địa', N'')
INSERT [dbo].[LOAI_KHACH_HANG] ([MaLoaiKhach], [TenLoaiKhach], [GhiChu]) VALUES (N'LK002', N'Nước ngoài', N'')
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [DonGia]) VALUES (N'LP001', N'A', 160000.0000)
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [DonGia]) VALUES (N'LP002', N'B', 170000.0000)
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [DonGia]) VALUES (N'LP003', N'C', 200000.0000)
INSERT [dbo].[NGUOI_DUNG] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau]) VALUES (1, N'buiducquan                                        ', N'vVm/wmKXQdY=        ')
INSERT [dbo].[NGUOI_DUNG] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau]) VALUES (2, N'lequocoai                                         ', N'QuYB6ZMP4k4=        ')
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaPhieuThue], [NgayBatDauThue], [MaPhong], [NgayTraPhongDK]) VALUES (3, CAST(N'2018-03-15' AS Date), 3, CAST(N'2018-05-22' AS Date))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaPhieuThue], [NgayBatDauThue], [MaPhong], [NgayTraPhongDK]) VALUES (4, CAST(N'2018-05-02' AS Date), 1, CAST(N'2018-05-10' AS Date))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaPhieuThue], [NgayBatDauThue], [MaPhong], [NgayTraPhongDK]) VALUES (5, CAST(N'2018-05-01' AS Date), 5, CAST(N'2018-05-30' AS Date))
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (1, N'Đầy', N'LP002', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (2, N'Trống', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (3, N'Đầy', N'LP001', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (5, N'Đầy', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (6, N'Sửa chữa', N'LP002', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (7, N'Trống', N'LP002', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (8, N'Trống', N'LP002', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (9, N'Trống', N'LP001', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (10, N'Trống', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (11, N'Trống', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (13, N'Sửa chữa', N'LP001', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (14, N'Trống', N'LP001', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (17, N'Trống', N'LP002', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (18, N'Trống', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (19, N'Trống', N'LP001', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (20, N'Trống', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (21, N'Sửa chữa', N'LP003', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (22, N'Trống', N'LP002', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (23, N'Trống', N'LP001', N'giường đôi')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (25, N'Trống', N'LP001', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (26, N'Trống', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (27, N'Sửa chữa', N'LP003', N'giường đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TinhTrang], [MaLoaiPhong], [GhiChu]) VALUES (30, N'Trống', N'LP002', N' giường đôi')
INSERT [dbo].[THAM_SO] ([SoKhachToiDa], [PhuThu], [HeSo], [SoNgayThue], [PhuThuKhachThu], [SLKhachNuocNgoai]) VALUES (3, 0.25, 1.5, 26, 3, 1)
ALTER TABLE [dbo].[CHI_TIET_HOA_DON] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON] ADD  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[DICH_VU] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT ((0)) FOR [TriGia]
GO
ALTER TABLE [dbo].[LOAI_KHACH_HANG] ADD  DEFAULT ('') FOR [GhiChu]
GO
ALTER TABLE [dbo].[LOAI_PHONG] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[PHONG] ADD  DEFAULT ('') FOR [GhiChu]
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON]  WITH CHECK ADD  CONSTRAINT [F_CHI_TIET_HOA_DON_1] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOA_DON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON] CHECK CONSTRAINT [F_CHI_TIET_HOA_DON_1]
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON]  WITH CHECK ADD  CONSTRAINT [F_CHI_TIET_HOA_DON_2] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON] CHECK CONSTRAINT [F_CHI_TIET_HOA_DON_2]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE]  WITH CHECK ADD  CONSTRAINT [F_CHI_TIET_PHIEU_THUE_1] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACH_HANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE] CHECK CONSTRAINT [F_CHI_TIET_PHIEU_THUE_1]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE]  WITH CHECK ADD  CONSTRAINT [F_CHI_TIET_PHIEU_THUE_2] FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PHIEU_THUE_PHONG] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE] CHECK CONSTRAINT [F_CHI_TIET_PHIEU_THUE_2]
GO
ALTER TABLE [dbo].[CHITIET_BAOCAODOANHTHU]  WITH CHECK ADD  CONSTRAINT [F_CHITIET_BAOCAODOANHTHU] FOREIGN KEY([MaBCDoanhThu])
REFERENCES [dbo].[BAOCAO_DOANHTHUTHEOLOAIPHONG] ([MaBCDoanhThu])
GO
ALTER TABLE [dbo].[CHITIET_BAOCAODOANHTHU] CHECK CONSTRAINT [F_CHITIET_BAOCAODOANHTHU]
GO
ALTER TABLE [dbo].[CHITIET_BAOCAOMATDOSUDUNG]  WITH CHECK ADD  CONSTRAINT [F_CHITIET_BAOCAOMATDOSUDUNG] FOREIGN KEY([MaBCMatDoSuDung])
REFERENCES [dbo].[BAOCAO_MATDOSUDUNGPHONG] ([MaBCMatDoSuDung])
GO
ALTER TABLE [dbo].[CHITIET_BAOCAOMATDOSUDUNG] CHECK CONSTRAINT [F_CHITIET_BAOCAOMATDOSUDUNG]
GO
ALTER TABLE [dbo].[DANG_KI_DICH_VU]  WITH CHECK ADD  CONSTRAINT [FK_DKDV_DV] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DICH_VU] ([MaDichVu])
GO
ALTER TABLE [dbo].[DANG_KI_DICH_VU] CHECK CONSTRAINT [FK_DKDV_DV]
GO
ALTER TABLE [dbo].[DANG_KI_DICH_VU]  WITH CHECK ADD  CONSTRAINT [FK_DKDV_P] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[DANG_KI_DICH_VU] CHECK CONSTRAINT [FK_DKDV_P]
GO
ALTER TABLE [dbo].[KHACH_HANG]  WITH CHECK ADD  CONSTRAINT [F_KHACH_HANG] FOREIGN KEY([MaLoaiKhach])
REFERENCES [dbo].[LOAI_KHACH_HANG] ([MaLoaiKhach])
GO
ALTER TABLE [dbo].[KHACH_HANG] CHECK CONSTRAINT [F_KHACH_HANG]
GO
ALTER TABLE [dbo].[PHIEU_THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [F_PHIEU_THUE_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[PHIEU_THUE_PHONG] CHECK CONSTRAINT [F_PHIEU_THUE_PHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [F_PHONG] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LOAI_PHONG] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [F_PHONG]
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTinhTrangPhong]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTinhTrangPhong]
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			UPDATE PHONG SET TinhTrang = N'Đầy' WHERE MaPhong = @MaPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

--5. Them moi mot phong
IF OBJECT_ID ( 'dbo.spThemPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemPhong;
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTSDonGia]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTSDonGia]
	@TenLoaiPhong Nvarchar(10),
	@DonGia money
AS
	BEGIN TRAN
		BEGIN
			UPDATE LOAI_PHONG SET DonGia = @DonGia WHERE MaLoaiPhong = @TenLoaiPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTSHeSo]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTSHeSo]
	@HeSo FLOAT
AS
	BEGIN TRAN
		BEGIN
			UPDATE THAM_SO SET HeSo = @HeSo
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTSPhuThu]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTSPhuThu]
	@PhuThu FLOAT
AS
	BEGIN TRAN
		BEGIN
			UPDATE THAM_SO SET PhuThu = @PhuThu
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTSSoKhachToiDa]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTSSoKhachToiDa]
	@SoKhachToiDa INT
AS
	BEGIN TRAN
		BEGIN
			UPDATE THAM_SO SET SoKhachToiDa = @SoKhachToiDa
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spDangKiDichVu]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDangKiDichVu]
	@MaDichVu int,
	@MaPhong int,
	@SoLuong int
AS
	BEGIN TRAN
		BEGIN
			DECLARE @MaDangKi INT
			SET @MaDangKi = 1
			WHILE((SELECT COUNT(*) FROM DANG_KI_DICH_VU WHERE MaDangKi = @MaDangKi) != 0)
			BEGIN
				SET @MaDangKi = @MaDangKi + 1
			END
			INSERT INTO DANG_KI_DICH_VU VALUES(@MaDangKi, @MaDichVu, @MaPhong, @SoLuong)
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spDoanhThuTheoLoaiPhong]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDoanhThuTheoLoaiPhong]
AS
BEGIN TRAN
		BEGIN
			SELECT p.MaLoaiPhong, SUM(hd.TriGia) AS DoanhThu
			FROM PHONG AS p, HOA_DON AS hd, CHI_TIET_HOA_DON AS ct
			WHERE p.MaPhong = ct.MaPhong and ct.MaHoaDon = hd.MaHoaDon
			GROUP BY p.MaLoaiPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spDoanhThuTheoNamTheoThang]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDoanhThuTheoNamTheoThang]
	@Thang INT,
	@Nam INT
AS
BEGIN TRAN
		BEGIN
			SELECT  SUM(hd.TriGia) AS DoanhThu
			FROM PHONG AS p, HOA_DON AS hd, CHI_TIET_HOA_DON AS ct
			WHERE p.MaPhong = ct.MaPhong AND ct.MaHoaDon = hd.MaHoaDon
			AND MONTH(ct.NgayThanhToan) = @Thang AND YEAR(ct.NgayThanhToan) = @Nam
			
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spSuaThongTinDichVu]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSuaThongTinDichVu]
	@MaDichVu INT,
	@TenDichVu NVARCHAR(50),
	@DonViTinh NVARCHAR(10),
	@DonGia Money 
AS
	BEGIN TRAN
		BEGIN
			UPDATE DICH_VU SET TenDichVu = @TenDichVu, DonViTinh = @DonViTinh, DonGia = @DonGia WHERE MaDichVu = @MaDichVu
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spSuaThongTinPhong]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSuaThongTinPhong]
	@MaPhong INT,
	@TinhTrang NVARCHAR(10),
	@MaLoaiPhong NVARCHAR(10),
	@GhiChu NTEXT
AS
	BEGIN TRAN
		BEGIN
			UPDATE PHONG SET TinhTrang = @TinhTrang, MaLoaiPhong = @MaLoaiPhong, GhiChu = @GhiChu WHERE MaPhong = @MaPhong
		END
	COMMIT TRAN
Error:

--execute spSuaThongTinPhong 31, N'Trống', 'LP001', N'nhìn ra biển, giường đôi'

GO
/****** Object:  StoredProcedure [dbo].[spSuaTTLoaiPhong]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSuaTTLoaiPhong]
	@MaLP NVARCHAR(10),
	@TenLP NVARCHAR(50),
	@DonGia MONEY
AS
BEGIN TRAN
		BEGIN
			UPDATE LOAI_PHONG SET TenLoaiPhong = @TenLP, DonGia = @DonGia WHERE MaLoaiPhong = @MaLP
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemBCCTDTTheoLoaiPhongTheoThang]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemBCCTDTTheoLoaiPhongTheoThang]
	@MaBCCTDoanhThu INT,
	@MaLoaiPhong NVARCHAR(10),
	@MaBCDoanhThu INT,
	@DoanhThuThang MONEY,
	@TiLe CHAR(10)
AS
BEGIN TRAN
		BEGIN
			INSERT INTO CHITIET_BAOCAODOANHTHU VALUES (@MaBCCTDoanhThu, @MaLoaiPhong, @MaBCDoanhThu, @DoanhThuThang, @TiLe)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemBCCTMDTheoPhongTheoThang]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemBCCTMDTheoPhongTheoThang]
	@MaBCCTMatDo INT,
	@MaPhong NVARCHAR(10),
	@MaBCMatDo INT,
	@SoNgayThue INT,
	@TiLe CHAR(10)
AS
BEGIN TRAN
		BEGIN
			INSERT INTO CHITIET_BAOCAOMATDOSUDUNG VALUES (@MaBCCTMatDo, @MaPhong, @MaBCMatDo, @SoNgayThue, @TiLe)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemBCDoanhThuTheoLoaiPhongTheoThang]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemBCDoanhThuTheoLoaiPhongTheoThang]
	@MaBCDoanhThu INT,
	@Thang INT
AS
BEGIN TRAN
		BEGIN
			INSERT INTO BAOCAO_DOANHTHUTHEOLOAIPHONG VALUES (@MaBCDoanhThu, @Thang)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemBCMatDoSuDungPhongTheoThang]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemBCMatDoSuDungPhongTheoThang]
	@MaBCCTMatDo INT,
	@Thang INT
AS
BEGIN TRAN
		BEGIN
			INSERT INTO BAOCAO_MATDOSUDUNGPHONG VALUES (@MaBCCTMatDo, @Thang)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemChiTietHD]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemChiTietHD]
	@MaHoaDon INT,
	@SoNgayThue INT,
	@DonGia MONEY,
	@ThanhTien MONEY,
	@NgayThanhToan DATE,
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			DECLARE @MaChiTietHD INT
			SET @MaChiTietHD = 1
			WHILE((SELECT COUNT(*) FROM CHI_TIET_HOA_DON WHERE MaChiTietHD = @MaChiTietHD) != 0)
				BEGIN
					SET @MaChiTietHD = @MaChiTietHD + 1
				END
			INSERT INTO CHI_TIET_HOA_DON VALUES(@MaChiTietHD, @MaHoaDon, @SoNgayThue, @DonGia, @ThanhTien, @NgayThanhToan, @MaPhong)
		END
	COMMIT TRAN
Error:


--10. Xoa khach hang
GO
/****** Object:  StoredProcedure [dbo].[spThemCTPhieuThue]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemCTPhieuThue]
	@MaCTPT INT,
	@MaKH INT,
	@MaPT INT
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO CHI_TIET_PHIEU_THUE VALUES (@MaCTPT, @MaKH, @MaPT)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemDichVu]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemDichVu]
	@TenDichVu NVARCHAR(50),
	@DonViTinh NVARCHAR(10),
	@DonGia MONEY
AS
	BEGIN TRAN
		BEGIN
			DECLARE @MaDichVu INT
			SET @MaDichVu = 1
			WHILE((SELECT COUNT(*) FROM DICH_VU WHERE MaDichVu = @MaDichVu) != 0)
			BEGIN
				SET @MaDichVu = @MaDichVu + 1
			END
			INSERT INTO DICH_VU VALUES(@MaDichVu, @TenDichVu, @DonViTinh, @DonGia)
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spThemHoaDon]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemHoaDon]
	@MaHoaDon INT,
	@TenKhachHang NVARCHAR(50),
	@TriGia MONEY
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO HOA_DON VALUES(@MaHoaDon, @TenKhachHang, @TriGia)
		END
	COMMIT TRAN
Error:

--9. Them moi chi tiet hoa don
GO
/****** Object:  StoredProcedure [dbo].[spThemKhachHang]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemKhachHang]
	@MaKH INT,
	@TenKH NVARCHAR(50),
	@CMND NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@MaLK NVARCHAR(10)
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO KHACH_HANG VALUES (@MaKH, @TenKH, @CMND, @DiaChi, @MaLK)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemLoaiPhong]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemLoaiPhong]
	@MaLP NVARCHAR(10),
	@TenLP NVARCHAR(50),
	@DonGia MONEY
AS
BEGIN TRAN
		BEGIN
			INSERT INTO LOAI_PHONG VALUES (@MaLP, @TenLP, @DonGia)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spThemPhieuThue]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemPhieuThue]
	@MaPT INT,
	@NgayThue DATE,
	@MaPhong INT,
	@NgayTraPhong DATE
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO PHIEU_THUE_PHONG VALUES (@MaPT, @NgayThue, @MaPhong, @NgayTraPhong)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spThemPhongMoi]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemPhongMoi]
	@TinhTrang NVARCHAR(10),
	@MaLoaiPhong NVARCHAR(10),
	@GhiChu NTEXT
AS
	BEGIN TRAN
		BEGIN
			DECLARE @MaPhong INT
			SET @MaPhong = 1
			WHILE((SELECT COUNT(*) FROM PHONG WHERE MaPhong = @MaPhong) != 0)
			BEGIN
				SET @MaPhong = @MaPhong + 1
			END
			INSERT INTO PHONG VALUES(@MaPhong, @TinhTrang, @MaLoaiPhong, @GhiChu)
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spThietLapTTrangPhongBanDau]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThietLapTTrangPhongBanDau]
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			UPDATE PHONG SET TinhTrang = N'Trống' WHERE MaPhong = @MaPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spTruNgayThangNam]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTruNgayThangNam]
	@NgayBDThue DATE
AS
BEGIN
	DECLARE @NgayHienTai DATE
	DECLARE @SLNgayThue INT
	SET @NgayHienTai = GETDATE()
	SET @SLNgayThue = DATEDIFF (DAY, @NgayBDThue, @NgayHienTai)
	
	UPDATE THAM_SO SET SoNgayThue = @SLNgayThue
END

--EXECUTE spTruNgayThangNam '2013-12-29'

--select kh.MaKhachHang, kh.TenKhachHang, kh.CMND, kh.DiaChi, kh.MaLoaiKhach
--from KHACH_HANG as kh, PHIEU_THUE_PHONG as pt, CHI_TIET_PHIEU_THUE as ct
--where kh.MaKhachHang = ct.MaKhachHang and pt.MaPhieuThue = ct.MaPhieuThue
--		and pt.MaPhong = 29

--8. Them moi hoa don
GO
/****** Object:  StoredProcedure [dbo].[spXoaCTPhieuThue]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaCTPhieuThue]
	@MaPhieuThue INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM CHI_TIET_PHIEU_THUE WHERE MaPhieuThue = @MaPhieuThue
		END
	COMMIT TRAN
Error:

--12. Xoa phieu thue
GO
/****** Object:  StoredProcedure [dbo].[spXoaDichVu]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaDichVu]
	@MaDichVu INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM DICH_VU WHERE MaDichVu = @MaDichVu
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spXoaKhachHang]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaKhachHang]
	@MaKhacHang INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM KHACH_HANG WHERE MaKhachHang = @MaKhacHang
		END
	COMMIT TRAN
Error:

--execute spXoaKhachHang 15

--11. Xoa chi tiet phieu thue
GO
/****** Object:  StoredProcedure [dbo].[spXoaLoaiPhong]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaLoaiPhong]
	@MaLP NVARCHAR(10)
AS
BEGIN TRAN
		BEGIN
			DELETE FROM PHONG WHERE MaLoaiPhong = @MaLP
			DELETE FROM LOAI_PHONG WHERE MaLoaiPhong = @MaLP
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:
GO
/****** Object:  StoredProcedure [dbo].[spXoaPhieuThue]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaPhieuThue]
	@MaPhieuThue INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM PHIEU_THUE_PHONG WHERE MaPhieuThue = @MaPhieuThue
		END
	COMMIT TRAN
Error:

GO
/****** Object:  StoredProcedure [dbo].[spXoaPhong]    Script Date: 5/28/2018 8:51:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaPhong]
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM PHONG WHERE MaPhong = @MaPhong
		END
	COMMIT TRAN
Error:

--execute spXoaPhong 31

--Thu cau truy van
--Lay so luong loai khach hang
select COUNT(*)
from PHIEU_THUE_PHONG as pt, CHI_TIET_PHIEU_THUE as ct, KHACH_HANG as kh
where pt.MaPhieuThue = ct.MaPhieuThue and kh.MaKhachHang = ct.MaKhachHang
		and pt.MaPhong = 29 and kh.MaLoaiKhach = 'LK001'
		
select NgayBatDauThue, DonGia
from PHIEU_THUE_PHONG as pt, PHONG as p, LOAI_PHONG as lp
where p.MaPhong = pt.MaPhong and p.MaLoaiPhong = lp.MaLoaiPhong and pt.MaPhong = 32

GO
USE [master]
GO
ALTER DATABASE [QUAN_LY_KHACH_SAN] SET  READ_WRITE 
GO
