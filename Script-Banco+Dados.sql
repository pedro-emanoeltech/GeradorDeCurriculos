USE [master]
GO
/****** Object:  Database [Curriculo]    Script Date: 05/08/2021 09:02:28 ******/
CREATE DATABASE [Curriculo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Curriculo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PEDROEMANOEL\MSSQL\DATA\Curriculo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Curriculo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PEDROEMANOEL\MSSQL\DATA\Curriculo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Curriculo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Curriculo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Curriculo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Curriculo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Curriculo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Curriculo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Curriculo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Curriculo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Curriculo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Curriculo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Curriculo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Curriculo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Curriculo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Curriculo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Curriculo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Curriculo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Curriculo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Curriculo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Curriculo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Curriculo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Curriculo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Curriculo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Curriculo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Curriculo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Curriculo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Curriculo] SET  MULTI_USER 
GO
ALTER DATABASE [Curriculo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Curriculo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Curriculo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Curriculo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Curriculo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Curriculo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Curriculo] SET QUERY_STORE = OFF
GO
USE [Curriculo]
GO
/****** Object:  Table [dbo].[Candidatura]    Script Date: 05/08/2021 09:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidatura](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDVaga] [int] NOT NULL,
	[IDDadosPessoais] [int] NOT NULL,
	[DataCadastro] [date] NULL,
	[Situacao] [bit] NULL,
	[Instrucoes] [nchar](500) NULL,
	[CurriculoNome] [nchar](100) NULL,
 CONSTRAINT [PK_Candidaturas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DadosPessoais]    Script Date: 05/08/2021 09:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DadosPessoais](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nchar](250) NOT NULL,
	[Endereco] [nchar](150) NULL,
	[Bairro] [nchar](100) NULL,
	[Cidade] [nchar](150) NULL,
	[Nacionalidade] [nchar](100) NOT NULL,
	[Telefone] [nchar](20) NULL,
	[DataNascimento] [datetime] NULL,
	[IDUsuario] [int] NOT NULL,
 CONSTRAINT [PK_DadosPessoais] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 05/08/2021 09:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CNPJ] [nchar](14) NOT NULL,
	[Nome] [nchar](200) NOT NULL,
	[Setor] [nchar](50) NULL,
	[Cidade] [nchar](100) NULL,
	[Endereco] [nchar](100) NULL,
	[Bairro] [nchar](100) NULL,
	[Numero] [nchar](100) NULL,
	[IDUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Empresas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExperienciaProfissional]    Script Date: 05/08/2021 09:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExperienciaProfissional](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Empresa] [nchar](150) NOT NULL,
	[Cargo] [nchar](150) NOT NULL,
	[Segmento] [nchar](200) NOT NULL,
	[Salario] [decimal](18, 2) NULL,
	[Descricao] [nchar](500) NULL,
	[IDDadosPessoais] [int] NOT NULL,
 CONSTRAINT [PK_ExperienciaProfissional] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formacao]    Script Date: 05/08/2021 09:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formacao](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Curso] [nchar](300) NOT NULL,
	[FormacaoNivel] [nchar](30) NOT NULL,
	[Status] [nchar](30) NOT NULL,
	[Inicio] [date] NULL,
	[Termino] [date] NULL,
	[Descricao] [nchar](500) NULL,
	[IDDadosPessoais] [int] NOT NULL,
 CONSTRAINT [PK_Formacao] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/08/2021 09:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nchar](50) NOT NULL,
	[Login] [nchar](50) NOT NULL,
	[Senha] [nchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[AcessoCurriculo] [bit] NOT NULL,
	[AcessoEmpresa] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vaga]    Script Date: 05/08/2021 09:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vaga](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TituloVaga] [nchar](200) NOT NULL,
	[Descricao] [nchar](500) NULL,
	[Atividade] [nchar](500) NULL,
	[Requisitos] [nchar](300) NULL,
	[Salario] [decimal](18, 2) NULL,
	[Cidade] [nchar](100) NULL,
	[TipoVaga] [nchar](100) NULL,
	[IDEmpresa] [int] NOT NULL,
 CONSTRAINT [PK_Vagas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidatura] ON 

INSERT [dbo].[Candidatura] ([ID], [IDVaga], [IDDadosPessoais], [DataCadastro], [Situacao], [Instrucoes], [CurriculoNome]) VALUES (2, 1, 1, CAST(N'2021-06-19' AS Date), 0, NULL, N'SUPORTE REMOTO                                                                                      ')
INSERT [dbo].[Candidatura] ([ID], [IDVaga], [IDDadosPessoais], [DataCadastro], [Situacao], [Instrucoes], [CurriculoNome]) VALUES (1003, 4, 1, CAST(N'2021-07-30' AS Date), 0, NULL, N'DESENVOLVEDOR WEB                                                                                   ')
SET IDENTITY_INSERT [dbo].[Candidatura] OFF
GO
SET IDENTITY_INSERT [dbo].[DadosPessoais] ON 

INSERT [dbo].[DadosPessoais] ([ID], [Nome], [Endereco], [Bairro], [Cidade], [Nacionalidade], [Telefone], [DataNascimento], [IDUsuario]) VALUES (1, N'Pedro Emanoel                                                                                                                                                                                                                                             ', N'TOCANTINS                                                                                                                                             ', N'SANTA ELIZA                                                                                         ', N'VOTUPORANGA                                                                                                                                           ', N'Brasileiro                                                                                          ', N'34-99674982         ', CAST(N'1998-09-22T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[DadosPessoais] ([ID], [Nome], [Endereco], [Bairro], [Cidade], [Nacionalidade], [Telefone], [DataNascimento], [IDUsuario]) VALUES (3, N'NATANAEL                                                                                                                                                                                                                                                  ', N'AMAZONAS                                                                                                                                              ', N'CENTRO                                                                                              ', N'VOTUPORANGA                                                                                                                                           ', N'BRASILEIRO                                                                                          ', N'17-997825662        ', CAST(N'2021-05-05T00:00:00.000' AS DateTime), 7)
INSERT [dbo].[DadosPessoais] ([ID], [Nome], [Endereco], [Bairro], [Cidade], [Nacionalidade], [Telefone], [DataNascimento], [IDUsuario]) VALUES (5, N'LUIZ                                                                                                                                                                                                                                                      ', N'JOSE CAFARO                                                                                                                                           ', N'CDH                                                                                                 ', N'VALENTIN GENTIL                                                                                                                                       ', N'BRASILEIRO                                                                                          ', N'17-998886555        ', CAST(N'1990-07-06T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[DadosPessoais] ([ID], [Nome], [Endereco], [Bairro], [Cidade], [Nacionalidade], [Telefone], [DataNascimento], [IDUsuario]) VALUES (8, N'LARISSA APARECIDA                                                                                                                                                                                                                                         ', N'RUA MANAUS                                                                                                                                            ', N'CENTRO                                                                                              ', N'FORTALEZA                                                                                                                                             ', N'BRASILEIRO                                                                                          ', N'19-987744558        ', CAST(N'1980-03-16T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[DadosPessoais] ([ID], [Nome], [Endereco], [Bairro], [Cidade], [Nacionalidade], [Telefone], [DataNascimento], [IDUsuario]) VALUES (9, N'PEDRO                                                                                                                                                                                                                                                     ', N'TESTE                                                                                                                                                 ', N'TESTE                                                                                               ', N'TESTE                                                                                                                                                 ', N'TESTE                                                                                               ', N'TESTE               ', CAST(N'2021-06-14T00:00:00.000' AS DateTime), 12)
SET IDENTITY_INSERT [dbo].[DadosPessoais] OFF
GO
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([ID], [CNPJ], [Nome], [Setor], [Cidade], [Endereco], [Bairro], [Numero], [IDUsuario]) VALUES (5, N'15548798000043', N'Brasil Tendas BR                                                                                                                                                                                        ', N'Laser                                             ', N'Sao paulo                                                                                           ', N'paulista                                                                                            ', N'centro                                                                                              ', N'4574                                                                                                ', 2)
INSERT [dbo].[Empresa] ([ID], [CNPJ], [Nome], [Setor], [Cidade], [Endereco], [Bairro], [Numero], [IDUsuario]) VALUES (7, N'15515555555555', N'AMAZON                                                                                                                                                                                                  ', N'TECNOLOGIA                                        ', N'SAO PAULO                                                                                           ', N'Rua brasil                                                                                          ', N'centro                                                                                              ', N'55                                                                                                  ', 8)
INSERT [dbo].[Empresa] ([ID], [CNPJ], [Nome], [Setor], [Cidade], [Endereco], [Bairro], [Numero], [IDUsuario]) VALUES (9, N'TESTE         ', N'TESTE                                                                                                                                                                                                   ', N'TESTET                                            ', N'TESTE                                                                                               ', N'TESTE                                                                                               ', N'TESTE                                                                                               ', N'TESTE                                                                                               ', 11)
INSERT [dbo].[Empresa] ([ID], [CNPJ], [Nome], [Setor], [Cidade], [Endereco], [Bairro], [Numero], [IDUsuario]) VALUES (10, N'15555555555555', N'EMPRESA                                                                                                                                                                                                 ', N'TEST                                              ', N'TESTE                                                                                               ', N'TESTE                                                                                               ', N'TESTE                                                                                               ', N'TESTE                                                                                               ', 12)
SET IDENTITY_INSERT [dbo].[Empresa] OFF
GO
SET IDENTITY_INSERT [dbo].[ExperienciaProfissional] ON 

INSERT [dbo].[ExperienciaProfissional] ([ID], [Empresa], [Cargo], [Segmento], [Salario], [Descricao], [IDDadosPessoais]) VALUES (2, N'UPPER                                                                                                                                                 ', N'SUPORTE                                                                                                                                               ', N'ERP                                                                                                                                                                                                     ', CAST(3000.00 AS Decimal(18, 2)), N'Atendimento e suporte ao cliente do sistema, Treinamentos, Ordem de Produção, Programação de produção, Planejamento, Controle Estoque, Faturamento, Financeiro, Auxilio nos preenchimentos de documentos fiscais como NF-e, NFC-e, CTe, SAT, MDFE, geração de SPED, Configuração de Etiquetas, Contas a Receber, Contas a Pagar, DDNS.                                                                                                                                                                              ', 1)
INSERT [dbo].[ExperienciaProfissional] ([ID], [Empresa], [Cargo], [Segmento], [Salario], [Descricao], [IDDadosPessoais]) VALUES (4, N'UNARH                                                                                                                                                 ', N'RECURSOS HUMANOS                                                                                                                                      ', N'RH RECURSOS HUMANOS                                                                                                                                                                                     ', CAST(1500.00 AS Decimal(18, 2)), N'Experiência com vendas e negociações (presencial, telefone e redes sociais).ATRIBUIÇÕES:- Negociações e fechamento de contratos;- Contribuir com o atendimento na recepção.Local de trabalho: Votuporanga, SPRegime de contratação de tipo: Efetivo – CLTJornada: Período IntegralÁrea e especialização profissional: Comercial, Vendas - Representação ComercialNível hierárquico: OperacionalHABILIDADESTrabalho em equipeFacilidade com VendasComunicação                                                        ', 3)
INSERT [dbo].[ExperienciaProfissional] ([ID], [Empresa], [Cargo], [Segmento], [Salario], [Descricao], [IDDadosPessoais]) VALUES (6, N'HAVAN                                                                                                                                                 ', N'VENDAS                                                                                                                                                ', N'VENDAS                                                                                                                                                                                                  ', CAST(1800.00 AS Decimal(18, 2)), N'Projetos de expansão ousados e metas desafiadoras fazem parte do dia-a-dia da Havan. A loja iniciou suas atividades em 1986 no município de Brusque (SC), com apenas um funcionário, hoje são mais de 22.000 colaboradores espalhados por todo o país.                                                                                                                                                                                                                                                              ', 8)
INSERT [dbo].[ExperienciaProfissional] ([ID], [Empresa], [Cargo], [Segmento], [Salario], [Descricao], [IDDadosPessoais]) VALUES (7, N'EXPERT                                                                                                                                                ', N'ANALISTA DE SISTEMAS                                                                                                                                  ', N'SISTEMAS                                                                                                                                                                                                ', CAST(1900.00 AS Decimal(18, 2)), N'O analista de sistemas atua na área de Tecnologia da Informação (TI) desenvolvendo soluções específicas em sistemas informatizados para empresas. Ele analisa, documenta, projeta, implementa, testa e gerencia os sistemas de informações necessários para os negócios de seus clientes ou empregadores.                                                                                                                                                                                                           ', 1)
INSERT [dbo].[ExperienciaProfissional] ([ID], [Empresa], [Cargo], [Segmento], [Salario], [Descricao], [IDDadosPessoais]) VALUES (8, N'YOUTUBE                                                                                                                                               ', N'DESENVOLVEDOR DE CONTEUDO                                                                                                                             ', N'TECNICO                                                                                                                                                                                                 ', CAST(5000.00 AS Decimal(18, 2)), N'Desevolver conteudo em video                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ', 1)
SET IDENTITY_INSERT [dbo].[ExperienciaProfissional] OFF
GO
SET IDENTITY_INSERT [dbo].[Formacao] ON 

INSERT [dbo].[Formacao] ([ID], [Curso], [FormacaoNivel], [Status], [Inicio], [Termino], [Descricao], [IDDadosPessoais]) VALUES (1, N'Engenharia da Computacão                                                                                                                                                                                                                                                                                    ', N'Superior                      ', N'Cursando                      ', CAST(N'2018-01-02' AS Date), CAST(N'2023-12-20' AS Date), N'O curso de Engenharia de Computação forma profissionais habilitados para o desenvolvimento e planejamento de softwares e hardwares.
No mercado de trabalho, as empresas buscam o profissional de Engenharia de Computação para criar e gerenciar sistemas ou desenvolver novas máquinas industriais e novas tecnologias.                                                                                                                                                                                           ', 1)
INSERT [dbo].[Formacao] ([ID], [Curso], [FormacaoNivel], [Status], [Inicio], [Termino], [Descricao], [IDDadosPessoais]) VALUES (4, N'Agronomia  teste                                                                                                                                                                                                                                                                                            ', N'Superior                      ', N'Cursando                      ', CAST(N'2015-03-25' AS Date), CAST(N'2020-12-20' AS Date), N'Agronomia é um campo da Gestão Ambiental e abarcado pelas ciências agrárias, sendo uma área multidisciplinar que inclui subáreas aplicadas das ciências naturais, exatas, sociais e econômicas que trabalham em conjunto visando aumentar a compreensão                                                                                                                                                                                                                                                             ', 3)
INSERT [dbo].[Formacao] ([ID], [Curso], [FormacaoNivel], [Status], [Inicio], [Termino], [Descricao], [IDDadosPessoais]) VALUES (6, N'Mecanica Quantica                                                                                                                                                                                                                                                                                           ', N'Superior                      ', N'Concluido                     ', CAST(N'2010-01-29' AS Date), CAST(N'2013-02-25' AS Date), NULL, 1)
SET IDENTITY_INSERT [dbo].[Formacao] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (1, N'Pedro Emanoel                                     ', N'PEDRO                                             ', N'123                                               ', 1, 1, 0)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (2, N'CAIO RIBEIRO                                      ', N'CAIO                                              ', N'123                                               ', 1, 0, 1)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (4, N'AMAZON                                            ', N'AMAZON                                            ', N'123456789                                         ', 1, 0, 1)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (6, N'LARISSA                                           ', N'LARISSA                                           ', N'123456789                                         ', 1, 1, 0)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (7, N'NATANAEL                                          ', N'NATANAEL                                          ', N'123                                               ', 1, 1, 0)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (8, N'LUIZ                                              ', N'LUIZ                                              ', N'123                                               ', 1, 1, 0)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (11, N'TESTE                                             ', N'TESTE                                             ', N'1                                                 ', 1, 0, 1)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (12, N'TESTE                                             ', N'USUARIO                                           ', N'123                                               ', 1, 1, 0)
INSERT [dbo].[Usuario] ([ID], [Nome], [Login], [Senha], [Ativo], [AcessoCurriculo], [AcessoEmpresa]) VALUES (13, N'TESTE SEM DADOS PESSOAIS                          ', N'TESTE                                             ', N'123                                               ', 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Vaga] ON 

INSERT [dbo].[Vaga] ([ID], [TituloVaga], [Descricao], [Atividade], [Requisitos], [Salario], [Cidade], [TipoVaga], [IDEmpresa]) VALUES (1, N'SUPORTE REMOTO                                                                                                                                                                                          ', N'SUPORTE TESTE                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', N'SUPORTE AO USUARIO                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', N'BASICO TESTE                                                                                                                                                                                                                                                                                                ', CAST(1200.00 AS Decimal(18, 2)), N'VOTUPORANGA                                                                                         ', N'CLT                                                                                                 ', 5)
INSERT [dbo].[Vaga] ([ID], [TituloVaga], [Descricao], [Atividade], [Requisitos], [Salario], [Cidade], [TipoVaga], [IDEmpresa]) VALUES (4, N'DESENVOLVEDOR WEB                                                                                                                                                                                       ', N'Javascript
HTML5
CSS3                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             ', N'Manutenção em aplicações existentes                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ', N'Experiência com python, java e scala; experiência com: Jenkins                                                                                                                                                                                                                                              ', CAST(5000.00 AS Decimal(18, 2)), N'VOTUPORANGA                                                                                         ', N'CLT                                                                                                 ', 5)
SET IDENTITY_INSERT [dbo].[Vaga] OFF
GO
ALTER TABLE [dbo].[Candidatura]  WITH CHECK ADD  CONSTRAINT [FK_Candidaturas_DadosPessoais] FOREIGN KEY([IDDadosPessoais])
REFERENCES [dbo].[DadosPessoais] ([ID])
GO
ALTER TABLE [dbo].[Candidatura] CHECK CONSTRAINT [FK_Candidaturas_DadosPessoais]
GO
ALTER TABLE [dbo].[Candidatura]  WITH CHECK ADD  CONSTRAINT [FK_Candidaturas_Vagas] FOREIGN KEY([IDVaga])
REFERENCES [dbo].[Vaga] ([ID])
GO
ALTER TABLE [dbo].[Candidatura] CHECK CONSTRAINT [FK_Candidaturas_Vagas]
GO
ALTER TABLE [dbo].[DadosPessoais]  WITH CHECK ADD  CONSTRAINT [FK_DadosPessoais_Usuarios] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([ID])
GO
ALTER TABLE [dbo].[DadosPessoais] CHECK CONSTRAINT [FK_DadosPessoais_Usuarios]
GO
ALTER TABLE [dbo].[ExperienciaProfissional]  WITH CHECK ADD  CONSTRAINT [FK_ExperienciaProfissional_DadosPessoais] FOREIGN KEY([IDDadosPessoais])
REFERENCES [dbo].[DadosPessoais] ([ID])
GO
ALTER TABLE [dbo].[ExperienciaProfissional] CHECK CONSTRAINT [FK_ExperienciaProfissional_DadosPessoais]
GO
ALTER TABLE [dbo].[Formacao]  WITH CHECK ADD  CONSTRAINT [FK_Formacao_DadosPessoais] FOREIGN KEY([IDDadosPessoais])
REFERENCES [dbo].[DadosPessoais] ([ID])
GO
ALTER TABLE [dbo].[Formacao] CHECK CONSTRAINT [FK_Formacao_DadosPessoais]
GO
ALTER TABLE [dbo].[Vaga]  WITH CHECK ADD  CONSTRAINT [FK_Vagas_Empresas] FOREIGN KEY([IDEmpresa])
REFERENCES [dbo].[Empresa] ([ID])
GO
ALTER TABLE [dbo].[Vaga] CHECK CONSTRAINT [FK_Vagas_Empresas]
GO
USE [master]
GO
ALTER DATABASE [Curriculo] SET  READ_WRITE 
GO
