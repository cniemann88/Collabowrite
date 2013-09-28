CREATE TABLE [dbo].[Stories]
(
	[Id] INT IDENTITY (1, 1) NOT NULL , 
    [SentenceIds] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Stories] PRIMARY KEY ([Id])
)
