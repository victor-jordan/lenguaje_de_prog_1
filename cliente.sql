USE [video_club]
GO

/****** Object:  Table [dbo].[cliente]    Script Date: 05/08/2018 18:48:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[cliente](
	[cliente_id] [int] IDENTITY(1,1) NOT NULL,
	[documento] [char](15) NOT NULL,
	[nombre] [char](20) NOT NULL,
	[apellido] [char](30) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[direccion] [varchar](70) NOT NULL,
	[telefono] [varchar](14) NOT NULL,
	[celular] [varchar](12) NOT NULL,
	[genero] [char](1) NOT NULL,
	[estado] [char](10) NOT NULL,
 CONSTRAINT [identidad_cliente] PRIMARY KEY CLUSTERED 
(
	[cliente_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [identidad_civil] UNIQUE NONCLUSTERED 
(
	[documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[cliente]  WITH CHECK ADD CHECK  (([estado]='Suspendido' OR [estado]='Moroso' OR [estado]='Inactivo' OR [estado]='Activo'))
GO

ALTER TABLE [dbo].[cliente]  WITH CHECK ADD CHECK  (([genero]='F' OR [genero]='M'))
GO

ALTER TABLE [dbo].[cliente] ADD  DEFAULT ('F') FOR [genero]
GO

ALTER TABLE [dbo].[cliente] ADD  DEFAULT ('Activo') FOR [estado]
GO

