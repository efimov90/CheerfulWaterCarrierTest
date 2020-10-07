CREATE TABLE [dbo].[Order]
(
	[OrderId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(50) NULL, 
    [EmployeeId] INT NULL
	CONSTRAINT [FK_Order_ToEmployee] FOREIGN KEY (EmployeeId) REFERENCES [Employee](EmployeeId)
)
