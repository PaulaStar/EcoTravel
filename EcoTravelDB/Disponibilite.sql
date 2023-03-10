CREATE TABLE [dbo].[Disponibilite]
(
	[id_Disponibilite] INT IDENTITY (1,1) NOT NULL, 
    [dateDebut] DATE NOT NULL, 
    [dateFin] DATE NOT NULL, 
    [id_Logement] INT NOT NULL,
    CONSTRAINT [PK_id_Disponibilite] PRIMARY KEY CLUSTERED ([id_Disponibilite] ASC),
    CONSTRAINT FK_Disponibilite_Logement FOREIGN KEY (id_Logement) REFERENCES Logement (id_Logement)
)
