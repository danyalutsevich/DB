--CREATE OR ALTER PROCEDURE
--GetManagersPagesCount
--@perPage FLOAT
--AS
--BEGIN

--	(SELECT CEILING(COUNT(*)/ @perpage) FROM Managers)

--END

--EXEC GetManagersPagesCount 7


CREATE OR ALTER PROCEDURE
GetManagersPage
@page INT,
@perPage INT
AS
BEGIN

	SELECT * 
	FROM Managers M
	ORDER BY M.Name
	OFFSET @page * @perPage ROWS
	FETCH NEXT @perpage ROWS ONLY

END

SELECT * FROM Managers ORDER BY Name

EXEC GetManagersPage 0, 5
