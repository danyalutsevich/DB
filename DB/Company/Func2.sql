--CREATE OR ALTER FUNCTION
--	Deps()
--	RETURNS TABLE
--AS
	
--	RETURN 
--		SELECT * FROM Departments;
	
	
--SELECT * FROM dbo.Deps()





CREATE OR ALTER FUNCTION
	Month_names(@month INT)
	RETURNS TABLE
AS
		
		RETURN SELECT
			DATENAME(MONTH,DATEADD( MONTH , @month-1,0)) [Month] 
		FROM
			(VALUES (1)) n(num)
			
		
	--SELECT * FROM dbo.Month_names(3)


CREATE OR ALTER FUNCTION
	Year_stat(@year INT)
	RETURNS TABLE
AS
RETURN
	SELECT
		(SELECT * FROM dbo.Month_names(MONTH(S.Moment)))[Month],
		COUNT(S.ID)[Checks],
		SUM(S.Cnt) [Pieces],
		ROUND(SUM(S.Cnt * P.Price),2) [UAH]
	FROM
		Sales S
		JOIN Products P ON S.Id_product = P.Id
	WHERE 
		YEAR(S.Moment) = @year
	GROUP BY 
		MONTH(S.Moment)
		
	SELECT * FROM sys.syslanguages
	SET LANGUAGE 繁體中文
	
	SELECT * FROM dbo.Year_stat(2021)