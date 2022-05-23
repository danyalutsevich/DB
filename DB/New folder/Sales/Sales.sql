
CREATE TABLE Sales (
	ID			UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	ID_manager	UNIQUEIDENTIFIER NOT NULL REFERENCES Managers( Id ),
	ID_product	UNIQUEIDENTIFIER NOT NULL REFERENCES Products( Id ),
	Cnt			INT NOT NULL,
	Moment		DATETIME DEFAULT CURRENT_TIMESTAMP
) ;




DECLARE @I INT
SET     @I = 0
SET     NOCOUNT ON
WHILE   @I < 100000
BEGIN
	SET @I = @I + 1 
	INSERT INTO Sales 
		( Id_manager, Id_product, Moment, Cnt)
	VALUES
	(
		( SELECT TOP 1 Id FROM Managers ORDER BY NEWID() ),				-- random ID from Manager
		( SELECT TOP 1 Id FROM Products ORDER BY NEWID() ),				-- random ID from Products
		('2021-01-01'													-- base date - first day in year
			+ DATEADD( day,    ( ABS( CHECKSUM( NEWID() ) ) % 365 ), 0) -- random day - one from 365
			+ DATEADD( hour,   ( ABS( CHECKSUM( NEWID() ) ) % 24  ), 0) -- random hour - one from 24
			+ DATEADD( minute, ( ABS( CHECKSUM( NEWID() ) ) % 60  ), 0) -- random minute - one from 60
		),
		( ABS( CHECKSUM( NEWID() ) ) % 10 + 1 )							-- random Cnt: 1 to 10
	)
END