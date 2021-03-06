USE [master]
GO
/****** Object:  Database [TodoList_db]    Script Date: 9.11.2021 21:08:57 ******/
CREATE DATABASE [TodoList_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TodoList_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TodoList_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TodoList_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TodoList_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TodoList_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TodoList_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TodoList_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TodoList_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TodoList_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TodoList_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TodoList_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [TodoList_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TodoList_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TodoList_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TodoList_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TodoList_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TodoList_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TodoList_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TodoList_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TodoList_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TodoList_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TodoList_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TodoList_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TodoList_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TodoList_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TodoList_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TodoList_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TodoList_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TodoList_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TodoList_db] SET  MULTI_USER 
GO
ALTER DATABASE [TodoList_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TodoList_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TodoList_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TodoList_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TodoList_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TodoList_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TodoList_db] SET QUERY_STORE = OFF
GO
USE [TodoList_db]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 9.11.2021 21:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubTaskID] [int] NOT NULL,
	[TaskName] [nvarchar](50) NOT NULL,
	[TaskDescription] [nvarchar](1000) NOT NULL,
	[Date] [date] NOT NULL,
	[IsItCompleted] [bit] NOT NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tasks] ON 

INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (1, 0, N'Günlük Rutin', N'Rutin günlük görevler', CAST(N'2021-11-06' AS Date), 1)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (4, 1, N'Kedi', N'Kedinin suyu ve yemi değişecek', CAST(N'2021-11-06' AS Date), 1)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (5, 1, N'Kahvaltı Öğünü', N'1 adet haşlanmış yumurta,2 adet kibrit büyüklüğünde peynir,7 adet zeytin,2 adet dilim tam buğday ekmek,1 bardak çay', CAST(N'2021-11-06' AS Date), 1)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (6, 1, N'Kitap okuma', N'Bilinçli yaşamın sırları adlı kitap', CAST(N'2021-11-06' AS Date), 1)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (7, 1, N'Yazılım', N'Todo List ödevine devam', CAST(N'2021-11-06' AS Date), 1)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (8, 1, N'Akşam Öğünü', N'1 tabak kuru fazulye ve gabine pilavı', CAST(N'2021-11-06' AS Date), 0)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (20, 0, N'Ödev todo list', N'ödevi yap', CAST(N'2021-11-09' AS Date), 0)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (21, 0, N'bisiklet kafe', N'dükkanı aç çayı demle dükkanı temizle esnafa çayı dağıt', CAST(N'2021-11-09' AS Date), 0)
INSERT [dbo].[Tasks] ([Id], [SubTaskID], [TaskName], [TaskDescription], [Date], [IsItCompleted]) VALUES (22, 0, N'of gün', N'kitap oku- uyu - muzik dinle', CAST(N'2021-11-09' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
GO
USE [master]
GO
ALTER DATABASE [TodoList_db] SET  READ_WRITE 
GO
