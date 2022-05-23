
	-- продано 1 шт
SELECT 
	S.Moment [DATE],
	P.Name [Product],
	S.Cnt [Count],
	M.Surname [Salesman]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	 AND S.Cnt =1
ORDER BY
	1 DESC

	-- продано 4 - 7 шт
SELECT 
	S.Moment [DATE],
	P.Name [Product],
	S.Cnt [Count],
	M.Surname [Salesman]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	 AND S.Cnt BETWEEN 4 AND 7
ORDER BY
	1 DESC


-- продавец Баранова
SELECT 
	S.Moment [DATE],
	P.Name [Product],
	S.Cnt [Count],
	M.Surname [Salesman]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	 AND M.Surname = N'Баранова'
ORDER BY
	1 DESC

-- ГВОЗДИ
SELECT 
	S.Moment [DATE],
	P.Name [Product],
	S.Cnt [Count],
	M.Surname [Salesman]
FROM
	Sales S
	   JOIN Managers M ON S.ID_manager = M.Id
	   JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	 AND P.Name LIKE N'%гвоздь%'
ORDER BY
	3 DESC


-- Сотрудник отдела продаж
SELECT 
	S.Moment [Date],
	P.Name [Product],
	S.Cnt [Count],
	M.Surname [Salesman],
	D.Name [Department],
	P.Price*S.Cnt [Check Amount]
FROM
	Sales S
		JOIN Managers M ON S.ID_manager = M.Id
		JOIN Products P ON S.ID_product = P.Id
		JOIN Departments D ON M.Id_main_dep = D.Id
WHERE
	CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	AND D.Name = N'Одтел продаж'
	AND P.Name LIKE N'%гвоздь%'
ORDER BY
	6 DESC
