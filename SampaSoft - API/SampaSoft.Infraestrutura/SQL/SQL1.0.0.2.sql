USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbFornecedores]    Script Date: 16/06/2018 11:55:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbFornecedores](
	[codFornecedor] [int] NOT NULL,
	[cpfcnpj] [nvarchar](50) NULL,
	[razaoSocial] [nvarchar](50) NULL,
	[nomeFantasia] [nvarchar](50) NULL,
	[logradouro] [nvarchar](250) NULL,
	[numero] [nvarchar](50) NULL,
	[complemento] [nvarchar](250) NULL,
	[bairro] [nvarchar](50) NULL,
	[cidade] [nvarchar](50) NULL,
	[estado] [char](2) NULL,
	[cep] [nvarchar](50) NULL,
	[dataCadastro] [datetime] NULL,
	[ativo] [bit] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbFornecedores] ADD  CONSTRAINT [DF_tbFornecedores_dataCadastro]  DEFAULT (getdate()) FOR [dataCadastro]
GO

ALTER TABLE [dbo].[tbFornecedores] ADD  CONSTRAINT [DF_tbFornecedores_ativo]  DEFAULT ((1)) FOR [ativo]