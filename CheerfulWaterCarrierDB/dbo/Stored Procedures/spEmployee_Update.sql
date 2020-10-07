CREATE PROCEDURE [dbo].[spEmployee_Update]
    @EmployeeId int,
	@FirstName nvarchar(50),
	@MiddleName nvarchar(50),
	@LastName nvarchar(50),
    @BirthDate datetime2,
    @Sex bit,
    @SubdivisionId int
AS
begin
    set nocount on;

    update dbo.Employee 
    set 
        [FirstName] = @FirstName,
        [MiddleName] = @MiddleName,
        [LastName] = @LastName, 
        [BirthDate] = @BirthDate,
        [Sex] = @Sex,
        [SubdivisionId] = @SubdivisionId
    where
        [EmployeeId] = @EmployeeId;
end