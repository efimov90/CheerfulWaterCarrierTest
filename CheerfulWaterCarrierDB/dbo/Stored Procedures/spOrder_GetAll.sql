CREATE PROCEDURE [dbo].[spOrder_GetAll]
AS
begin
	set nocount on;

	select [OrderId], [ProductName], [EmployeeId]
	from dbo.[Order];
end