USE [master]
GO
/****** Object:  Database [YinuoYang.HotelManagementDb]    Script Date: 12/20/2020 2:46:16 PM ******/
CREATE DATABASE [YinuoYang.HotelManagementDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YinuoYang.HotelManagementDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\YinuoYang.HotelManagementDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YinuoYang.HotelManagementDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\YinuoYang.HotelManagementDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YinuoYang.HotelManagementDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET RECOVERY FULL 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET  MULTI_USER 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'YinuoYang.HotelManagementDb', N'ON'
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET QUERY_STORE = OFF
GO
USE [YinuoYang.HotelManagementDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/20/2020 2:46:16 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/20/2020 2:46:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoomNo] [int] NULL,
	[CName] [nvarchar](20) NULL,
	[Address] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](40) NULL,
	[CheckIn] [datetime2](7) NULL,
	[TotalPersons] [int] NULL,
	[BookingDays] [int] NULL,
	[Advance] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 12/20/2020 2:46:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RTCode] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomTypes]    Script Date: 12/20/2020 2:46:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Rtdesc] [nvarchar](20) NULL,
	[Rent] [decimal](18, 2) NULL,
 CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 12/20/2020 2:46:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoomNo] [int] NULL,
	[Sdesc] [nvarchar](50) NULL,
	[amount] [decimal](18, 2) NULL,
	[ServiceDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Customers_RoomNo]    Script Date: 12/20/2020 2:46:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Customers_RoomNo] ON [dbo].[Customers]
(
	[RoomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Rooms_RTCode]    Script Date: 12/20/2020 2:46:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Rooms_RTCode] ON [dbo].[Rooms]
(
	[RTCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Services_RoomNo]    Script Date: 12/20/2020 2:46:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Services_RoomNo] ON [dbo].[Services]
(
	[RoomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (getdate()) FOR [CheckIn]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT (getdate()) FOR [ServiceDate]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Rooms_RoomNo] FOREIGN KEY([RoomNo])
REFERENCES [dbo].[Rooms] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Rooms_RoomNo]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomTypes_RTCode] FOREIGN KEY([RTCode])
REFERENCES [dbo].[RoomTypes] ([Id])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomTypes_RTCode]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_Rooms_RoomNo] FOREIGN KEY([RoomNo])
REFERENCES [dbo].[Rooms] ([Id])
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_Rooms_RoomNo]
GO
USE [master]
GO
ALTER DATABASE [YinuoYang.HotelManagementDb] SET  READ_WRITE 
GO
