USE [ControlSystemRZD]
GO
/****** Object:  User [SystemADM]    Script Date: 15.11.2024 22:11:31 ******/
CREATE USER [SystemADM] FOR LOGIN [SystemADM] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Поезда]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Поезда](
	[ПоездID] [int] IDENTITY(1,1) NOT NULL,
	[НомерПоезда] [nvarchar](20) NOT NULL,
	[ТипПоезда] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ПоездID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Станции]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Станции](
	[СтанцияID] [int] IDENTITY(1,1) NOT NULL,
	[НазваниеСтанции] [nvarchar](100) NOT NULL,
	[Местоположение] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[СтанцияID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Расписание]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Расписание](
	[РасписаниеID] [int] IDENTITY(1,1) NOT NULL,
	[ПоездID] [int] NOT NULL,
	[МаршрутID] [int] NOT NULL,
	[ВремяОтправления] [time](7) NULL,
	[ВремяПрибытия] [time](7) NULL,
	[Путь] [int] NULL,
	[Опоздание] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[РасписаниеID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Маршруты]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Маршруты](
	[МаршрутID] [int] IDENTITY(1,1) NOT NULL,
	[СтанцияНачалаID] [int] NOT NULL,
	[СтанцияКонцаID] [int] NOT NULL,
	[Длительность] [int] NULL,
 CONSTRAINT [PK__Маршруты__22F362C87C1F78B8] PRIMARY KEY CLUSTERED 
(
	[МаршрутID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TrainBoardView]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TrainBoardView] AS
SELECT 
    Поезда.НомерПоезда AS [Номер поезда],
    Поезда.ТипПоезда AS Категория,
    Станции.НазваниеСтанции AS Назначение,
    Расписание.ВремяПрибытия AS Прибытие,
    Расписание.ВремяОтправления AS Отправление,
    Расписание.Путь AS Путь,
    Расписание.Опоздание AS Опоздание
FROM 
    Расписание
JOIN 
    Поезда ON Расписание.ПоездID = Поезда.ПоездID
JOIN 
    Маршруты ON Расписание.МаршрутID = Маршруты.МаршрутID
JOIN 
    Станции ON Маршруты.СтанцияКонцаID = Станции.СтанцияID;
GO
/****** Object:  View [dbo].[TrainOverview]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TrainOverview] AS
SELECT ПоездID, НомерПоезда, ТипПоезда
FROM dbo.Поезда;
GO
/****** Object:  View [dbo].[ПоездаПредставление]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ПоездаПредставление] AS
SELECT ПоездID, НомерПоезда, ТипПоезда
FROM dbo.Поезда;
GO
ALTER TABLE [dbo].[Маршруты]  WITH CHECK ADD  CONSTRAINT [FK__Маршруты__Станци__412EB0B6] FOREIGN KEY([СтанцияНачалаID])
REFERENCES [dbo].[Станции] ([СтанцияID])
GO
ALTER TABLE [dbo].[Маршруты] CHECK CONSTRAINT [FK__Маршруты__Станци__412EB0B6]
GO
ALTER TABLE [dbo].[Маршруты]  WITH CHECK ADD  CONSTRAINT [FK__Маршруты__Станци__4222D4EF] FOREIGN KEY([СтанцияКонцаID])
REFERENCES [dbo].[Станции] ([СтанцияID])
GO
ALTER TABLE [dbo].[Маршруты] CHECK CONSTRAINT [FK__Маршруты__Станци__4222D4EF]
GO
ALTER TABLE [dbo].[Расписание]  WITH CHECK ADD  CONSTRAINT [FK__Расписани__Маршр__45F365D3] FOREIGN KEY([МаршрутID])
REFERENCES [dbo].[Маршруты] ([МаршрутID])
GO
ALTER TABLE [dbo].[Расписание] CHECK CONSTRAINT [FK__Расписани__Маршр__45F365D3]
GO
ALTER TABLE [dbo].[Расписание]  WITH CHECK ADD FOREIGN KEY([ПоездID])
REFERENCES [dbo].[Поезда] ([ПоездID])
GO
/****** Object:  StoredProcedure [dbo].[AddTrain]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddTrain]
    @НомерПоезда INT,
    @ТипПоезда NVARCHAR(50)
AS
BEGIN
    INSERT INTO Поезда (НомерПоезда, ТипПоезда)
    VALUES (@НомерПоезда, @ТипПоезда);
END;

GO
/****** Object:  StoredProcedure [dbo].[UpdateTrain]    Script Date: 15.11.2024 22:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTrain]
    @ПоездID INT,
    @НомерПоезда INT,
    @ТипПоезда NVARCHAR(50)
AS
BEGIN
    UPDATE Поезда
    SET НомерПоезда = @НомерПоезда,
        ТипПоезда = @ТипПоезда
    WHERE ПоездID = @ПоездID;
END;
GO
