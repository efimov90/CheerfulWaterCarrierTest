CREATE PROCEDURE [dbo].[spEmployee_Insert]
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

    insert into dbo.Employee ([FirstName], [MiddleName], [LastName], [BirthDate], [Sex], [SubdivisionId])
    values (@FirstName, @MiddleName, @LastName, @BirthDate, @Sex, @SubdivisionId);
end