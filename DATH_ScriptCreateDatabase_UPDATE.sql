use [master]
go
if DB_ID('HQTCSDL') is not null
	drop database HQTCSDL
go
CREATE DATABASE HQTCSDL
go
use HQTCSDL
go

CREATE TABLE AccountType
(
Account_Type INT,
Account_Type_Name NVARCHAR(20),
PRIMARY KEY (Account_Type)
)
--insert AccountType
insert into AccountType values ('1',N'Quản Trị')
insert into AccountType values ('2',N'Tài Xế')
insert into AccountType values ('3',N'Khách Hàng')
insert into AccountType values ('4',N'Nhân Viên')
insert into AccountType values ('5',N'Đối Tác')

CREATE TABLE Account
(
Account_Name VARCHAR(20),
Account_Password VARCHAR(20),
Account_Type INT
PRIMARY KEY (Account_Name),
CONSTRAINT AC_AT FOREIGN KEY (Account_Type) REFERENCES AccountType(Account_Type),
)
--insert Account
insert into Account values ('ST123','1234','1')
insert into Account values ('TX1','1234','2')
insert into Account values ('KH1','1234','3')
insert into Account values ('NV1','1234','4')
insert into Account values ('DT1','1234','5')
--Bang khach hang--
insert into Account values ('nvanh@gmail.com','1234','3')
insert into Account values ('nqbao@gmail.com','1234','3')
insert into Account values ('tvthao@gmail.com','1234','3')
insert into Account values ('nnmy@gmail.com','1234','3')
insert into Account values ('nuvanh@gmail.com','1234','3')

CREATE TABLE Customer
(
Customer_ID VARCHAR(10),
Name_Cus NVARCHAR(50),
Phone_Number_Cus VARCHAR(15),
Adr_Cus NVARCHAR(100),
Email_Cus NVARCHAR(50),
Account_Name VARCHAR(20),
PRIMARY KEY (Customer_ID),
CONSTRAINT CS_AC FOREIGN KEY (Account_Name) REFERENCES Account(Account_Name)
)
---insert Customer
insert into Customer values ('Cus0001', N'Nguyễn Văn Anh','0357971972',N'25/3 Lạc Long Quân, Q10 TPHCM','nvanh@gmail.com','nvanh@gmail.com')
insert into Customer values ('Cus0002', N'Nguyễn Quốc Bảo','0357971973',N'25/4 Lý Thường Kiệt, Q10 TPHCM','nqbao@gmail.com','nqbao@gmail.com')
insert into Customer values ('Cus0003', N'Trần Văn Thảo','0357971974',N'239 Khuông Việt, Tân Phú TPHCM','tvthao@gmail.com','tvthao@gmail.com')
insert into Customer values ('Cus0004', N'Nguyễn Ngọc My','0357971945',N'245 Âu Cơ, Q11 TPHCM','nnmy@gmail.com','nnmy@gmail.com')
insert into Customer values ('Cus0005', N'Lê Mai Trâm','0357971972',N'25/3 Lạc Long Quân, Q10 TPHCM','nuvanh@gmail.com','nuvanh@gmail.com')

--Bang tai xe--
CREATE TABLE Driver
(
Driver_ID VARCHAR(10),
Name_Driver NVARCHAR(50),
Phone_number_Driver VARCHAR(15),
Adr_Driver NVARCHAR(100),
Email_Driver NVARCHAR(50),
License_Plates CHAR(12),	--so cua giay phep lai xe dai 12 ki tu--
Active_Area NVARCHAR(50),
Bank_Account_Driver VARCHAR(14), --so tai khoan ngân hang dai tu 10 den 14 ki tu--
Identity_Code_Driver VARCHAR(12), --so cmnd co 9 so, so can cuoc co 12 so, nen chọn kieu du lieu la varchar(12)--
Active_Fee MONEY, --Phí kích hoạt tài khoản của lái xe--
Account_Name VARCHAR(20),
PRIMARY KEY (Driver_ID),
CONSTRAINT DV_AC FOREIGN KEY (Account_Name) REFERENCES Account(Account_Name)
)
---insert DRIVER
insert into Account values ('hqviet@gmail.com','1234','2')
insert into Account values ('hqnguyen@gmail.com','1234','2')
insert into Account values ('lvdat@gmail.com','1234','2')
insert into Account values ('cttien@gmail.com','1234','2')
insert into Account values ('tqhoa@gmail.com','1234','2')

