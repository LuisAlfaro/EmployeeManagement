CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[IdType] [int] NOT NULL,
	[Telephone] [varchar](50) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[EmploymentDate] [date] NOT NULL,
	CONSTRAINT [PK_Employee] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Employee_EmployeeType] FOREIGN KEY ([IdType]) REFERENCES [EmployeeType]([Id]), 
)
