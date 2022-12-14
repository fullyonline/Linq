USE [JuveTest]
GO
SET IDENTITY_INSERT [dbo].[Abteilung] ON 

INSERT [dbo].[Abteilung] ([AbteilungID], [Name]) VALUES (1, N'Software')
INSERT [dbo].[Abteilung] ([AbteilungID], [Name]) VALUES (2, N'Produktion')
INSERT [dbo].[Abteilung] ([AbteilungID], [Name]) VALUES (3, N'Engineering')
INSERT [dbo].[Abteilung] ([AbteilungID], [Name]) VALUES (24, N'Mechanik')
SET IDENTITY_INSERT [dbo].[Abteilung] OFF
SET IDENTITY_INSERT [dbo].[Projekte] ON 

INSERT [dbo].[Projekte] ([ProjekteID], [ProjektName]) VALUES (1, N'Mars')
INSERT [dbo].[Projekte] ([ProjekteID], [ProjektName]) VALUES (2, N'Jupiter')
INSERT [dbo].[Projekte] ([ProjekteID], [ProjektName]) VALUES (3, N'Erde')
INSERT [dbo].[Projekte] ([ProjekteID], [ProjektName]) VALUES (7, N'Merkur')
SET IDENTITY_INSERT [dbo].[Projekte] OFF
SET IDENTITY_INSERT [dbo].[Mitarbeiter] ON 

INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (1, N'Wolf', N'Kurt', N'Mitarbeiter', 3, 24)
INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (5, N'Hans ', N'Muster', N'Abteilungsleiter', 2, 3)
INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (10, N'Kohler', N'Reto', N'Mitarbeiter', 1, 24)
INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (11, N'Walter', N'Marcel', N'Abteilungsleiter', 7, 1)
INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (12, N'Konrad', N'Thomas', N'Mitarbeiter', 3, 3)
INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (13, N'Krausel', N'Jörg', N'Mitarbeiter', 3, 1)
INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (14, N'Zürcher', N'Sandro', N'Mitarbeiter', 1, 1)
INSERT [dbo].[Mitarbeiter] ([MitarbeiterID], [Name], [Vorname], [Position], [ProjektID], [AbteilungID]) VALUES (15, N'Kramer', N'Uwe', N'Mitarbeiter', 1, 2)
SET IDENTITY_INSERT [dbo].[Mitarbeiter] OFF
