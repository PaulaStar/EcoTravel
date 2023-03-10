

	CREATE VIEW [dbo].[LogementMieuxNote] 
	AS SELECT L.*
	FROM [Logement] AS L
	WHERE (SELECT AVG(Avis.[note]) FROM Avis WHERE Avis.id_Logement = L.id_Logement)>(SELECT AVG([note]) FROM [Avis]);


