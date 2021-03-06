

-- HOMEWORK

-- сотрудники, которые не продавали гвозди за сегодня

SELECT 
	CONCAT (M.Surname, ' ' , M.Name) [Managers] 
FROM
	Managers M
WHERE
	M.Id NOT IN ( -- выбираем оставшихся сотрудников и получаем тех кто не продавал гвозди
	
		SELECT    -- получаем всех сотрудников которые продавали гвозди за сегодня
			MIN(M.Id) [Manager Id]
		FROM
			Sales S
			JOIN Managers M ON S.Id_manager = M.Id
		WHERE
			CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
			AND (S.ID_product = 'B6D20749-B495-4B1A-BA1C-80B88E78B7CD' OR S.ID_product = 'DA1E17BB-A90D-4C79-B801-5462FB070F57')
		GROUP BY
			S.ID_manager
	) 


SELECT
	M.Name
FROM
	Managers M
WHERE
	M.Id NOT IN (
SELECT DISTINCT 
	(S.ID_manager) [Manager Id]
FROM
	Sales S
	JOIN Managers M ON S.Id_manager = M.Id
WHERE
	CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	AND (S.ID_product = 'B6D20749-B495-4B1A-BA1C-80B88E78B7CD' OR S.ID_product = 'DA1E17BB-A90D-4C79-B801-5462FB070F57')
	)
	


-- END OF HOMEWORK

	-- худший по продажам (товаров-штук) за сегодня отдел
	
SELECT TOP 1
	MAX(D.Name) [Name],
	SUM(S.Cnt) [Quantity]
FROM
	Sales S
	JOIN Managers M ON S.ID_manager = M.Id
	JOIN Departments D ON M.Id_main_dep = D.Id
WHERE
	CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY 
	D.Id
ORDER BY 2


-- отделы, суммы продаж за месяц по которым превышают 100000 грн

SELECT 
	MAX(D.Name) [Name],
	SUM(S.Cnt) [Quantity],
	SUM(S.Cnt * P.Price) [UAH]
FROM
	Sales S
	JOIN Managers M ON S.ID_manager = M.Id
	JOIN Departments D ON M.Id_main_dep = D.Id
	JOIN Products P ON S.ID_product = P.Id
WHERE
	MONTH(S.Moment ) = 5 
GROUP BY 
	D.Id
HAVING
	SUM(S.Cnt * P.Price)>2000000
ORDER BY 3


-- отделы сумма продаж (грн) которых меньше чем в среднем за сегодня

SELECT 
	MAX(D.Name) [Name],
	SUM(S.Cnt) [Quantity],
	SUM(S.Cnt * P.Price) [UAH]
FROM
	Sales S
	JOIN Managers M ON S.ID_manager = M.Id
	JOIN Departments D ON M.Id_main_dep = D.Id
	JOIN Products P ON S.ID_product = P.Id
WHERE
	CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY 
	D.Id
HAVING 
	SUM(S.Cnt * P.Price)<
	(
		SELECT
			AVG(AVERAGE.UAH)
		FROM
		(
			SELECT 
				SUM(S.Cnt * P.Price) [UAH]
			FROM
				Sales S
				JOIN Managers M ON S.ID_manager = M.Id
				JOIN Departments D ON M.Id_main_dep = D.Id
				JOIN Products P ON S.ID_product = P.Id
			WHERE
				CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
			GROUP BY 
				D.Id
			
		) AVERAGE 
	) 

ORDER BY 3

-- END OF HOMEWORK

SELECT 
	P.Name [Name],
	SUM(S.Cnt) [Quantity]
FROM
	Sales S
	JOIN Products P ON S.ID_product = P.Id
WHERE
	CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY 
	P.Name
HAVING
	SUM(S.Cnt)>100
ORDER BY 
	2 DESC
	


SELECT 
	MIN(M.Name + ' ' + M.Surname),
	AVG(S.Cnt * P.Price)
FROM
	Sales S
	JOIN Products P ON S.ID_product = P.Id
	JOIN Managers M ON S.ID_manager = M.Id
WHERE
	MONTH(S.Moment) = 2
GROUP BY
	S.ID_manager
HAVING
	AVG(S.Cnt * P.Price)<1500

ORDER BY 1



SELECT
	M.Surname + ' ' + M.Name,
	COALESCE(STR(IC.Count),'-')
FROM	
	Managers M
	LEFT JOIN(
		SELECT
			M.Id [Id],
			COUNT(M.Id) [Count]
		FROM
			Managers M
			JOIN Managers MC ON M.Id = MC.Id_chief
		GROUP BY M.Id
		HAVING 
			COUNT(M.Id)>0
		
	)IC ON M.Id = IC.Id
	JOIN Departments D ON M.Id_main_dep = D.Id
WHERE
	D.Name = N'Бухгалтерия'
ORDER BY 2 


-- топ 3 худших товаров по продажам


SELECT TOP 3
	MAX(P.Name) [Product Name],
	SUM (S.Cnt) [Quantity],
	SUM(S.Cnt) * MAX(P.Price) [UAH]
FROM
	Sales S
	JOIN Products P ON S.ID_product = P.Id
WHERE
	CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY 
	S.ID_product
ORDER BY
	2 


-- топ 3 менеджера по продажам
	
SELECT TOP 3
	MAX(M.Surname + ' ' + M.Name ) [Name],
	SUM( S.Cnt ) [Quantity],
	SUM(S.Cnt * P.Price) [UAH]
FROM	
	Sales S 
	JOIN Managers M ON S.ID_manager = M.Id
	JOIN Products P ON P.Id = S.ID_product
WHERE
	CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY
	M.Id
ORDER BY 
	2 DESC


	-- card stack 
SELECT
	CONCAT(Val.N,' ', Suit.N)
FROM
	(VALUES ('6'),('7'),('8'),('9'),('10'),('J'),('Q'),('K'),('A')) Val(N),
	(VALUES ('Clubs'),('Diamonds'),('Hearts'),('Spades')) Suit(N)
ORDER BY
	NEWID()