insert into Driver values ('Dri0001', N'Hoàng Quốc Việt','0357971854',N'25/8 Lạc Long Quân, Q10 TPHCM','hqviet@gmail.com','XE1234567890',N'Quận 10','BANK12345670','CMND123450',500000,'hqviet@gmail.com')
insert into Driver values ('Dri0002', N'Hoàng Quốc Nguyên','0357971855',N'14 Lý Thường Kiệt, Q10 TPHCM','hqnguyen@gmail.com','XE1234567891',N'Quận 10','BANK12345671','CMND123451',500000,'hqnguyen@gmail.com')
insert into Driver values ('Dri0003', N'Lê Văn Đạt','0357971856',N'18 Âu Cơ, Tân Phú TPHCM','lvdat@gmail.com','XE1234567893',N'Quận Tân Phú','BANK12345672','CMND123452',500000,'lvdat@gmail.com')
insert into Driver values ('Dri0004', N'Cao Thanh Tiến','0357971857',N'45/5 Đường số 8 Thủ Đức TPHCM','cttien@gmail.com','XE1234567894',N'Quận Thủ Đức','BANK12345673','CMND123453',500000,'cttien@gmail.com')
insert into Driver values ('Dri0005', N'Trần Quốc Hoa','0357971858',N'2 Phan Văn Trị Bình Thạnh TPHCM','tqhoa@gmail.com','XE1234567895',N'Quận Bình Thạnh','BANK12345674','CMND123454',500000,'tqhoa@gmail.com')--Bang nguoi dai dien--



