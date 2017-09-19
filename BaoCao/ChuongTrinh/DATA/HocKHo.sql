USE [master]
GO
/****** Object:  Database [HocKHo]    Script Date: 8/25/2017 9:39:26 PM ******/
CREATE DATABASE [HocKHo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HocKHo', FILENAME = N'D:\Study\DoAn\BaoCao\ChuongTrinh\SOURCE\DACN_UD_Hoc_KHo_CTK37\DACN_UD_Hoc_KHo_CTK37\App_Data\HocKHo.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HocKHo_log', FILENAME = N'D:\Study\DoAn\BaoCao\ChuongTrinh\SOURCE\DACN_UD_Hoc_KHo_CTK37\DACN_UD_Hoc_KHo_CTK37\App_Data\HocKHo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HocKHo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HocKHo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HocKHo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HocKHo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HocKHo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HocKHo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HocKHo] SET ARITHABORT OFF 
GO
ALTER DATABASE [HocKHo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HocKHo] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [HocKHo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HocKHo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HocKHo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HocKHo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HocKHo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HocKHo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HocKHo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HocKHo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HocKHo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HocKHo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HocKHo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HocKHo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HocKHo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HocKHo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HocKHo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HocKHo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HocKHo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HocKHo] SET  MULTI_USER 
GO
ALTER DATABASE [HocKHo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HocKHo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HocKHo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HocKHo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [HocKHo]
GO
/****** Object:  Table [dbo].[BaiHoc]    Script Date: 8/25/2017 9:39:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiHoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKHo] [nvarchar](250) NULL,
	[TenViet] [nvarchar](250) NULL,
 CONSTRAINT [PK_BaiHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BaiKhoa]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiKhoa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoiKHo] [ntext] NULL,
	[TraLoiKHo] [ntext] NULL,
	[HoiViet] [ntext] NULL,
	[TraLoiViet] [ntext] NULL,
	[NoiDung] [ntext] NULL,
	[IDDanhMucCon] [int] NULL,
 CONSTRAINT [PK_BaiKhoa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Hoi] [nvarchar](250) NULL,
	[TraLoi] [ntext] NULL,
	[IDDanhMucCon] [int] NULL,
 CONSTRAINT [PK_CauHoi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DamThoai]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DamThoai](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CauHoiKHo] [ntext] NULL,
	[TraLoiKHo] [ntext] NULL,
	[CauHoiViet] [ntext] NULL,
	[TraLoiViet] [ntext] NULL,
	[IDDanhMucCon] [int] NULL,
 CONSTRAINT [PK_DamThoai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKHo] [nvarchar](250) NULL,
	[TenViet] [nvarchar](250) NULL,
	[IDBaiHoc] [int] NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucCon]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucCon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](250) NULL,
	[IDDanhMuc] [int] NULL,
	[IDHinh] [int] NULL,
 CONSTRAINT [PK_DanhMucCon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichKHoViet]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichKHoViet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KHo] [ntext] NULL,
	[Viet] [ntext] NULL,
	[IDDanhMucCon] [int] NULL,
 CONSTRAINT [PK_DichKHoViet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVietKHo]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVietKHo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Viet] [ntext] NULL,
	[KHo] [ntext] NULL,
	[IDDanhMucCon] [int] NULL,
 CONSTRAINT [PK_DichVietKHo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hinh]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHinh] [nvarchar](250) NULL,
	[DuongDan] [ntext] NULL,
 CONSTRAINT [PK_Hinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoiHayYDep]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoiHayYDep](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CauKHo] [ntext] NULL,
	[CauViet] [ntext] NULL,
	[IDBaiHoc] [int] NULL,
 CONSTRAINT [PK_LoiHayYDep] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LuyenTap]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuyenTap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoiKHo] [nvarchar](250) NULL,
	[HoiViet] [nvarchar](250) NULL,
	[TraLoiKHo] [ntext] NULL,
	[TraLoiViet] [ntext] NULL,
	[IDDanhMucCon] [int] NULL,
 CONSTRAINT [PK_LuyenTap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TuVung]    Script Date: 8/25/2017 9:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuVung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KHo] [nvarchar](250) NULL,
	[Viet] [nvarchar](250) NULL,
	[IDDanhMucCon] [int] NULL,
 CONSTRAINT [PK_TuVung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BaiHoc] ON 

INSERT [dbo].[BaiHoc] ([ID], [TenKHo], [TenViet]) VALUES (1, N'JƠNAU MƠ KHAR KƠHO', NULL)
INSERT [dbo].[BaiHoc] ([ID], [TenKHo], [TenViet]) VALUES (2, N'KỜP KHA', N'ĐẾM SỐ')
INSERT [dbo].[BaiHoc] ([ID], [TenKHo], [TenViet]) VALUES (3, N'TU| TƠNGAI', N'THỜI GIAN')
INSERT [dbo].[BaiHoc] ([ID], [TenKHo], [TenViet]) VALUES (4, N'LÙP MƠ HƠ', N'HÒI VÀ TRẢ LỜI')
SET IDENTITY_INSERT [dbo].[BaiHoc] OFF
SET IDENTITY_INSERT [dbo].[DamThoai] ON 

INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (1, N'N|chi do? (Do làh n\chi pơ?)', N'Do làh ………………….(1)', N'Cái gì đây? (Đây là cái gì?)', N'Đây là ………………….(1)', 9)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (2, N'Mê lòt mơ n\cau?', N'An\ lòt is dùl nă.', N'Anh đi với ai?', N'Tôi đi một mình', 11)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (3, N'N|cau lòt bal mơ mê?', N'An\ lòt mơ bau an\.', N'Anh đi cùng với ai?', N'Tôi đi với vợ tôi', 11)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (4, N'Bi rơwah ào dà pơ?', N'An\ rơwah ào dà tơlir', N'Anh chọn áo màu nào?', N'Tôi chọn áo màu xanh.', 13)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (5, N'Gùng do mpa đah lòt?', N'Gùng do lòt tus sàh Lat.', N'Đường này đi đâu?', N'Đường này đi đến xã Lát', 15)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (6, N'Bi mpa đah ơm?', N'An| ơm [òn Bơdơr', N'Anh ở đâu?', N'Tôi ở buôn Bờ Đơr', 15)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (7, N'Mpa đah sră?', N'Sră ơm rềp sră cih.', N'Quyển sách ở đâu?', N'Quyển sách ở gần quyển vở.', 15)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (8, N'Gai cih mpa đah?', N'Gai cih tàm ……. (1)hồp.', N'Cây bút ở đâu?', N'Cây bút ở ……. (1) cái hộp.', 15)
INSERT [dbo].[DamThoai] ([ID], [CauHoiKHo], [TraLoiKHo], [CauHoiViet], [TraLoiViet], [IDDanhMucCon]) VALUES (9, N'N|chi bơh tài bi gơboh bơsram jơnau Kơho?', N'Tài bơh an\ kờn\ đơs, iat mơ wa\ jơnau Kơho. ', N'Tại sao anh thích học tiếng Cơ Ho?', N'Vì tôi muốn nói, nghe và hiểu được tiếng Cơ Ho.', 17)
SET IDENTITY_INSERT [dbo].[DamThoai] OFF
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (1, NULL, NULL, 1)
INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (2, NULL, NULL, 2)
INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (3, NULL, NULL, 3)
INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (4, N'N|CHI DO? ', N'CÁI GÌ ĐÂY?', 4)
INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (5, N'N|CAU HƠ|? ', N'AI ĐÓ', 4)
INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (6, N'DÀ GUR LƠI?', N'MÀU GÌ?', 4)
INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (7, N'NTỀNG?', N'ĐÂU?', 4)
INSERT [dbo].[DanhMuc] ([ID], [TenKHo], [TenViet], [IDBaiHoc]) VALUES (8, N'N|CHI BƠH TÀI?', N'TẠI SAO', 4)
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
SET IDENTITY_INSERT [dbo].[DanhMucCon] ON 

INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (1, N'Từ vựng', 2, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (2, N'Từ vựng', 2, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (3, N'Luyện tập', 2, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (4, N'Từ vựng', 3, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (5, N'Dịch tiếng K''Ho sang tiếng Việt', 3, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (6, N'Từ vựng', 3, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (7, N'Luyện tập', 3, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (8, N'Từ vựng', 4, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (9, N'Đàm thoại', 4, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (10, N'Từ vựng', 5, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (11, N'Đàm thoại', 5, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (12, N'Từ vựng', 6, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (13, N'Đàm thoại', 6, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (14, N'Từ vựng', 7, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (15, N'Đàm thoại', 7, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (16, N'Từ vựng', 8, NULL)
INSERT [dbo].[DanhMucCon] ([ID], [Ten], [IDDanhMuc], [IDHinh]) VALUES (17, N'Đàm thoại', 8, NULL)
SET IDENTITY_INSERT [dbo].[DanhMucCon] OFF
SET IDENTITY_INSERT [dbo].[DichKHoViet] ON 

INSERT [dbo].[DichKHoViet] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (1, N'Ngai dơ\ nđờ?', N'Ngày thứ mấy?', 5)
INSERT [dbo].[DichKHoViet] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (2, N'Ngai dơ\ bàr', N'Ngày thứ hai', 5)
INSERT [dbo].[DichKHoViet] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (3, N'Ngai lơi?', N'Ngày mấy?', 5)
INSERT [dbo].[DichKHoViet] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (4, N'Ngai sin nhai bàr nam bàr rờbô pram', N'Ngày 9 tháng 2 năm 2015', 5)
SET IDENTITY_INSERT [dbo].[DichKHoViet] OFF
SET IDENTITY_INSERT [dbo].[LuyenTap] ON 

INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (1, N'Kờp bơh khà dùl tus khà bàr jơt', N'Đếm từ số 1 đến số 20', NULL, NULL, 3)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (2, N'Kờp bơh khà jớt tus khà dùl', N'Đếm từ số 10 đến số 1', NULL, NULL, 3)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (3, N'Đal: 2.153.978.654 đong', N'Đọc: 2.153.978.645 đồng', NULL, NULL, 3)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (4, N'Dùl rơhiang mơ puan rơhiang làh nđờ rờhiang?', N'Một trăm với bốn trăm là mấy trăm?', NULL, NULL, 3)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (5, N'Dùl rờhiang mờ puan rơhiang làh pram rơhiang.', N'Một trăm với bốn trăm là năm trăm', NULL, NULL, 3)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (6, N'Tu\ lơi bi rê bic?', N'Khi nào anh đi ngủ?', N'An\ rê bic tu\ jơt jơ', N'Tôi đi ngủ lúc 10 giờ', 7)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (7, N'Àng drim nđờ jơ bi guh bic?', N'Buổi sáng mấy giờ anh thức dậy?', N'Prau jơ drim an\ guh bic.', N'Sáu giờ sáng tôi thức dậy.', 7)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (8, N'Ngai hìng nđờ jơ mè lòt broa\?', N'Ngày mai mẹ đi làm lúc mấy giờ?', N'Drim hìng mè lòt lơh broa\ tu\ poh jơ.', N'Sáng mai mẹ đi làm lúc bảy giờ.', 7)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (9, N'Ngai do làh ngai dơ\ nđờ?', N'Hôm này là ngày thứ mấy?', N'Ngai do làh ngai dơ\ pram.', N'Hôm nay là ngày thứ năm', 7)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (10, N'Ngai hìng làh ngai pơ?', N'Ngày mai là ngày nào?', N'Ngai hìng làh ngai dơ\ prau.', N'Ngày mai là ngày thứ sáu.', 7)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (11, N'Ngai hìng nau làh ngai nđờ?', N'Ngày mốt là ngày bao nhiêu?', N'Ngai hìng nau làh ngai bàr jơt pe.', N'Ngày mốt là ngày hai mươi ba.', 7)
INSERT [dbo].[LuyenTap] ([ID], [HoiKHo], [HoiViet], [TraLoiKHo], [TraLoiViet], [IDDanhMucCon]) VALUES (12, N'Ngai dơ là làh ngai dơ\ nđờ?', N'Ngày kia là ngài thứ mấy?', N'Ngai dơ là làh ngai n\ờk, ngai rơlô', N'Ngày kia là ngày chủ nhật, ngày nghỉ ngơi.', NULL)
SET IDENTITY_INSERT [dbo].[LuyenTap] OFF
SET IDENTITY_INSERT [dbo].[TuVung] ON 

INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (1, N'dùl', N'1', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (2, N'bàr', N'2', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (3, N'pe', N'3', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (4, N'puan (puơn, poan)', N'4', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (5, N'pram', N'5', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (6, N'prau', N'6', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (7, N'poh', N'7', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (8, N'phàm', N'8', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (9, N'sin', N'9', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (10, N'jơt', N'10', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (11, N'dùl rơhiang', N'100', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (12, N'dùl rờbô', N'1000', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (13, N'dùl tờlak', N'1000000', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (14, N'dùl tơman', N'1000000000', 1)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (15, N'Jơnau', N'bài', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (16, N'Kha', N'số', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (17, N'Đong', N'đồng', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (18, N'Đal', N'đọc', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (19, N'Kờp', N'đếm', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (20, N'Làh', N'là', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (21, N'Bơh … tus …', N'từ...đến...', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (22, N'Mơ', N'anh \t quan', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (23, N'Nđờ', N'khanh\n vinh', 2)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (24, N'Nđờ jơ?', N'mấy giờ', 4)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (25, N'Tu\ ', N'lúc, khi', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (26, N'Jơ', N'giờ', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (27, N'Nggùl jơ', N'nửa giờ', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (28, N'Phuk', N'phút', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (29, N'Ngai', N'ngày', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (30, N'Tu\ tơngai', N'thời gian', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (31, N'Dơ\ bàr', N'thứ hai', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (32, N'Ngai n\ờk', N'ngày chủ nhật', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (33, N'Nhai', N'tháng, mùa', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (34, N'Nam', N'năm', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (35, N'Ngai do', N'hôm nay', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (36, N'Ngai hìng', N'ngày mai', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (37, N'Ngai hìng nau', N'ngày mốt', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (38, N'Ngai dơ là', N'ngày kia', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (39, N'Drim', N'sáng', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (40, N'Mho', N'chiều', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (41, N'Mang', N'tối', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (42, N'Mè (me)', N'mẹ', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (43, N'An', N'tôi', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (44, N'Bi', N'anh', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (45, N'Lòt', N'đi', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (46, N'Rê', N'đi về', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (47, N'Bic', N'ngủ', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (48, N'Rơle', N'chậm', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (49, N'Rơlô', N'nghỉ ngơi', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (50, N'Guh', N'thức dậy', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (51, N'Lơh', N'làm', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (52, N'Broa\ (brua\)	', N'công việc', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (53, N'Sang te\', N'lãng phí', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (54, N'Ban', N'đừng', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (55, N'Lơi?', N'mấy? nào?', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (56, N'Pơ?', N'nào', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (57, N'Nđờ?', N'mấy?', 6)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (58, N'Bồ', N'đầu', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (59, N'Tồr', N'tai', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (60, N'Ngko', N'cổ', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (61, N'So', N'tóc', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (62, N'Bơr', N'miệng', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (63, N'Mat', N'mắt', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (64, N'Muh', N'mũi', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (65, N'Tê', N'tay', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (66, N'Ndul', N'bụng', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (67, N'Jơng', N'chân', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (68, N'Do', N'đây, này', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (69, N'Lùp', N'hỏi', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (70, N'Hơ', N'trả lời', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (71, N'N|||chi?', N'cái gì?', 8)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (72, N'An', N'tôi', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (73, N'Bol an', N'chúng tôi', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (74, N'Bi', N'anh', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (75, N'Mê', N'mày, anh (dành cho nam giới)', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (76, N'Ai', N'mày (giành cho nữ giới)', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (77, N'Oh', N'em', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (78, N'Oh mi (bi)', N'anh em', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (79, N'Khai', N'nó, anh ấy', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (80, N'Khi', N'họ', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (81, N'Nă', N'người, đứa', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (82, N'Bau', N'vợ, chồng', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (83, N'Bal', N'cùng', 10)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (84, N'Tờlir', N'xanh', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (85, N'Pơrhê', N'đỏ', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (86, N'Dum rìng', N'nâu', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (87, N'Dum phồng', N'hồng', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (88, N'Rờmit', N'vàng', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (89, N'Jù (wàm, ồt, nđồc)', N'đen', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (90, N'Bò (kò)', N'trắng', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (91, N'Dà gur', N'nước, màu', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (92, N'Ào', N'áo', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (93, N'Rơwah (sac)', N'chọn', 12)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (94, N'Tềng (anih, cồh)', N'chỗ', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (95, N'Tềng do', N'ở đây', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (96, N'Anih do', N'chỗ này', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (97, N'Anih ne', N'chỗ', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (98, N'Đah do', N'bên này', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (99, N'Đah ne', N'bên kia', 14)
GO
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (100, N'Đah ma', N'bên phải', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (101, N'Đah kiau (kiơu)', N'bên trái', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (102, N'Hơ đang', N'ở trên', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (103, N'Hơ đơm', N'ở dưới', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (104, N'Tềng (tơ) gùl', N'ở giữa', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (105, N'Tàm dơlam', N'bên trong', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (106, N'Bơdìh', N'ở ngoài', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (107, N'Tơ kêng', N'bên cạnh', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (108, N'Tơ (hơ) đap', N'phía trước', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (109, N'Tơ (hơ) nỡ', N'đằng sau', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (110, N'Rềp', N'gần', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (111, N'Ơm', N'ở', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (112, N'{òn', N'buôn', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (113, N'Sàh', N'xã', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (114, N'Gùng', N'đường', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (115, N'Sră', N'giấy, quyển sách', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (116, N'Cih', N'viết', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (117, N'Sră cih', N'quyển vở', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (118, N'Gai cih', N'cây viết', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (119, N'Ntềng (mpa đah)', N'đâu?', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (120, N'Tàm', N'ở, tại', 14)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (121, N'Jơnau (dà) Kơho', N'tiếng Cơ Ho', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (122, N'Gơboh', N'thích', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (123, N'Bơsram', N'học', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (124, N'Kờn', N'muốn', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (125, N'Đơs', N'nói', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (126, N'Iat', N'nghe', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (127, N'Wă', N'hiểu', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (128, N'Prap gàr', N'bảo tồn', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (129, N'Pal', N'hãy', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (130, N'N|chi bowh tài?', N'tại sao?', 16)
INSERT [dbo].[TuVung] ([ID], [KHo], [Viet], [IDDanhMucCon]) VALUES (131, N'Tài bơh', NULL, 16)
SET IDENTITY_INSERT [dbo].[TuVung] OFF
ALTER TABLE [dbo].[BaiKhoa]  WITH CHECK ADD  CONSTRAINT [FK_BaiKhoa_DanhMucCon] FOREIGN KEY([IDDanhMucCon])
REFERENCES [dbo].[DanhMucCon] ([ID])
GO
ALTER TABLE [dbo].[BaiKhoa] CHECK CONSTRAINT [FK_BaiKhoa_DanhMucCon]
GO
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_CauHoi_DanhMucCon] FOREIGN KEY([IDDanhMucCon])
REFERENCES [dbo].[DanhMucCon] ([ID])
GO
ALTER TABLE [dbo].[CauHoi] CHECK CONSTRAINT [FK_CauHoi_DanhMucCon]
GO
ALTER TABLE [dbo].[DamThoai]  WITH CHECK ADD  CONSTRAINT [FK_DamThoai_DanhMucCon] FOREIGN KEY([IDDanhMucCon])
REFERENCES [dbo].[DanhMucCon] ([ID])
GO
ALTER TABLE [dbo].[DamThoai] CHECK CONSTRAINT [FK_DamThoai_DanhMucCon]
GO
ALTER TABLE [dbo].[DanhMuc]  WITH CHECK ADD  CONSTRAINT [FK_DanhMuc_BaiHoc] FOREIGN KEY([IDBaiHoc])
REFERENCES [dbo].[BaiHoc] ([ID])
GO
ALTER TABLE [dbo].[DanhMuc] CHECK CONSTRAINT [FK_DanhMuc_BaiHoc]
GO
ALTER TABLE [dbo].[DanhMucCon]  WITH CHECK ADD  CONSTRAINT [FK_DanhMucCon_DanhMuc] FOREIGN KEY([IDDanhMuc])
REFERENCES [dbo].[DanhMuc] ([ID])
GO
ALTER TABLE [dbo].[DanhMucCon] CHECK CONSTRAINT [FK_DanhMucCon_DanhMuc]
GO
ALTER TABLE [dbo].[DichKHoViet]  WITH CHECK ADD  CONSTRAINT [FK_DichKHoViet_DanhMucCon] FOREIGN KEY([IDDanhMucCon])
REFERENCES [dbo].[DanhMucCon] ([ID])
GO
ALTER TABLE [dbo].[DichKHoViet] CHECK CONSTRAINT [FK_DichKHoViet_DanhMucCon]
GO
ALTER TABLE [dbo].[DichVietKHo]  WITH CHECK ADD  CONSTRAINT [FK_DichVietKHo_DanhMucCon] FOREIGN KEY([IDDanhMucCon])
REFERENCES [dbo].[DanhMucCon] ([ID])
GO
ALTER TABLE [dbo].[DichVietKHo] CHECK CONSTRAINT [FK_DichVietKHo_DanhMucCon]
GO
ALTER TABLE [dbo].[LoiHayYDep]  WITH CHECK ADD  CONSTRAINT [FK_LoiHayYDep_BaiHoc] FOREIGN KEY([IDBaiHoc])
REFERENCES [dbo].[BaiHoc] ([ID])
GO
ALTER TABLE [dbo].[LoiHayYDep] CHECK CONSTRAINT [FK_LoiHayYDep_BaiHoc]
GO
ALTER TABLE [dbo].[LuyenTap]  WITH CHECK ADD  CONSTRAINT [FK_LuyenTap_DanhMucCon] FOREIGN KEY([IDDanhMucCon])
REFERENCES [dbo].[DanhMucCon] ([ID])
GO
ALTER TABLE [dbo].[LuyenTap] CHECK CONSTRAINT [FK_LuyenTap_DanhMucCon]
GO
ALTER TABLE [dbo].[TuVung]  WITH CHECK ADD  CONSTRAINT [FK_TuVung_DanhMucCon] FOREIGN KEY([IDDanhMucCon])
REFERENCES [dbo].[DanhMucCon] ([ID])
GO
ALTER TABLE [dbo].[TuVung] CHECK CONSTRAINT [FK_TuVung_DanhMucCon]
GO
USE [master]
GO
ALTER DATABASE [HocKHo] SET  READ_WRITE 
GO
