
CREATE OR ALTER FUNCTION
	FindProdByName(@fragment NVARCHAR(30))
RETURNS TABLE
AS
	RETURN
		SELECT *
		FROM Products P
		WHERE P.Name LIKE '%' + @fragment + '%'


SELECT * FROM dbo.FindProdByName(N'гвозд')


SELECT 
	MIN(FP.Name) [Product],
	SUM(S.Cnt) [Count]
FROM Sales S
	JOIN dbo.FindProdByName(N'гвозд') FP ON S.ID_product = FP.Id
WHERE
	MONTH(S.Moment)= 4
GROUP BY S.ID_product






