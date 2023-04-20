CREATE TABLE [dbo].[EmployeeShop]
(
    [Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEmployee] INT NOT NULL, 
    [IdShop] INT NOT NULL, 
    [Date] DATE NOT NULL, 
    [IsSupervisor] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_EmployeeShop] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_EmployeeShop_ToEmployee] FOREIGN KEY ([IdEmployee]) REFERENCES [Employee]([Id]), 
	CONSTRAINT [FK_EmployeeShop_ToShop] FOREIGN KEY ([IdShop]) REFERENCES [Shop]([Id]),
    CONSTRAINT [UQ_EmployeeDate] UNIQUE ([IdEmployee], [Date], [IdShop]),
    CONSTRAINT [UQ_EmployeeShopDate] UNIQUE ([IdEmployee],[Date]),	
)

