CREATE OR ALTER TRIGGER
UNIVERSAL
ON Sales
AFTER INSERT, DELETE, UPDATE
AS
BEGIN

	SET NOCOUNT ON
	
	DECLARE @Isum FLOAT
	DECLARE @Icnt INT
	DECLARE @Ichecks INT

	DECLARE @Dsum FLOAT
	DECLARE @Dcnt INT
	DECLARE @Dchecks INT
	
	DECLARE @lastsaledate DATETIME

	SET @Isum = COALESCE((SELECT SUM(S.Cnt * P.Price) FROM inserted S JOIN Products P ON S.ID_product = P.Id),0)
	SET @Icnt = COALESCE((SELECT SUM(Cnt) FROM inserted),0)
	SET @Ichecks = COALESCE((SELECT COUNT(ID) FROM inserted),0)

	SET @Dsum = COALESCE((SELECT SUM(S.Cnt * P.Price) FROM deleted S JOIN Products P ON S.ID_product = P.Id),0)
	SET @Dcnt = COALESCE((SELECT SUM(Cnt) FROM deleted),0)
	SET @Dchecks = COALESCE((SELECT COUNT(ID) FROM deleted),0)

	SET @lastsaledate = (SELECT MAX(S.Moment) FROM inserted S)


	UPDATE Acu_sales
	SET
		total_sum += @Isum - @Dsum,
		total_cnt += @Icnt - @Dcnt,
		total_checks += @Ichecks - @Dchecks,
		lastsale = @lastsaledate
	WHERE id = 1

END