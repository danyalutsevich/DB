SELECT * FROM sys.objects WHERE name LIKE '%sales%'
-- WHERE type = 'U'

SELECT * FROM sys.tables T JOIN sys.columns C ON T.object_id = C.object_id


SELECT * FROM sys.objects O  WHERE parent_object_id = 1285579618 




SELECT 
	C.name [Field],
	TY.name [Type],
	C.max_length [Size],
	CASE WHEN C.is_nullable = 1 THEN 'YES' ELSE 'NO' END [Null],
	C.is_identity [Extra],
	--I.is_primary_key [Key],	
	D.definition [Default]
	
FROM sys.columns C
	JOIN sys.types TY ON C.system_type_id = TY.system_type_id
	LEFT JOIN sys.default_constraints D ON C.default_object_id = D.object_id
	-- JOIN sys.indexes I ON I.object_id = C.object_id
WHERE 
	C.object_id = 18099105
	AND TY.name <> 'sysname'

	


SELECT *
	
FROM sys.columns C
	JOIN sys.types TY ON C.system_type_id = TY.system_type_id
WHERE 
	object_id = 18099105


SELECT * FROM sys.systypes
SELECT * FROM sys.default_constraints
SELECT * FROM sys.indexes



SELECT T.name, TP.name, C.* 
FROM sys.columns C -- поля объектов
JOIN sys.tables T ON C.object_id = T.object_id
JOIN sys.systypes TP ON C.system_type_id = TP.xtype