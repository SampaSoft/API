USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbOrdensCompras]    Script Date: 16/06/2018 19:46:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbOrdensCompras](
	[codOrdemCompra] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [nvarchar](250) NULL,
	[justificativa] [nvarchar](250) NULL,
	[dataCadastro] [datetime] NULL,
	[dataAprovado] [datetime] NULL,
	[protocolo] [uniqueidentifier] NULL,
	[ativo] [bit] NULL,
 CONSTRAINT [PK_tbOrdensCompras] PRIMARY KEY CLUSTERED 
(
	[codOrdemCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbOrdensCompras] ADD  CONSTRAINT [DF_tbOrdensCompras_dataCadastro]  DEFAULT (getdate()) FOR [dataCadastro]
GO

ALTER TABLE [dbo].[tbOrdensCompras] ADD  CONSTRAINT [DF_tbOrdensCompras_ativo]  DEFAULT ((1)) FOR [ativo]