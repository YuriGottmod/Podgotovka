USE [master]
GO
/****** Object:  Database [BD_Fabrica_N_Markov]    Script Date: 18.11.2022 11:14:53 ******/
CREATE DATABASE [BD_Fabrica_N_Markov]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_Fabrica_N_Markov', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BD_Fabrica_N_Markov.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_Fabrica_N_Markov_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BD_Fabrica_N_Markov_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_Fabrica_N_Markov].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET  MULTI_USER 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET QUERY_STORE = OFF
GO
USE [BD_Fabrica_N_Markov]
GO
/****** Object:  Table [dbo].[Авторизация]    Script Date: 18.11.2022 11:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Авторизация](
	[Логин] [nchar](20) NULL,
	[Пароль] [nchar](20) NULL,
	[ТипПользователя] [nchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Продукция]    Script Date: 18.11.2022 11:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продукция](
	[КодПродукции] [int] NOT NULL,
	[Название] [nchar](30) NOT NULL,
	[ЦенаЗаШт] [money] NULL,
	[КоличествоВНаличии] [int] NULL,
	[Описание] [nvarchar](max) NULL,
 CONSTRAINT [PK_Продукция] PRIMARY KEY CLUSTERED 
(
	[КодПродукции] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Авторизация] ([Логин], [Пароль], [ТипПользователя]) VALUES (N'1                   ', N'111                 ', N'Заказчик       ')
INSERT [dbo].[Авторизация] ([Логин], [Пароль], [ТипПользователя]) VALUES (N'2                   ', N'222                 ', N'Администратор  ')
INSERT [dbo].[Авторизация] ([Логин], [Пароль], [ТипПользователя]) VALUES (N'3                   ', N'333                 ', N'Работник       ')
INSERT [dbo].[Авторизация] ([Логин], [Пароль], [ТипПользователя]) VALUES (N'Банан               ', N'999                 ', N'Заказчик       ')
GO
INSERT [dbo].[Продукция] ([КодПродукции], [Название], [ЦенаЗаШт], [КоличествоВНаличии], [Описание]) VALUES (1, N'Матрас Comfort Plus           ', 5190.0000, 12, N'Главная особенность модели – блок независимых пружин. Благодаря независимой поддержке позвоночник во время сна находится в анатомически правильном положении, что улучшает качество сна и общее самочувствие утром. Прочный войлок устойчив к истиранию, что существенно продлевает срок службы изделия. Слой упругой пены улучшает анатомические свойства матраса, повторяя контуры тела спящего. Вы прекрасно выспитесь и утром будете чувствовать себя отлично!')
INSERT [dbo].[Продукция] ([КодПродукции], [Название], [ЦенаЗаШт], [КоличествоВНаличии], [Описание]) VALUES (2, N'Матрас Sleep Style Spring     ', 10217.0000, 3, N'Двусторонний матрас Sleep Style Spring – ниже средней жесткости. Подходит всем, кто мало двигается в течение дня и ценит мягкость и комфорт. В основе матраса:  7-зональный блок независимых пружин поддерживает позвоночник в анатомически правильном положении;  хлопковый войлок способствует равномерному распределению нагрузки на матрас, защищает его от деформации.')
INSERT [dbo].[Продукция] ([КодПродукции], [Название], [ЦенаЗаШт], [КоличествоВНаличии], [Описание]) VALUES (3, N'Анатомическая подушка Alpha   ', 3208.0000, 7, N'Анатомическая подушка выполнена из революционного материала NeoTaktile. Идеально принимает форму головы и хорошо поддерживает шейный отдел позвоночника. Обладает эффектом терморегуляции, пропускает воздух, охлаждает.')
GO
USE [master]
GO
ALTER DATABASE [BD_Fabrica_N_Markov] SET  READ_WRITE 
GO
