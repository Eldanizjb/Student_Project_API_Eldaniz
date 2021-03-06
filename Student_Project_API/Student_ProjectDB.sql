USE [StudentApiDB]
GO
SET IDENTITY_INSERT [dbo].[Specialties] ON 

INSERT [dbo].[Specialties] ([Id], [Name]) VALUES (1, N'History')
INSERT [dbo].[Specialties] ([Id], [Name]) VALUES (2, N'Mathematics')
INSERT [dbo].[Specialties] ([Id], [Name]) VALUES (3, N'Physics')
INSERT [dbo].[Specialties] ([Id], [Name]) VALUES (4, N'Chemistry')
SET IDENTITY_INSERT [dbo].[Specialties] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [Class], [CreatedDate], [specialtyId]) VALUES (1, N'Samir', N'Abbasov', 21, 2, CAST(N'2021-12-15T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [Class], [CreatedDate], [specialtyId]) VALUES (2, N'Arif', N'Atayev', 22, 2, CAST(N'2021-12-15T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [Class], [CreatedDate], [specialtyId]) VALUES (3, N'Habil', N'Eliyev', 21, 2, CAST(N'2021-12-15T00:00:00.0000000' AS DateTime2), 3)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [Class], [CreatedDate], [specialtyId]) VALUES (4, N'Hamid', N'Babayev', 21, 3, CAST(N'2021-12-15T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
