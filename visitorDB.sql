USE [master]
GO
/****** Object:  Database [visitorDB]    Script Date: 05/28/2015 11:38:26 ******/
CREATE DATABASE [visitorDB] ON  PRIMARY 
( NAME = N'visitorDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\visitorDB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'visitorDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\visitorDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [visitorDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [visitorDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [visitorDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [visitorDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [visitorDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [visitorDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [visitorDB] SET ARITHABORT OFF
GO
ALTER DATABASE [visitorDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [visitorDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [visitorDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [visitorDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [visitorDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [visitorDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [visitorDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [visitorDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [visitorDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [visitorDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [visitorDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [visitorDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [visitorDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [visitorDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [visitorDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [visitorDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [visitorDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [visitorDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [visitorDB] SET  READ_WRITE
GO
ALTER DATABASE [visitorDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [visitorDB] SET  MULTI_USER
GO
ALTER DATABASE [visitorDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [visitorDB] SET DB_CHAINING OFF
GO
USE [visitorDB]
GO
/****** Object:  Table [dbo].[t_visitor]    Script Date: 05/28/2015 11:38:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_visitor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NULL,
	[Email] [varchar](50) NULL,
	[Contract] [varchar](50) NULL,
 CONSTRAINT [PK_t_visitor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[t_visitor] ON
INSERT [dbo].[t_visitor] ([Id], [Name], [Email], [Contract]) VALUES (3, N'rana', N'rana@gmail.com', N'0932903290')
INSERT [dbo].[t_visitor] ([Id], [Name], [Email], [Contract]) VALUES (4, N'kamal', N'kamal@gmail.com', N'9324930943')
SET IDENTITY_INSERT [dbo].[t_visitor] OFF
/****** Object:  Table [dbo].[t_zone]    Script Date: 05/28/2015 11:38:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_zone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Zone] [varchar](150) NULL,
 CONSTRAINT [PK_t_zone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_t_zone] ON [dbo].[t_zone] 
(
	[Zone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[t_zone] ON
INSERT [dbo].[t_zone] ([Id], [Zone]) VALUES (6, N'Biomedical Technology')
INSERT [dbo].[t_zone] ([Id], [Zone]) VALUES (7, N'Computer Technology')
INSERT [dbo].[t_zone] ([Id], [Zone]) VALUES (3, N'Digital Zone')
INSERT [dbo].[t_zone] ([Id], [Zone]) VALUES (1, N'Mobile Application')
INSERT [dbo].[t_zone] ([Id], [Zone]) VALUES (5, N'Robotic Technology')
INSERT [dbo].[t_zone] ([Id], [Zone]) VALUES (4, N'Software')
INSERT [dbo].[t_zone] ([Id], [Zone]) VALUES (2, N'Telecom')
SET IDENTITY_INSERT [dbo].[t_zone] OFF
/****** Object:  Table [dbo].[t_VisitorZone]    Script Date: 05/28/2015 11:38:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_VisitorZone](
	[VisitorID] [int] NOT NULL,
	[ZoneID] [int] NOT NULL,
 CONSTRAINT [PK_t_VisitorZone] PRIMARY KEY CLUSTERED 
(
	[VisitorID] ASC,
	[ZoneID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[t_VisitorZone] ([VisitorID], [ZoneID]) VALUES (3, 1)
INSERT [dbo].[t_VisitorZone] ([VisitorID], [ZoneID]) VALUES (3, 2)
INSERT [dbo].[t_VisitorZone] ([VisitorID], [ZoneID]) VALUES (3, 3)
INSERT [dbo].[t_VisitorZone] ([VisitorID], [ZoneID]) VALUES (3, 4)
INSERT [dbo].[t_VisitorZone] ([VisitorID], [ZoneID]) VALUES (3, 5)
INSERT [dbo].[t_VisitorZone] ([VisitorID], [ZoneID]) VALUES (4, 3)
/****** Object:  View [dbo].[VisitorZoneVisitor]    Script Date: 05/28/2015 11:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VisitorZoneVisitor] as
Select vz.ZoneID, v.Name,v.Email,v.Contract from t_VisitorZone as vz LEFT OUTER JOIN t_visitor as v on vz.VisitorID=v.id
GO
/****** Object:  View [dbo].[Visitor_Zone]    Script Date: 05/28/2015 11:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Visitor_Zone] as
Select  vzv.ZoneID,vzv.Name,vzv.Email,vzv.Contract,z.Zone From VisitorZoneVisitor as vzv LEFT OUTER JOIN t_zone as z  on vzv.ZoneID = z.Id
GO
/****** Object:  ForeignKey [FK_t_VisitorZone_t_visitor]    Script Date: 05/28/2015 11:38:29 ******/
ALTER TABLE [dbo].[t_VisitorZone]  WITH CHECK ADD  CONSTRAINT [FK_t_VisitorZone_t_visitor] FOREIGN KEY([VisitorID])
REFERENCES [dbo].[t_visitor] ([Id])
GO
ALTER TABLE [dbo].[t_VisitorZone] CHECK CONSTRAINT [FK_t_VisitorZone_t_visitor]
GO
