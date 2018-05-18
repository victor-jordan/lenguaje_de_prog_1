USE [video_club]
GO

/****** Object:  Table [dbo].[alquiler]    Script Date: 05/08/2018 18:48:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[alquiler](
	[alquiler_id] [int] IDENTITY(1,1) NOT NULL,
	[pelicula_id] [int] NOT NULL,
	[cliente_id] [int] NOT NULL,
	[fecha_alquiler] [date] NOT NULL,
	[fecha_devolucion] [date] NULL,
	[situacion] [char](8) NOT NULL,
	[creado_por] [int] NOT NULL,
	[modificado_por] [int] NOT NULL,
 CONSTRAINT [identidad_alquiler] PRIMARY KEY CLUSTERED 
(
	[alquiler_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[alquiler]  WITH CHECK ADD  CONSTRAINT [cliente_que_alquila] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[cliente] ([cliente_id])
GO

ALTER TABLE [dbo].[alquiler] CHECK CONSTRAINT [cliente_que_alquila]
GO

ALTER TABLE [dbo].[alquiler]  WITH CHECK ADD  CONSTRAINT [pelicula_alquilada] FOREIGN KEY([pelicula_id])
REFERENCES [dbo].[pelicula] ([pelicula_id])
GO

ALTER TABLE [dbo].[alquiler] CHECK CONSTRAINT [pelicula_alquilada]
GO

ALTER TABLE [dbo].[alquiler]  WITH CHECK ADD  CONSTRAINT [usuario_crea] FOREIGN KEY([creado_por])
REFERENCES [dbo].[usuario] ([usuario_id])
GO

ALTER TABLE [dbo].[alquiler] CHECK CONSTRAINT [usuario_crea]
GO

ALTER TABLE [dbo].[alquiler]  WITH CHECK ADD  CONSTRAINT [usuario_modifica] FOREIGN KEY([modificado_por])
REFERENCES [dbo].[usuario] ([usuario_id])
GO

ALTER TABLE [dbo].[alquiler] CHECK CONSTRAINT [usuario_modifica]
GO

ALTER TABLE [dbo].[alquiler]  WITH CHECK ADD CHECK  (([situacion]='Mora' OR [situacion]='Prorroga' OR [situacion]='Vigente'))
GO

ALTER TABLE [dbo].[alquiler] ADD  DEFAULT (getdate()) FOR [fecha_alquiler]
GO

ALTER TABLE [dbo].[alquiler] ADD  DEFAULT ('Vigente') FOR [situacion]
GO

