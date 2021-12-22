--Transaction 1
-- Procedure Xem thông tin gia hạn hợp đồng
Create Procedure selectProduct
						@Product_ID varchar(10)
as
begin
	select * from Product where Product_ID = @Product_ID;
end
