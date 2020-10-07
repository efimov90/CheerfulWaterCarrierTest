CREATE PROCEDURE [dbo].[spEmployee_GetAll]
AS
begin
	set nocount on;

	select [EmployeeId], [FirstName], [MiddleName], [LastName], [BirthDate], [Sex], [SubdivisionId]
	from dbo.Employee;
end