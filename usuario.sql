USE [video_club]
GO

/****** Object:  Table [dbo].[usuario]    Script Date: 05/08/2018 18:48:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[usuario](
	[usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[denominacion] [char](14) NOT NULL,
	[clave] [varchar](8) NOT NULL,
	[nombre] [char](20) NOT NULL,
	[apellido] [char](30) NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [identidad_usuario] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((1)) FOR [activo]
GO

