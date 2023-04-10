CREATE TABLE [dbo].[Employee_Shop]
(
	[IdEmployee] INT NOT NULL, 
    [IdShop] INT NOT NULL, 
    [Date] DATE NOT NULL, 
    [IsSupervisor] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_Employee_Shop] PRIMARY KEY ([IdEmployee], [Date], [IdShop]), 
    CONSTRAINT [FK_Employee_Shop_ToEmployee] FOREIGN KEY ([IdEmployee]) REFERENCES [Employee]([Id]), 
	CONSTRAINT [FK_Employee_Shop_ToShop] FOREIGN KEY ([IdShop]) REFERENCES [Shop]([Id]),
	CONSTRAINT [UQ_EmployeeDate] UNIQUE ([IdEmployee],[Date])    
)

