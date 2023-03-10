CREATE TABLE [dbo].[Proprietaire]
(
	[id_Client] INT NOT NULL PRIMARY KEY,
	CONSTRAINT FK_Proprietaire_Client FOREIGN KEY (id_Client) REFERENCES Client (id_Client)
)
