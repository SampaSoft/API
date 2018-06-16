USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbMunicipios]    Script Date: 16/06/2018 12:05:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbMunicipios](
	[codMunicipio] [int] NULL,
	[nome] [nvarchar](250) NULL,
	[codIBGE] [int] NULL
) ON [PRIMARY]