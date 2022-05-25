

-- HOMEWORK

-- ВСЕ отделы и кол-во проданных "гвоздей"
SELECT
	MIN(D.Name) [Name],
	COALESCE(SUM(DS.[Sold Items]),0)[Sold Items]
FROM
	Departments D
	LEFT JOIN (
		SELECT 
			M.Id_main_dep [DepId],
			MS.[Sold Items]
		FROM
			Managers M 
			JOIN (SELECT
						S.ID_manager [Manager],
						COUNT(S.Id) *  SUM(S.Cnt) [Sold Items]
					FROM
						Sales S
					WHERE
						CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
						AND S.ID_product IN (SELECT P.Id FROM Products P WHERE P.Name LIKE N'%гвозд%')
					GROUP BY S.ID_manager
				) MS ON MS.Manager = M.Id
	)DS ON D.Id = DS.DepId
GROUP BY
	DS.DepId










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


-- проданые гвозди по всем менееджерам

SELECT 
	COUNT(S.ID)*SUM(S.Cnt) [Items Sold],
	MAX(M.Name+' '+M.Surname) [Manager]
FROM
	Managers M
	LEFT JOIN Sales S ON M.Id = S.ID_manager
	JOIN Products P ON S.ID_product = P.Id
WHERE
	 CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
	 AND P.Name LIKE N'%гвозд%'
GROUP BY 
	M.Id


	
	-- проданые гвозди за сегодня по менеджерам
	
SELECT
	M.Name + ' ' + M.Surname [Name],
	
	COALESCE(SA.[Sold Items],'0') [Items Sold]
FROM
	Managers M
	LEFT JOIN (

			SELECT 
				S.ID_manager [Manager] ,
				MAX(S.ID_product) [Product Id],
				SUM(S.Cnt) * COUNT(S.ID) [Sold Items]
			FROM
				Sales S
			WHERE
				CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP - DATEADD(YEAR,1,0) AS DATE) 
				AND S.ID_product IN (SELECT P.ID FROM Products P WHERE P.Name LIKE N'%гвозд%')
			GROUP BY 
				S.ID_manager
	) SA ON M.Id = SA.Manager
ORDER BY 
	2 DESC,
	1 ASC

	-- проданые гвозди за сегодня по отделам






