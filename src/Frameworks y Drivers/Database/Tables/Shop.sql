CREATE TABLE [dbo].[Shop](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Telephone] [varchar](50) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	CONSTRAINT [PK_Shop] PRIMARY KEY ([Id])
)