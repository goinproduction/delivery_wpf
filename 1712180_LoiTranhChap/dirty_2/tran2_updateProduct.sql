--Transaction 2
-- Procedure Cập nhật thông tin gia hạn hợp đồng
Create procedure updateProduct
	@Product_ID varchar(10),
	@Branch_ID varchar(10),
	@Name_Product nvarchar(50),
	@Price_Product money
as
begin
	update Product 
	set Name_Product = @Name_Product, Price_Product = @Price_Product
	where Product_ID = @Product_ID and Branch_ID = @Branch_ID
end