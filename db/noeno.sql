USE [master]
GO
/****** Object:  Database [NewProject_db]    Script Date: 6/14/2021 11:25:36 AM ******/
CREATE DATABASE [NewProject_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NewProject_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewProject_db.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NewProject_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewProject_db_log.ldf' , SIZE = 2368KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NewProject_db] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NewProject_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NewProject_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NewProject_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NewProject_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NewProject_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NewProject_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [NewProject_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NewProject_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NewProject_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NewProject_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NewProject_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NewProject_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NewProject_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NewProject_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NewProject_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NewProject_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [NewProject_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NewProject_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NewProject_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NewProject_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NewProject_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NewProject_db] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [NewProject_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NewProject_db] SET RECOVERY FULL 
GO
ALTER DATABASE [NewProject_db] SET  MULTI_USER 
GO
ALTER DATABASE [NewProject_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NewProject_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NewProject_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NewProject_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [NewProject_db] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'NewProject_db', N'ON'
GO
USE [NewProject_db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AdminPays]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminPays](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[Time] [datetime2](7) NOT NULL,
	[Price] [int] NOT NULL,
	[TypePay] [nvarchar](max) NULL,
 CONSTRAINT [PK_AdminPays] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_GalleryProducts]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_GalleryProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProduct] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_GalleryProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_ImageGalleries]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ImageGalleries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdGallery] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_ImageGalleries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Adress]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Adress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[Post] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[FirstAddress] [nvarchar](max) NULL,
	[SecondAddress] [nvarchar](max) NULL,
	[LocationAd] [nvarchar](max) NULL,
	[Tel1Ad] [nvarchar](max) NULL,
	[Tel2Ad] [nvarchar](max) NULL,
	[Officetel1Ad] [nvarchar](max) NULL,
	[Officetel2Ad] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Adress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Advertisings]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Advertisings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_creator] [nvarchar](max) NULL,
	[Category] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Image1] [nvarchar](max) NULL,
	[Image2] [nvarchar](max) NULL,
	[Image3] [nvarchar](max) NULL,
	[Title_Pro] [nvarchar](max) NULL,
	[Discreption_Pro] [nvarchar](max) NULL,
	[Type_pro] [nvarchar](max) NULL,
	[Type_Transaction] [nvarchar](max) NULL,
	[Main_Price_Auction] [nvarchar](max) NULL,
	[Auction_Time] [nvarchar](max) NULL,
	[Auction_Start_Time] [nvarchar](max) NULL,
	[Main_Price] [nvarchar](max) NULL,
	[PriceB] [int] NOT NULL,
	[Pricek] [int] NOT NULL,
	[PricekC] [int] NOT NULL,
	[Discount_Price] [nvarchar](max) NULL,
	[Online_Exchange] [nvarchar](max) NULL,
	[Take_Discount] [nvarchar](max) NULL,
	[Time] [datetime2](7) NOT NULL,
	[State] [nvarchar](max) NULL,
	[TimeReturn] [datetime2](7) NOT NULL,
	[WhyReturn] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Special] [nvarchar](max) NULL,
	[Number] [int] NOT NULL,
	[FatherIdCat] [nvarchar](max) NULL,
	[Father] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Advertisings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Agencie]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Agencie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageAg] [nvarchar](max) NULL,
	[NameAg] [nvarchar](max) NULL,
	[NamePersenAg] [nvarchar](max) NULL,
	[TelAg] [nvarchar](max) NULL,
	[OfficetelAg] [nvarchar](max) NULL,
	[LocationAg] [nvarchar](max) NULL,
	[DescreptionAg] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Agencie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Baner]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Baner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleSlid] [nvarchar](max) NULL,
	[CategoryIdSlid] [int] NOT NULL,
	[CategoryProductIdSlid] [int] NOT NULL,
	[TypeSlid] [nvarchar](max) NULL,
	[ImageMainSlid] [nvarchar](max) NULL,
	[link] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Baner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Blog]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Blog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleBLo] [nvarchar](max) NULL,
	[IdCtegoryBlo] [int] NOT NULL,
	[SummaryBlo] [nvarchar](max) NULL,
	[ImageMainBlo] [nvarchar](max) NULL,
	[FullTextBlo] [nvarchar](max) NULL,
	[KeywordsBlo] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Blog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_category]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCat] [nvarchar](max) NULL,
	[FatherIdCat] [int] NOT NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Comments]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [nvarchar](max) NULL,
	[Resever_Id] [nvarchar](max) NULL,
	[Send_Id] [nvarchar](max) NULL,
	[blog_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[DateComment] [datetime2](7) NOT NULL,
	[State] [bit] NOT NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Experts]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Experts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameEx] [nvarchar](max) NULL,
	[ImageEx] [nvarchar](max) NULL,
	[TelEx] [nvarchar](max) NULL,
	[OfficeTelEx] [nvarchar](max) NULL,
	[LocationEx] [nvarchar](max) NULL,
	[AboutEx] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Experts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Factors]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Factors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Order] [int] NOT NULL,
	[Id_creator] [int] NOT NULL,
	[Id_Factro] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[product_Name] [nvarchar](max) NULL,
	[Date_Order] [datetime2](7) NOT NULL,
	[Product_Count] [int] NOT NULL,
	[product_Price] [int] NOT NULL,
	[Total_sum] [int] NOT NULL,
	[StatusA] [nvarchar](max) NULL,
	[StatusM] [nvarchar](max) NULL,
	[Type_Transaction] [nvarchar](max) NULL,
	[TellBuy] [nvarchar](max) NULL,
	[TellSel] [nvarchar](max) NULL,
	[IdUser] [int] NOT NULL,
	[Post] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[FirstAddress] [nvarchar](max) NULL,
	[PriceB] [int] NOT NULL,
	[PriceK] [int] NOT NULL,
	[NameBuy] [nvarchar](max) NULL,
	[NameSel] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Pay] [nvarchar](max) NULL,
	[Send_Sales_Code] [nvarchar](max) NULL,
	[Send_Order_Code] [nvarchar](max) NULL,
	[Send_Admin_Code] [nvarchar](max) NULL,
	[Why_Return_Admin_Bazrasi] [nvarchar](max) NULL,
	[Why_Return_Request] [nvarchar](max) NULL,
	[ImageReturn] [nvarchar](max) NULL,
	[ImgNoB] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Factors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Factors2]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Factors2](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdOrder] [int] NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdSeller] [int] NOT NULL,
	[IdKala] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[prices] [int] NOT NULL,
	[Date] [int] NOT NULL,
	[Address] [int] NOT NULL,
	[Ordertype] [int] NOT NULL,
	[Inspection] [int] NOT NULL,
	[Orderstatus] [int] NOT NULL,
	[Reference] [int] NOT NULL,
	[Code] [int] NOT NULL,
	[X] [int] NOT NULL,
	[Y] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_Factors2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Financial]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Financial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserNameFi] [nvarchar](max) NULL,
	[TelFi] [nvarchar](max) NULL,
	[RemovalFi] [nvarchar](max) NULL,
	[DepositFi] [nvarchar](max) NULL,
	[DateFi] [datetime2](7) NOT NULL,
	[StateFi] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Financial] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Gallery]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Gallery](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleGal] [nvarchar](max) NULL,
	[pathImage] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Gallery] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Logo]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Logo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleLogo] [nvarchar](max) NULL,
	[ImageLogo] [nvarchar](max) NULL,
	[FavIcon] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Logo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Message]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Message](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SenderMess] [nvarchar](max) NULL,
	[ResiverMess] [nvarchar](max) NULL,
	[DateMess] [datetime2](7) NOT NULL,
	[SubjectMess] [nvarchar](max) NULL,
	[TextMess] [nvarchar](max) NULL,
	[StateMess] [bit] NOT NULL,
	[Language] [nvarchar](max) NULL,
	[pathfile] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Message] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_MyFavorites]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_MyFavorites](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdKala] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_MyFavorites] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Order]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_user] [int] NOT NULL,
	[Date_Order] [datetime2](7) NOT NULL,
	[Pay] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Originality]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Originality](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProductOri] [int] NOT NULL,
	[NumberProductOri] [nvarchar](max) NULL,
	[DateCreateOri] [datetime2](7) NOT NULL,
	[HologramCodeOri] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Originality] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Pays]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Pays](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[NameFamily] [nvarchar](max) NULL,
	[Pay] [int] NOT NULL,
	[Harvest] [int] NOT NULL,
	[Paytime] [datetime2](7) NOT NULL,
	[havesttime] [datetime2](7) NOT NULL,
	[status] [bit] NOT NULL,
	[iduser] [int] NOT NULL,
	[Id_Factro] [int] NOT NULL,
	[StatusP] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Pays] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Price]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Price](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cat_Type] [nvarchar](max) NULL,
	[Min] [nvarchar](max) NULL,
	[Max] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Price] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Product]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleProductPro] [nvarchar](max) NULL,
	[ImageMainPro] [nvarchar](max) NULL,
	[CategoryIdPro] [nvarchar](max) NULL,
	[PricePro] [nvarchar](max) NULL,
	[OfferPro] [nvarchar](max) NULL,
	[SizePro] [nvarchar](max) NULL,
	[ColorPro] [nvarchar](max) NULL,
	[BrandPro] [nvarchar](max) NULL,
	[TypeCarPro] [nvarchar](max) NULL,
	[MaterialPro] [nvarchar](max) NULL,
	[TotalPro] [nvarchar](max) NULL,
	[DescreptionPro] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Richats]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Richats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ScriptChat] [nvarchar](max) NULL,
	[zarinpal] [nvarchar](max) NULL,
	[enemad] [nvarchar](max) NULL,
	[sms] [nvarchar](max) NULL,
	[website] [nvarchar](max) NULL,
	[paternsms] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Richats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_SendNumberCodes]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_SendNumberCodes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LessonName] [nvarchar](max) NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_SendNumberCodes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Slider]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Slider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleSlid] [nvarchar](max) NULL,
	[CategoryIdSlid] [int] NOT NULL,
	[CategoryProductIdSlid] [int] NOT NULL,
	[TypeSlid] [nvarchar](max) NULL,
	[ImageMainSlid] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[linkslaid] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Slider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_SocialNetwork]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_SocialNetwork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Instagram] [nvarchar](max) NULL,
	[Telegram] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Twitter] [nvarchar](max) NULL,
	[Whatsapp] [nvarchar](max) NULL,
	[Aparat] [nvarchar](max) NULL,
	[Youtube] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_SocialNetwork] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Teaser]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Teaser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleTeaser] [nvarchar](max) NULL,
	[CategoryIdTeaser] [nvarchar](max) NULL,
	[VideoPathTeaser] [nvarchar](max) NULL,
	[LinkVideoTeaser] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Teaser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_User]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserNameUs] [nvarchar](max) NULL,
	[EmailUS] [nvarchar](max) NULL,
	[PhoneUs] [nvarchar](max) NULL,
	[PasswordUs] [nvarchar](max) NULL,
	[AddressUs] [nvarchar](max) NULL,
	[ProfileImageUs] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Users]    Script Date: 6/14/2021 11:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[TimeLogIn] [datetime2](7) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Random_Link] [int] NOT NULL,
	[RPass] [nvarchar](max) NULL,
	[NameFamily] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[Post] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[TokenPhone] [nvarchar](max) NULL,
	[CodeNational] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[CardNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210601183013_fgfg', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210602110936_int', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210602121436_tytyy', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210602170344_qwertyuuyterewq', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210613144450_fdfdfdfddf', N'3.1.8')
SET IDENTITY_INSERT [dbo].[tbl_Advertisings] ON 

INSERT [dbo].[tbl_Advertisings] ([Id], [Id_creator], [Category], [Image], [Image1], [Image2], [Image3], [Title_Pro], [Discreption_Pro], [Type_pro], [Type_Transaction], [Main_Price_Auction], [Auction_Time], [Auction_Start_Time], [Main_Price], [PriceB], [Pricek], [PricekC], [Discount_Price], [Online_Exchange], [Take_Discount], [Time], [State], [TimeReturn], [WhyReturn], [Description], [Special], [Number], [FatherIdCat], [Father]) VALUES (1, N'1', N'2', N'24a2f6b1-0058-415d-8a8e-a61729573e7e.jpg', NULL, NULL, N'19478f2e-00d5-4ddf-a875-36c26777472b.jpg', N'وبکم', N'jkhjhjio
kl;joil;h;
', N'کالای کسب و کار محلی و خانگی', N'انتخاب برعهده خریدار', NULL, NULL, NULL, N'35000', 0, 0, 0, N'25000', NULL, NULL, CAST(N'2021-06-03 00:00:00.0000000' AS DateTime2), N'تایید شده', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), NULL, NULL, N'جدید نو نو', 2, N'1', N'زیبایی و سلامتی')
INSERT [dbo].[tbl_Advertisings] ([Id], [Id_creator], [Category], [Image], [Image1], [Image2], [Image3], [Title_Pro], [Discreption_Pro], [Type_pro], [Type_Transaction], [Main_Price_Auction], [Auction_Time], [Auction_Start_Time], [Main_Price], [PriceB], [Pricek], [PricekC], [Discount_Price], [Online_Exchange], [Take_Discount], [Time], [State], [TimeReturn], [WhyReturn], [Description], [Special], [Number], [FatherIdCat], [Father]) VALUES (4, N'1', N'2', N'62293780-97f6-4828-ab61-a6432a4561f0.jpg', NULL, NULL, NULL, N'w4rrrtf', N'ergetgg', N'کالای نو استفاده نشده', N'بصورت مستقیم', NULL, NULL, NULL, N'35000', 0, 0, 0, N'12000', NULL, NULL, CAST(N'2021-06-05 00:00:00.0000000' AS DateTime2), N'تایید شده', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), NULL, NULL, N'جدید نو نو', 3, N'1', N'زیبایی و سلامتی')
INSERT [dbo].[tbl_Advertisings] ([Id], [Id_creator], [Category], [Image], [Image1], [Image2], [Image3], [Title_Pro], [Discreption_Pro], [Type_pro], [Type_Transaction], [Main_Price_Auction], [Auction_Time], [Auction_Start_Time], [Main_Price], [PriceB], [Pricek], [PricekC], [Discount_Price], [Online_Exchange], [Take_Discount], [Time], [State], [TimeReturn], [WhyReturn], [Description], [Special], [Number], [FatherIdCat], [Father]) VALUES (1002, N'1002', N'2', N'62f0078c-9fd7-48df-a70e-8a2d660ef46f.jpg', NULL, NULL, NULL, N'mobile', N'x3', N'کالای کسب و کار محلی و خانگی', N'انتخاب برعهده خریدار', NULL, NULL, NULL, N'25000', 0, 0, 0, N'20000', NULL, NULL, CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), N'تایید شده', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), NULL, NULL, N'جدید نو نو', 15, N'1', N'زیبایی و سلامتی')
SET IDENTITY_INSERT [dbo].[tbl_Advertisings] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Baner] ON 

INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [link]) VALUES (4, NULL, 0, 3, NULL, N'99e936f1-c05c-4ae1-a8cc-65b4ed31a5fa.jpg', NULL)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [link]) VALUES (5, NULL, 0, 1, NULL, N'09894e09-f0de-4245-b831-5115a4602bbc.jpg', NULL)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [link]) VALUES (6, NULL, 0, 2, NULL, N'69db791c-3614-4196-9085-7d77c760f9c8.jpg', NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Baner] OFF
SET IDENTITY_INSERT [dbo].[tbl_category] ON 

INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (1, N'کرم', -1, N'زیبایی و سلامتی')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (2, N'داروگر', 1, N'زیبایی و سلامتی')
SET IDENTITY_INSERT [dbo].[tbl_category] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Factors] ON 

INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Id_creator], [Id_Factro], [Product_Id], [product_Name], [Date_Order], [Product_Count], [product_Price], [Total_sum], [StatusA], [StatusM], [Type_Transaction], [TellBuy], [TellSel], [IdUser], [Post], [State], [City], [FirstAddress], [PriceB], [PriceK], [NameBuy], [NameSel], [Image], [Pay], [Send_Sales_Code], [Send_Order_Code], [Send_Admin_Code], [Why_Return_Admin_Bazrasi], [Why_Return_Request], [ImageReturn], [ImgNoB]) VALUES (2004, 1, 1002, 340411, 1002, N'mobile', CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), 0, 20000, 20000, N'No', N'عدم تایید فروشنده', N'مستقیم', N'09214351340', N'09370664172', 0, N'8888888888888888', N'کردستان', NULL, N'خیابان امام پاساژ میلاد نور', 0, 2000, N'مجید', N'محمد', N'62f0078c-9fd7-48df-a70e-8a2d660ef46f.jpg', N'Ok', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Id_creator], [Id_Factro], [Product_Id], [product_Name], [Date_Order], [Product_Count], [product_Price], [Total_sum], [StatusA], [StatusM], [Type_Transaction], [TellBuy], [TellSel], [IdUser], [Post], [State], [City], [FirstAddress], [PriceB], [PriceK], [NameBuy], [NameSel], [Image], [Pay], [Send_Sales_Code], [Send_Order_Code], [Send_Admin_Code], [Why_Return_Admin_Bazrasi], [Why_Return_Request], [ImageReturn], [ImgNoB]) VALUES (2005, 1, 1002, 340411, 1002, N'mobile', CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), 0, 20000, 22000, N'No', N'عدم تایید فروشنده', N'بازرسی', N'09214351340', N'09370664172', 0, N'8888888888888888', N'کردستان', NULL, N'خیابان امام پاساژ میلاد نور', 2000, 2000, N'مجید', N'محمد', N'62f0078c-9fd7-48df-a70e-8a2d660ef46f.jpg', N'Ok', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Id_creator], [Id_Factro], [Product_Id], [product_Name], [Date_Order], [Product_Count], [product_Price], [Total_sum], [StatusA], [StatusM], [Type_Transaction], [TellBuy], [TellSel], [IdUser], [Post], [State], [City], [FirstAddress], [PriceB], [PriceK], [NameBuy], [NameSel], [Image], [Pay], [Send_Sales_Code], [Send_Order_Code], [Send_Admin_Code], [Why_Return_Admin_Bazrasi], [Why_Return_Request], [ImageReturn], [ImgNoB]) VALUES (2006, 1, 1002, 432511, 1002, N'mobile', CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), 0, 20000, 22000, N'NoB', N'عدم تایید سیستم بازرسی', N'بازرسی', N'09214351340', N'09370664172', 0, N'8888888888888888', N'کردستان', NULL, N'خیابان امام پاساژ میلاد نور', 2000, 2000, N'مجید', N'محمد', N'62f0078c-9fd7-48df-a70e-8a2d660ef46f.jpg', N'Ok', N'123456789', NULL, NULL, N'7777777777777777777777777', NULL, NULL, NULL)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Id_creator], [Id_Factro], [Product_Id], [product_Name], [Date_Order], [Product_Count], [product_Price], [Total_sum], [StatusA], [StatusM], [Type_Transaction], [TellBuy], [TellSel], [IdUser], [Post], [State], [City], [FirstAddress], [PriceB], [PriceK], [NameBuy], [NameSel], [Image], [Pay], [Send_Sales_Code], [Send_Order_Code], [Send_Admin_Code], [Why_Return_Admin_Bazrasi], [Why_Return_Request], [ImageReturn], [ImgNoB]) VALUES (2012, 1, 1002, 992424, 1002, N'mobile', CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), 0, 20000, 20000, N'No', N'عدم تایید فروشنده', N'مستقیم', N'09214351340', N'09370664172', 0, N'8888888888888888', N'کردستان', NULL, N'خیابان امام پاساژ میلاد نور', 0, 2000, N'مجید', N'محمد', N'62f0078c-9fd7-48df-a70e-8a2d660ef46f.jpg', N'Ok', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Id_creator], [Id_Factro], [Product_Id], [product_Name], [Date_Order], [Product_Count], [product_Price], [Total_sum], [StatusA], [StatusM], [Type_Transaction], [TellBuy], [TellSel], [IdUser], [Post], [State], [City], [FirstAddress], [PriceB], [PriceK], [NameBuy], [NameSel], [Image], [Pay], [Send_Sales_Code], [Send_Order_Code], [Send_Admin_Code], [Why_Return_Admin_Bazrasi], [Why_Return_Request], [ImageReturn], [ImgNoB]) VALUES (2013, 1, 1002, 992424, 1002, N'mobile', CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), 0, 20000, 22000, N'NoB', N'عدم تایید سیستم بازرسی', N'بازرسی', N'09214351340', N'09370664172', 0, N'8888888888888888', N'کردستان', NULL, N'خیابان امام پاساژ میلاد نور', 2000, 2000, N'مجید', N'محمد', N'62f0078c-9fd7-48df-a70e-8a2d660ef46f.jpg', N'Ok', N'1232', NULL, NULL, N'qqqqqqqqqqqqqqqqq', NULL, NULL, N'3853495c-7876-4705-a56b-631a34bcda95.jpg')
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Id_creator], [Id_Factro], [Product_Id], [product_Name], [Date_Order], [Product_Count], [product_Price], [Total_sum], [StatusA], [StatusM], [Type_Transaction], [TellBuy], [TellSel], [IdUser], [Post], [State], [City], [FirstAddress], [PriceB], [PriceK], [NameBuy], [NameSel], [Image], [Pay], [Send_Sales_Code], [Send_Order_Code], [Send_Admin_Code], [Why_Return_Admin_Bazrasi], [Why_Return_Request], [ImageReturn], [ImgNoB]) VALUES (2014, 1, 1002, 506445, 1002, N'mobile', CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), 0, 20000, 20000, N'R', N'در انتظار تایید فروشنده', N'مستقیم', N'09214351340', N'09370664172', 0, N'2222222222222', N'فارس', N'فیروزآباد ', N'خیابان امام پاساژ', 0, 2000, N'مجید', N'محمد', N'62f0078c-9fd7-48df-a70e-8a2d660ef46f.jpg', N'Ok', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Factors] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Logo] ON 

