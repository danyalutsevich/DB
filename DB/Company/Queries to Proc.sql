--CREATE FUNCTION
--	Month_stat(@month INT)
--RETURNS INT
--AS
--BEGIN

	
--		SELECT SUM(S.Cnt)
--		FROM Sales S
--		WHERE MONTH(S.Date) = @month
	
	
--END


--CREATE OR ALTER PROC
--	Get_year_stat
--	@year INT
--AS
--BEGIN
--	SELECT
--		MIN(DATENAME(MONTH,DATEADD( MONTH , MONTH(S.Moment)-1,0)))[Month] ,
--		SUM(S.Cnt) [Pieces]
--	FROM
--		Sales S
--	WHERE 
--		YEAR(S.Moment) = @year
--	GROUP BY 
--		MONTH(S.Moment)
--	ORDER BY MONTH(S.Moment)
--END

--EXEC Get_year_stat @year = 2022




--CREATE OR ALTER PROC
--	Find_prod
--	@name NVARCHAR(50)
--AS
--BEGIN

--	SELECT
--		P.Name,
--		P.Price
--	FROM
--		Products P
--	WHERE
--		P.Name LIKE '%' + @name + '%'
--	ORDER BY P.Name

--END

--EXEC Find_prod @name = N'свар'


CREATE OR ALTER PROC
	Find_man
	@fragment as NVARCHAR(100)
AS
BEGIN

	SELECT DISTINCT 
		CONCAT(M.Name, ' ',M.Surname,' ', M.Secname)
	FROM
		Managers M
	WHERE
		M.Name LIKE ('%'+@fragment+'%') 
		OR M.Surname LIKE ('%'+@fragment+'%') 
		OR M.Secname LIKE ('%'+@fragment+'%') 
	
END

EXEC Find_man N'абрам'


