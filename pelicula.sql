USE [video_club]
GO

/****** Object:  Table [dbo].[pelicula]    Script Date: 05/08/2018 18:48:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[pelicula](
	[pelicula_id] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](40) NOT NULL,
	[genero] [varchar](15) NOT NULL,
	[año] [char](4) NOT NULL,
	[director] [varchar](20) NOT NULL,
	[formato] [char](3) NOT NULL,
	[precio_alquiler] [int] NOT NULL,
 CONSTRAINT [identidad_pelicula] PRIMARY KEY CLUSTERED 
(
	[pelicula_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[pelicula]  WITH CHECK ADD CHECK  (([formato]='HD' OR [formato]='TDI' OR [formato]='BRY' OR [formato]='DVD' OR [formato]='VHS'))
GO

ALTER TABLE [dbo].[pelicula] ADD  DEFAULT ('DVD') FOR [formato]
GO

ALTER TABLE [dbo].[pelicula] ADD  CONSTRAINT [DF_pelicula_precio_alquiler]  DEFAULT ((5000)) FOR [precio_alquiler]
GO

