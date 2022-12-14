USE [master]
GO
/****** Object:  Database [ТурФирмаМарков]    Script Date: 18.11.2022 11:17:33 ******/
CREATE DATABASE [ТурФирмаМарков]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ТурФирмаМарков', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ТурФирмаМарков.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ТурФирмаМарков_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ТурФирмаМарков_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ТурФирмаМарков] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ТурФирмаМарков].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ТурФирмаМарков] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET ARITHABORT OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ТурФирмаМарков] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ТурФирмаМарков] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ТурФирмаМарков] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ТурФирмаМарков] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ТурФирмаМарков] SET  MULTI_USER 
GO
ALTER DATABASE [ТурФирмаМарков] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ТурФирмаМарков] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ТурФирмаМарков] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ТурФирмаМарков] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ТурФирмаМарков] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ТурФирмаМарков] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ТурФирмаМарков] SET QUERY_STORE = OFF
GO
USE [ТурФирмаМарков]
GO
/****** Object:  Table [dbo].[Туристы]    Script Date: 18.11.2022 11:17:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Туристы](
	[КодТуриста] [int] NOT NULL,
	[Фамилия] [varchar](30) NOT NULL,
	[Имя] [varchar](30) NOT NULL,
	[Отчество] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Туристы] PRIMARY KEY CLUSTERED 
(
	[КодТуриста] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ИнформацияОТуристах]    Script Date: 18.11.2022 11:17:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ИнформацияОТуристах](
	[КодТуриста] [int] NOT NULL,
	[СерияПаспорта] [varchar](30) NOT NULL,
	[Город] [varchar](30) NOT NULL,
	[Страна] [varchar](30) NOT NULL,
	[Телефон] [varchar](30) NOT NULL,
	[Индекс] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ВсеТуристыИзРоссии]    Script Date: 18.11.2022 11:17:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ВсеТуристыИзРоссии]
AS
SELECT        dbo.Туристы.Фамилия, dbo.Туристы.Имя, dbo.Туристы.Отчество, dbo.ИнформацияОТуристах.СерияПаспорта, dbo.ИнформацияОТуристах.Город, dbo.ИнформацияОТуристах.Страна, dbo.ИнформацияОТуристах.Телефон, 
                         dbo.ИнформацияОТуристах.Индекс
FROM            dbo.ИнформацияОТуристах INNER JOIN
                         dbo.Туристы ON dbo.ИнформацияОТуристах.КодТуриста = dbo.Туристы.КодТуриста
WHERE        (dbo.ИнформацияОТуристах.Страна LIKE 'Россия')
GO
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (1, N'2000 546897', N'Воронеж', N'Россия', N'2-22-22', 123456)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (2, N'2100 579632', N'Ростов', N'Россия', N'2-33-33', 234556)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (3, N'2432 458965', N'Харьков', N'Украина', N'2-44-44', 455678)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (4, N'2111 468796', N'Семилуки', N'Россия', N'2-55-55', 789456)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (5, N'3201 457891', N'Воронеж', N'Россия', N'2-66-66', 568923)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (6, N'2607 568793', N'Москва', N'Россия', N'2-77-77', 467913)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (7, N'2710 789565', N'Запорожье', N'Украина', N'2-88-88', 151948)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (8, N'3214 124578', N'Москва', N'Россия', N'2-99-99', 131994)
INSERT [dbo].[ИнформацияОТуристах] ([КодТуриста], [СерияПаспорта], [Город], [Страна], [Телефон], [Индекс]) VALUES (9, N'3345 789531', N'Воронеж', N'Россия', N'2-13-13', 643197)
GO
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (1, N'Иванов', N'Иван', N'Иванович')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (2, N'Петров', N'Петр', N'Петрович')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (3, N'Волков', N'Алексей', N'Александрович')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (4, N'Медведев', N'Дмитрий', N'Васильевич')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (5, N'Авдеев', N'Михаил', N'Сергеевич')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (6, N'Васильев', N'Владимир', N'Николаевич')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (7, N'Соколова', N'Светлана', N'Викторовна')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (8, N'Яковлева', N'Юлия', N'Владимировна')
INSERT [dbo].[Туристы] ([КодТуриста], [Фамилия], [Имя], [Отчество]) VALUES (9, N'Янова', N'Екатерина', N'Николаевна')
GO
ALTER TABLE [dbo].[ИнформацияОТуристах]  WITH CHECK ADD  CONSTRAINT [FK_ИнформацияОТуристах_Туристы] FOREIGN KEY([КодТуриста])
REFERENCES [dbo].[Туристы] ([КодТуриста])
GO
ALTER TABLE [dbo].[ИнформацияОТуристах] CHECK CONSTRAINT [FK_ИнформацияОТуристах_Туристы]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ИнформацияОТуристах"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Туристы"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 136
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ВсеТуристыИзРоссии'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ВсеТуристыИзРоссии'
GO
USE [master]
GO
ALTER DATABASE [ТурФирмаМарков] SET  READ_WRITE 
GO
