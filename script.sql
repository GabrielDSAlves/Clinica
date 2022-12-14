create database Clinica_odonto
go

USE [Clinica_odonto]
GO
/****** Object:  Table [dbo].[consulta]    Script Date: 07/12/2022 22:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta](
	[ID_Consulta] [int] IDENTITY(1,1) NOT NULL,
	[DataAtual_Consulta] [varchar](50) NULL,
	[DataMarcada_Consulta] [varchar](50) NULL,
	[HoraInicio_Consulta] [varchar](50) NULL,
	[HoraFim_Consulta] [varchar](50) NULL,
	[ID_Func] [int] NULL,
	[ID_Pac] [int] NULL,
	[ID_Dent] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DENTISTA]    Script Date: 07/12/2022 22:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DENTISTA](
	[ID_Dent] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Dent] [varchar](100) NULL,
	[CPF_Dent] [varchar](15) NULL,
	[DataNascimento_Dent] [date] NULL,
	[Cidade_Dent] [varchar](50) NULL,
	[Endereco_Dent] [varchar](50) NULL,
	[Numero_Dent] [varchar](15) NULL,
	[Bairro_Dent] [varchar](50) NULL,
	[Email_Dent] [varchar](50) NULL,
	[Telefone_Dent] [varchar](15) NULL,
	[CRO_Dent] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Dent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionarios]    Script Date: 07/12/2022 22:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionarios](
	[ID_Func] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Func] [varchar](100) NULL,
	[CPF_Func] [varchar](20) NULL,
	[Datanascimento_Func] [varchar](50) NULL,
	[Cidade_Func] [varchar](50) NULL,
	[Endereco_Func] [varchar](50) NULL,
	[Numero_Func] [varchar](15) NULL,
	[Bairro_Func] [varchar](50) NULL,
	[Email_Func] [varchar](50) NULL,
	[Telefone_Func] [varchar](15) NULL,
	[Senha_Func] [varchar](250) NULL,
	[Cargo_func] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Func] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pacientes]    Script Date: 07/12/2022 22:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pacientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[CPF] [varchar](20) NULL,
	[Datanascimento] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Numero] [varchar](5) NULL,
	[Bairro] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Telefone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([ID_Dent])
REFERENCES [dbo].[DENTISTA] ([ID_Dent])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([ID_Func])
REFERENCES [dbo].[funcionarios] ([ID_Func])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([ID_Pac])
REFERENCES [dbo].[pacientes] ([ID])
GO