INSERT [dbo].[Tbl_Logo] ([Id], [TitleLogo], [ImageLogo], [FavIcon], [Language]) VALUES (1, N'نوِنو', N'2b93b79f-4072-4c16-a34d-e32da104a43d.png', N'005cbc6f-94bc-4f01-aac2-4201c152563a.png', N'fa')
SET IDENTITY_INSERT [dbo].[Tbl_Logo] OFF
SET IDENTITY_INSERT [dbo].[Tbl_MyFavorites] ON 

INSERT [dbo].[Tbl_MyFavorites] ([Id], [IdKala], [IdUser]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[Tbl_MyFavorites] OFF
SET IDENTITY_INSERT [dbo].[tbl_Pays] ON 

INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2005, N'09214351340', N'مجید', 42000, 0, CAST(N'2021-06-13 12:41:00.6658419' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 1, 1, 0, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2006, N'09214351340', NULL, 0, 0, CAST(N'2021-06-13 12:41:04.3666186' AS DateTime2), CAST(N'2021-06-13 12:41:04.3665003' AS DateTime2), 0, 1, 340411, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2007, N'09214351340', N'مجید', 0, 0, CAST(N'2021-06-13 13:06:34.9174766' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 1, 0, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2008, N'09214351340', NULL, 0, 0, CAST(N'2021-06-13 13:06:34.9679696' AS DateTime2), CAST(N'2021-06-13 13:06:34.9679161' AS DateTime2), 0, 1, 432511, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2009, N'09214351340', N'مجید', 0, 0, CAST(N'2021-06-13 13:10:00.3797003' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 1, 0, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2010, N'09214351340', NULL, 0, 0, CAST(N'2021-06-13 13:10:00.4355214' AS DateTime2), CAST(N'2021-06-13 13:10:00.4354671' AS DateTime2), 0, 1, 397336, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2011, N'09214351340', N'مجید', 2000, 0, CAST(N'2021-06-13 13:18:19.6891438' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 1, 1, 0, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2012, N'09214351340', NULL, 0, 0, CAST(N'2021-06-13 13:18:24.1919102' AS DateTime2), CAST(N'2021-06-13 13:18:24.1918391' AS DateTime2), 0, 1, 992424, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2013, N'09214351340', N'مجید', 0, 0, CAST(N'2021-06-13 14:21:22.4076090' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 1, 0, NULL)
INSERT [dbo].[tbl_Pays] ([Id], [Phone], [NameFamily], [Pay], [Harvest], [Paytime], [havesttime], [status], [iduser], [Id_Factro], [StatusP]) VALUES (2014, N'09214351340', NULL, 0, 0, CAST(N'2021-06-13 14:21:22.4307788' AS DateTime2), CAST(N'2021-06-13 14:21:22.4307728' AS DateTime2), 0, 1, 506445, NULL)
SET IDENTITY_INSERT [dbo].[tbl_Pays] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Price] ON 

INSERT [dbo].[Tbl_Price] ([Id], [Cat_Type], [Min], [Max], [Price]) VALUES (1, N'کمسیون', N'0', N'1000000', N'10')
INSERT [dbo].[Tbl_Price] ([Id], [Cat_Type], [Min], [Max], [Price]) VALUES (2, N'بازرسی', N'0', N'1000000', N'10')
SET IDENTITY_INSERT [dbo].[Tbl_Price] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Slider] ON 

INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [linkslaid]) VALUES (1, NULL, 0, 0, NULL, N'869b4e31-ac75-4c75-84c4-8b700ed89e8a.jpg', N'A', N'admin/Category/index')
INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [linkslaid]) VALUES (2, NULL, 0, 0, NULL, N'74523093-1b12-47e6-b5f1-720f0d49f412.jpg', NULL, N'admin/Category/index')
SET IDENTITY_INSERT [dbo].[Tbl_Slider] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Users] ON 

