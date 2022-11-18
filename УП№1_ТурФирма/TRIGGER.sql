CREATE TRIGGER ”даление_туриста
ON “уристы
INSTEAD OF DELETE
AS
BEGIN
SET NOCOUNT ON;

DELETE »нформаци€ќ“уристах
FROM deleted
Where deleted. од“уриста=»нформаци€ќ“уристах. од“уриста
Delete “уристы
FROM deleted
Where deleted. од“уриста = “уристы. од“уриста
END
GO