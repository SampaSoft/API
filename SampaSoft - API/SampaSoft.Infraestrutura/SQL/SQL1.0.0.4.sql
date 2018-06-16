USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbSecretarias]    Script Date: 16/06/2018 13:29:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbSecretarias](
	[codSecretaria] [int] IDENTITY(1,1) NOT NULL,
	[cnpj] [nvarchar](50) NULL,
	[nome] [nvarchar](250) NULL,
	[email] [nvarchar](50) NULL,
	[logradouro] [nvarchar](250) NULL,
	[numero] [nvarchar](50) NULL,
	[complemento] [nvarchar](50) NULL,
	[codMunicipio] [int] NULL,
	[telefone] [nvarchar](50) NULL,
	[horaAtendimentoInicial] [time](7) NULL,
	[horaAtendimentoFinal] [time](7) NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_tbSecretarias] PRIMARY KEY CLUSTERED 
(
	[codSecretaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbSecretarias] ADD  CONSTRAINT [DF_tbSecretarias_ativo]  DEFAULT ((1)) FOR [ativo]
GO

ALTER TABLE [dbo].[tbSecretarias]  WITH CHECK ADD  CONSTRAINT [FK_tbSecretarias_tbMunicipios] FOREIGN KEY([codMunicipio])
REFERENCES [dbo].[tbMunicipios] ([codMunicipio])
GO

ALTER TABLE [dbo].[tbSecretarias] CHECK CONSTRAINT [FK_tbSecretarias_tbMunicipios]