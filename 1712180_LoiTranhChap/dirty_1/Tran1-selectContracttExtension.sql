--Transaction 1
-- Procedure Xem thông tin gia hạn hợp đồng
Create Procedure selectContracttExtension
						@Contract_Extension_ID varchar(10)
as
begin
	select * from ContractExtension where Contract_Extension_ID = @Contract_Extension_ID;
end