--nguoi dai dien
CREATE TABLE Representative
(
Repre_ID VARCHAR(10),
Name_Repre NVARCHAR(50),
Phone_Number_Repre VARCHAR(15),
Adr_Repre NVARCHAR(100),
Email_Repre NVARCHAR(50),
PRIMARY KEY (Repre_ID)
)
---insert Representative
insert into Representative values ('Repre0001',N'Cao Tiến Đạt','0354123451',N'71 Tôn Đức Thắng Q1 TPHCM','ctdat@gmail.com')
insert into Representative values ('Repre0002',N'Trịnh Linh Nhi','0354123452',N'71 Cao Thắng Q3 TPHCM','tlnhi@gmail.com')
insert into Representative values ('Repre0003',N'Hoàng Thùy Trang','0354123453',N'78 Tôn Đản Q4 TPHCM','httrang@gmail.com')
insert into Representative values ('Repre0004',N'Trần Thanh Huyền','0354123454',N'25 Tôn Đức Thắng Q1 TPHCM','tthuyen@gmail.com')
insert into Representative values ('Repre0005',N'Nguyễn Tiến Công','0354123455',N'71 Hòa Bình Q11 TPHCM','ntcong@gmail.com')
--Bang doi tac--
CREATE TABLE PPartner
(
Partner_ID VARCHAR(10),
Repre_ID VARCHAR(10),
Name_Partner NVARCHAR(50),
City_Partner NVARCHAR(30),		--thanh pho cua doi tac--
District_Partner NVARCHAR(30),		--quan cua doi tac--
Number_Of_Branch SMALLINT,		--so luong chi nhanh cua doi tac--
Product_Shipping_Type NVARCHAR(30),	--loai san pham van chuyen cua doi tac--
Adr_Business_Partner NVARCHAR(100),	--dia chi kinh doanh cua doi tac (co the hieu đây là địa chỉ cơ quan đầu não của đối tác đó--
Phone_Number_Partner VARCHAR(15),
Email_Partner NVARCHAR(50),
Sale_Partner MONEY,			--tong doanh thu cua doi tac--
Account_Name VARCHAR(20),
PRIMARY KEY (Partner_ID),
CONSTRAINT PN_RP FOREIGN KEY (Repre_ID) REFERENCES Representative(Repre_ID),
CONSTRAINT PN_AC FOREIGN KEY (Account_Name) REFERENCES Account(Account_Name)
)
---insert PPartner
insert into Account values ('tuanthangcorp','1234','5')
insert into Account values ('daithanhcorp','1234','5')
insert into Account values ('yenthanhcorp','1234','5')
insert into Account values ('quocthinhcorp','1234','5')
insert into Account values ('nhattamcorp','1234','5')
insert into PPartner values ('Part0001','Repre0001',N'Tuấn Thăng',N'Đà Nẵng',N'Thanh Khê','1',N'Quần áo',N'85 Hoàng Diệu Thanh Khê Đà Nẵng','0357458451','tuanthangcorp@gmail.com','500000000','tuanthangcorp')
insert into PPartner values ('Part0002','Repre0002',N'Đại Thành',N'TPHCM',N'Quận 1','1',N'Thực phẩm',N'78 Võ Thị Sáu Quận 1 TPHCM','0357458452','daithanhcorp@gmail.com','700000000','daithanhcorp')
insert into PPartner values ('Part0003','Repre0003',N'Yên Thành',N'TPHCM',N'Quận 7','1',N'Giày dép',N'85 Cao Lỗ Quận 7 TPHCM','0357458453','yenthanhcorp@gmail.com','500000000','yenthanhcorp')
insert into PPartner values ('Part0004','Repre0004',N'Quốc Thịnh',N'Đà Nẵng',N'Thanh Khê','1',N'Quần áo',N'15 Quang Trung Thanh Khê Đà Nẵng','0357458454','quocthinhcorp@gmail.com','500000000','quocthinhcorp')
insert into PPartner values ('Part0005','Repre0005',N'Nhất Tâm',N'Đà Nẵng',N'Thanh Khê','1',N'Quần áo',N'18 Phan Liêm Thanh Khê Đà Nẵng','0357458455','nhattamcorp@gmail.com','500000000','nhattamcorp')
--Bang chi nhanh--
CREATE TABLE Branch
(
Branch_ID VARCHAR(10),
Partner_ID VARCHAR(10),
Name_Branch NVARCHAR(50),
Adr_Branch NVARCHAR(100),
Phone_Number_Branch VARCHAR(15),
Email_Branch NVARCHAR(50),
Long_Branch FLOAT,		--kinh do cua chi nhanh--
Late_Branch FLOAT,		--vi do cua chi nhanh--
PRIMARY KEY (Branch_ID),
CONSTRAINT BR_PN FOREIGN KEY (Partner_ID) REFERENCES PPartner(Partner_ID)
)

--insert branch
insert into Branch values ('Bran0001','Part0001',N'Tuấn Thăng 1',N'86 Nguyễn Oanh Gò Vấp HCM','0354159751','tuanthang1branch@gmail.com','1','5')
insert into Branch values ('Bran0002','Part0002',N'Đại Thành 1',N'86 Quang Trung Gò Vấp HCM','0354159752','daithanh1branch@gmail.com','1','5')
insert into Branch values ('Bran0003','Part0003',N'Yên Thành 1',N'86 Gò Dầu Tân Phú HCM','0354159753','yenthanh1branch@gmail.com','1','6')
insert into Branch values ('Bran0004','Part0004',N'Quốc Thịnh 1',N'86 Tôn Đản quận 4 HCM','0354159754','quocthinh1branch@gmail.com','1','7')
insert into Branch values ('Bran0005','Part0005',N'Nhất Tâm 1',N'86 Đường số 8 Thủ Đức HCM','0354159755','nhattam1branch@gmail.com','2','1')


--Bang san pham--
CREATE TABLE Product
(
Product_ID VARCHAR(10),
Branch_ID VARCHAR(10),
Name_Product NVARCHAR(50),
Price_Product MONEY,
PRIMARY KEY (Product_ID),
CONSTRAINT PD_BR FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID)
)
--insert product
insert into Product values ('Pro0001','Bran0001',N'Áo thun','500000')
insert into Product values ('Pro0002','Bran0002',N'Chả cá','300000')
insert into Product values ('Pro0003','Bran0003',N'Giày Nike','3000000')
insert into Product values ('Pro0004','Bran0004',N'Áo somi','500000')
insert into Product values ('Pro0005','Bran0005',N'Quần Jeans','700000')

--Bang don hang--
CREATE TABLE District
(
District_ID int,
District_Name NVARCHAR(50),
PRIMARY KEY(District_ID)
)
insert into District values('1',N'Quận 1')
insert into District values('2',N'Quận 2')
insert into District values('3',N'Quận 3')
insert into District values('4',N'Quận 4')
insert into District values('5',N'Quận 5')
insert into District values('6',N'Quận 6')
insert into District values('7',N'Quận 7')
insert into District values('8',N'Quận 8')
insert into District values('9',N'Quận 9')
insert into District values('10',N'Quận 10')
insert into District values('11',N'Quận 11')
insert into District values('12',N'Quận 12')
insert into District values('13',N'Quận Bình Thạnh')
insert into District values('14',N'Quận Bình Tân')
insert into District values('15',N'Quận Tân Bình')
insert into District values('16',N'Quận Tân Phú')
insert into District values('17','NQuận Phú Nhuận')
insert into District values('18',N'Quận Gò Vấp')

