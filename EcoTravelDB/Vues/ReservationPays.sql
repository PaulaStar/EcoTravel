CREATE VIEW [dbo].[ReservationPays]
	AS SELECT [id_Reservation], [dateDepart], [dateArrivee], Logement.[adressePays] 
	FROM [Reservation] AS Reservation 
	JOIN [Logement] AS Logement
	ON Reservation.[id_Logement] = Logement.[id_Logement]
	
