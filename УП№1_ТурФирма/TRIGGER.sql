CREATE TRIGGER ��������_�������
ON �������
INSTEAD OF DELETE
AS
BEGIN
SET NOCOUNT ON;

DELETE �������������������
FROM deleted
Where deleted.����������=�������������������.����������
Delete �������
FROM deleted
Where deleted.���������� = �������.����������
END
GO