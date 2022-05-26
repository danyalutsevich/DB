
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