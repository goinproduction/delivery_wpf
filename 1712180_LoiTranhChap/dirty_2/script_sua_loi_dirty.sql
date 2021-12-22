--Transaction 1
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN TRAN
EXEC selectProduct 'pro0001'
COMMIT TRAN

-- Khi tran 2 đang cập nhật dữ liệu trên một đơn vị dữ liệu thì dữ liệu thì tran 1 đọc dữ liệu đó
-- Nâng mức độ cô lập lên thành read committed

SET TRANSACTION ISOLATION
LEVEL READ UNCOMMITTED;
BEGIN TRAN;
EXEC updateProduct 'pro0001', 'Bran0001', 'Áo thun', '7000000.00'
WAITFOR DELAY '00:00:20' 
ROLLBACK TRAN
