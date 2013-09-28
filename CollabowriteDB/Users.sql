CREATE TABLE [dbo].[Users]
(
	[Id] INT IDENTITY (1, 1) NOT NULL , 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Age] INT NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
)
