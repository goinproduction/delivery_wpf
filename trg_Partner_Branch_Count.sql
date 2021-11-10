-- Trigger này có chức năng cập nhật lại Number_Of_Branch ở bảng PPartner khi cập nhật bảng Branch
CREATE TRIGGER trg_Partner_Branch_Delete ON Branch AFTER DELETE AS
BEGIN
    IF((SELECT p.Number_Of_Branch FROM PPartner p) <= 0 )
        BEGIN
            ROLLBACK
        END
    UPDATE PPartner
    SET Number_Of_Branch = Number_Of_Branch - (SELECT COUNT(d.Branch_ID) FROM deleted d 
                                                JOIN PPartner p on d.Partner_ID = p.Partner_ID)
    WHERE PPartner.Partner_ID = (SELECT DISTINCT d.Partner_ID FROM deleted d);
END