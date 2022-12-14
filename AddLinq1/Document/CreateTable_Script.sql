USE [JuveTest]
GO
/****** Object:  Table [dbo].[Abteilung]    Script Date: 30.06.2017 13:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Abteilung](
	[AbteilungID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Abteilung] PRIMARY KEY CLUSTERED 
(
	[AbteilungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 30.06.2017 13:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mitarbeiter](
	[MitarbeiterID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Vorname] [varchar](50) NULL,
	[Position] [varchar](50) NULL,
	[ProjektID] [int] NOT NULL,
	[AbteilungID] [int] NOT NULL,
 CONSTRAINT [PK_Mitarbeiter] PRIMARY KEY CLUSTERED 
(
	[MitarbeiterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Projekte]    Script Date: 30.06.2017 13:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Projekte](
	[ProjekteID] [int] IDENTITY(1,1) NOT NULL,
	[ProjektName] [varchar](100) NULL,
 CONSTRAINT [PK_Projekte] PRIMARY KEY CLUSTERED 
(
	[ProjekteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Mitarbeiter]  WITH CHECK ADD  CONSTRAINT [FK_Mitarbeiter_Abteilung] FOREIGN KEY([AbteilungID])
REFERENCES [dbo].[Abteilung] ([AbteilungID])
GO
ALTER TABLE [dbo].[Mitarbeiter] CHECK CONSTRAINT [FK_Mitarbeiter_Abteilung]
GO
ALTER TABLE [dbo].[Mitarbeiter]  WITH CHECK ADD  CONSTRAINT [FK_Mitarbeiter_Projekte] FOREIGN KEY([ProjektID])
REFERENCES [dbo].[Projekte] ([ProjekteID])
GO
ALTER TABLE [dbo].[Mitarbeiter] CHECK CONSTRAINT [FK_Mitarbeiter_Projekte]
GO
