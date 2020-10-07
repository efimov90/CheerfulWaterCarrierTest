CREATE PROCEDURE [dbo].[spOrder_Update]
	@OrderId int,
	@ProductName nvarchar(50),
    @EmployeeId int
AS
begin
    set nocount on;

    update dbo.[Order] 
    set 
        [ProductName] = @ProductName,
        [EmployeeId] = @EmployeeId
    where
        [OrderId] = @OrderId;
end
