IF NOT EXISTS (SELECT TOP 1 * FROM Employee)
BEGIN
    SET IDENTITY_INSERT [dbo].[Employee] ON
   
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (1, N'GUSTAVO ROJAS ARIAS', 3, N'74407680', N'', CAST(N'2017-04-30' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (2, N'PRISCILLA BERROCAL SOLIS', 4, N'28188277', N'', CAST(N'2017-04-23' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (3, N'AARON CASTRO VARGAS', 1, N'41459511', N'', CAST(N'2017-04-19' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (4, N'SOLON MANUEL CHAVARRIA BOLA�OS', 1, N'60203070', N'', CAST(N'2017-04-14' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (5, N'CARLOS LUIS ESPINOZA CHAVES', 5, N'85568021', N'', CAST(N'2017-04-13' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (6, N'ALEXANDER ARRIETA CARRILLO', 1, N'63287405', N'', CAST(N'2017-04-11' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (7, N'OSVALDO VEGA QUESADA', 4, N'29722449', N'', CAST(N'2017-03-28' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (8, N'IORELLA VERONICA JARA HERNANDEZ', 3, N'28522756', N'', CAST(N'2017-03-25' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (9, N'MAX ALBERTO RODRIGUEZ NARANJO', 1, N'23692531', N'', CAST(N'2017-03-21' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (10, N'JOSE ANDRES GAITAN ROJAS', 3, N'21438631', N'', CAST(N'2017-03-07' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (11, N'JUAN GABRIEL VALVERDE JIMENEZ', 1, N'66362643', N'', CAST(N'2017-03-06' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (12, N'LUIS MANUEL PEREZ ALVARADO', 1, N'55979380', N'', CAST(N'2017-03-03' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (13, N'HERNAN ALBERTO CASTRO PANIAGUA', 1, N'69656712', N'', CAST(N'2017-03-02' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (14, N'ALEJANDRA DANIELA VARGAS VARGAS', 1, N'91006454', N'', CAST(N'2017-02-21' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (15, N'MARCO VINICIO HIDALGO MENDEZ', 1, N'87398468', N'', CAST(N'2017-02-13' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (16, N'DANNY ALEXANDER GOMEZ JUAREZ', 5, N'72455790', N'', CAST(N'2017-02-07' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (17, N'ANGEL GARCIA LUNA', 3, N'81324388', N'', CAST(N'2017-02-05' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (18, N'MARLON GERARDO MENA SALAZAR', 1, N'79059135', N'', CAST(N'2017-02-01' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (19, N'JESUS ALFONSO QUESADA CASTILLO', 3, N'26544802', N'', CAST(N'2017-01-30' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (20, N'JONATHAN GERARDO CORDERO ZU�IGA', 1, N'69946399', N'', CAST(N'2017-01-14' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (21, N'STEVF DOUGLAS FLORES CHAVEZ', 1, N'53265703', N'', CAST(N'2017-01-10' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (22, N'EDAR STEPHEN VILLARREAL GONZALEZ', 5, N'64424600', N'', CAST(N'2017-01-08' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (23, N'MAURICIO CARVAJAL NU�EZ', 3, N'92541269', N'', CAST(N'2016-12-30' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (24, N'IVANNIA VEGA SALGADO', 5, N'32385225', N'', CAST(N'2016-12-28' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (25, N'JACKELINE QUESADA ALVAREZ', 3, N'72208144', N'', CAST(N'2016-12-15' AS Date))    
    INSERT [dbo].[Employee] ([Id], [Name], [IdType], [Telephone], [Address], [EmploymentDate]) VALUES (26, N'GEISEL IVETH RUIZ MARTINEZ', 1, N'83939994', N'', CAST(N'2016-12-14' AS Date))
    
    SET IDENTITY_INSERT [dbo].[Employee] OFF
END