CREATE PROCEDURE [dbo].[spSubdivision_Update]
	@SubdivisionId int,
	@SupervisorId int
AS
begin
    set nocount on;

    update dbo.Subdivision
    set
        [SupervisorId] = @SupervisorId
    where
        [SubdivisionId] = @SubdivisionId;
end