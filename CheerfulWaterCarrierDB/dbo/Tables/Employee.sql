CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [BirthDate] DATETIME2 NULL, 
    [Sex] BIT NULL, 
    [SubdivisionId] INT NULL
	CONSTRAINT [FK_Employee_ToSubdivision] FOREIGN KEY (SubdivisionId) REFERENCES [Subdivision](SubdivisionId)
)
