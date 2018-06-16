USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbOrdensComprasProdutosServicos]    Script Date: 16/06/2018 19:48:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbOrdensComprasProdutosServicos](
	[codOrdemCompra] [int] NOT NULL,
	[codProdutoServico] [int] NOT NULL,
 CONSTRAINT [PK_tbOrdensComprasProdutosServicos] PRIMARY KEY CLUSTERED 
(
	[codOrdemCompra] ASC,
	[codProdutoServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbOrdensComprasProdutosServicos]  WITH CHECK ADD  CONSTRAINT [FK_tbOrdensComprasProdutosServicos_tbOrdensCompras] FOREIGN KEY([codOrdemCompra])
REFERENCES [dbo].[tbOrdensCompras] ([codOrdemCompra])
GO

ALTER TABLE [dbo].[tbOrdensComprasProdutosServicos] CHECK CONSTRAINT [FK_tbOrdensComprasProdutosServicos_tbOrdensCompras]
GO

ALTER TABLE [dbo].[tbOrdensComprasProdutosServicos]  WITH CHECK ADD  CONSTRAINT [FK_tbOrdensComprasProdutosServicos_tbProdutosServicos] FOREIGN KEY([codProdutoServico])
REFERENCES [dbo].[tbProdutosServicos] ([codProdutoServico])
GO

ALTER TABLE [dbo].[tbOrdensComprasProdutosServicos] CHECK CONSTRAINT [FK_tbOrdensComprasProdutosServicos_tbProdutosServicos]