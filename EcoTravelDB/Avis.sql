CREATE TABLE [dbo].[Avis]
(
	[id_Avis] INT IDENTITY (1,1) NOT NULL, 
    [note] TINYINT NOT NULL,
    [avis] NVARCHAR(MAX) NOT NULL, 
    [id_Client] INT NOT NULL, 
    [id_Logement] INT NOT NULL,
    CONSTRAINT [PK_id_Avis] PRIMARY KEY CLUSTERED ([id_Avis] ASC),
    CONSTRAINT FK_Avis_Client FOREIGN KEY (id_Client) REFERENCES Client (id_Client),
    CONSTRAINT FK_Avis_Logement FOREIGN KEY (id_Logement) REFERENCES Logement (id_Logement),
    CONSTRAINT Ck_Note CHECK (note >= 1 AND note <= 5)
)
