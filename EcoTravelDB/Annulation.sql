CREATE TABLE [dbo].[Annulation]
(
	[id_Reservation] INT NOT NULL, 
    [dateAnnulation] DATETIME NOT NULL DEFAULT GETDATE(), 
    [id_Client] INT NOT NULL,
    CONSTRAINT PK_Annulation PRIMARY KEY ([id_Reservation],[id_Client]),
    CONSTRAINT FK_Annulation_Reservation FOREIGN KEY (id_Reservation) REFERENCES Reservation (id_Reservation),
    CONSTRAINT FK_Annulation_Client FOREIGN KEY (id_Client) REFERENCES Client (id_Client)
)
