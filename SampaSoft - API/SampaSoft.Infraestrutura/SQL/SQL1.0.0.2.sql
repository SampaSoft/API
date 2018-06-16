USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbFornecedores]    Script Date: 16/06/2018 12:34:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbFornecedores](
	[codFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[cpfcnpj] [nvarchar](50) NULL,
	[razaoSocial] [nvarchar](50) NULL,
	[nomeFantasia] [nvarchar](50) NULL,
	[porteEmpresa] [nvarchar](50) NULL,
	[logradouro] [nvarchar](250) NULL,
	[numero] [nvarchar](50) NULL,
	[complemento] [nvarchar](250) NULL,
	[bairro] [nvarchar](50) NULL,
	[codMunicipio] [int] NOT NULL,
	[estado] [char](2) NULL,
	[cep] [nvarchar](50) NULL,
	[dataCadastro] [datetime] NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_tbFornecedores] PRIMARY KEY CLUSTERED 
(
	[codFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbFornecedores] ADD  CONSTRAINT [DF_tbFornecedores_dataCadastro]  DEFAULT (getdate()) FOR [dataCadastro]
GO

ALTER TABLE [dbo].[tbFornecedores] ADD  CONSTRAINT [DF_tbFornecedores_ativo]  DEFAULT ((1)) FOR [ativo]
GO

ALTER TABLE [dbo].[tbFornecedores]  WITH CHECK ADD  CONSTRAINT [FK_tbFornecedores_tbMunicipios] FOREIGN KEY([codMunicipio])
REFERENCES [dbo].[tbMunicipios] ([codMunicipio])
GO

ALTER TABLE [dbo].[tbFornecedores] CHECK CONSTRAINT [FK_tbFornecedores_tbMunicipios]