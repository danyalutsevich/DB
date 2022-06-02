-- События удаления
CREATE OR ALTER TRIGGER
	OnDelete
ON Sales
AFTER DELETE
AS
BEGIN

SET NOCOUNT ON
	DECLARE @sum FLOAT
	SET @sum = (SELECT S.Cnt * P.Price FROM deleted S JOIN Products P ON S.ID_product = P.Id)
	SET @sum = ROUND(@sum,2)
	
	UPDATE 
	Acu_sales
	SET total_checks = total_checks - COALESCE((SELECT COUNT(D.ID) FROM deleted D),0),
		total_cnt = total_cnt -  COALESCE((SELECT SUM(D.Cnt) FROM deleted D),0),
		total_sum = total_sum - COALESCE(@sum,0)

		--SET total_checks =1,
		--total_cnt = 2,
		--total_sum = 2
	WHERE id =1
END


SELECT * FROM Acu_sales
-- 549870 184953461,24 100005 2021-11-02 02:42:00.000

SELECT TOP 1 * FROM Sales

DELETE FROM Sales WHERE ID ='AE2823BF-9131-40A3-96B5-000572E4AD63'

	