---
CREATE TABLE District_E
(
District_ID int,
District_Name NVARCHAR(50),
PRIMARY KEY(District_ID)
)
insert into District_E values('1',N'Quận 1')
insert into District_E values('2',N'Quận 2')
insert into District_E values('3',N'Quận 3')
insert into District_E values('4',N'Quận 4')
insert into District_E values('5',N'Quận 5')
insert into District_E values('6',N'Quận 6')
insert into District_E values('7',N'Quận 7')
insert into District_E values('8',N'Quận 8')
insert into District_E values('9',N'Quận 9')
insert into District_E values('10',N'Quận 10')
insert into District_E values('11',N'Quận 11')
insert into District_E values('12',N'Quận 12')
insert into District_E values('13',N'Quận Bình Thạnh')
insert into District_E values('14',N'Quận Bình Tân')
insert into District_E values('15',N'Quận Tân Bình')
insert into District_E values('16',N'Quận Tân Phú')
insert into District_E values('17','NQuận Phú Nhuận')
insert into District_E values('18',N'Quận Gò Vấp')

--Bang don hang----Chỉnh bảng đơn hàng
---Nơi giao nhận hóa đơn đc đổi thành quận
CREATE TABLE DeliveryOrder
(
Order_ID VARCHAR(10),
Branch_ID VARCHAR(10),
Customer_ID VARCHAR(10),
Driver_ID VARCHAR(10),
Delivery_Date DATETIME,		--ngày tài xế nhận đơn và bắt đầu đi giao--
Delivered_Date DATETIME,	--ngày khách nhận được hàng--
District_Start int,		--quan tai xe nhan hang--
District_End int,--Quận tài xê giao hàng đến--
Status_Order NVARCHAR(20),		--trạng thái của đơn hàng--
Create_Date DATETIME,		--ngày tạo đơn hàng--
Estimate_Date DATETIME,		--ngày hết hạn của đơn hàng--
Total_Price MONEY,			--tổng tiền của đơn hàng--
Delivery_Fee MONEY,			--phí vận chuyển đơn hàng--
Payment NVARCHAR(10),			--hình thức thanh toán--
PRIMARY KEY (Order_ID),
CONSTRAINT OD_BR FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID),
CONSTRAINT OD_CS FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
CONSTRAINT OD_DR FOREIGN KEY (Driver_ID) REFERENCES Driver(Driver_ID),
CONSTRAINT DS_DE FOREIGN KEY (District_Start) REFERENCES District(District_ID),
CONSTRAINT DS_DE2 FOREIGN KEY (District_End) REFERENCES District_E(District_ID)
)
--insert Deliveryorder
insert into DeliveryOrder values ('Ord0001','Bran0001','Cus0001','Dri0001','11/12/2021','12/12/2021','1','2',N'Đã nhận','11/12/2021','11/15/2021','500000','50000','Online')
insert into DeliveryOrder values ('Ord0002','Bran0002','Cus0002','Dri0001','11/12/2021','12/12/2021','1','2',N'Đã nhận','11/12/2021','11/15/2021','500000','50000','Offline')
insert into DeliveryOrder values ('Ord0003','Bran0003','Cus0003','Dri0002','11/12/2021','12/12/2021','1','2',N'Đã giao','11/12/2021','11/15/2021','500000','50000','Online')
insert into DeliveryOrder values ('Ord0004','Bran0004','Cus0004','Dri0003','11/12/2021','12/12/2021','1','3',N'Đã nhận','11/13/2021','11/15/2021','500000','50000','Online')
insert into DeliveryOrder values ('Ord0005','Bran0005','Cus0001','Dri0001','11/12/2021','12/12/2021','1','2',N'Đã nhận','11/12/2021','11/15/2021','500000','50000','Online')

insert into DeliveryOrder values ('Ord0006','Bran0005','Cus0001',Null ,'11/12/2021','12/12/2021','1','2',N'Chưa giao','11/12/2021','11/15/2021','500000','50000','Online')
insert into DeliveryOrder values ('Ord0007','Bran0004','Cus0002',Null ,'11/12/2021','12/12/2021','1','14',N'Chưa giao','11/12/2021','11/15/2021','500000','50000','Online')
insert into DeliveryOrder values ('Ord0008','Bran0003','Cus0005',Null ,'11/12/2021','12/12/2021','1','12',N'Chưa giao','11/12/2021','11/15/2021','500000','50000','Online')

