--Phan he tai xe
--Tao Login Tai Xe va cap quyen vao database
use [HQTCSDL]
GO
exec sp_addlogin 'loginTaiXe', 'a'
go
use [HQTCSDL]
GO
create user userTaiXe for login loginTaiXe
go
--Xem thong tin tai xe 
use [HQTCSDL]
GO
grant select on dbo.driver to userTaiXe
go
--Xem sua thuoc tinh status trong bang delivery order
use [HQTCSDL]
GO
GRANT select ON [dbo].[DeliveryOrder] ([Status_Order]) TO [userTaiXe]
GO
GRANT UPDATE ON [dbo].[DeliveryOrder] ([Status_Order]) TO [userTaiXe]
GO
--Xem thong tin bang delivery order
use [HQTCSDL]
GO
grant select on dbo.deliveryorder to userTaiXe
go
--Phan he khach hang
--Tao Login khach hang va cap quyen vao database
use [HQTCSDL]
GO
exec sp_addlogin 'loginKhachHang', 'a'
go
use [HQTCSDL]
GO
create user userKhachHang for login loginKhachHang
go
--Xem danh sach doi tac
use [HQTCSDL]
GO
grant select on dbo.ppartner to userKhachHang
go
--Xem thong tin cua khach hang
use [HQTCSDL]
GO
grant select on dbo.customer to userKhachHang
go
--Xem trang thai cua cot status trong bang delivery order
use [HQTCSDL]
GO
GRANT select ON [dbo].[DeliveryOrder] ([Status_Order]) TO [userKhachHang]
GO
--Phan he nhan vien
--Tao Login nhan vien va cap quyen vao database
use [HQTCSDL]
GO
exec sp_addlogin 'loginNhanVien', 'a'
go
use [HQTCSDL]
GO
create user userNhanVien for login loginNhanVien
go
--Them xoa sua va xem tren bang hop dong
use [HQTCSDL]
GO
grant select on dbo.contractt to userNhanVien
use [HQTCSDL]
GO
GRANT DELETE ON [dbo].[Contractt] TO [userNhanVien]
GO
use [HQTCSDL]
GO
GRANT INSERT ON [dbo].[Contractt] TO [userNhanVien]
GO
use [HQTCSDL]
GO
GRANT UPDATE ON [dbo].[Contractt] TO [userNhanVien]
GO
--Phan he doi tac
--Tao Login doi tac va cap quyen vao database
use [HQTCSDL]
GO
exec sp_addlogin 'loginDoiTac', 'a'
go
use [HQTCSDL]
GO
create user userDoiTac for login loginDoiTac
go
--Xem thong tin bang san pham
use [HQTCSDL]
GO
grant select on dbo.product to userDoiTac
go
--Thuc hien tham xoa sua tren bang san pham
use [HQTCSDL]
GO
GRANT DELETE ON [dbo].[Product] TO [userDoiTac]
GO
use [HQTCSDL]
GO
GRANT INSERT ON [dbo].[Product] TO [userDoiTac]
GO
use [HQTCSDL]
GO
GRANT UPDATE ON [dbo].[Product] TO [userDoiTac] 
GO
--Sua cot trang thai tren bang delivery order
use [HQTCSDL]
GO
GRANT UPDATE ON [dbo].[DeliveryOrder] ([Status_Order]) TO [userDoiTac]
GO
--Xem thong tin bang deliveryorder va partner
use [HQTCSDL]
GO
grant select on dbo.deliveryorder to userDoiTac
go
use [HQTCSDL]
GO
grant select on dbo.ppartner to userDoiTac
go