CREATE OR ALTER PROCEDURE
GetPage
@page INT,
@perpage INT
AS
BEGIN

	SELECT *
	FROM
	Products P
	ORDER BY P.Name
OFFSET @page - 1 * @perpage ROWS
FETCH NEXT @perpage ROWS ONLY


END

EXEC GetPage 1,1 