insert into DeliveryOrder values ('Ord0009','Bran0005','Cus0001',Null ,'11/12/2021','12/12/2021','1','2',N'Chưa giao','11/12/2021','11/15/2021','500000','50000','Online')
insert into DeliveryOrder values ('Ord0010','Bran0004','Cus0002',Null ,'11/12/2021','12/12/2021','16','14',N'Chưa giao','11/12/2021','11/15/2021','500000','50000','Online')
insert into DeliveryOrder values ('Ord0011','Bran0003','Cus0005',Null ,'11/12/2021','12/12/2021','4','12',N'Chưa giao','11/12/2021','11/15/2021','500000','50000','Online')

--Bang hơp dong
CREATE TABLE Contractt
(
Contract_ID VARCHAR(10),
Repre_ID VARCHAR(10),
Partner_ID VARCHAR(10),
Tax_Number_Partner VARCHAR(13),		--mã số thuế của đối tác--
Register_Branch_Count SMALLINT,		--số lượng chi nhánh của đối tác kí hợp đồng--
EExpiry_Date DATETIME,				--ngày hết hạn hợp đồng--
Commission MONEY,					--tiền hoa hồng--
Activate_Fee MONEY,					--phí đóng mỗi khi lập hợp đồng (cố định 1tr/1hopdong)--		
Max_Order SMALLINT,					--số lượng đơn hàng tối đa mỗi ngày của đối tác--
PRIMARY KEY (Contract_ID),
CONSTRAINT CT_RP FOREIGN KEY (Repre_ID) REFERENCES Representative(Repre_ID),
CONSTRAINT CT_PN FOREIGN KEY (Partner_ID) REFERENCES PPartner(Partner_ID)
)
---insert contract
insert into Contractt values ('Con0001','Repre0001','Part0001','TAX0001','1','01/01/2025','50000000','1000000','200')
insert into Contractt values ('Con0002','Repre0002','Part0002','TAX0002','1','01/01/2025','50000000','1000000','200')
insert into Contractt values ('Con0003','Repre0003','Part0003','TAX0003','1','01/01/2023','50000000','1000000','200')
insert into Contractt values ('Con0004','Repre0004','Part0004','TAX0004','1','01/01/2025','50000000','1000000','200')
insert into Contractt values ('Con0005','Repre0005','Part0005','TAX0005','1','01/01/2025','50000000','1000000','200')

--Bang nhan vien (day la nhan vien cua cong ty van chuyen, khong phai cua doi tac--
CREATE TABLE Employee
(
Employee_ID VARCHAR(10),
Name_Employee NVARCHAR(50),
Phone_Number_Employee VARCHAR(15),
Adr_Employee NVARCHAR(100),
Email_Employee NVARCHAR(50),
Account_Name VARCHAR(20),
PRIMARY KEY (Employee_ID),
CONSTRAINT EM_AC FOREIGN KEY (Account_Name) REFERENCES Account(Account_Name)
)
--insert employee
insert into Account values ('nvlong','1234','4')
insert into Account values ('ctanh','1234','4')
insert into Employee values ('Emp0001',N'Nguyễn Văn Long','0357852961',N'12 Hoa Sứ Bình Thạnh HCM','nvlong@gmail.com','nvlong')
insert into Employee values ('Emp0002',N'Cao Thùy Anh','0357852962',N'12 Phùng Hưng Q4 HCM','ctanh@gmail.com','ctanh')

--Bang gia han hop dong--
CREATE TABLE ContractExtension
(
Contract_Extension_ID [int] IDENTITY(1,1) NOT NULL,
Contract_ID VARCHAR(10),
Employee_ID VARCHAR(10),
New_Expiry_Date DATETIME,			--ngày hết hạn hợp đồng mới sau khi đã gia hạn hợp đồng. ngày này sẽ được cập nhập lên bảng hợp đồng.
Price_Extension MONEY,				--phí gia hạn hợp đồng, đóng mỗi khi gia hạn hợp đồng--
PRIMARY KEY (Contract_Extension_ID),
CONSTRAINT CE_CT FOREIGN KEY (Contract_ID) REFERENCES Contractt(Contract_ID),
CONSTRAINT CE_EM FOREIGN KEY (Employee_ID) REFERENCES Employee(Employee_ID)
)
--insert ContractExtension
insert into ContractExtension values ('Con0001','Emp0001','01/01/2025','500000000')
insert into ContractExtension values ('Con0002','Emp0001','01/01/2025','500000000')
insert into ContractExtension values ('Con0003','Emp0002','01/01/2023','500000000')
insert into ContractExtension values ('Con0004','Emp0001','01/01/2025','500000000')
insert into ContractExtension values ('Con0005','Emp0001','01/01/2025','500000000')
insert into ContractExtension values ('Con0005','Emp0001','01/01/2029','500000000') --test trigger--
GO

-- Bang Gio Hang
CREATE TABLE CartDetails(
	Cart_ID VARCHAR(10),
	Product_ID VARCHAR(10) CONSTRAINT FK_C_P FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID),
	Quantity SMALLINT,
	ToTal MONEY
)
GO
-- insert CartDetail
INSERT INTO CartDetails(Cart_ID, Product_ID, Quantity) VALUES ('Cart0001', 'Pro0001', 5);
INSERT INTO CartDetails(Cart_ID, Product_ID, Quantity) VALUES ('Cart0002', 'Pro0003', 10);
GO

