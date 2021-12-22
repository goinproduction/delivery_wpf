--Transaction 1
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRANEXEC selectContracttExtension '1'COMMIT TRAN-- Khi tran 2 đang cập nhật dữ liệu trên một đơn vị dữ liệu thì dữ liệu thì tran 1 đọc dữ liệu đóSET TRANSACTION ISOLATION
LEVEL READ UNCOMMITTED;
BEGIN TRAN;EXEC updateContracttExtension '1', 'Emp0001', '2030-01-01', '500000000.00'WAITFOR DELAY '00:00:20' ROLLBACK TRAN