USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbMunicipios]    Script Date: 16/06/2018 12:07:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbMunicipios](
	[codMunicipio] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](250) NULL,
	[codIBGE] [int] NULL,
 CONSTRAINT [PK_tbMunicipios] PRIMARY KEY CLUSTERED 
(
	[codMunicipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]