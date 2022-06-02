
CREATE OR ALTER TRIGGER
OnUpdate
On Sales
AFTER UPDATE -- обновление воспринемается как удаление и внесение данных
AS
BEGIN

SET NOCOUNT ON

	DECLARE @sum FLOAT
	DECLARE @cnt INT

	SET @sum = COALESCE((SELECT SUM(S.Cnt * P.Price) FROM inserted S JOIN Products P ON S.ID_product = P.Id),0) - 
	COALESCE((SELECT SUM(S.Cnt * P.Price) FROM deleted S JOIN Products P ON S.ID_product = P.Id),0)
	
	SET @sum = ROUND(@sum,2)

	SET @cnt = COALESCE((SELECT SUM(cnt) FROM inserted),0)-COALESCE((SELECT SUM(D.Cnt) FROM deleted D),0)

	UPDATE Acu_sales
	SET total_cnt += @cnt,
		total_sum += @sum
	WHERE id=1

END
