
--CREATE OR ALTER PROC
--	Get_Stat_month
--	@month DATETIME
--AS
--	SELECT
--		SUM (S.Cnt) [Cnt]
--	FROM
--		Sales S
--	WHERE
--		MONTH(S.Moment) = MONTH(@month)

--EXEC Get_Stat_month '2021-05-1'
		

CREATE OR ALTER PROC
	Get_stat_interval
	@from DATETIME,
	@to DATETIME
AS
BEGIN

	DECLARE @from_d DATE
	SET @from_d = CAST(@from AS DATE)
	DECLARE @to_d DATE
	SET @to_d = CAST(@to AS DATE)
	SELECT
		SUM(S.Cnt) Cnt
	FROM 
		Sales S
	WHERE
		S.Moment BETWEEN @from_d AND @to_d
		
END

EXEC Get_stat_Interval '2021-01-1 10:20:00','2021-11-1 10:20:00'