--Transaction 2
-- Procedure Cập nhật thông tin gia hạn hợp đồng
Create procedure updateContracttExtension
	@Contract_Extension_ID int,
	@Employee_ID varchar(10),
	@New_Expiry_Date datetime,
	@Price_Extension money
as
begin
	update ContractExtension 
	set Employee_ID = @Employee_ID, New_Expiry_Date = @New_Expiry_Date, Price_Extension = @Price_Extension
	where Contract_Extension_ID = @Contract_Extension_ID
end