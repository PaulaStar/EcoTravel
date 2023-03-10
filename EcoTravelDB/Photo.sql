CREATE TABLE [dbo].[Photo]
(
	[id_Photo] INT IDENTITY (1,1) NOT NULL, 
    [photo] NVARCHAR(255) NOT NULL, 
    [id_Logement] INT NOT NULL,
    CONSTRAINT [PK_id_Photo] PRIMARY KEY CLUSTERED ([id_Photo] ASC),
    CONSTRAINT FK_Photo_Logement FOREIGN KEY (id_Logement) REFERENCES Logement (id_Logement),
    CONSTRAINT [CK_Photo_photo] CHECK (LEN([photo]) >= 5 AND ([photo] LIKE '%_.png' OR [photo] LIKE '%_.jpg'))

)
