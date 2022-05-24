
--HOMEWORK
-- Данные о продажах (кол-во чеков, кол-во штук, сумма грн) "за сегодня" по отделам


SELECT 
	MIN(CAST(S.Moment AS DATE))  [DATE],
	MIN(D.Name) [Department],
	SUM(S.Cnt) [Sold Items],
	COUNT(S.ID_product) [Checks],
	SUM(S.Cnt*P.Price) [Profit (UAH)]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
	   JOIN Departments D ON M.Id_main_dep = D.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY
	D.Id

-- END OF HOMEWORK

-- Aggregators
SELECT
	SUM (S.Cnt) [Всего проданно, шт.],
	MIN (S.Cnt * P.Price ) [Минимальный чек],
	MAX (S.Moment)[Последняя продажа],
	COUNT (S.ID)[Всего чеков], 
	AVG (P.Price)[Средняя цена единицы]
	
FROM 
	Sales S
	JOIN Products P ON S.Id_product = P.Id


-- Group by P.Name
SELECT 
	P.Name [Product],
	COUNT(S.ID) [Count],
	MAX(P.Id)
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY
	P.Name
ORDER BY
	1 DESC


-- Group by P.Id
SELECT 
	MAX (P.Name) [Product],
	COUNT(S.ID) [Count],
	SUM (S.Cnt) [SOLD],
	SUM(P.Price * S.Cnt) [AMOUNT]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY
	P.Id
ORDER BY
	1 DESC


-- GROUP BY MANAGERS
SELECT
	MAX(CONCAT(M.Surname,' ',M.Name))[ФИ],
	COUNT(S.ID) [Count],
	SUM (S.Cnt) [SOLD],
	SUM(P.Price * S.Cnt) [AMOUNT]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
GROUP BY
	S.ID_manager


-- проданые гвозди
SELECT 
	MIN(CAST(S.Moment AS DATE))  [DATE],
	MIN(P.Name) [Product],
	SUM(S.Cnt) [Count],
	MIN(CONCAT(M.Surname,' ',M.Name)) [Salesman]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	 AND P.Name LIKE N'%гвозд%'
GROUP BY
	m.Id
ORDER BY
	3 DESC


	
