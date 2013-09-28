CREATE TABLE [dbo].[Sentences]
(
	[Id] INT IDENTITY (1, 1) NOT NULL , 
    [StoryId] INT NOT NULL, 
    [Text] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Sentences] PRIMARY KEY ([Id]) 
)
