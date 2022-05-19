
SELECT * FROM Products


SELECT 
	P.Name  [Названиие],
	P.Price [Цена]
FROM 
	Products P
ORDER BY 
	P.Name ASC


SELECT 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
WHERE 
	P.Name LIKE N'%шуруп %'
ORDER BY
	P.Price DESC


-- HOMEWORK --


SELECT 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
WHERE 
	P.Price < 100

	
SELECT 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
WHERE 
	P.Price > 100 AND P.Price < 500

	
SELECT 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
WHERE 
	P.Name LIKE N'%вер%'


SELECT TOP 10 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
ORDER BY 
	P.Name ASC
	
	
SELECT TOP 1 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
ORDER BY
	P.Price ASC
	
SELECT TOP 3 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
ORDER BY
	P.Price ASC


SELECT TOP 1 
	P.Name [Название],
	P.Price [Цена],
	P.Id [Код]
FROM 
	Products P
ORDER BY
	LEN(P.Name) DESC