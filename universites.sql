USE [master]
GO
/****** Object:  Database [Universities]    Script Date: 9/7/2021 11:34:03 AM ******/
CREATE DATABASE [Universities]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Universities', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Universities.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Universities_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Universities_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Universities] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Universities].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Universities] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Universities] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Universities] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Universities] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Universities] SET ARITHABORT OFF 
GO
ALTER DATABASE [Universities] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Universities] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Universities] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Universities] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Universities] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Universities] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Universities] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Universities] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Universities] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Universities] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Universities] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Universities] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Universities] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Universities] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Universities] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Universities] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Universities] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Universities] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Universities] SET  MULTI_USER 
GO
ALTER DATABASE [Universities] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Universities] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Universities] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Universities] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Universities] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Universities] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Universities] SET QUERY_STORE = OFF
GO
USE [Universities]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 9/7/2021 11:34:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[university_id] [bigint] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[teacher_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Universities]    Script Date: 9/7/2021 11:34:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universities](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
	[country] [nvarchar](100) NULL,
	[minimum_gpa] [decimal](4, 2) NOT NULL,
	[minimum_gre_score] [int] NOT NULL,
 CONSTRAINT [PK_Universities] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (1, 1, N'Computer science', N'Ramesh')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (2, 1, N'Data sciencce', N'Prakash')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (4, 2, N'Computer science', N'Sudheer')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (5, 2, N'Data science', N'Varma')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (7, 3, N'Computer sciene', N'ram nayak')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (8, 3, N'Data science', N'Ramesh Goud')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (9, 1, N'AI', N'Tagoor')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (10, 2, N'AI', N'Lakshmi rai')
INSERT [dbo].[Courses] ([id], [university_id], [name], [teacher_name]) VALUES (11, 3, N'AI', N'Ravail ')
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Universities] ON 

INSERT [dbo].[Universities] ([id], [name], [description], [country], [minimum_gpa], [minimum_gre_score]) VALUES (1, N'Andhra', N'locatedin vizag', N'india', CAST(4.50 AS Decimal(4, 2)), 144)
INSERT [dbo].[Universities] ([id], [name], [description], [country], [minimum_gpa], [minimum_gre_score]) VALUES (2, N'JNTU', N'Located in hyderabad', N'United States', CAST(5.60 AS Decimal(4, 2)), 150)
INSERT [dbo].[Universities] ([id], [name], [description], [country], [minimum_gpa], [minimum_gre_score]) VALUES (3, N'KU', N'Locatedin varagal', N'North affrica', CAST(6.70 AS Decimal(4, 2)), 160)
SET IDENTITY_INSERT [dbo].[Universities] OFF
GO
USE [master]
GO
ALTER DATABASE [Universities] SET  READ_WRITE 
GO
