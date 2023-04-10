CREATE TABLE [dbo].[EmployeeType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Salary] [decimal](18, 2) NOT NULL,
	CONSTRAINT [PK_EmployeeType] PRIMARY KEY ([Id])
) 