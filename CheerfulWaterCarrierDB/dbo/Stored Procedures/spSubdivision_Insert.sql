CREATE PROCEDURE [dbo].[spSubdivision_Insert]
	@SubdivisionId int,
	@SupervisorId int
AS
begin
    set nocount on;

    insert into dbo.Subdivision([SupervisorId])
    values (@SupervisorId);
end
