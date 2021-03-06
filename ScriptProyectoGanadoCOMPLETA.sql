USE [master]
GO
/****** Object:  Database [base_proyecto]    Script Date: 26/7/2021 09:00:57 ******/
CREATE DATABASE [base_proyecto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'base_proyecto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\base_proyecto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'base_proyecto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\base_proyecto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [base_proyecto] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [base_proyecto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [base_proyecto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [base_proyecto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [base_proyecto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [base_proyecto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [base_proyecto] SET ARITHABORT OFF 
GO
ALTER DATABASE [base_proyecto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [base_proyecto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [base_proyecto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [base_proyecto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [base_proyecto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [base_proyecto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [base_proyecto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [base_proyecto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [base_proyecto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [base_proyecto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [base_proyecto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [base_proyecto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [base_proyecto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [base_proyecto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [base_proyecto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [base_proyecto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [base_proyecto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [base_proyecto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [base_proyecto] SET  MULTI_USER 
GO
ALTER DATABASE [base_proyecto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [base_proyecto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [base_proyecto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [base_proyecto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [base_proyecto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [base_proyecto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'base_proyecto', N'ON'
GO
ALTER DATABASE [base_proyecto] SET QUERY_STORE = OFF
GO
USE [base_proyecto]
GO
/****** Object:  ColumnMasterKey [CMK_Auto1]    Script Date: 26/7/2021 09:00:58 ******/
CREATE COLUMN MASTER KEY [CMK_Auto1]
WITH
(
	KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
	KEY_PATH = N'CurrentUser/my/CC6FF67D2571BD65E6888E2A9942F3D0744FC698'
)
GO
/****** Object:  ColumnEncryptionKey [CEK_Auto1]    Script Date: 26/7/2021 09:00:58 ******/
CREATE COLUMN ENCRYPTION KEY [CEK_Auto1]
WITH VALUES
(
	COLUMN_MASTER_KEY = [CMK_Auto1],
	ALGORITHM = 'RSA_OAEP',
	ENCRYPTED_VALUE = 0x016E000001630075007200720065006E00740075007300650072002F006D0079002F0063006300360066006600360037006400320035003700310062006400360035006500360038003800380065003200610039003900340032006600330064003000370034003400660063003600390038008B947594487689117A4F9A6A0FC9F63987A4EE3C7A1D078D05527BCDBC6B2EEEF6529390353D28B0A2C42FC772172A7B1F665256292422AF84665E77F7CC18454957F9E2F50DE782DDFA11B98FB9C5C2FC08B668E0F4516F9EF2FE1D52451887D134F9F33C7D16426624E1DA03224132B432794D9610D99670D78D87B86A520086773F30A8011475D3BA333C4324AAB90466DD8F83A93158C0077EAF6D19C7D2E50B1795E66683EBC60E577CBDF6D7D72CF0F75CF129A0B055595A5AD7B0B429C93D7438F692ED3344B45C871D8312B650BD25866AC59C664072C3DF15F9FDD1C322A6CE205029AEB154EC2144E21253B4A4D61265477D234432A4BE404D17557AE02360ABB3E2DA092DF3E0EF58A2CE8339B24AF84DE4BF36D82C242E0231565298FD09E719EF258509A4AF1B9EB77DCC82E6D64A26E2F59C60DBE60C49D2ED4CBB536352C975F7F43D1129BA18D7B621B841BB867F60D3BC0321841B2AAF7AE7EC29EBEA4A03E04B915CCE5E1B93FC38416B0D2C5CA640F2BD5B7CE149C429C23B37587780006703EF6C79A933116C07278DC53FFB670F12CA2D973CBC51A5058176152979019074BAD27036A9EC0C4FA7C0FE71A18B8B1F8B56203AEEFD22CE2E8994480EC19FD81EE857E6192300B888B483CEC985A6D667432E2DD1FC2FE578017942E621565872657E40BEB8C788CC7F74ADBA5975C42236D627FE0844
)
GO
/****** Object:  Table [dbo].[animales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animales](
	[cod_animal] [int] IDENTITY(1,1) NOT NULL,
	[peso_inicial] [int] NULL,
	[peso_1] [int] NULL,
	[peso_2] [int] NULL,
	[peso_3] [int] NULL,
	[peso_4] [int] NULL,
	[peso_objetivo] [int] NULL,
	[edad] [int] NULL,
	[raza] [nvarchar](15) NULL,
	[observaciones] [nvarchar](max) NULL,
	[cod_grupo] [int] NULL,
	[precio_compra] [int] NULL,
	[estado] [nvarchar](15) NULL,
 CONSTRAINT [PK_animales] PRIMARY KEY CLUSTERED 
(
	[cod_animal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[cod_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[identidad] [int] NULL,
	[direcion] [nvarchar](50) NULL,
	[telefono] [int] NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[cod_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra_animales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra_animales](
	[cod_compra] [int] IDENTITY(1,1) NOT NULL,
	[cod_cliente] [int] NULL,
	[total] [int] NULL,
	[fecha] [date] NULL,
	[cantidad_animales] [int] NULL,
 CONSTRAINT [PK_compra_animales] PRIMARY KEY CLUSTERED 
(
	[cod_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detall_venta_animal]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detall_venta_animal](
	[cod_detalle_venta] [int] NOT NULL,
	[cod_venta] [int] NULL,
	[cod_animal] [int] NULL,
	[peso_animal] [int] NULL,
 CONSTRAINT [PK_detall_venta_animal] PRIMARY KEY CLUSTERED 
(
	[cod_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_compra_animal]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_compra_animal](
	[cod_compra] [int] NOT NULL,
	[cod_detalle_compra] [int] IDENTITY(1,1) NOT NULL,
	[peso_inicial] [int] NULL,
	[raza] [nvarchar](50) NULL,
	[precio_compra] [int] NULL,
 CONSTRAINT [PK_detalle_compra_animal] PRIMARY KEY CLUSTERED 
(
	[cod_compra] ASC,
	[cod_detalle_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_gastos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_gastos](
	[cod_detalle_gastos] [int] IDENTITY(1,1) NOT NULL,
	[cod_gastos] [int] NOT NULL,
	[cod_ingrediente] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [int] NULL,
	[subtotal] [int] NULL,
 CONSTRAINT [PK_detalle_gastos] PRIMARY KEY CLUSTERED 
(
	[cod_detalle_gastos] ASC,
	[cod_gastos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dieta]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dieta](
	[cod_dieta] [int] IDENTITY(1,1) NOT NULL,
	[cantidad_libras] [int] NULL,
	[comidas_al_dia] [int] NULL,
 CONSTRAINT [PK_dieta] PRIMARY KEY CLUSTERED 
(
	[cod_dieta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dietas_ingredientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dietas_ingredientes](
	[cod_dieta] [int] NOT NULL,
	[cod_ingrediente] [int] NOT NULL,
 CONSTRAINT [PK_dietas_ingredientes] PRIMARY KEY CLUSTERED 
(
	[cod_dieta] ASC,
	[cod_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gastos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gastos](
	[cod_gastos] [int] IDENTITY(1,1) NOT NULL,
	[cod_grupo] [int] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_gastos] PRIMARY KEY CLUSTERED 
(
	[cod_gastos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupos](
	[cod_grupo] [int] NOT NULL,
	[numero_animales] [int] NULL,
	[cod_dieta] [int] NULL,
	[fecha_inicial] [date] NULL,
	[fecha_final] [date] NULL,
	[observaciones] [nvarchar](max) NULL,
 CONSTRAINT [PK_grupos] PRIMARY KEY CLUSTERED 
(
	[cod_grupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingredientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingredientes](
	[cod_ingredientes] [int] IDENTITY(0,1) NOT NULL,
	[descripcion] [nvarchar](25) NULL,
	[costo] [int] NULL,
	[cod_dieta] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[cod_ingredientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[cod_usuario] [int] NOT NULL,
	[usuario] [nvarchar](15) NOT NULL,
	[contrasenia] [nvarchar](255) NOT NULL,
	[tipo_usuario] [nvarchar](20) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[cod_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta_animales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta_animales](
	[cod_venta] [int] IDENTITY(1,1) NOT NULL,
	[cod_cliente] [int] NULL,
	[fecha] [date] NULL,
	[cantidad_libras] [int] NULL,
	[precio_libra] [int] NULL,
	[cod_grupo] [int] NULL,
 CONSTRAINT [PK_venta_animales] PRIMARY KEY CLUSTERED 
(
	[cod_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[animales] ON 

INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2, 360, 0, 0, 0, 0, 0, 2, N'dd', N' ', 26, 2500, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (3, 3000, 0, 0, 0, 0, 0, 1, N'dcs', N' ', 27, 3000, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (4, 250, 0, 0, 0, 500, 0, 2, N'sds', N' ', 27, 3600, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (5, 300, 0, 0, 0, 1000, 0, 1, N'asd', N' ', 28, 2500, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (6, 300, 0, 0, 0, 800, 0, 1, N'sdf', N' ', 29, 500, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (7, 250, 0, 0, 0, 850, 0, 1, N'll', N' ', 29, 798, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (8, 150, 0, 0, 0, 750, 0, 2, N'dd', N' ', 29, 132, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (9, 250, 0, 0, 0, 600, 0, 2, N'Braham', N' ', 30, 4500, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (10, 300, 0, 0, 0, 500, 0, 2, N'Braham', N' ', 30, 5000, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (11, 1200, 0, 0, 0, 1360, 0, 1, N'Brahman', N' ', 31, 20, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (13, 1212, 0, 0, 0, 0, 0, 12, N'Brahman', N' ', 35, 1, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (16, 12, 0, 0, 0, 1050, 0, 12, N'Brahman', N' ', 39, 12, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (17, 1222, 0, 0, 0, 1500, 0, 1, N'Brahman', N' ', 39, 121, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (18, 300, 0, 0, 0, 1200, 0, 2, N'Brahman', N' ', 40, 3500, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (19, 360, 0, 0, 0, 1500, 0, 1, N'Jersey', N' ', 40, 3600, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (20, 250, 0, 0, 0, 1360, 0, 2, N'Holstein', N' ', 40, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (1018, 300, 0, 0, 0, 1500, 0, 1, N'Holstein', N' ', 1040, 3600, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (1019, 350, 0, 0, 0, 1500, 0, 1, N'Brahman', N' ', 1041, 3500, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (1020, 459, 0, 0, 0, 1130, 0, 2, N'Brahman', N' ', 1041, 5000, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (1021, 695, 700, 0, 0, 1200, 0, 1, N'Brahman', N' ', 1041, 3800, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (1024, 350, 456, 545, 800, 0, 1200, 1, N'Holstien', N'', 40, 3600, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (1025, 400, 0, 0, 0, 0, 0, 1, N'Holstien', N'', 40, 4596, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2019, 900, 0, 0, 0, 1260, 0, 2, N'Pardo Suizo', N' ', 2040, 16200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2020, 350, 0, 0, 0, 0, 0, 2, N'Brahman', N' ', 2040, 18000, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2021, 486, 0, 0, 0, 0, 0, 1, N'Brahman', N'', 2040, 0, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2022, 690, 0, 0, 0, 0, 0, 1, N'Holstein', N'', 2040, 2300, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2023, 144, 0, 0, 0, 0, 0, 1, N'Pardo Suizo', N' ', 2040, 3600, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2026, 1800, 0, 0, 0, 0, 0, 1, N'Brahman', N' ', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2029, 1855, 1200, 1300, 1400, 1550, 1500, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2030, 1855, 1200, 1300, 0, 2000, 1500, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2031, 1855, 0, 0, 0, 2000, 1500, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2032, 1855, 0, 0, 0, 2000, 1500, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2033, 1855, 0, 0, 0, 2000, 0, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2035, 1855, 0, 0, 0, 0, 0, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2036, 1855, 0, 0, 0, 0, 0, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2037, 1855, 0, 0, 0, 0, 0, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2038, 1855, 0, 0, 0, 0, 0, 1, N'Brahman', N'Prueba2', 2040, 3200, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2040, 1000, 1500, 1500, 1500, 1500, 2000, 1, N'Brahman', N'prueba3', 2040, 1000, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2042, 1000, 0, 0, 0, 0, 0, 1, N'Holstein', N' ', 2040, 1000, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2043, 1000, 0, 0, 0, 0, 0, 1, N'Holstein', N' ', 2040, 0, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2045, 1250, 0, 0, 0, 0, 0, 1, N'Pardo Suizo', N' ', 2040, 1500, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2046, 1250, 0, 0, 0, 0, 2000, 1, N'Jersey', N' ', 2040, 1500, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2048, 1000, 0, 0, 0, 2000, 0, 1, N'Pardo Suizo', N' ', 2040, 0, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2052, 100, 0, 0, 0, 1000, 0, 1, N'Brahman', N' ', 2041, 1, NULL)
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2053, 100, 0, 0, 0, 1000, 0, 1, N'Brahman', N' ', 2042, 1, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2054, 100, 0, 0, 0, 1000, 0, 2, N'Brahman', N' ', 2043, 10, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2055, 100, 0, 0, 0, 1000, 0, 1, N'Brahman', N' ', 2043, 1212, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2056, 120, 0, 0, 0, 1000, 0, 1, N'Brahman', N' ', 2043, 1212, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2057, 100, 0, 0, 0, 1000, 0, 1, N'Holstein', N' ', 2043, 1212, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2058, 150, 1000, 1500, 2000, 2600, 2500, 1, N'Jersey', N' ', 2044, 1000, N'vendido')
INSERT [dbo].[animales] ([cod_animal], [peso_inicial], [peso_1], [peso_2], [peso_3], [peso_4], [peso_objetivo], [edad], [raza], [observaciones], [cod_grupo], [precio_compra], [estado]) VALUES (2059, 150, 900, 1800, 2400, 2600, 2500, 1, N'Jersey', N' ', 2044, 1000, N'vendido')
SET IDENTITY_INSERT [dbo].[animales] OFF
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([cod_cliente], [nombre], [apellido], [identidad], [direcion], [telefono]) VALUES (1, N'Carlos', NULL, NULL, N'Catacamas', 99999)
INSERT [dbo].[clientes] ([cod_cliente], [nombre], [apellido], [identidad], [direcion], [telefono]) VALUES (2, N'pinguino', NULL, NULL, N'antartica', 23132132)
INSERT [dbo].[clientes] ([cod_cliente], [nombre], [apellido], [identidad], [direcion], [telefono]) VALUES (4, N'kkkk', NULL, NULL, N'jhf', 9876)
INSERT [dbo].[clientes] ([cod_cliente], [nombre], [apellido], [identidad], [direcion], [telefono]) VALUES (7, N'daniel ', N'andrade', 801, N'jhf', 9876)
INSERT [dbo].[clientes] ([cod_cliente], [nombre], [apellido], [identidad], [direcion], [telefono]) VALUES (8, N'Luis', NULL, NULL, N'Barrio X', 99999999)
INSERT [dbo].[clientes] ([cod_cliente], [nombre], [apellido], [identidad], [direcion], [telefono]) VALUES (9, N' oscar ', N'anddrade', 808, N'qwqw', 1212)
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[compra_animales] ON 

INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (24, 2, 1098, CAST(N'2021-07-23' AS Date), 2)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (25, 1, 5500, CAST(N'2021-07-22' AS Date), 2)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (26, 3, 11500, CAST(N'2021-07-21' AS Date), 4)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (27, 1, 6600, CAST(N'2021-07-20' AS Date), 2)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (28, 1, 2500, CAST(N'2021-04-16' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (29, 1, 1430, CAST(N'2021-04-16' AS Date), 3)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (30, 0, 9500, CAST(N'2021-06-12' AS Date), 2)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (31, 1, 20, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (32, 0, 1000, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (33, 0, 12, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (34, 0, 12, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (35, 0, 1, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (36, 1, 1, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (37, 0, 12, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (38, 1, 12, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (39, 1, 121, CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (40, 1, 10300, CAST(N'2021-06-14' AS Date), 3)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (1040, 1, 3600, CAST(N'2021-06-15' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (1041, 1, 12300, CAST(N'2021-06-15' AS Date), 3)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (1042, 1, 8178, CAST(N'2021-06-16' AS Date), 2)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (2040, 1, 34200, CAST(N'2021-06-18' AS Date), 2)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (2041, 1, 1, CAST(N'2021-07-24' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (2042, 1, 1, CAST(N'2021-07-24' AS Date), 1)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (2043, 1, 3646, CAST(N'2021-07-24' AS Date), 4)
INSERT [dbo].[compra_animales] ([cod_compra], [cod_cliente], [total], [fecha], [cantidad_animales]) VALUES (2044, 2, 2000, CAST(N'2021-07-25' AS Date), 2)
SET IDENTITY_INSERT [dbo].[compra_animales] OFF
GO
SET IDENTITY_INSERT [dbo].[detalle_compra_animal] ON 

INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (26, 1, 250, N'kk', 3500)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (26, 2, 360, N'dd', 2500)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (27, 3, 3000, N'dcs', 3000)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (27, 4, 250, N'sds', 3600)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (28, 5, 300, N'asd', 2500)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (29, 6, 300, N'sdf', 500)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (29, 7, 250, N'll', 798)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (29, 8, 150, N'dd', 132)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (30, 9, 250, N'Braham', 4500)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (30, 10, 300, N'Braham', 5000)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (31, 11, 1200, N'Brahman', 20)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (33, 12, 12, N'Brahman', 12)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (35, 13, 1212, N'Brahman', 1)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (36, 14, 133, N'Brahman', 1)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (37, 15, 12, N'Brahman', 12)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (38, 16, 12, N'Brahman', 12)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (39, 17, 1222, N'Brahman', 121)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (40, 18, 300, N'Brahman', 3500)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (40, 19, 360, N'Jersey', 3600)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (40, 20, 250, N'Holstein', 3200)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (1040, 1018, 300, N'Holstein', 3600)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (1041, 1019, 350, N'Brahman', 3500)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (1041, 1020, 459, N'Brahman', 5000)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (1041, 1021, 695, N'Brahman', 3800)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (1042, 1022, 300, N'Brahman', 3600)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (1042, 1023, 368, N'Brahman', 4578)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2040, 2018, 900, N'Pardo Suizo', 16200)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2040, 2019, 1000, N'Brahman', 18000)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2042, 2020, 1, N'Brahman', 1)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2043, 2021, 100, N'Brahman', 10)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2043, 2022, 100, N'Brahman', 1212)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2043, 2023, 120, N'Brahman', 1212)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2043, 2024, 100, N'Holstein', 1212)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2044, 2025, 150, N'Jersey', 1000)
INSERT [dbo].[detalle_compra_animal] ([cod_compra], [cod_detalle_compra], [peso_inicial], [raza], [precio_compra]) VALUES (2044, 2026, 150, N'Jersey', 1000)
SET IDENTITY_INSERT [dbo].[detalle_compra_animal] OFF
GO
SET IDENTITY_INSERT [dbo].[detalle_gastos] ON 

INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (47, 47, 1, 3, 10, 30)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (48, 47, 2, 2, 15, 30)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1047, 47, 2, 3, 15, 45)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1048, 47, 3, 10, 30, 300)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1055, 1048, 1, 3, 10, 30)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1056, 1048, 3, 36, 30, 1080)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1057, 1048, 3, 300, 30, 9000)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1058, 1049, 2, 30, 15, 450)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1059, 1049, 1, 46, 10, 460)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1060, 1049, 3, 30, 30, 900)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1061, 1050, 2, 30, 15, 450)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1062, 1050, 3, 150, 30, 4500)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1063, 1051, 1, 250, 10, 2500)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (1064, 1051, 2, 30, 15, 450)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2056, 2049, 2, 30, 15, 450)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2057, 2050, 3, 50, 30, 1500)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2058, 2050, 2, 26, 15, 390)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2061, 2052, 2, 30, 15, 450)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2063, 2053, 3, 30, 30, 900)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2064, 2055, 3, 30, 30, 900)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2065, 2055, 2, 360, 15, 5400)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2066, 2056, 3, 69, 30, 2070)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2067, 2057, 3, 36, 30, 1080)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2069, 2059, 2, 600, 15, 9000)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2070, 2059, 3, 350, 30, 10500)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2072, 2060, 2, 500, 15, 7500)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2073, 2060, 2, 80, 15, 1200)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (2074, 2060, 3, 57, 30, 1710)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3055, 3048, 1, 1440, 3, 4320)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3056, 3048, 2, 1080, 2, 2160)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3057, 3048, 3, 900, 1, 900)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3058, 3048, 1, 1080, 1, 1080)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3059, 3048, 1, 1080, 1, 1080)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3060, 3048, 1, 2520, 1, 2520)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3061, 3049, 1, 10, 10, 100)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3062, 3049, 2, 10, 15, 150)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3063, 3050, 1, 100, 10, 1000)
INSERT [dbo].[detalle_gastos] ([cod_detalle_gastos], [cod_gastos], [cod_ingrediente], [cantidad], [precio], [subtotal]) VALUES (3064, 3050, 2, 100, 15, 1500)
SET IDENTITY_INSERT [dbo].[detalle_gastos] OFF
GO
SET IDENTITY_INSERT [dbo].[dieta] ON 

INSERT [dbo].[dieta] ([cod_dieta], [cantidad_libras], [comidas_al_dia]) VALUES (1, 25, 3)
INSERT [dbo].[dieta] ([cod_dieta], [cantidad_libras], [comidas_al_dia]) VALUES (2, 26, 2)
INSERT [dbo].[dieta] ([cod_dieta], [cantidad_libras], [comidas_al_dia]) VALUES (3, 30, 3)
SET IDENTITY_INSERT [dbo].[dieta] OFF
GO
INSERT [dbo].[dietas_ingredientes] ([cod_dieta], [cod_ingrediente]) VALUES (1, 1)
INSERT [dbo].[dietas_ingredientes] ([cod_dieta], [cod_ingrediente]) VALUES (1, 2)
INSERT [dbo].[dietas_ingredientes] ([cod_dieta], [cod_ingrediente]) VALUES (2, 1)
INSERT [dbo].[dietas_ingredientes] ([cod_dieta], [cod_ingrediente]) VALUES (2, 3)
INSERT [dbo].[dietas_ingredientes] ([cod_dieta], [cod_ingrediente]) VALUES (3, 1)
INSERT [dbo].[dietas_ingredientes] ([cod_dieta], [cod_ingrediente]) VALUES (3, 2)
INSERT [dbo].[dietas_ingredientes] ([cod_dieta], [cod_ingrediente]) VALUES (3, 3)
GO
SET IDENTITY_INSERT [dbo].[gastos] ON 

INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (47, 29, CAST(N'2021-04-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (1048, 40, CAST(N'2021-06-14' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (1049, 40, CAST(N'2021-06-14' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (1050, 40, CAST(N'2021-06-14' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (1051, 30, CAST(N'2021-06-14' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2048, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2049, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2050, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2051, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2052, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2053, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2054, 35, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2055, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2056, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2057, 1040, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2058, 1041, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2059, 1041, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (2060, 1041, CAST(N'2021-06-15' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (3048, 2040, CAST(N'2021-06-18' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (3049, 2043, CAST(N'2021-07-24' AS Date))
INSERT [dbo].[gastos] ([cod_gastos], [cod_grupo], [fecha]) VALUES (3050, 2044, CAST(N'2021-07-25' AS Date))
SET IDENTITY_INSERT [dbo].[gastos] OFF
GO
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (21, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (22, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (23, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (24, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (25, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (26, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (27, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (28, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (29, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (30, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (31, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (35, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (38, 0, 1, CAST(N'2021-07-24' AS Date), CAST(N'2021-10-24' AS Date), N'pp')
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (39, 2, 1, CAST(N'2021-07-24' AS Date), CAST(N'2021-10-24' AS Date), N'pruebaaa jj')
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (40, 5, 1, CAST(N'2021-07-16' AS Date), CAST(N'2021-10-16' AS Date), N'')
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (1040, 1, 1, CAST(N'2021-07-21' AS Date), CAST(N'2021-10-21' AS Date), N'prueba de obs')
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (1041, 3, 1, CAST(N'2021-07-24' AS Date), CAST(N'2021-10-24' AS Date), N'')
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (2040, 21, 1, CAST(N'2021-06-18' AS Date), CAST(N'2021-08-18' AS Date), N'')
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (2041, 1, 1, CAST(N'2021-07-25' AS Date), CAST(N'2021-10-25' AS Date), N'')
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (2042, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (2043, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[grupos] ([cod_grupo], [numero_animales], [cod_dieta], [fecha_inicial], [fecha_final], [observaciones]) VALUES (2044, 2, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ingredientes] ON 

INSERT [dbo].[ingredientes] ([cod_ingredientes], [descripcion], [costo], [cod_dieta]) VALUES (0, N'Selecione', 0, 1)
INSERT [dbo].[ingredientes] ([cod_ingredientes], [descripcion], [costo], [cod_dieta]) VALUES (1, N'maiz', 10, 1)
INSERT [dbo].[ingredientes] ([cod_ingredientes], [descripcion], [costo], [cod_dieta]) VALUES (2, N'coco', 15, 1)
INSERT [dbo].[ingredientes] ([cod_ingredientes], [descripcion], [costo], [cod_dieta]) VALUES (3, N'heno', 30, 1)
SET IDENTITY_INSERT [dbo].[ingredientes] OFF
GO
INSERT [dbo].[usuarios] ([cod_usuario], [usuario], [contrasenia], [tipo_usuario]) VALUES (1, N'oscar', N'T5hPSaCsKJPdhiTh5Uz5Yg==', N'1')
INSERT [dbo].[usuarios] ([cod_usuario], [usuario], [contrasenia], [tipo_usuario]) VALUES (2, N'daniel', N'T5hPSaCsKJPdhiTh5Uz5Yg==', N'2')
INSERT [dbo].[usuarios] ([cod_usuario], [usuario], [contrasenia], [tipo_usuario]) VALUES (3, N'admin', N'Dm1e75+uc3auYBUIN0hDLQ==', N'1')
INSERT [dbo].[usuarios] ([cod_usuario], [usuario], [contrasenia], [tipo_usuario]) VALUES (4, N'jessy', N'T5hPSaCsKJPdhiTh5Uz5Yg==', N'1')
INSERT [dbo].[usuarios] ([cod_usuario], [usuario], [contrasenia], [tipo_usuario]) VALUES (5, N'eduard', N'T5hPSaCsKJPdhiTh5Uz5Yg==', N'1')
INSERT [dbo].[usuarios] ([cod_usuario], [usuario], [contrasenia], [tipo_usuario]) VALUES (6, N'giselle', N'T5hPSaCsKJPdhiTh5Uz5Yg==', N'1')
GO
SET IDENTITY_INSERT [dbo].[venta_animales] ON 

INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (5, 2, CAST(N'2021-04-16' AS Date), 2400, 6, 29)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (12, 1, CAST(N'2021-06-14' AS Date), 900, 100, 27)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (13, 1, CAST(N'2021-06-14' AS Date), 4060, 20, 40)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (14, 1, CAST(N'2021-06-14' AS Date), 1100, 15, 30)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (1013, 1, CAST(N'2021-06-15' AS Date), 1500, 36, 1040)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (1014, 1, CAST(N'2021-06-16' AS Date), 2000, 13, 1042)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (2013, 1, CAST(N'2021-06-18' AS Date), 2620, 20, 2040)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (2014, 1, CAST(N'2021-07-24' AS Date), 4000, 100, 2043)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (2015, 1, CAST(N'2021-07-24' AS Date), 1000, 2000, 2042)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (2016, 2, CAST(N'2021-07-25' AS Date), 14310, 150, 2040)
INSERT [dbo].[venta_animales] ([cod_venta], [cod_cliente], [fecha], [cantidad_libras], [precio_libra], [cod_grupo]) VALUES (2017, 2, CAST(N'2021-07-25' AS Date), 5200, 150, 2044)
SET IDENTITY_INSERT [dbo].[venta_animales] OFF
GO
/****** Object:  Index [IX_detalle_gastos]    Script Date: 26/7/2021 09:00:58 ******/
CREATE NONCLUSTERED INDEX [IX_detalle_gastos] ON [dbo].[detalle_gastos]
(
	[cod_detalle_gastos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[animales] ADD  CONSTRAINT [DF_animales_peso_1]  DEFAULT ((0)) FOR [peso_1]
GO
ALTER TABLE [dbo].[animales] ADD  CONSTRAINT [DF_animales_peso_2]  DEFAULT ((0)) FOR [peso_2]
GO
ALTER TABLE [dbo].[animales] ADD  CONSTRAINT [DF_animales_peso_3]  DEFAULT ((0)) FOR [peso_3]
GO
ALTER TABLE [dbo].[animales] ADD  CONSTRAINT [DF_animales_peso_4]  DEFAULT ((0)) FOR [peso_4]
GO
ALTER TABLE [dbo].[animales] ADD  CONSTRAINT [DF_animales_peso_objetivo]  DEFAULT ((0)) FOR [peso_objetivo]
GO
ALTER TABLE [dbo].[animales] ADD  CONSTRAINT [DF_animales_observaciones]  DEFAULT (' ') FOR [observaciones]
GO
ALTER TABLE [dbo].[animales]  WITH CHECK ADD  CONSTRAINT [FK_animales_compra_animales] FOREIGN KEY([cod_grupo])
REFERENCES [dbo].[compra_animales] ([cod_compra])
GO
ALTER TABLE [dbo].[animales] CHECK CONSTRAINT [FK_animales_compra_animales]
GO
ALTER TABLE [dbo].[animales]  WITH CHECK ADD  CONSTRAINT [FK_animales_grupos] FOREIGN KEY([cod_grupo])
REFERENCES [dbo].[grupos] ([cod_grupo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[animales] CHECK CONSTRAINT [FK_animales_grupos]
GO
ALTER TABLE [dbo].[detall_venta_animal]  WITH CHECK ADD  CONSTRAINT [FK_detall_venta_animal_animales] FOREIGN KEY([cod_animal])
REFERENCES [dbo].[animales] ([cod_animal])
GO
ALTER TABLE [dbo].[detall_venta_animal] CHECK CONSTRAINT [FK_detall_venta_animal_animales]
GO
ALTER TABLE [dbo].[detall_venta_animal]  WITH CHECK ADD  CONSTRAINT [FK_detall_venta_animal_venta_animales] FOREIGN KEY([cod_venta])
REFERENCES [dbo].[venta_animales] ([cod_venta])
GO
ALTER TABLE [dbo].[detall_venta_animal] CHECK CONSTRAINT [FK_detall_venta_animal_venta_animales]
GO
ALTER TABLE [dbo].[detalle_compra_animal]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_animal_compra_animales] FOREIGN KEY([cod_compra])
REFERENCES [dbo].[compra_animales] ([cod_compra])
GO
ALTER TABLE [dbo].[detalle_compra_animal] CHECK CONSTRAINT [FK_detalle_compra_animal_compra_animales]
GO
ALTER TABLE [dbo].[detalle_gastos]  WITH CHECK ADD  CONSTRAINT [FK_detalle_gastos_gastos] FOREIGN KEY([cod_gastos])
REFERENCES [dbo].[gastos] ([cod_gastos])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_gastos] CHECK CONSTRAINT [FK_detalle_gastos_gastos]
GO
ALTER TABLE [dbo].[detalle_gastos]  WITH CHECK ADD  CONSTRAINT [FK_detalle_gastos_ingredientes] FOREIGN KEY([cod_ingrediente])
REFERENCES [dbo].[ingredientes] ([cod_ingredientes])
GO
ALTER TABLE [dbo].[detalle_gastos] CHECK CONSTRAINT [FK_detalle_gastos_ingredientes]
GO
ALTER TABLE [dbo].[dietas_ingredientes]  WITH CHECK ADD  CONSTRAINT [FK_dietas_ingredientes_dieta] FOREIGN KEY([cod_dieta])
REFERENCES [dbo].[dieta] ([cod_dieta])
GO
ALTER TABLE [dbo].[dietas_ingredientes] CHECK CONSTRAINT [FK_dietas_ingredientes_dieta]
GO
ALTER TABLE [dbo].[dietas_ingredientes]  WITH CHECK ADD  CONSTRAINT [FK_dietas_ingredientes_ingredientes] FOREIGN KEY([cod_ingrediente])
REFERENCES [dbo].[ingredientes] ([cod_ingredientes])
GO
ALTER TABLE [dbo].[dietas_ingredientes] CHECK CONSTRAINT [FK_dietas_ingredientes_ingredientes]
GO
ALTER TABLE [dbo].[gastos]  WITH CHECK ADD  CONSTRAINT [FK_gastos_grupos] FOREIGN KEY([cod_grupo])
REFERENCES [dbo].[grupos] ([cod_grupo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[gastos] CHECK CONSTRAINT [FK_gastos_grupos]
GO
ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [FK_grupos_dieta] FOREIGN KEY([cod_dieta])
REFERENCES [dbo].[dieta] ([cod_dieta])
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [FK_grupos_dieta]
GO
ALTER TABLE [dbo].[venta_animales]  WITH CHECK ADD  CONSTRAINT [FK_venta_animales_clientes] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[clientes] ([cod_cliente])
GO
ALTER TABLE [dbo].[venta_animales] CHECK CONSTRAINT [FK_venta_animales_clientes]
GO
/****** Object:  StoredProcedure [dbo].[ActualizacionAnimalesVendidos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 15 de julio del 2021
-- Description:	Actualizacion de estado de los animales de acuerdo al grupo
-- =============================================
CREATE PROCEDURE [dbo].[ActualizacionAnimalesVendidos] 
	-- Add the parameters for the stored procedure here
	@estado nvarchar(15),
	@cod_grupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update animales 
		set estado=@estado 
		where cod_grupo = @cod_grupo 
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarAnimales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActualizarAnimales]
	@cod_animal int,
	@pesoinicial int,
	@raza nvarchar(15),
	@codgrupo int,
	@preciocompra int,
	@edad int,
	@pesoobjetivo int,
	@peso1 int,
	@peso2 int,
	@peso3 int,
	@peso4 int,
	@obs nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update animales
		set peso_inicial=@pesoinicial,
		raza=@raza,
		cod_grupo=@codgrupo,
		precio_compra=@preciocompra,
		edad=@edad,
		peso_objetivo= @pesoobjetivo,
		peso_1=@peso1,
		peso_2=@peso2,
		peso_3=@peso3,
		peso_4=@peso4,
		observaciones=@obs
	where cod_animal=@cod_animal
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCantidadAnimales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCantidadAnimales]
	@cod_grupo int
	--@numero_actualizado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update grupos
		set numero_animales=(select COUNT(cod_animal) from animales where cod_grupo=@cod_grupo)
	where cod_grupo=@cod_grupo
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarClientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarClientes] 
	@cod_cliente int,
	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@identidad varchar(50),
	@direccion nvarchar(50),
	@telefono varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update clientes 
		set nombre = @nombre,
		apellido = @apellido,
		identidad = @identidad,
		@direccion= @direccion,
		telefono= @telefono
	where cod_cliente= @cod_cliente

    
END


/****** Object:  StoredProcedure [dbo].[EliminarClientes]    Script Date: 25/7/2021 00:03:34 ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 12/julio/21
-- Description:	Actualiza el numero de animales del grupo
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarGrupos] 
	@num_animales int,
	@cod_grupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update grupos set numero_animales=@num_animales where cod_grupo= @cod_grupo
	END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGruposFormGrupos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActualizarGruposFormGrupos]
	@cod_grupo int,
	@fechaini DATE,
	@fechafin DATE,
	@cod_dieta int,
	@obs nvarchar(MAX)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update grupos
		set fecha_inicial=@fechaini,
		fecha_final=@fechafin,
		cod_dieta = @cod_dieta,
		observaciones =@obs

	where cod_grupo=@cod_grupo
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarUsuarios]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 20 de julio de 2021
-- Description:	Actualizar los usuarios de la BD
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarUsuarios] 
	-- Add the parameters for the stored procedure here
	@cod_usuario int,
	@usuario nvarchar(15),
	@contrasenia nvarchar(255),
	@tipousuario nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update usuarios 
		set usuario = @usuario,
		contrasenia= @contrasenia,
		tipo_usuario = @tipousuario 
	where cod_usuario= @cod_usuario
END
GO
/****** Object:  StoredProcedure [dbo].[CalcularPesoTotalAnimales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 12/julio/21
-- Description:	Peso Total de Animales listo para venta
-- =============================================
CREATE PROCEDURE [dbo].[CalcularPesoTotalAnimales]
	@grupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select 
		sum(peso_4) 
	From animales 
	where cod_grupo = @grupo
END
GO
/****** Object:  StoredProcedure [dbo].[CargarDietaXCodigo]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CargarDietaXCodigo] 
	@coddieta as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dieta where cod_dieta=@coddieta 
END
GO
/****** Object:  StoredProcedure [dbo].[CargarGastos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CargarGastos] 
	-- Add the parameters for the stored procedure here
	@grupo as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cod_detalle_gastos 'Detalle Gastos',
	b.cod_gastos 'Codigo Gastos',
	cod_ingrediente 'Codigo Ingredientes',
	cantidad Cantidad,precio Precio ,
	subtotal  Subtotal 
	FROM detalle_gastos 
	a join  gastos b on a.cod_gastos = b.cod_gastos 
	where cod_grupo= @grupo
END
GO
/****** Object:  StoredProcedure [dbo].[CargarGastoTotal]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CargarGastoTotal]
	@grupo as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select sum(subtotal) 
	from detalle_gastos a join  gastos b on a.cod_gastos = b.cod_gastos 
	where cod_grupo=@grupo
END
GO
/****** Object:  StoredProcedure [dbo].[CargarGrupos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CargarGrupos] 
	-- Add the parameters for the stored procedure here
	@grupo as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cod_animal 'Codigo Animal',
	peso_4 'Peso Final',
	precio_compra 'Precio de Compra' 
	FROM animales 
	WHERE cod_grupo= @grupo
END
GO
/****** Object:  StoredProcedure [dbo].[CargarVentasBalance]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CargarVentasBalance] 
	@grupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cod_cliente AS 'Codigo Cliente',
	fecha Fecha,cantidad_libras AS 'Cantidad en libras',
	precio_libra AS 'Precio por libra',
	cod_grupo AS 'Codigo de grupo'
	FROM venta_animales 
	WHERE cod_grupo = @grupo
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarClientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarClientes]
	@codcliente int
	
AS
BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete from clientes where cod_cliente = @codcliente

    
END


/****** Object:  StoredProcedure [dbo].[insertarClientes]    Script Date: 25/7/2021 00:04:01 ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[EliminarDieta]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarDieta]  
	@coddieta as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM dieta where cod_dieta=@coddieta
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuarios]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 20 de julio del 2021
-- Description:	Eliminar usuarios de la BD
-- =============================================
CREATE PROCEDURE [dbo].[EliminarUsuarios] 
	-- Add the parameters for the stored procedure here
	@codusuario int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from usuarios where cod_usuario = @codusuario 
END
GO
/****** Object:  StoredProcedure [dbo].[HistoricoCompra_General]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Oscar Andrade
-- Create date: 20 de julio del 2021
-- Description:	Historico de Compra de Animales
-- =============================================
CREATE PROCEDURE [dbo].[HistoricoCompra_General]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  
	CA.fecha as 'Fecha',
	CA.cod_compra as 'Grupo',
	C.nombre as 'Cliente',
	DCA.raza as 'Raza',
	SUM(DCA.peso_inicial) as 'Peso Inicial',
	SUM(DCA.precio_compra) as 'Total Precio'

FROM compra_animales CA
INNER JOIN clientes C ON CA.cod_cliente = C.cod_cliente
INNER JOIN detalle_compra_animal DCA ON CA.cod_compra = DCA.cod_compra
GROUP BY CA.fecha,CA.cod_compra,C.nombre,DCA.raza
ORDER BY CA.fecha DESC
END

GO
/****** Object:  StoredProcedure [dbo].[HistoricoCompraFiltradoCliente]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Oscar Andrade
-- Create date: 20 de julio del 2021
-- Description:	Historico de Compra de Animales Filtrado x Cliente
-- =============================================

CREATE PROCEDURE [dbo].[HistoricoCompraFiltradoCliente] 
	@cliente nvarchar(30),
	@fechainicial date,
	@fechafinal date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  
	CA.fecha as 'Fecha',
	CA.cod_compra as 'Grupo',
	C.nombre as 'Cliente',
	DCA.raza as 'Raza',
	SUM(DCA.peso_inicial) as 'Peso Inicial',
	SUM(DCA.precio_compra) as 'Total Precio'

FROM compra_animales CA
INNER JOIN clientes C ON CA.cod_cliente = C.cod_cliente
INNER JOIN detalle_compra_animal DCA ON CA.cod_compra = DCA.cod_compra
WHERE C.nombre like '%'+@cliente+'%' AND (CA.fecha between @fechainicial and @fechafinal) 
GROUP BY CA.fecha,CA.cod_compra,C.nombre,DCA.raza
ORDER BY CA.fecha DESC
END
GO
/****** Object:  StoredProcedure [dbo].[HistoricoCompraFiltradoRaza]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Oscar Andrade
-- Create date: 21 de julio del 2021
-- Description:	Historico de Compra de Animales Filtrado x Raza
-- =============================================
CREATE PROCEDURE [dbo].[HistoricoCompraFiltradoRaza]
	@raza nvarchar(30),
	@fechainicial date,
	@fechafinal date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  
	CA.fecha as 'Fecha',
	CA.cod_compra as 'Grupo',
	C.nombre as 'Cliente',
	DCA.raza as 'Raza',
	SUM(DCA.peso_inicial) as 'Peso Inicial',
	SUM(DCA.precio_compra) as 'Total Precio'

FROM compra_animales CA
INNER JOIN clientes C ON CA.cod_cliente = C.cod_cliente
INNER JOIN detalle_compra_animal DCA ON CA.cod_compra = DCA.cod_compra
WHERE DCA.raza like '%'+@raza+'%' AND (CA.fecha between @fechainicial and @fechafinal)
GROUP BY CA.fecha,CA.cod_compra,C.nombre,DCA.raza
ORDER BY CA.fecha DESC
END
GO
/****** Object:  StoredProcedure [dbo].[HistoricoCompraxGrupo]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 20 de julio del 2021
-- Description:	Historico de Compra por Grupo en específico
-- =============================================
CREATE PROCEDURE [dbo].[HistoricoCompraxGrupo]
	-- Add the parameters for the stored procedure here
	@grupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  
	CA.fecha as 'Fecha',
	CA.cod_compra as 'Grupo',
	C.nombre as 'Cliente',
	SUM(DCA.peso_inicial) as 'Peso Inicial',
	SUM(DCA.precio_compra) as 'Total Precio'

FROM compra_animales CA
INNER JOIN clientes C ON CA.cod_cliente = C.cod_cliente
INNER JOIN detalle_compra_animal DCA ON CA.cod_compra = DCA.cod_compra
WHERE CA.cod_compra = @grupo
GROUP BY CA.fecha,CA.cod_compra,C.nombre
END

/****** Object:  StoredProcedure [dbo].[HistoricoVentas_FiltradoCliente]    Script Date: 23/7/2021 22:32:05 ******/
DROP PROCEDURE [dbo].[HistoricoVentas_FiltradoCliente]
GO
/****** Object:  StoredProcedure [dbo].[HistoricoVentas_FiltradoCliente]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Oscar Andrade
-- Create date: 21 de julio del 2021
-- Description:	Historico de Ventas de Animales Filtrado por Cliente
-- =============================================
CREATE PROCEDURE [dbo].[HistoricoVentas_FiltradoCliente]
@cliente nvarchar(30),
@fechainicial date,
@fechafinal date

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT
	VA.fecha as 'Fecha',
	C.nombre as 'Cliente',
	VA.cod_grupo as 'Grupo',
	VA.cantidad_libras as 'Total Lbs',
	VA.precio_libra as 'Precio x Lb',
	VA.cantidad_libras * Va.precio_libra AS 'Total'
	

FROM animales A
INNER JOIN venta_animales VA ON a.cod_grupo = VA.cod_grupo
Inner JOIN clientes C ON VA.cod_cliente = C.cod_cliente
WHERE a.estado is not null and C.nombre like '%'+@cliente+'%' AND (VA.fecha between @fechainicial and @fechafinal)
ORDER BY VA.fecha DESC
END
GO
/****** Object:  StoredProcedure [dbo].[HistoricoVentas_FiltradoPesoMayor]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 21 de julio del 2021
-- Description:	Historico de Ventas de Animales Filtrado por Peso Mayor
-- =============================================
CREATE PROCEDURE [dbo].[HistoricoVentas_FiltradoPesoMayor]
@peso int,
@fechainicial date,
@fechafinal date


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT
	VA.fecha as 'Fecha',
	C.nombre as 'Cliente',
	VA.cod_grupo as 'Grupo',
	VA.cantidad_libras 'Total Lbs',
	VA.precio_libra as 'Precio x Lb',
	VA.cantidad_libras * Va.precio_libra AS 'Total'
	

FROM animales A
INNER JOIN venta_animales VA ON a.cod_grupo = VA.cod_grupo
Inner JOIN clientes C ON VA.cod_cliente = C.cod_cliente
WHERE A.estado is not null AND 
	(VA.fecha between @fechainicial and @fechafinal) AND
	VA.cantidad_libras >= @peso
ORDER BY VA.fecha DESC
END
GO
/****** Object:  StoredProcedure [dbo].[HistoricoVentas_FiltradoPesoMenor]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 21 de julio del 2021
-- Description:	Historico de Ventas de Animales Filtrado por Peso Menor
-- =============================================
CREATE PROCEDURE [dbo].[HistoricoVentas_FiltradoPesoMenor]
@peso int,
@fechainicial date,
@fechafinal date

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT
	VA.fecha as 'Fecha',
	C.nombre as 'Cliente',
	VA.cod_grupo as 'Grupo',
	VA.cantidad_libras 'Total Lbs',
	VA.precio_libra as 'Precio x Lb',
	VA.cantidad_libras * Va.precio_libra AS 'Total'
	

FROM animales A
INNER JOIN venta_animales VA ON a.cod_grupo = VA.cod_grupo
Inner JOIN clientes C ON VA.cod_cliente = C.cod_cliente
WHERE 
	a.estado is not null AND 
	(VA.fecha between @fechainicial and @fechafinal) AND 
	VA.cantidad_libras <= @peso  
ORDER BY VA.fecha DESC
END
GO
/****** Object:  StoredProcedure [dbo].[HistoricoVentasxGrupo]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 21 de julio del 2021
-- Description:	Historico de Venta de Animales filtrado por Grupo
-- =============================================
CREATE PROCEDURE [dbo].[HistoricoVentasxGrupo]
	@codgrupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT
	
	C.nombre as 'Cliente',
	VA.cod_grupo as 'Grupo',
	VA.cantidad_libras as 'Total Lbs',
	VA.cantidad_libras * Va.precio_libra AS 'Total'
	
FROM animales A
INNER JOIN venta_animales VA ON a.cod_grupo = VA.cod_grupo
Inner JOIN clientes C ON VA.cod_cliente = C.cod_cliente
WHERE a.estado is not null and VA.cod_grupo = @codgrupo
END
GO
/****** Object:  StoredProcedure [dbo].[HistorioVentas_General]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 21 de julio del 2021
-- Description:	Historico de Ventas de Animales
-- =============================================
CREATE PROCEDURE [dbo].[HistorioVentas_General]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT
	VA.fecha as 'Fecha',
	C.nombre as 'Cliente',
	VA.cod_grupo as 'Grupo',
	VA.cantidad_libras as 'Total Lbs',
	VA.precio_libra as 'Precio x Lb',
	VA.cantidad_libras * Va.precio_libra AS 'Total'
	

FROM animales A
INNER JOIN venta_animales VA ON a.cod_grupo = VA.cod_grupo
Inner JOIN clientes C ON VA.cod_cliente = C.cod_cliente
WHERE a.estado is not null
END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Usuarios]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 20 de julio del 2021
-- Description:	Ingresar nuevos usuarios al sistema
-- =============================================
CREATE PROCEDURE [dbo].[Insertar_Usuarios]
	-- Add the parameters for the stored procedure here
	@cod_usuario int,
	@usuario nvarchar(15),
	@contrasenia nvarchar(255),
	@tipousuario nvarchar(20)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into usuarios(cod_usuario,usuario,contrasenia,tipo_usuario) 
	values(@cod_usuario,@usuario,@contrasenia,@tipousuario)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarAnimales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 12/julio/21
-- Description:	Ingreso de Animales Comprados
-- =============================================
CREATE PROCEDURE [dbo].[InsertarAnimales] 
	@pesoinicial int,
	@raza varchar(15),
	@codgrupo int,
	@preciocompra int,
	@edad int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into animales(peso_inicial,raza,cod_grupo,precio_compra,edad) 
	values(@pesoinicial,@raza,@codgrupo,@preciocompra,@edad)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarAnimalesFormCabezas]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertarAnimalesFormCabezas]
	@pesoinicial int,
	@raza nvarchar(15),
	@codgrupo int,
	@preciocompra int,
	@edad int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into animales(peso_inicial,raza,cod_grupo,precio_compra,edad) 
	values(@pesoinicial,@raza,@codgrupo,@preciocompra,@edad)
END
GO
/****** Object:  StoredProcedure [dbo].[insertarClientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertarClientes]

	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@identidad varchar(50),
	@direccion nvarchar(50),
	@telefono varchar(50)
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into clientes(nombre,apellido, identidad,direcion, telefono) 
	values(@nombre,@apellido,@identidad,@direccion,@telefono)
END


/****** Object:  StoredProcedure [dbo].[insertarIngredientes]    Script Date: 25/7/2021 00:04:23 ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[InsertarCompraAnimales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 13/julio/21
-- Description:	Ingreso de Animales Comprados
-- =============================================
CREATE PROCEDURE [dbo].[InsertarCompraAnimales]
	@cod_cliente int,
	@total int,
	@fecha date,
	@cantidad_animales int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into compra_animales(cod_cliente,total,fecha,cantidad_animales)values(@cod_cliente,@total,@fecha,@cantidad_animales)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetalleCompraAnimales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 13/julio/21
-- Description:	Ingresa el detalle de los animales comprados
-- =============================================
CREATE PROCEDURE [dbo].[InsertarDetalleCompraAnimales] 
	-- Add the parameters for the stored procedure here
	@codCompra int,
	@pesoinicial int,
	@raza nvarchar(50),
	@preciocompra int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into detalle_compra_animal(cod_detalle_compra,peso_inicial,raza,precio_compra) 
	values(@codCompra,@pesoinicial,@raza,@preciocompra)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetalleGastoxGrupo]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 15 de julio del 2021
-- Description:	Insertar el detalle de gasto  x Grupo
-- =============================================
CREATE PROCEDURE [dbo].[InsertarDetalleGastoxGrupo]
	-- Add the parameters for the stored procedure here
	@cod_gastos int,
	@cod_ingrediente int,
	@cantidad int,
	@precio int,
	@subtotal int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into 
		detalle_gastos(cod_gastos,cod_ingrediente,cantidad,precio, subtotal) 
		values(@cod_gastos,@cod_ingrediente,@cantidad,@precio, @subtotal)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarGastosxGrupo]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 15 de julio del 2021
-- Description:	Insertar los gastos x grupo
-- =============================================
CREATE PROCEDURE [dbo].[InsertarGastosxGrupo]
	-- Add the parameters for the stored procedure here
	@cod_grupo int,
	@fecha date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into gastos(cod_grupo,fecha)values(@cod_grupo,@fecha)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarGrupos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 13/julio/21
-- Description:	Ingresa los nuevos grupos comprados
-- =============================================
CREATE PROCEDURE [dbo].[InsertarGrupos] 
	@numGrupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into grupos(cod_grupo) values(@numGrupo)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarIngredientesDietas]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertarIngredientesDietas]
	@coddieta as int,
	@cod_ingrediente int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into dietas_ingredientes VALUES
		(@coddieta,@cod_ingrediente)

END
GO
/****** Object:  StoredProcedure [dbo].[InsertarVentaAnimales]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Oscar Andrade>
-- Create date: <15 de julio del 2021>
-- Description:	<Procedimiento para el registro de la venta de animales>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarVentaAnimales] 
	@cod_cliente int,
	@fecha date,
	@cantidad_libras int,
	@precio_libra int,
	@cod_grupo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into 
		venta_animales(cod_cliente,fecha,cantidad_libras,precio_libra,cod_grupo)
		values(@cod_cliente,@fecha,@cantidad_libras,@precio_libra,@cod_grupo)
END
GO
/****** Object:  StoredProcedure [dbo].[LecturaUsuarios_BD]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date:	20 de julio del 2021
-- Description:	Lectura de los Usuarios en BD
-- =============================================
CREATE PROCEDURE [dbo].[LecturaUsuarios_BD] 
	-- Add the parameters for the stored procedure here
	@nombre nvarchar(15)
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		usuario AS 'Usuario',
		contrasenia AS 'Password',
		tipo_usuario as 'Nivel'
	FROM usuarios
	WHERE usuario = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[Lista_Usuarios]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 20 de julio del 2021
-- Description:	Lista de todos los usuarios en la BD
-- =============================================
CREATE PROCEDURE [dbo].[Lista_Usuarios]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select 
		cod_usuario as 'Codigo',
		usuario as 'Usuario',
		contrasenia as 'Password',
		tipo_usuario as 'Nivel'
	From usuarios
END
GO
/****** Object:  StoredProcedure [dbo].[ListaClientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListaClientes]


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Select 
		cod_cliente as 'Código',
		nombre as 'Nombre',
		apellido as 'Apellido',
		identidad as 'Identidad',
		direcion as 'dirección',
		telefono as 'Teléfono'

	From clientes
   
END
GO
/****** Object:  StoredProcedure [dbo].[ListaDietas]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListaDietas]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cod_dieta 'Código Dieta',
	cantidad_libras 'Cantidad en libras',
	comidas_al_dia 'Comidas al día' 
	FROM dieta 
END
GO
/****** Object:  StoredProcedure [dbo].[ListaIngredientes]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 16/julio/21
-- Description:	Listar todos los ingredientes	
-- =============================================
CREATE PROCEDURE [dbo].[ListaIngredientes]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select  * from ingredientes 
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarAnimales_DistintosGrupos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 13/julio/21
-- Description:	Muestra los grupos de animales listos
-- =============================================
CREATE PROCEDURE [dbo].[MostrarAnimales_DistintosGrupos]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select 
		DISTINCT cod_grupo As 'Grupos', 
		raza AS 'Raza' 
		from animales 
		where estado is null and peso_4 != 0
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarAnimales_GrupoListos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 13/julio/21
-- Description:	Muestra los animales listo para la venta
-- =============================================
CREATE PROCEDURE [dbo].[MostrarAnimales_GrupoListos]

@grupo as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
		cod_grupo AS 'Grupo', 
		cod_animal AS 'Codigo Animal', 
		peso_4 AS 'Peso Final' 
	from animales 
	where cod_grupo = @grupo
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarGrupos_NoVendidos]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Oscar Andrade
-- Create date: 16/julio/21
-- Description:	Mostrar los grupo que no se han vendido aun
-- =============================================
CREATE PROCEDURE [dbo].[MostrarGrupos_NoVendidos] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT distinct cod_grupo AS 'Grupo' FROM animales where estado is null 
END
GO
/****** Object:  StoredProcedure [dbo].[TotalCostoCompra]    Script Date: 26/7/2021 09:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TotalCostoCompra]
	-- Add the parameters for the stored procedure here
	@grupo as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT sum(precio_compra) from animales where cod_grupo=@grupo
END
GO
USE [master]
GO
ALTER DATABASE [base_proyecto] SET  READ_WRITE 
GO
