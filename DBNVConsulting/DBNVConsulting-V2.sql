USE MASTER
GO
create database DBNVConsulting
GO
use DBNVConsulting
go

/****** Object:  Table [dbo].[ALUMNO_CURSOS]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNO_CURSOS](
	[ID_ALUMNO_CURSOS] [int] IDENTITY(1,1) NOT NULL,
	[ID_CURSOS] [int] NULL,
	[ID_ALUMNO] [int] NULL,
 CONSTRAINT [PK_ALUMNO_CURSOS] PRIMARY KEY CLUSTERED 
(
	[ID_ALUMNO_CURSOS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ALUMNOS]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNOS](
	[ID_ALUMNO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRES] [varchar](50) NULL,
	[APELLIDOS] [varchar](50) NULL,
	[DNI] [char](8) NULL,
	[CORREO] [varchar](50) NULL,
	[TELEFONO] [char](9) NULL,
	[DIRECCION] [varchar](50) NULL,
 CONSTRAINT [PK_ALUMNOS] PRIMARY KEY CLUSTERED 
(
	[ID_ALUMNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CARGO]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARGO](
	[ID_CARGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
 CONSTRAINT [PK_CARGO] PRIMARY KEY CLUSTERED 
(
	[ID_CARGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CURSOS]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CURSOS](
	[ID_CURSOS] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](500) NULL,
	[NRO_HORAS] [int] NULL,
	[FECHA_INICIO] [datetime] NULL,
	[FECHA_FIN] [datetime] NULL,
	[PRECIO_CURSO] [decimal](10, 2) NULL,
	[ID_EMPLEADOS] [int] NULL,
 CONSTRAINT [PK_CURSOS] PRIMARY KEY CLUSTERED 
(
	[ID_CURSOS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[ID_EMPLEADOS] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRES] [varchar](50) NULL,
	[APELLIDOS] [varchar](50) NULL,
	[DNI] [char](8) NULL,
	[CORREO] [varchar](50) NULL,
	[TELEFONO] [char](9) NULL,
	[DIRECCION] [varchar](50) NULL,
	[ID_CARGO] [int] NULL,
 CONSTRAINT [PK_EMPLEADOS] PRIMARY KEY CLUSTERED 
(
	[ID_EMPLEADOS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAGO]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGO](
	[ID_PAGO] [int] IDENTITY(1,1) NOT NULL,
	[FORMA_PAGO] [varchar](50) NULL,
	[ENTIDAD_FINANCIERA] [varchar](50) NULL,
	[FECHA_HORA] [datetime] NULL,
	[ESTADO] [varchar](50) NULL,
	[OBSERVACION] [varchar](50) NULL,
	[ID_CURSOS] [int] NULL,
	[ID_ALUMNO] [int] NULL,
 CONSTRAINT [PK_PAGO] PRIMARY KEY CLUSTERED 
(
	[ID_PAGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[ID_ROL] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[ESTADO] [varchar](50) NULL,
	[ID_USUARIOS] [int] NULL,
 CONSTRAINT [PK_ROL] PRIMARY KEY CLUSTERED 
(
	[ID_ROL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 15/12/2021 03:46:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[ID_USUARIOS] [int] IDENTITY(1,1) NOT NULL,
	[OBSERVACION] [varchar](50) NULL,
	[ID_EMPLEADOS] [int] NULL,
	[ID_ALUMNO] [int] NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIOS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CURSOS] ON 
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (25, N'ASEGURAMIENTO DE CALIDAD DE RESULTADOS DE ENSAYO SEG�N LA NORMA ISOIEC ', 150, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'2022-04-20T00:00:00.000' AS DateTime), CAST(350.00 AS Decimal(10, 2)), NULL)
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (26, N'CONTROL Y MONITOREO DE VARIABLES POR GR�FICOS DE CONTROL UNIVARIADOS', 150, CAST(N'2022-02-10T00:00:00.000' AS DateTime), CAST(N'2022-04-21T00:00:00.000' AS DateTime), CAST(350.00 AS Decimal(10, 2)), NULL)
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (27, N'DETERMINACI�N DE L�MITES DE DETECCI�N Y CUANTIFICACI�N DE M�TODOS DE ENSAYO F�SICO QU�MICO', 100, CAST(N'2022-02-10T00:00:00.000' AS DateTime), CAST(N'2022-04-22T00:00:00.000' AS DateTime), CAST(280.00 AS Decimal(10, 2)), NULL)
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (28, N'GESTI�N DE LA CALIDAD POR INDICADORES EN UN LABORATORIO DE ENSAYO', 230, CAST(N'2022-02-12T00:00:00.000' AS DateTime), CAST(N'2022-04-28T00:00:00.000' AS DateTime), CAST(320.00 AS Decimal(10, 2)), NULL)
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (29, N'GESTI�N DE LA MEJORA CONTINUA', 150, CAST(N'2022-02-25T00:00:00.000' AS DateTime), CAST(N'2022-04-24T00:00:00.000' AS DateTime), CAST(300.00 AS Decimal(10, 2)), NULL)
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (30, N'GESTI�N DE RIESGO EN LABORATORIO DE ENSAYO', 120, CAST(N'2022-02-23T00:00:00.000' AS DateTime), CAST(N'2022-04-28T00:00:00.000' AS DateTime), CAST(300.00 AS Decimal(10, 2)), NULL)
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (31, N'MEDICI�N DE LA SATISFACCI�N DEL CLIENTE', 180, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'2022-04-26T00:00:00.000' AS DateTime), CAST(250.00 AS Decimal(10, 2)), NULL)
GO
INSERT [dbo].[CURSOS] ([ID_CURSOS], [NOMBRE], [NRO_HORAS], [FECHA_INICIO], [FECHA_FIN], [PRECIO_CURSO], [ID_EMPLEADOS]) VALUES (32, N'VALIDACI�N DE M�TODOS DE ENSAYO CUALITATIVOS', 170, CAST(N'2022-02-25T00:00:00.000' AS DateTime), CAST(N'2022-02-27T00:00:00.000' AS DateTime), CAST(250.00 AS Decimal(10, 2)), NULL)
GO
SET IDENTITY_INSERT [dbo].[CURSOS] OFF
GO
ALTER TABLE [dbo].[ALUMNO_CURSOS]  WITH CHECK ADD  CONSTRAINT [FK_ALUMNO_CURSOS_ALUMNO] FOREIGN KEY([ID_ALUMNO])
REFERENCES [dbo].[ALUMNOS] ([ID_ALUMNO])
GO
ALTER TABLE [dbo].[ALUMNO_CURSOS] CHECK CONSTRAINT [FK_ALUMNO_CURSOS_ALUMNO]
GO
ALTER TABLE [dbo].[ALUMNO_CURSOS]  WITH CHECK ADD  CONSTRAINT [FK_ALUMNO_CURSOS_CURSO] FOREIGN KEY([ID_CURSOS])
REFERENCES [dbo].[CURSOS] ([ID_CURSOS])
GO
ALTER TABLE [dbo].[ALUMNO_CURSOS] CHECK CONSTRAINT [FK_ALUMNO_CURSOS_CURSO]
GO
ALTER TABLE [dbo].[CURSOS]  WITH CHECK ADD  CONSTRAINT [FK_CURSOS_EMPLEADOS] FOREIGN KEY([ID_EMPLEADOS])
REFERENCES [dbo].[EMPLEADOS] ([ID_EMPLEADOS])
GO
ALTER TABLE [dbo].[CURSOS] CHECK CONSTRAINT [FK_CURSOS_EMPLEADOS]
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADOS_CARGO] FOREIGN KEY([ID_CARGO])
REFERENCES [dbo].[CARGO] ([ID_CARGO])
GO
ALTER TABLE [dbo].[EMPLEADOS] CHECK CONSTRAINT [FK_EMPLEADOS_CARGO]
GO
ALTER TABLE [dbo].[PAGO]  WITH CHECK ADD  CONSTRAINT [FK_PAGO_ALUMNO] FOREIGN KEY([ID_ALUMNO])
REFERENCES [dbo].[ALUMNOS] ([ID_ALUMNO])
GO
ALTER TABLE [dbo].[PAGO] CHECK CONSTRAINT [FK_PAGO_ALUMNO]
GO
ALTER TABLE [dbo].[PAGO]  WITH CHECK ADD  CONSTRAINT [FK_PAGO_CURSOS] FOREIGN KEY([ID_CURSOS])
REFERENCES [dbo].[CURSOS] ([ID_CURSOS])
GO
ALTER TABLE [dbo].[PAGO] CHECK CONSTRAINT [FK_PAGO_CURSOS]
GO
ALTER TABLE [dbo].[ROL]  WITH CHECK ADD  CONSTRAINT [FK_ROL_USUARIOS] FOREIGN KEY([ID_USUARIOS])
REFERENCES [dbo].[USUARIOS] ([ID_USUARIOS])
GO
ALTER TABLE [dbo].[ROL] CHECK CONSTRAINT [FK_ROL_USUARIOS]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_ALUMNO] FOREIGN KEY([ID_ALUMNO])
REFERENCES [dbo].[ALUMNOS] ([ID_ALUMNO])
GO
ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [FK_USUARIOS_ALUMNO]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_EMPLEADOS] FOREIGN KEY([ID_EMPLEADOS])
REFERENCES [dbo].[EMPLEADOS] ([ID_EMPLEADOS])
GO
ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [FK_USUARIOS_EMPLEADOS]
GO
