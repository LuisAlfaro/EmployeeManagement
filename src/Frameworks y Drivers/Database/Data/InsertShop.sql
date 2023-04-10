IF NOT EXISTS (SELECT TOP 1 * FROM Shop)
BEGIN
    SET IDENTITY_INSERT [dbo].[Shop] ON
    INSERT [dbo].[Shop] ([Id], [Telephone], [Name], [Address]) VALUES (1, N'29405483', N'Local 15', N'Mall San Pedro')
    INSERT [dbo].[Shop] ([Id], [Telephone], [Name], [Address]) VALUES (2, N'29903654', N'Local 35', N'Plaza Rofas')
    INSERT [dbo].[Shop] ([Id], [Telephone], [Name], [Address]) VALUES (3, N'25542339', N'Local 22', N'Multiplaza Escazu')
    INSERT [dbo].[Shop] ([Id], [Telephone], [Name], [Address]) VALUES (4, N'24627855', N'Local 66', N'Paseo de las Flores')
    INSERT [dbo].[Shop] ([Id], [Telephone], [Name], [Address]) VALUES (5, N'23904232', N'Local 99', N'Lincoln Plaza')
    SET IDENTITY_INSERT [dbo].[Shop] OFF
END