USE [SampasoftDB]
GO

/****** Object:  Table [dbo].[tbUsuarios]    Script Date: 16/06/2018 12:10:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbUsuarios](
	[codUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](250) NULL,
	[rg] [nvarchar](50) NULL,
	[cpf] [nvarchar](50) NULL,
	[logradouro] [nvarchar](250) NULL,
	[numero] [nvarchar](50) NULL,
	[complemento] [nvarchar](250) NULL,
	[bairro] [nvarchar](50) NULL,
	[codMunicipio] [int] NOT NULL,
	[estado] [char](2) NULL,
	[cep] [nvarchar](50) NULL,
	[sexo] [char](1) NULL,
	[dataNascimento] [datetime] NULL,
	[senha] [nvarchar](max) NULL,
	[dataCadastro] [datetime] NULL,
	[ativo] [bit] NULL,
 CONSTRAINT [PK_tbUsuarios] PRIMARY KEY CLUSTERED 
(
	[codUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbUsuarios] ADD  CONSTRAINT [DF_tbUsuarios_dataCadastro]  DEFAULT (getdate()) FOR [dataCadastro]
GO

ALTER TABLE [dbo].[tbUsuarios] ADD  CONSTRAINT [DF_tbUsuarios_ativo]  DEFAULT ((1)) FOR [ativo]
GO

ALTER TABLE [dbo].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarios_tbMunicipios] FOREIGN KEY([codMunicipio])
REFERENCES [dbo].[tbMunicipios] ([codMunicipio])
GO

ALTER TABLE [dbo].[tbUsuarios] CHECK CONSTRAINT [FK_tbUsuarios_tbMunicipios]