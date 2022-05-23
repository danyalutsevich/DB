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




	