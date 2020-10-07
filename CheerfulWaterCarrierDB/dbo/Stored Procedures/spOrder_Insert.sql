CREATE PROCEDURE [dbo].[spOrder_Insert]
    @OrderId int,
	@ProductName nvarchar(50),
	@EmployeeId int
AS
begin
    set nocount on;

    insert into dbo.[Order] ([ProductName], [EmployeeId])
    values (@ProductName, @EmployeeId);
end
