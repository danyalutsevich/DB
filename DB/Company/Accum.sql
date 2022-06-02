

CREATE TABLE Acu_sales(id INT UNIQUE, total_cnt INT, total_sum FLOAT, total_checks INT, lastsale DATETIME)

DELETE Acu_sales

DROP TABLE Acu_sales

INSERT INTO Acu_sales (id,total_cnt,total_sum,total_checks,lastsale)
SELECT 1,
	SUM(S.Cnt),
	SUM(S.Cnt * P.Price),
	COUNT(S.ID),
	MAX(S.Moment)
FROM Sales S JOIN Products P ON P.Id = S.ID_product
	
UPDATE Acu_sales SET total_sum = ROUND(total_sum,2) WHERE id = 1
	
SELECT * FROM Acu_sales

-- before trigger
-- 549841
-- 184945470,84

-- after
-- 549846
-- 184945720,74





CREATE OR ALTER TRIGGER 
	onInsert
ON Sales 
AFTER INSERT
AS
BEGIN
	
	SET NOCOUNT ON  -- отключение вывода 1 row affected
	DECLARE @sum FLOAT
	DECLARE @cnt INT
	
	SET @cnt = (SELECT cnt FROM inserted) -- внутрененная таблица содержащая то что вводится в таблицу триггера (Sales) 
										  --эта таблица (inserted) имеет такую же структуру что и Sales ее можно обьединять с другими таблицами
	
	SET @sum = (SELECT S.Cnt * P.Price FROM inserted S JOIN Products P ON S.ID_product = P.Id)
	SET @sum = ROUND(@sum,2)
											-- в теле мы можем обращаться к любым таблицам базы

	
	UPDATE
		Acu_sales
		SET total_sum += @sum,
			total_cnt += @cnt,
			total_checks = total_checks+1,
			lastsale = (SELECT S.Moment FROM inserted S)
	WHERE id = 1


END