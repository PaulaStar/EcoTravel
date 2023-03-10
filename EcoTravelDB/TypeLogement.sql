CREATE TABLE [dbo].[TypeLogement]
(
	[id_TypeLogement] INT IDENTITY (1,1) NOT NULL, 
    [nom] NVARCHAR(32) NOT NULL UNIQUE,
	CONSTRAINT [PK_id_TypeLogement] PRIMARY KEY CLUSTERED ([id_TypeLogement] ASC),
)
