USE [PartyDB]
GO

/****** Object:  Table [dbo].[Dish]    Script Date: 12/7/2018 1:17:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dish](
	[DishID] [int] NOT NULL,
	[PersonName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](24) NULL,
	[DishName] [nvarchar](50) NULL,
	[DishDescription] [nvarchar](100) NULL,
	[Option] [nchar](20) NULL,
 CONSTRAINT [PK_PartyDishes] PRIMARY KEY CLUSTERED 
(
	[DishID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


