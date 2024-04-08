CREATE DATABASE [SmartCrop];
GO

USE [SmartCrop];
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

CREATE TABLE [dbo].[Weather](
    [temperature] [decimal](18, 0) NULL,
    [pressure] [decimal](18, 0) NULL,
    [humidity] [decimal](18, 0) NULL,
    [precipitation] [decimal](18, 0) NULL,
    [wind_speed] [decimal](18, 0) NULL,
    [Id] [int] NOT NULL identity,
	[date] [datetime] NULL,
 CONSTRAINT [PK_weather] PRIMARY KEY CLUSTERED 
(
    [Id] 
) ON [PRIMARY]
) ON [PRIMARY];
GO



CREATE TABLE [dbo].[Farm](
    [address] [nvarchar](max) NULL,
    [zipcode] [nvarchar](max) NULL,
    [city] [nvarchar](max) NULL,
    [state] [nvarchar](max) NULL,
    [name] [nvarchar](max) NULL,
    [Id] [int] NOT NULL identity,
	[Latitude] decimal(9,6),
	[Longitude] decimal(9,6)
 CONSTRAINT [PK_farm] PRIMARY KEY CLUSTERED 
(
    [Id] 
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];
GO
