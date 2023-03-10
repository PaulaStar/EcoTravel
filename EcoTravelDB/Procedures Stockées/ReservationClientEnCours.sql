CREATE PROCEDURE [dbo].[ReservationClientEnCours]
	@id_Client int
AS
BEGIN
	SELECT * FROM Reservation WHERE id_Client = @id_Client AND dateArrivee <= GETDATE() AND dateDepart >= GETDATE()
END
