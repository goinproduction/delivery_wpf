CREATE DATABASE HQTCSDL
USE HQTCSDL
--Bang khach hang--
CREATE TABLE Customer
(
Customer_ID VARCHAR(10),
Name_Cus NCHAR(50),
Phone_Number_Cus VARCHAR(15),
Adr_Cus NCHAR(100),
Email_Cus NCHAR(50),
PRIMARY KEY (Customer_ID)
)

--Bang tai xe--
CREATE TABLE Driver
(
Driver_ID VARCHAR(10),
Name_Driver NCHAR(50),
Phone_number_Driver VARCHAR(15),
Adr_Driver NCHAR(100),
Email_Driver NCHAR(50),
License_Plates CHAR(12),	--so cua giay phep lai xe dai 12 ki tu--
Active_Area FLOAT,
Bank_Account_Driver CHAR(14), --so tai khoan ngân hang dai tu 10 den 14 ki tu--
Identity_Code_Driver VARCHAR(12), --so cmnd co 9 so, so can cuoc co 12 so, nen chọn kieu du lieu la varchar(12)--
Active_Fee MONEY, --Phí kích hoạt tài khoản của lái xe--
PRIMARY KEY (Driver_ID)
)

--Bang nguoi dai dien--
CREATE TABLE Representative
(
Repre_ID VARCHAR(10),
Name_Repre NCHAR(50),
Phone_Number_Repre VARCHAR(15),
Adr_Repre NCHAR(100),
Email_Repre NCHAR(50),
PRIMARY KEY (Repre_ID)
)

--Bang doi tac--
CREATE TABLE PPartner
(
Partner_ID VARCHAR(10),
Repre_ID VARCHAR(10),
Name_Partner NCHAR(50),
City_Partner NCHAR(30),		--thanh pho cua doi tac--
District_Partner NCHAR(30),		--quan cua doi tac--
Number_Of_Branch SMALLINT,		--so luong chi nhanh cua doi tac--
Product_Shipping_Type NCHAR(30),	--loai san pham van chuyen cua doi tac--
Adr_Business_Partner NCHAR(100),	--dia chi kinh doanh cua doi tac (co the hieu đây là địa chỉ cơ quan đầu não của đối tác đó--
Phone_Number_Partner VARCHAR(15),
Email_Partner NCHAR(50),
Sale_Partner MONEY,			--tong doanh thu cua doi tac--
PRIMARY KEY (Partner_ID),
CONSTRAINT PN_RP FOREIGN KEY (Repre_ID) REFERENCES Representative(Repre_ID)
)

--Bang chi nhanh--
CREATE TABLE Branch
(
Branch_ID VARCHAR(10),
Partner_ID VARCHAR(10),
Name_Branch NCHAR(50),
Adr_Branch NCHAR(100),
Phone_Number_Branch VARCHAR(15),
Email_Branch NCHAR(50),
Long_Branch FLOAT,		--kinh do cua chi nhanh--
Late_Branch FLOAT,		--vi do cua chi nhanh--
PRIMARY KEY (Branch_ID),
CONSTRAINT BR_PN FOREIGN KEY (Partner_ID) REFERENCES PPartner(Partner_ID)
)

--Bang san pham--
CREATE TABLE Product
(
Product_ID VARCHAR(10),
Branch_ID VARCHAR(10),
Name_Product NCHAR(50),
Price_Product MONEY,
PRIMARY KEY (Product_ID),
CONSTRAINT PD_BR FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID)
)

--Bang don hang--
CREATE TABLE DeliveryOrder
(
Order_ID VARCHAR(10),
Branch_ID VARCHAR(10),
Customer_ID VARCHAR(10),
Driver_ID VARCHAR(10),
Delivery_Date DATETIME,		--ngày tài xế nhận đơn và bắt đầu đi giao--
Delivered_Date DATETIME,	--ngày khách nhận được hàng--
Long_Receiver FLOAT,		--kinh độ của nơi tài xế cần giao hàng tới--
Late_Receiver FLOAT,		--vĩ độ của nơi tài xế cần giao hàng tới--
Status_Order NCHAR(20),		--trạng thái của đơn hàng--
Create_Date DATETIME,		--ngày tạo đơn hàng--
Estimate_Date DATETIME,		--ngày hết hạn của đơn hàng--
Total_Price MONEY,			--tổng tiền của đơn hàng--
Delivery_Fee MONEY,			--phí vận chuyển đơn hàng--
Payment NCHAR(10),			--hình thức thanh toán--
PRIMARY KEY (Order_ID),
CONSTRAINT OD_BR FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID),
CONSTRAINT OD_CS FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
CONSTRAINT OD_DR FOREIGN KEY (Driver_ID) REFERENCES Driver(Driver_ID)
)

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

--Bang nhan vien (day la nhan vien cua cong ty van chuyen, khong phai cua doi tac--
CREATE TABLE Employee
(
Employee_ID VARCHAR(10),
Name_Employee NCHAR(50),
Phone_Number_Employee VARCHAR(15),
Adr_Employee NCHAR(100),
Email_Employee NCHAR(50),
PRIMARY KEY (Employee_ID)
)

--Bang gia han hop dong--
CREATE TABLE ContractExtension
(
Contract_Extension_ID VARCHAR(10),
Contract_ID VARCHAR(10),
Employee_ID VARCHAR(10),
New_Expiry_Date DATETIME,			--ngày hết hạn hợp đồng mới sau khi đã gia hạn hợp đồng. ngày này sẽ được cập nhập lên bảng hợp đồng.
Price_Extension MONEY,				--phí gia hạn hợp đồng, đóng mỗi khi gia hạn hợp đồng--
PRIMARY KEY (Contract_Extension_ID),
CONSTRAINT CE_CT FOREIGN KEY (Contract_ID) REFERENCES Contractt(Contract_ID),
CONSTRAINT CE_EM FOREIGN KEY (Employee_ID) REFERENCES Employee(Employee_ID)
)