USE [master]
GO
/****** Object:  Database [PetStore]    Script Date: 26-Oct-21 11:09:33 PM ******/
CREATE DATABASE [PetStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PetStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PetStore.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PetStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PetStore_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PetStore] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PetStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PetStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PetStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PetStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PetStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PetStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [PetStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PetStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PetStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PetStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PetStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PetStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PetStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PetStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PetStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PetStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PetStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PetStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PetStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PetStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PetStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PetStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PetStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PetStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PetStore] SET  MULTI_USER 
GO
ALTER DATABASE [PetStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PetStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PetStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PetStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PetStore] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PetStore]
GO
/****** Object:  Table [dbo].[tblBillDetails]    Script Date: 26-Oct-21 11:09:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBillDetails](
	[BillDetailID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[PetID] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Gender] [bit] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[QuantityBuy] [int] NOT NULL,
	[Discount] [float] NOT NULL,
	[SubTotal] [money] NOT NULL,
 CONSTRAINT [PK_tblBillDetails] PRIMARY KEY CLUSTERED 
(
	[BillDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBills]    Script Date: 26-Oct-21 11:09:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBills](
	[BillID] [int] NOT NULL,
	[Total] [money] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_tblBills] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCategories]    Script Date: 26-Oct-21 11:09:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblCategories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPets]    Script Date: 26-Oct-21 11:09:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPets](
	[PetID] [int] IDENTITY(1,1) NOT NULL,
	[PetName] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [bit] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[QuantityInStock] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[ImportPrice] [money] NOT NULL,
	[ExportPrice] [money] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_tblPets] PRIMARY KEY CLUSTERED 
(
	[PetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblBillDetails] ON 

INSERT [dbo].[tblBillDetails] ([BillDetailID], [BillID], [PetID], [UserName], [Gender], [Address], [Phone], [QuantityBuy], [Discount], [SubTotal]) VALUES (1, 1, 1, N'Phương', 1, N'Đường Quang Trung', N'09237182371', 2, 0.3, 1000000.0000)
INSERT [dbo].[tblBillDetails] ([BillDetailID], [BillID], [PetID], [UserName], [Gender], [Address], [Phone], [QuantityBuy], [Discount], [SubTotal]) VALUES (2, 6, 2, N'aaaaaaaaaaaa', 1, N'aaaaaaaaaaaa', N'31237811122', 4, 0.3, 1092000.0000)
INSERT [dbo].[tblBillDetails] ([BillDetailID], [BillID], [PetID], [UserName], [Gender], [Address], [Phone], [QuantityBuy], [Discount], [SubTotal]) VALUES (3, 7, 1, N'abbbbbbbbbbbb', 1, N'abbbbbbbbbbbb', N'2371237131', 1, 0.3, 350000.0000)
INSERT [dbo].[tblBillDetails] ([BillDetailID], [BillID], [PetID], [UserName], [Gender], [Address], [Phone], [QuantityBuy], [Discount], [SubTotal]) VALUES (4, 7, 3, N'abbbbbbbbbbbb', 1, N'abbbbbbbbbbbb', N'2371237131', 3, 0.3, 1050000.0000)
SET IDENTITY_INSERT [dbo].[tblBillDetails] OFF
INSERT [dbo].[tblBills] ([BillID], [Total], [Date], [Status]) VALUES (1, 1000000.0000, CAST(N'2021-10-15 08:19:45.707' AS DateTime), 1)
INSERT [dbo].[tblBills] ([BillID], [Total], [Date], [Status]) VALUES (6, 32000.0000, CAST(N'2021-10-26 23:03:22.990' AS DateTime), 1)
INSERT [dbo].[tblBills] ([BillID], [Total], [Date], [Status]) VALUES (7, 32000.0000, CAST(N'2021-10-26 23:05:20.860' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tblCategories] ON 

INSERT [dbo].[tblCategories] ([CategoryID], [CategoryName]) VALUES (1, N'Chó')
INSERT [dbo].[tblCategories] ([CategoryID], [CategoryName]) VALUES (2, N'Mèo')
INSERT [dbo].[tblCategories] ([CategoryID], [CategoryName]) VALUES (3, N'Thỏ')
INSERT [dbo].[tblCategories] ([CategoryID], [CategoryName]) VALUES (4, N'Hamster')
INSERT [dbo].[tblCategories] ([CategoryID], [CategoryName]) VALUES (5, N'Nhím')
SET IDENTITY_INSERT [dbo].[tblCategories] OFF
SET IDENTITY_INSERT [dbo].[tblPets] ON 

INSERT [dbo].[tblPets] ([PetID], [PetName], [Age], [Gender], [Color], [QuantityInStock], [CategoryID], [ImportPrice], [ExportPrice], [Status]) VALUES (1, N'Chó Phú Quốc', 1, 1, N'Black', 2, 1, 300000.0000, 500000.0000, 1)
INSERT [dbo].[tblPets] ([PetID], [PetName], [Age], [Gender], [Color], [QuantityInStock], [CategoryID], [ImportPrice], [ExportPrice], [Status]) VALUES (2, N'Meow Meow', 1, 0, N'White-Yellow', 1, 2, 230000.0000, 390000.0000, 1)
INSERT [dbo].[tblPets] ([PetID], [PetName], [Age], [Gender], [Color], [QuantityInStock], [CategoryID], [ImportPrice], [ExportPrice], [Status]) VALUES (3, N'Bubu Chacha', 2, 1, N'Black-Yellow', 0, 3, 300000.0000, 500000.0000, 0)
INSERT [dbo].[tblPets] ([PetID], [PetName], [Age], [Gender], [Color], [QuantityInStock], [CategoryID], [ImportPrice], [ExportPrice], [Status]) VALUES (4, N'Mickey', 2, 0, N'White-Back', 2, 4, 250000.0000, 480000.0000, 1)
INSERT [dbo].[tblPets] ([PetID], [PetName], [Age], [Gender], [Color], [QuantityInStock], [CategoryID], [ImportPrice], [ExportPrice], [Status]) VALUES (5, N'Kitty', 1, 0, N'Pink-White', 4, 5, 555000.0000, 900000.0000, 1)
INSERT [dbo].[tblPets] ([PetID], [PetName], [Age], [Gender], [Color], [QuantityInStock], [CategoryID], [ImportPrice], [ExportPrice], [Status]) VALUES (6, N'Ping Pong', 1, 1, N'Green-White', 5, 3, 330000.0000, 890000.0000, 1)
SET IDENTITY_INSERT [dbo].[tblPets] OFF
ALTER TABLE [dbo].[tblBillDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBillDetails_tblBills] FOREIGN KEY([BillID])
REFERENCES [dbo].[tblBills] ([BillID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblBillDetails] CHECK CONSTRAINT [FK_tblBillDetails_tblBills]
GO
ALTER TABLE [dbo].[tblBillDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBillDetails_tblPets] FOREIGN KEY([PetID])
REFERENCES [dbo].[tblPets] ([PetID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblBillDetails] CHECK CONSTRAINT [FK_tblBillDetails_tblPets]
GO
ALTER TABLE [dbo].[tblPets]  WITH CHECK ADD  CONSTRAINT [FK_tblPets_tblCategories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[tblCategories] ([CategoryID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblPets] CHECK CONSTRAINT [FK_tblPets_tblCategories]
GO
USE [master]
GO
ALTER DATABASE [PetStore] SET  READ_WRITE 
GO
