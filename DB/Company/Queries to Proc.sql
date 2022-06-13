


 -- Get_year_stat запрос с статистикой за каждый месяц года, *год передавать как аргумент

CREATE OR ALTER PROC
	Get_year_stat
	@year INT
AS
BEGIN
	SELECT
		MIN(DATENAME(MONTH,DATEADD( MONTH , MONTH(S.Moment)-1,0)))[Month] ,
		SUM(S.Cnt) [Pieces]
	FROM
		Sales S
	WHERE 
		YEAR(S.Moment) = @year
	GROUP BY 
		MONTH(S.Moment)
	ORDER BY MONTH(S.Moment)
END

EXECUTE Get_year_stat @year = 2021



-- Find_prod 'fragment' - поиск среди товаров по заданному фрагменту

CREATE OR ALTER PROC
	Find_prod
	@name NVARCHAR(50)
AS
BEGIN

	SELECT
		P.Name,
		P.Price
	FROM
		Products P
	WHERE
		P.Name LIKE '%' + @name + '%'
	ORDER BY P.Name

END

EXEC Find_prod @name = N'свар'



-- Find_man 'fragment' - поиск менеджеров (и по имени, и по фамилии, *и по отчеству)

CREATE OR ALTER PROC
	Find_man
	@fragment AS NVARCHAR(100)
AS
BEGIN

	SELECT DISTINCT 
		CONCAT(M.Name, ' ',M.Surname,' ', M.Secname)
	FROM
		Managers M
	WHERE
		M.Name LIKE ('%' + @fragment + '%') 
		OR M.Surname LIKE ('%' + @fragment + '%') 
		OR M.Secname LIKE ('%' + @fragment + '%') 
	
END

EXEC Find_man N'л'



--Daily_best_prod 'date' - самый продаваемый товар за указанную дату

CREATE OR ALTER PROC
	Daily_best_prod 
	@date AS DATE
AS
BEGIN

	SELECT TOP 1
		COUNT(S.ID_product),
		MAX(P.Name)
	FROM
		Sales S
		JOIN Products P ON S.ID_product = P.Id
	WHERE
		CAST(S.Moment AS DATE) = @date
	GROUP BY 
		S.ID_product
	ORDER BY 1 DESC
END

EXEC Daily_best_prod '2021-03-21'



-- Daily_best_man 'date' - сотрудник с лучшими показателями продаж (ФИО, отдел)

CREATE OR ALTER PROC
	Daily_best_man 
	@date AS DATE
AS
BEGIN

	SELECT TOP 1
		COUNT(S.ID_manager) [Sold Items],
		CONCAT(MAX(M.Name), ' ', MAX(M.Surname), ' ',MAX(M.Secname)) [Name],
		MAX(D.Name) [Department]
	FROM
		Sales S
		JOIN Managers M ON S.ID_manager=M.Id
		JOIN Departments D ON M.Id_main_dep = D.Id
		WHERE
		CAST(S.Moment AS DATE) = @date
	GROUP BY 
		S.ID_manager
	ORDER BY 1 DESC

END

EXEC Daily_best_man '2021-03-21'


-- END OF HOMEWORK

--CREATE FUNCTION
--	Month_stat(@month INT)
--RETURNS INT
--AS
--BEGIN

	
--		SELECT SUM(S.Cnt)
--		FROM Sales S
--		WHERE MONTH(S.Date) = @month
	
	
--END
