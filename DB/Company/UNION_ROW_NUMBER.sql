
-- IT Dep Managers

SELECT
	ROW_NUMBER() OVER (ORDER BY CONCAT(M.Name, ' ' , M.Surname)) AS [#],
	(CONCAT(M.Name, ' ' , M.Surname)) AS Name
FROM
	Managers M
WHERE
	M.Id_main_dep = 'D3C376E4-BCE3-4D85-ABA4-E3CF49612C94'
	OR M.Id_sec_dep = 'D3C376E4-BCE3-4D85-ABA4-E3CF49612C94'

	-- IT Department Quantity (Main, Sec)
SELECT 
	N'Main Dep'[Department],
	COUNT (M.Id_main_dep) [IT одтел]						-- Quantity of managers in main department
FROM
	Managers M
	JOIN Departments D ON M.Id_main_dep = D.Id
WHERE
	M.Id_main_dep = 'D3C376E4-BCE3-4D85-ABA4-E3CF49612C94'
	UNION
SELECT 
	N'Sec Dep',
	COUNT (M.Id_sec_dep) [Sec Dep]							-- Quantity of managers in sec department
FROM
	Managers M
	JOIN Departments D ON M.Id_sec_dep = D.Id
WHERE
	M.Id_sec_dep = 'D3C376E4-BCE3-4D85-ABA4-E3CF49612C94'


	-- Current month and previous Statistics
SELECT
	CONCAT('Current Month: ',MONTH(CURRENT_TIMESTAMP))[Month],
	COUNT(S.ID)[Checks],
	SUM(S.Cnt) [Pieces],
	ROUND(SUM(S.Cnt * P.Price),2) [UAH]
FROM
	Sales S
	JOIN Products P ON S.Id_product = P.Id
WHERE 
	MONTH(S.Moment) = MONTH(CURRENT_TIMESTAMP) 
	
UNION ALL

SELECT
	CONCAT('Previous Month: ',MONTH((CURRENT_TIMESTAMP) - DATEADD(MONTH,1,0))),
	COUNT(S.ID)[Checks],
	SUM(S.Cnt) [Pieces],
	ROUND(SUM(S.Cnt * P.Price),2) [UAH]
FROM
	Sales S
	JOIN Products P ON S.Id_product = P.Id
WHERE 
	MONTH(S.Moment) = MONTH((CURRENT_TIMESTAMP) - DATEADD(MONTH,1,0))
	
-- Statistics for Every month Statistics
SELECT
	MIN(DATENAME(MONTH,DATEADD( MONTH , MONTH(S.Moment)-1,0)))[Month] ,
	COUNT(S.ID)[Checks],
	SUM(S.Cnt) [Pieces],
	ROUND(SUM(S.Cnt * P.Price),2) [UAH]
FROM
	Sales S
	JOIN Products P ON S.Id_product = P.Id
GROUP BY 
	MONTH(S.Moment)
ORDER BY MONTH(S.Moment)