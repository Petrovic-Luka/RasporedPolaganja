USE [master]
GO
/****** Object:  Database [RasporedPolaganjaDB]    Script Date: 08/02/2024 09:11:07 ******/
CREATE DATABASE [RasporedPolaganjaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RasporedPolaganjaDB', FILENAME = N'C:\Users\lukap\RasporedPolaganjaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RasporedPolaganjaDB_log', FILENAME = N'C:\Users\lukap\RasporedPolaganjaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RasporedPolaganjaDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RasporedPolaganjaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RasporedPolaganjaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET  MULTI_USER 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RasporedPolaganjaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RasporedPolaganjaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RasporedPolaganjaDB] SET QUERY_STORE = OFF
GO
USE [RasporedPolaganjaDB]
GO
/****** Object:  Table [dbo].[Ispit]    Script Date: 08/02/2024 09:11:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ispit](
	[IspitId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[ESPB] [int] NOT NULL,
 CONSTRAINT [PK_Ispit] PRIMARY KEY CLUSTERED 
(
	[IspitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrijavaNaTerminPolaganja]    Script Date: 08/02/2024 09:11:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrijavaNaTerminPolaganja](
	[TerminId] [int] NOT NULL,
	[BrojIndeksa] [nvarchar](10) NOT NULL,
	[SalaId] [int] NULL,
	[DatumPrijave] [date] NOT NULL,
	[Izasao] [bit] NULL,
 CONSTRAINT [PK_PrijavaNaTerminPolagajna] PRIMARY KEY CLUSTERED 
(
	[TerminId] ASC,
	[BrojIndeksa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 08/02/2024 09:11:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[ProfesorId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Sifra] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[ProfesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 08/02/2024 09:11:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[SalaId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[BrojMesta] [int] NOT NULL,
	[Rc] [bit] NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[SalaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 08/02/2024 09:11:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[BrojIndeksa] [nvarchar](10) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Sifra] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[BrojIndeksa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TerminPolaganja]    Script Date: 08/02/2024 09:11:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TerminPolaganja](
	[TerminPolaganjaId] [int] IDENTITY(1,1) NOT NULL,
	[Datum] [date] NOT NULL,
	[IspitId] [int] NOT NULL,
	[Tip] [nvarchar](50) NOT NULL,
	[PotrebanRacunar] [bit] NOT NULL,
	[PrijavaDo] [date] NOT NULL,
	[MaxBrojSala] [int] NOT NULL,
 CONSTRAINT [PK_TerminPolaganja] PRIMARY KEY CLUSTERED 
(
	[TerminPolaganjaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ispit] ON 

INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (1, N'Projektovane Softvera', 6)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (2, N'Engleski 2', 5)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (3, N'RMT', 6)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (4, N'POIS', 4)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (5, N'SPA', 6)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (1002, N'Test', 4)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (2002, N'qweqwe', 4)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (3002, N'weq', 4)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (4002, N'NoviPredmet', 5)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (5002, N'Menadzment', 6)
INSERT [dbo].[Ispit] ([IspitId], [Naziv], [ESPB]) VALUES (6002, N'Ispit', 4)
SET IDENTITY_INSERT [dbo].[Ispit] OFF
GO
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2018/0001', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2018/0025', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2018/0027', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2018/0099', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2018/0302', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0013', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0128', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0138', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0225', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0327', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0344', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0374', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0515', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0566', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0568', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0573', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0576', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0577', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0639', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0670', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0691', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0806', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0810', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2019/0825', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0417', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0425', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0440', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0452', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0523', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0586', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0606', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0612', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0668', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0696', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0715', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0764', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/0982', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3, N'2020/1928', 1, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (2004, N'2018/0001', NULL, CAST(N'2024-02-07' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (2005, N'2020.0300', NULL, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (2006, N'2020.0300', NULL, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3004, N'2018/0001', 4, CAST(N'2024-02-07' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3004, N'2020.0300', 4, CAST(N'2024-02-05' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (3004, N'2020/1928', 4, CAST(N'2024-02-05' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (4004, N'2018/0001', 4, CAST(N'2024-02-08' AS Date), 0)
INSERT [dbo].[PrijavaNaTerminPolaganja] ([TerminId], [BrojIndeksa], [SalaId], [DatumPrijave], [Izasao]) VALUES (4004, N'2020.0300', 4, CAST(N'2024-02-08' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[Profesor] ON 

INSERT [dbo].[Profesor] ([ProfesorId], [Ime], [Prezime], [Email], [Sifra]) VALUES (1, N'Pera', N'Peric', N'p@p', N'123')
INSERT [dbo].[Profesor] ([ProfesorId], [Ime], [Prezime], [Email], [Sifra]) VALUES (2, N'Mika', N'Mikic', N'm@m.com', N'123')
SET IDENTITY_INSERT [dbo].[Profesor] OFF
GO
SET IDENTITY_INSERT [dbo].[Sala] ON 

INSERT [dbo].[Sala] ([SalaId], [Naziv], [BrojMesta], [Rc]) VALUES (1, N'D301', 50, 1)
INSERT [dbo].[Sala] ([SalaId], [Naziv], [BrojMesta], [Rc]) VALUES (3, N'D300', 45, 0)
INSERT [dbo].[Sala] ([SalaId], [Naziv], [BrojMesta], [Rc]) VALUES (4, N'105', 20, 0)
INSERT [dbo].[Sala] ([SalaId], [Naziv], [BrojMesta], [Rc]) VALUES (5, N'015', 80, 0)
INSERT [dbo].[Sala] ([SalaId], [Naziv], [BrojMesta], [Rc]) VALUES (6, N'C002', 20, 1)
INSERT [dbo].[Sala] ([SalaId], [Naziv], [BrojMesta], [Rc]) VALUES (7, N'005', 25, 1)
SET IDENTITY_INSERT [dbo].[Sala] OFF
GO
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0001', N'Raddy', N'Pethrick', N'rpethrickp@gov.uk', N'o9jca')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0009', N'Brian', N'Pinard', N'bpinard1k@rambler.ru', N'syGnbWY')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0025', N'Jocelyn', N'Ryott', N'jryott1n@tiny.cc', N'tqty+')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0027', N'Hortensia', N'Duckett', N'hduckett1d@deviantart.com', N's&xK5y@')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0099', N'Frieda', N'Seacombe', N'fseacombe2m@naver.com', N'lYe%')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0147', N'Jarrod', N'Hegges', N'jheggesw@examiner.com', N'a?<(s')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0175', N'Kally', N'Munkley', N'kmunkley2n@clickbank.net', N'eHK}')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0179', N'Karol', N'Duddan', N'kduddan1o@ibm.com', N'r<MAt0}A')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0234', N'Christina', N'Jouen', N'cjouenx@indiatimes.com', N'qM<L(bJ$')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0241', N'Les', N'Cubbini', N'lcubbinid@samsung.com', N'qE.+''iO')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0273', N'Alyosha', N'Pedlow', N'apedlow1b@nationalgeographic.com', N'lTGp')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0285', N'Roma', N'Conduit', N'rconduit25@shutterfly.com', N'un}}tE')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0302', N'Martie', N'Ditchfield', N'mditchfield2f@rakuten.co.jp', N'g|9+B')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0317', N'Amabelle', N'Hardison', N'ahardisono@harvard.edu', N'ylaj6h!N')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0377', N'Carl', N'Skamal', N'cskamal26@de.vu', N'sCC"sm=')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0390', N'Olivier', N'Duckett', N'oduckettk@plala.or.jp', N'v+0=Ox,')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0409', N'Nil', N'Brugemann', N'nbrugemann2i@qq.com', N'qEO2')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0453', N'Bradley', N'Feuell', N'bfeuell2p@google.pl', N'pEyukL')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0467', N'Towney', N'Longstreeth', N'tlongstreethy@woothemes.com', N'qgNgk')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0511', N'Derek', N'Noorwood', N'dnoorwood6@pagesperso-orange.fr', N'rxds')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0563', N'Jose', N'Bonifacio', N'jbonifacioc@dailymotion.com', N'iEjKr?')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0571', N'Meryl', N'Richel', N'mrichela@seesaa.net', N'ineu')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0586', N'Sayre', N'Peris', N'sperisf@moonfruit.com', N'kPVy')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0600', N'Tawsha', N'Mahody', N'tmahody11@apple.com', N'xs\UYVR')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0657', N'Clemens', N'Johansson', N'cjohansson2h@wp.com', N'muZC`zji')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0663', N'Baird', N'Adamthwaite', N'badamthwaite7@hhs.gov', N'kqF_''')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0718', N'Pascal', N'Lipgens', N'plipgens2d@guardian.co.uk', N'wzplS')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0775', N'Frederik', N'Ricoald', N'fricoald2e@google.it', N'nz!\v')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0786', N'Gayla', N'Goneau', N'ggoneau9@scientificamerican.com', N't"f=')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0788', N'Leroi', N'Trayford', N'ltrayford19@sfgate.com', N'z2,g')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2018/0892', N'Hammad', N'Jubert', N'hjubert29@seattletimes.com', N't>J.Oc')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0013', N'Nike', N'Loveguard', N'nloveguard24@umn.edu', N'mm*5I_')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0128', N'Zsazsa', N'Bradly', N'zbradlyb@statcounter.com', N'l#\g')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0138', N'Sapphire', N'Parris', N'sparris2c@si.edu', N'ok#i')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0162', N'Stavros', N'Biggerstaff', N'sbiggerstaffq@altervista.org', N'i*6(o')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0188', N'Vida', N'Bartalin', N'vbartalin14@gravatar.com', N'syM\AU?')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0194', N'Margarette', N'Boydell', N'mboydell1j@bloglovin.com', N'yj!+K1')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0225', N'Florrie', N'Maass', N'fmaass8@t.co', N'uasTl')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0232', N'Adriane', N'Saipy', N'asaipy23@xing.com', N'j6{ZAr')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0233', N'Augie', N'Gresswell', N'agresswellh@pagesperso-orange.fr', N'l#3O')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0246', N'Georgina', N'Izac', N'gizaci@arizona.edu', N'd~p!zJ')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0253', N'Milo', N'Saggs', N'msaggsm@microsoft.com', N'gTgBF')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0327', N'Tarra', N'Stenners', N'tstenners2o@noaa.gov', N'yHrmA')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0344', N'Constancy', N'Thomesson', N'cthomesson1g@reddit.com', N'e4%P')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0374', N'Stanislaus', N'Joscelyne', N'sjoscelyne1t@unesco.org', N'jK=|UT''')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0515', N'Bern', N'Sowray', N'bsowray2a@php.net', N'aa0V`e`''')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0566', N'Dorry', N'Spendley', N'dspendley16@e-recht24.de', N'gR>8&,')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0568', N'Lucina', N'Melledy', N'lmelledy17@wsj.com', N'uu5U#v7')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0573', N'Alessandra', N'Scullion', N'ascullion1y@alexa.com', N'x<}}4ex)')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0576', N'Dorthy', N'Kays', N'dkays22@indiatimes.com', N'f`$@R$)')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0577', N'Olenka', N'Bispham', N'obispham1l@netvibes.com', N'l5.+A')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0639', N'Tore', N'Bavister', N'tbavister1r@bizjournals.com', N'bBN3')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0670', N'Renault', N'Brosnan', N'rbrosnan2q@auda.org.au', N'a(R(gd!@')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0691', N'Poul', N'De Bellis', N'pdebellis12@google.cn', N'tXC0/')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0775', N'Agnella', N'Coyte', N'acoyte1h@indiatimes.com', N'g%ewgn)B')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0806', N'Amalia', N'Farrah', N'afarrah2@discuz.net', N'cd.\.n}')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0810', N'Berenice', N'Henmarsh', N'bhenmarsh4@cocolog-nifty.com', N'e)4PD')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0825', N'Bride', N'Curnnokk', N'bcurnnokke@cbslocal.com', N'i03Ry$_')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0827', N'Lu', N'McLagain', N'lmclagaint@redcross.org', N'sL''{')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0901', N'Fern', N'Braisted', N'fbraisted1q@delicious.com', N'y=vDLG>$')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0913', N'Brandtr', N'Buxam', N'bbuxamz@hp.com', N'zqaJw{aS')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0915', N'Noemi', N'Broomhead', N'nbroomhead1s@huffingtonpost.com', N'hBct')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2019/0976', N'Sandra', N'Diboll', N'sdiboll3@merriam-webster.com', N'x`4{IjP')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020.0300', N'Luka', N'Petrovic', N'lp@gmail.com', N'12345')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0005', N'Valeria', N'Servant', N'vservant5@pcworld.com', N'mOvZ4\')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0024', N'Juliette', N'Tomsa', N'jtomsau@yahoo.co.jp', N'g,4OeKH+')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0027', N'Zachary', N'Hatherley', N'zhatherley2g@cmu.edu', N'rh$Z1?3')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0043', N'Mason', N'Shulem', N'mshulemn@vk.com', N'dc~(')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0060', N'Tabor', N'Barroux', N'tbarroux1x@loc.gov', N'dThh')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0069', N'Lauretta', N'Kinig', N'lkinig0@ca.gov', N'd@5{}8')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0077', N'Jolynn', N'Skittrall', N'jskittrallj@gnu.org', N'f{ZO''FX')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0116', N'Darby', N'Mound', N'dmound1@google.co.uk', N'i"in%Pd')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0123', N'Mika', N'Mikic', N'm@m.com', N'123')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0143', N'Elsa', N'Caspell', N'ecaspell15@omniture.com', N'b297z@Jy')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0176', N'Kerwin', N'Masding', N'kmasding1c@cmu.edu', N'rBLi_wn')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0199', N'Avictor', N'Chatell', N'achatell18@home.pl', N'ngAg')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0206', N'Cheryl', N'Ratlee', N'cratlee13@yahoo.com', N'e//"')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0218', N'Hertha', N'Snasdell', N'hsnasdell1z@nifty.com', N'x@vL')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0245', N'Chrystel', N'Dimmne', N'cdimmnel@addthis.com', N'z!4so(H')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0278', N'Federica', N'Coulson', N'fcoulson2j@a8.net', N'zXTU')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0354', N'Kare', N'Cuttings', N'kcuttings1v@t.co', N'sF2k6')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0408', N'Diannne', N'Bladesmith', N'dbladesmith1w@tiny.cc', N'ymwtM')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0417', N'Ilsa', N'Standon', N'istandons@google.fr', N'r(~Pp')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0425', N'Raven', N'Vogt', N'rvogt2b@mapy.cz', N'v">#M=')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0440', N'Zita', N'Fennelly', N'zfennellyv@nih.gov', N'cPaSjT3o')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0452', N'Iggy', N'Lindeboom', N'ilindeboom1e@netvibes.com', N'mK?/i''~$')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0523', N'Collen', N'Muro', N'cmuro27@howstuffworks.com', N'm/~ur`Nl')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0586', N'Riobard', N'Longbottom', N'rlongbottom2r@washington.edu', N'pr%(x%.')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0606', N'Keefer', N'Hodge', N'khodge20@senate.gov', N'vjaivK|H')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0612', N'Shana', N'Readhead', N'sreadhead2l@howstuffworks.com', N'd3=(C')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0614', N'Ferdy', N'Dunmore', N'fdunmore1i@networkadvertising.org', N'fS/vD')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0668', N'Raddy', N'Cicculi', N'rcicculi1a@fastcompany.com', N'wLv,/rJ{')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0696', N'Noland', N'Threadkell', N'nthreadkell28@amazonaws.com', N'o?D{CH')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0715', N'Gerti', N'Ebbutt', N'gebbutt1m@squarespace.com', N'c5V{')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0764', N'Beverlee', N'Stonestreet', N'bstonestreetg@barnesandnoble.com', N'o&4d{!|K')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0790', N'Maegan', N'Pamment', N'mpammentr@cmu.edu', N'a1''B')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0807', N'Dan', N'McKune', N'dmckune1f@whitehouse.gov', N'v@sxE')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0869', N'Elsbeth', N'Beeden', N'ebeeden10@ehow.com', N'wJf{')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0905', N'Adair', N'Rozenzweig', N'arozenzweig1p@google.it', N'd4%UG')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0929', N'Fredericka', N'Whether', N'fwhether1u@huffingtonpost.com', N'a/l2r`%')
GO
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/0982', N'Blair', N'Mesnard', N'bmesnard2k@nytimes.com', N'jwjnR/')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/1357', N'Kojot', N'Kojotovic', N'k@k.co', N'1234')
INSERT [dbo].[Student] ([BrojIndeksa], [Ime], [Prezime], [Email], [Sifra]) VALUES (N'2020/1928', N'Jovan', N'Jovic', N'j@j.com', N'12345')
GO
SET IDENTITY_INSERT [dbo].[TerminPolaganja] ON 

INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (2, CAST(N'2024-01-31' AS Date), 1, N'asd', 0, CAST(N'2024-01-26' AS Date), 0)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (3, CAST(N'2024-01-31' AS Date), 1, N'asd', 1, CAST(N'2024-01-31' AS Date), 0)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (4, CAST(N'2024-05-05' AS Date), 1, N'pismeni', 0, CAST(N'2024-05-01' AS Date), 10)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (2004, CAST(N'2024-02-02' AS Date), 3, N'qwe', 0, CAST(N'2024-02-10' AS Date), 0)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (2005, CAST(N'2024-02-04' AS Date), 1002, N'asd', 1, CAST(N'2024-02-10' AS Date), 0)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (2006, CAST(N'2024-02-03' AS Date), 1, N'qwe', 0, CAST(N'2024-02-02' AS Date), 0)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (2007, CAST(N'2024-02-03' AS Date), 1, N'', 0, CAST(N'2024-01-31' AS Date), 0)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (3004, CAST(N'2024-02-10' AS Date), 5, N'Usmeni', 0, CAST(N'2024-02-07' AS Date), 0)
INSERT [dbo].[TerminPolaganja] ([TerminPolaganjaId], [Datum], [IspitId], [Tip], [PotrebanRacunar], [PrijavaDo], [MaxBrojSala]) VALUES (4004, CAST(N'2024-02-13' AS Date), 6002, N'Usmeni', 0, CAST(N'2024-02-09' AS Date), 0)
SET IDENTITY_INSERT [dbo].[TerminPolaganja] OFF
GO
ALTER TABLE [dbo].[PrijavaNaTerminPolaganja]  WITH CHECK ADD  CONSTRAINT [FK_BrojIndeksa_Prijava] FOREIGN KEY([BrojIndeksa])
REFERENCES [dbo].[Student] ([BrojIndeksa])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PrijavaNaTerminPolaganja] CHECK CONSTRAINT [FK_BrojIndeksa_Prijava]
GO
ALTER TABLE [dbo].[PrijavaNaTerminPolaganja]  WITH CHECK ADD  CONSTRAINT [FK_PrijavaNaTerminPolaganja_Sala] FOREIGN KEY([SalaId])
REFERENCES [dbo].[Sala] ([SalaId])
GO
ALTER TABLE [dbo].[PrijavaNaTerminPolaganja] CHECK CONSTRAINT [FK_PrijavaNaTerminPolaganja_Sala]
GO
ALTER TABLE [dbo].[PrijavaNaTerminPolaganja]  WITH CHECK ADD  CONSTRAINT [FK_TerminId] FOREIGN KEY([TerminId])
REFERENCES [dbo].[TerminPolaganja] ([TerminPolaganjaId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PrijavaNaTerminPolaganja] CHECK CONSTRAINT [FK_TerminId]
GO
ALTER TABLE [dbo].[TerminPolaganja]  WITH CHECK ADD  CONSTRAINT [FK_IspitId] FOREIGN KEY([IspitId])
REFERENCES [dbo].[Ispit] ([IspitId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TerminPolaganja] CHECK CONSTRAINT [FK_IspitId]
GO
USE [master]
GO
ALTER DATABASE [RasporedPolaganjaDB] SET  READ_WRITE 
GO
