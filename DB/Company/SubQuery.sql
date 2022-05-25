-- Подзапросы
SELECT 
	Tmp.Stamp
FROM
(			-- Должен быть взят в скобки 
SELECT  -- Любой SELECT возвращает таблицу
	CURRENT_TIMESTAMP [Stamp] -- Вподзапросе не должно быть анонимных полей
	) Tmp -- Временное имя таблицы 



SELECT
	*
FROM
	(SELECT
		D.*,
		LEN(D.Name) [LEN]
	FROM
		Departments D
	WHERE LEN(D.Name)<12) Dep12
	JOIN Managers M ON Dep12.Id = M.Id_sec_dep
	
ORDER BY
	2


--	
SELECT
	COALESCE( MC.Surname + ' '+ SUBSTRING(MC.Name,1,1)+'.', '--') [Name],
	Dep12.Name [Department] 
FROM
	(
	SELECT
		D.*,
		LEN(D.Name) [LEN]
	FROM
		Departments D
	WHERE LEN(D.Name) < (SELECT AVG(LEN(DD.Name)) FROM Departments DD) -- использование подзапроса как значение для условия должен возвращать только одно значение
	) Dep12
	LEFT JOIN (
	SELECT
		*
	FROM 
		Managers M
	WHERE 
		M.Id_chief IS NOT NULL
	)MC
	ON Dep12.Id = MC.Id_sec_dep
	
ORDER BY -- ORDER BY применяется ко всему запросу и запрещен в подзапросе
	1