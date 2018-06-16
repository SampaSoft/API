	USE [SampasoftDB]
	GO

	/****** Object:  Table [dbo].[tbProdutosServicos]    Script Date: 16/06/2018 13:24:31 ******/
	SET ANSI_NULLS ON
	GO

	SET QUOTED_IDENTIFIER ON
	GO

	CREATE TABLE [dbo].[tbProdutosServicos](
		[codProdutoServico] [int] NOT NULL,
		[codFornecedor] [int] NULL,
		[nome] [nvarchar](250) NULL,
		[unidadeMedida] [nvarchar](50) NULL,
		[precoUnitario] [decimal](18, 2) NULL,
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
	GO

	ALTER TABLE [dbo].[tbProdutosServicos]  WITH CHECK ADD  CONSTRAINT [FK_tbProdutosServicos_tbFornecedores] FOREIGN KEY([codFornecedor])
	REFERENCES [dbo].[tbFornecedores] ([codFornecedor])
	GO

	ALTER TABLE [dbo].[tbProdutosServicos] CHECK CONSTRAINT [FK_tbProdutosServicos_tbFornecedores]