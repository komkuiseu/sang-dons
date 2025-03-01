USE [master]
GO
/****** Object:  Database [gestion_dons]    Script Date: 05/12/2024 06:06:23 ******/
CREATE DATABASE [gestion_dons]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gestion_dons', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gestion_dons.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gestion_dons_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gestion_dons_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gestion_dons] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gestion_dons].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gestion_dons] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gestion_dons] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gestion_dons] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gestion_dons] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gestion_dons] SET ARITHABORT OFF 
GO
ALTER DATABASE [gestion_dons] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gestion_dons] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gestion_dons] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gestion_dons] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gestion_dons] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gestion_dons] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gestion_dons] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gestion_dons] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gestion_dons] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gestion_dons] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gestion_dons] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gestion_dons] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gestion_dons] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gestion_dons] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gestion_dons] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gestion_dons] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gestion_dons] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gestion_dons] SET RECOVERY FULL 
GO
ALTER DATABASE [gestion_dons] SET  MULTI_USER 
GO
ALTER DATABASE [gestion_dons] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gestion_dons] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gestion_dons] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gestion_dons] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gestion_dons] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gestion_dons] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'gestion_dons', N'ON'
GO
ALTER DATABASE [gestion_dons] SET QUERY_STORE = OFF
GO
USE [gestion_dons]
GO
/****** Object:  Table [dbo].[authentification]    Script Date: 05/12/2024 06:06:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[authentification](
	[id_auth] [int] NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[besoin]    Script Date: 05/12/2024 06:06:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[besoin](
	[idbesoin] [int] NULL,
	[idLieu] [int] NULL,
	[groupesanguin] [nchar](10) NULL,
	[datebesoin] [datetime] NULL,
	[urgence] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[don]    Script Date: 05/12/2024 06:06:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[don](
	[id_don] [int] NULL,
	[id_utilisateur] [int] NULL,
	[idLieu] [int] NULL,
	[dateDon] [date] NULL,
	[quantitedonne] [int] NULL,
	[groupesanguin] [nchar](3) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lieu]    Script Date: 05/12/2024 06:06:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lieu](
	[idLieu] [int] NULL,
	[nomlieu] [nvarchar](50) NULL,
	[adresse] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notification]    Script Date: 05/12/2024 06:06:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notification](
	[idnotiv] [int] NULL,
	[id_utilisateur] [int] NULL,
	[typenotiv] [nvarchar](50) NULL,
	[message] [text] NULL,
	[dateenvoi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 05/12/2024 06:06:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[id_utilisateur] [int] NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[email] [ntext] NULL,
	[telephone] [bigint] NULL,
	[ville] [nvarchar](50) NULL,
	[date_inscription] [datetime] NULL,
	[age] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [gestion_dons] SET  READ_WRITE 
GO
