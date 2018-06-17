USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbProdutosServicos]    Script Date: 16/06/2018 20:45:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbProdutosServicos](
	[codProdutoServico] [int] NOT NULL,
	[nome] [nvarchar](250) NULL,
	[unidadeMedida] [nvarchar](50) NULL,
	[precoMedio] [decimal](18, 2) NULL,
	[dataCadastro] [datetime] NULL,
	[ativo] [bit] NULL,
 CONSTRAINT [PK_tbProdutosServicos] PRIMARY KEY CLUSTERED 
(
	[codProdutoServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbProdutosServicos] ADD  CONSTRAINT [DF_tbProdutosServicos_dataCadastro]  DEFAULT (getdate()) FOR [dataCadastro]
GO

ALTER TABLE [dbo].[tbProdutosServicos] ADD  CONSTRAINT [DF_tbProdutosServicos_ativo]  DEFAULT ((1)) FOR [ativo]