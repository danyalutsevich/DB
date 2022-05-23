-- Сотрудники которые работают по совместительству
-- [Фамилия] [Имя] [Название департамента]
SELECT 
	M.Surname [Фамилия],
	M.Name [Имя],
	D.Name [Название департамента]
FROM 
	Managers M
	JOIN Departments D
		ON M.Id_sec_dep = D.Id
ORDER BY 
	D.Name ASC

	
-- Сотрудники у которых есть начальник
-- [Фамилия сотрудника] [Имя сотрудника] [Фамилия начальника] [Имя начальника]
SELECT 
	M.Surname [Фамилия сотрудника],
	M.Name [Имя сотрудника],
	Ma.Surname [Фамилия начальника],
	Ma.Name [Имя начальника]
FROM 
	Managers M
	JOIN Managers Ma
		ON M.Id_chief = Ma.Id
ORDER BY 
	Ma.Name ASC

-- END OF HOMEWORK	


-- Сотрудники и их департамент 
SELECT 
	CONCAT(M.Surname, ' ', M.Name) AS [Cотрудник],
	COALESCE(D.Name, '--') AS [Департамент]
FROM
	Managers M
	LEFT JOIN Departments D
		ON M.Id_sec_dep = D.Id
ORDER BY 
    D.Name ASC

-- Сотруднки и их начальники без прочерка
SELECT
	CONCAT(M.Surname, ' ', M.Name) AS [Cотрудник],
	COALESCE(CONCAT(Ma.Surname, ' ', Ma.Name), '--') AS [Начальник]
FROM 
	Managers M
	 LEFT JOIN Managers Ma
		ON M.Id_chief = Ma.Id

-- Сотруднки и их начальники с прочерком
SELECT 
	CONCAT(M.Surname ,M.Name) [Сотрудник],
	CONCAT(COALESCE(Ma.Surname ,'-'),COALESCE(Ma.Name,'-')) [Начальник]
FROM
	Managers M
	LEFT JOIN Managers Ma
		ON M.Id_chief = Ma.Id
ORDER BY 2 ASC

-- Начальники и их подчиненые
SELECT 
	CONCAT(COALESCE(Ma.Surname ,'-'),COALESCE(Ma.Name,'-')) [Начальник],
	CONCAT(COALESCE(M.Surname,'-'),' ', COALESCE(M.Name,'-')) [Сотрудник]
FROM
	Managers M
	RIGHT JOIN Managers Ma
		ON M.Id_chief = Ma.Id
ORDER BY 1 ASC

SELECT 
	M.Surname,
	D.Name
FROM
	Managers M,
	Departments D

-- Вывести журнал продаж за 23.05.2021

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
	-- S.Moment BETWEEN '2021-05-23' AND '2021-05-24'
	-- S.Moment BETWEEN '2021-05-23' AND DATEADD(DAY,1,'2021-05-23')
	-- CAST(S.Moment AS DATE) = '2021-05-23'
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE)
	
ORDER BY
	1 DESC


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
	1 DESC


-- Сотрудник отдела продаж
	SELECT 
	S.Moment [DATE],
	P.Name [Product],
	S.Cnt [Count],
	M.Surname [Salesman]
FROM
	Sales S
		JOIN Managers M ON S.ID_manager = M.Id
		JOIN Products P ON S.ID_product = P.Id
		JOIN Departments D 
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	 AND P.Name LIKE N'%гвоздь%'
ORDER BY
	1 DESC
