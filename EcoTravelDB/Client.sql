CREATE TABLE [dbo].[Client]
(
	[id_Client] INT IDENTITY (1,1) NOT NULL, 
    [nom] NVARCHAR(32) NOT NULL, 
    [prenom] NVARCHAR(32) NOT NULL, 
    [email] NVARCHAR(32) NOT NULL, 
    [password] VARBINARY(64) NOT NULL,
    [telephone] INT NOT NULL, 
    [pays] NVARCHAR(32) NOT NULL,
    CONSTRAINT [PK_id_Client] PRIMARY KEY CLUSTERED ([id_Client] ASC),
    CONSTRAINT [CK_Client_Email] CHECK ([email] LIKE ('%__@__%.__%'))



)
