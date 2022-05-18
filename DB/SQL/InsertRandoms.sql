-- DML
INSERT INTO -- внесение данных
randoms		-- куда внести даные
VALUES		-- перечень значений
(NEWID(), -- попадает в id
CHECKSUM(NEWID())); -- попадает в rnd

INSERT INTO randoms(rnd,id) VALUES (CHECKSUM(NEWID()),NEWID()) -- указываем перечень и порядок полей при внесении

DELETE FROM randoms WHERE id = '407EA299-2EE8-467D-8A90-535B7E0C2796'

INSERT INTO randoms(rnd,id) VALUES (999999999,'407EA299-2EE8-467D-8A90-535B7E0C2796')
 
