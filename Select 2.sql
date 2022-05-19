SELECT
D.Name [Название отдела],
D.Id [Код отдела]
FROM
Departments D
ORDER BY 
 -- D.Name ASC -- ASC - по возрастанию, DESC - по убыванию
  1 -- по первому полю выборки (D.Name) по возрастанию
 -- [Название отдела] DESC

 -- Условия в выборке

SELECT
D.Name [Название отдела],
D.Id [Код отдела]
FROM
Departments D
WHERE 
	D.Name > N'О'
	AND  D.Name < N'С'

SELECT
	D.Name [Название отдела],
	D.Id [Код отдела]
FROM
	Departments D
WHERE 
	D.Name  BETWEEN N'О' AND N'С'
ORDER BY D.Name DESC -- сортировка всегда на последнем месте


SELECT
	D.Name [Название отдела],
	D.Id [Код отдела]
FROM
	Departments D
WHERE 
	D.Name  LIKE N'%о%' -- содердит букву о
ORDER BY D.Name DESC 