--trigger Khi có một đối tượng được thêm mới vào bảng Contract_extension--
--mà có Contract_ID trùng với Contract_ID ở bảng Contract thì thuộc tính Expire_Date = Time
create trigger Contract_ID_trigger on ContractExtension 
after insert 
AS
BEGIN
	declare @ContractID as varchar(10);
	declare @NewExpiryDate as DATETIME;
	SELECT @ContractID = i.Contract_ID , @NewExpiryDate = i.New_Expiry_Date
	FROM INSERTED i
	BEGIN 
		UPDATE Contractt 
		SET EExpiry_Date = @NewExpiryDate
		WHERE Contract_ID = @ContractID
	END
END
GO
--Khi có thay đổi số lượng chi nhánh (Branch) thì thuộc tính Number_Of_Branch sẽ tự động cập nhập--
CREATE TRIGGER UPDATE_BRANCH_QUANTITY ON BRANCH
AFTER INSERT, DELETE
AS
BEGIN
	DECLARE @PARTNER_ID VARCHAR(10)
	IF EXISTS (SELECT * FROM DELETED) --DELETE BRANCH CASE
	BEGIN
		SELECT @PARTNER_ID = DELETED.Partner_ID
		FROM DELETED;
		--THIS BLOCK BELOW TO UPDATE VALUE OF THE NUMBER OF BRANCH FIELD
		UPDATE PPartner
		SET Number_Of_Branch = Number_Of_Branch - 1
		WHERE PPartner.Partner_ID = @PARTNER_ID
	END
	IF EXISTS (SELECT * FROM INSERTED) --INSERT BRANCH CASE
	BEGIN
		SELECT @PARTNER_ID = INSERTED.Partner_ID
		FROM INSERTED;
		-- THIS BLOCK BELOW TO UPDATE VALUE OF THE NUMBER OF BRANCH FIELD
		UPDATE PPartner
		SET Number_Of_Branch = Number_Of_Branch + 1
		WHERE PPartner.Partner_ID = @PARTNER_ID
	END
END

GO
--trigger Sale_Partner (doanh thu của đối tác) sẽ được tính bằng tổng của thuộc tính Total--
--trong bảng Delivery Order với các đơn hàng có Branch_ID thuộc Partner_ID đó.--
CREATE TRIGGER UPDATE_TOTAL_REVENUE ON DeliveryOrder
AFTER INSERT
AS
BEGIN
	DECLARE @PARTNER_ID VARCHAR(10)
	DECLARE @BRANCH_ID VARCHAR(10)
	DECLARE @SALE MONEY
	-- THIS CODE USING TO GET BRANCH ID WHEN INSERT DELIVERYORDER SUCEESS
	SELECT @BRANCH_ID = INSERTED.Branch_ID, @SALE = INSERTED.Total_Price
	FROM INSERTED;
	-- THIS CODE USING TO GET PARTNERiD
	SELECT DISTINCT @PARTNER_ID = Partner_ID 
	FROM Branch
	WHERE Branch_ID = @BRANCH_ID
	-- THIS CODE USING TO UPDATE REVENUE ON PPARTNER
	UPDATE PPartner
	SET Sale_Partner = Sale_Partner + @SALE 
	WHERE PPartner.Partner_ID = @PARTNER_ID

END