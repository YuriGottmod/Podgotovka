USE [master]
GO
/****** Object:  Database [ПродажаЦветовМарков]    Script Date: 19.11.2022 11:18:10 ******/
CREATE DATABASE [ПродажаЦветовМарков]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ПродажаЦветовМарков', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ПродажаЦветовМарков.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ПродажаЦветовМарков_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ПродажаЦветовМарков_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ПродажаЦветовМарков] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ПродажаЦветовМарков].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ПродажаЦветовМарков] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET ARITHABORT OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET  MULTI_USER 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ПродажаЦветовМарков] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ПродажаЦветовМарков] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ПродажаЦветовМарков] SET QUERY_STORE = OFF
GO
USE [ПродажаЦветовМарков]
GO
/****** Object:  Table [dbo].[Продавец]    Script Date: 19.11.2022 11:18:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продавец](
	[код_продавца] [int] NOT NULL,
	[фамилия] [varchar](40) NOT NULL,
	[имя] [varchar](40) NOT NULL,
	[отчество] [varchar](40) NULL,
	[разряд] [int] NULL,
	[оклад] [money] NULL,
	[дата_приема] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[код_продавца] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Продажи]    Script Date: 19.11.2022 11:18:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продажи](
	[код_продажи] [int] NOT NULL,
	[код_цветка] [int] NOT NULL,
	[дата_продажи] [smalldatetime] NOT NULL,
	[цена] [money] NOT NULL,
	[количество] [int] NULL,
	[код_продавца] [int] NOT NULL,
 CONSTRAINT [PK__Продажи__50EB4080688A3375] PRIMARY KEY CLUSTERED 
(
	[код_продажи] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Цветы]    Script Date: 19.11.2022 11:18:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Цветы](
	[Код_цветка] [int] NOT NULL,
	[Название_цветка] [varchar](40) NOT NULL,
	[Сорт_цветка] [varchar](40) NULL,
	[Средняя_высота] [int] NOT NULL,
	[Тип_листа] [varchar](40) NULL,
	[Цветущий] [bit] NULL,
	[Дополнительные_сведения] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Код_цветка] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Продавец] ([код_продавца], [фамилия], [имя], [отчество], [разряд], [оклад], [дата_приема]) VALUES (1, N'Иванов', N'Иван', N'Иванович', 3, 15000.0000, CAST(N'2005-05-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[Продавец] ([код_продавца], [фамилия], [имя], [отчество], [разряд], [оклад], [дата_приема]) VALUES (2, N'Петров', N'Петр', N'Петрович', 2, 20000.0000, CAST(N'2008-06-20T00:00:00' AS SmallDateTime))
INSERT [dbo].[Продавец] ([код_продавца], [фамилия], [имя], [отчество], [разряд], [оклад], [дата_приема]) VALUES (3, N'Васильев', N'Владимир', N'Сергеевич', 3, 15000.0000, CAST(N'2008-08-08T00:00:00' AS SmallDateTime))
INSERT [dbo].[Продавец] ([код_продавца], [фамилия], [имя], [отчество], [разряд], [оклад], [дата_приема]) VALUES (4, N'Волков', N'Алесей', N'Александрович', 1, 25000.0000, CAST(N'2000-09-25T00:00:00' AS SmallDateTime))
INSERT [dbo].[Продавец] ([код_продавца], [фамилия], [имя], [отчество], [разряд], [оклад], [дата_приема]) VALUES (5, N'Яковлева', N'Светлана', N'Дмитриева', 2, 20000.0000, CAST(N'2001-02-01T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (1, 3, CAST(N'2015-06-25T00:00:00' AS SmallDateTime), 300.0000, 5, 2)
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (2, 6, CAST(N'2016-06-26T00:00:00' AS SmallDateTime), 450.0000, 3, 1)
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (3, 2, CAST(N'2015-06-27T00:00:00' AS SmallDateTime), 580.0000, 1, 5)
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (4, 1, CAST(N'2016-06-28T00:00:00' AS SmallDateTime), 100.0000, 3, 1)
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (5, 7, CAST(N'2016-06-30T00:00:00' AS SmallDateTime), 220.0000, 3, 3)
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (6, 2, CAST(N'2016-07-01T00:00:00' AS SmallDateTime), 580.0000, 5, 4)
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (7, 8, CAST(N'2016-07-02T00:00:00' AS SmallDateTime), 770.0000, 3, 2)
INSERT [dbo].[Продажи] ([код_продажи], [код_цветка], [дата_продажи], [цена], [количество], [код_продавца]) VALUES (8, 2, CAST(N'2016-07-03T00:00:00' AS SmallDateTime), 580.0000, 1, 4)
GO
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (1, N'Ромашка', N'крупноцветковые', 60, N'овальный', 1, N'')
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (2, N'Астрамелия', N'бьюти', 65, N'овальный', 1, NULL)
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (3, N'Роза', N'Айсберг', 76, N'сетчатое ', 1, NULL)
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (4, N'Герберы', N'blond', 78, N'сетчатое', 0, NULL)
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (6, N'Гиацинты ', N'водный', 50, N'ланцентный', 1, NULL)
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (7, N'Лилии ', N'Пурпл Харт', 120, N'черешок', 0, NULL)
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (8, N'Бегония', N'Party Dress', 60, N'овальный', 1, NULL)
INSERT [dbo].[Цветы] ([Код_цветка], [Название_цветка], [Сорт_цветка], [Средняя_высота], [Тип_листа], [Цветущий], [Дополнительные_сведения]) VALUES (9, N'Герань душистая', N'Герань', 50, N'черешковый', NULL, NULL)
GO
ALTER TABLE [dbo].[Продажи]  WITH CHECK ADD  CONSTRAINT [FK_Продажи_Продавец] FOREIGN KEY([код_продавца])
REFERENCES [dbo].[Продавец] ([код_продавца])
GO
ALTER TABLE [dbo].[Продажи] CHECK CONSTRAINT [FK_Продажи_Продавец]
GO
ALTER TABLE [dbo].[Продажи]  WITH CHECK ADD  CONSTRAINT [FK_Продажи_Цветы] FOREIGN KEY([код_цветка])
REFERENCES [dbo].[Цветы] ([Код_цветка])
GO
ALTER TABLE [dbo].[Продажи] CHECK CONSTRAINT [FK_Продажи_Цветы]
GO
USE [master]
GO
ALTER DATABASE [ПродажаЦветовМарков] SET  READ_WRITE 
GO
