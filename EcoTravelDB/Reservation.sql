CREATE TABLE [dbo].[Reservation]
(
	[id_Reservation] INT IDENTITY (1,1) NOT NULL, 
    [dateArrivee] DATE NOT NULL, 
    [dateDepart] DATE NOT NULL, 
    [nbAdulte] TINYINT NOT NULL, 
    [nbEnfant] TINYINT NOT NULL, 
    [Assurance] BIT NOT NULL, 
    [id_Logement] INT NOT NULL, 
    [id_Client] INT NOT NULL,
    CONSTRAINT [PK_id_Reservation] PRIMARY KEY CLUSTERED ([id_Reservation] ASC),
    CONSTRAINT FK_Reservation_Client FOREIGN KEY (id_Client) REFERENCES Client (id_Client),
    CONSTRAINT FK_Reservation_Logement FOREIGN KEY (id_Logement) REFERENCES Logement (id_Logement)
)
