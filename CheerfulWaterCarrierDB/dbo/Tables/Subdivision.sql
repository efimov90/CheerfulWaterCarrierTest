CREATE TABLE [dbo].[Subdivision]
(
	[SubdivisionId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SupervisorId] INT NULL
	CONSTRAINT [FK_Subdivision_ToEmployee] FOREIGN KEY (SupervisorId) REFERENCES [Employee](EmployeeId)
)
