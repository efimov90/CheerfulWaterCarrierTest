CREATE PROCEDURE [dbo].[spSubdivision_GetAll]
AS
begin
	set nocount on;

	select [SubdivisionId], [SupervisorId]
	from dbo.Subdivision;
end