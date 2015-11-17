USE [master]
GO
/****** Object:  Database [830TestDB]    Script Date: 11/11/2015 12:32:05 p.m. ******/
CREATE DATABASE [830TestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'830TestDB', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\830TestDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'830TestDB_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\830TestDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [830TestDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [830TestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [830TestDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [830TestDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [830TestDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [830TestDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [830TestDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [830TestDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [830TestDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [830TestDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [830TestDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [830TestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [830TestDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [830TestDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [830TestDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [830TestDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [830TestDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [830TestDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [830TestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [830TestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [830TestDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [830TestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [830TestDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [830TestDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [830TestDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [830TestDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [830TestDB] SET  MULTI_USER 
GO
ALTER DATABASE [830TestDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [830TestDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [830TestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [830TestDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [830TestDB]
GO
/****** Object:  User [dbtest]    Script Date: 11/11/2015 12:32:05 p.m. ******/
CREATE USER [dbtest] FOR LOGIN [dbtest] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [dbtest]
GO
/****** Object:  StoredProcedure [dbo].[sp_StoreMessage]    Script Date: 11/11/2015 12:32:05 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Hernandez
-- Create date: 11/Nov/2015
-- Description:	Inserta un mensaje en la tabla de mensajes
-- =============================================
CREATE PROCEDURE [dbo].[sp_StoreMessage]
	-- Add the parameters for the stored procedure here
	@content nvarchar(200) = '',
	@type nvarchar(50) = ''	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO dbo.message(content, type, dateSent)
	VALUES (@content, @type, CURRENT_TIMESTAMP)

END
GO
/****** Object:  Table [dbo].[message]    Script Date: 11/11/2015 12:32:05 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[message](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[content] [nvarchar](200) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[dateSent] [datetime] NOT NULL,
 CONSTRAINT [PK_message] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [830TestDB] SET  READ_WRITE 
GO
