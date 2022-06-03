
CREATE OR ALTER FUNCTION
GetPagesCount(@perpage INT)
RETURNS INT
AS
BEGIN
	DECLARE @res INT
	DECLARE @count FLOAT 

	SET @count = (SELECT COUNT(*) FROM Products)
	--SET @res = @count / @perpage

	--IF @res * @perpage < @count
	--	SET @res = @res+1

	SET @res = CEILING(@count / @perpage)

	RETURN @res
END


SELECT dbo.GetPagesCount(7)