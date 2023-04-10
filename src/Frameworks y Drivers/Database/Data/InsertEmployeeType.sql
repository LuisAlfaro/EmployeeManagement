IF NOT EXISTS (SELECT TOP 1 * FROM EmployeeType)
BEGIN
    SET IDENTITY_INSERT [dbo].[EmployeeType] ON 
    INSERT [dbo].[EmployeeType] ([Id], [Name], [Salary]) VALUES (1, N'Vendedor', CAST(235000.00 AS Decimal(18, 2)))
    INSERT [dbo].[EmployeeType] ([Id], [Name], [Salary]) VALUES (2, N'Vendedor 2', CAST(245000.00 AS Decimal(18, 2)))
    INSERT [dbo].[EmployeeType] ([Id], [Name], [Salary]) VALUES (3, N'Vendedor 3', CAST(255000.00 AS Decimal(18, 2)))
    INSERT [dbo].[EmployeeType] ([Id], [Name], [Salary]) VALUES (4, N'Administrador', CAST(300000.00 AS Decimal(18, 2)))
    INSERT [dbo].[EmployeeType] ([Id], [Name], [Salary]) VALUES (5, N'Bodeguero', CAST(235000.00 AS Decimal(18, 2)))
    SET IDENTITY_INSERT [dbo].[EmployeeType] OFF
END