INSERT [dbo].[Tbl_Users] ([Id], [Phone], [TimeLogIn], [Password], [Random_Link], [RPass], [NameFamily], [State], [city], [Post], [Address], [Code], [TokenPhone], [CodeNational], [Email], [Image], [CardNumber]) VALUES (1, N'09214351340', CAST(N'2021-06-03 00:00:00.0000000' AS DateTime2), N'123456', 279483, N'Ok', N'مجید', N'فارس', N'فیروزآباد ', N'2222222222222', N'خیابان امام پاساژ میلاد نور', NULL, N'1389', N'1720188415', NULL, N'a8b8232b-9806-4a74-bc09-2fc15ced5ebb.jpg', N'123456789000008')
INSERT [dbo].[Tbl_Users] ([Id], [Phone], [TimeLogIn], [Password], [Random_Link], [RPass], [NameFamily], [State], [city], [Post], [Address], [Code], [TokenPhone], [CodeNational], [Email], [Image], [CardNumber]) VALUES (2, N'09224505887', CAST(N'2021-06-03 00:00:00.0000000' AS DateTime2), N'123456', 576955, NULL, N'علی', N'سیستان و بلوچستان', N'خاش ', N'8558', N'خیابان امام ', NULL, N'7250', N'123456', NULL, N'bd1af27b-39c9-46fb-a87f-9d8b78440ac3.jpg', N'123456789000008')
INSERT [dbo].[Tbl_Users] ([Id], [Phone], [TimeLogIn], [Password], [Random_Link], [RPass], [NameFamily], [State], [city], [Post], [Address], [Code], [TokenPhone], [CodeNational], [Email], [Image], [CardNumber]) VALUES (3, N'09336192158', CAST(N'2021-06-03 00:00:00.0000000' AS DateTime2), N'123456', 988211, NULL, N'محمد', N'آذربایجان غربی', N'خوی ', NULL, NULL, NULL, N'6715', NULL, NULL, NULL, NULL)
INSERT [dbo].[Tbl_Users] ([Id], [Phone], [TimeLogIn], [Password], [Random_Link], [RPass], [NameFamily], [State], [city], [Post], [Address], [Code], [TokenPhone], [CodeNational], [Email], [Image], [CardNumber]) VALUES (1002, N'09370664172', CAST(N'2021-06-13 00:00:00.0000000' AS DateTime2), N'123456', 152635, NULL, N'محمد', N'فارس', N'بوانات ', N'111111111111111', N'ضضضضضضضضضضضضضضضضض', NULL, N'8809', N'1222222222', NULL, N'3a309e73-ad2e-4bf2-ac68-eea8f09be4bf.jpg', N'222222222222222222222')
SET IDENTITY_INSERT [dbo].[Tbl_Users] OFF
USE [master]
GO
ALTER DATABASE [NewProject_db] SET  READ_WRITE 
GO
