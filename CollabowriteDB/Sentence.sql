﻿CREATE TABLE [dbo].[Sentence]
(
	[UUID] NVARCHAR(50) NOT NULL , 
    [StoryUUID] NVARCHAR(50) NOT NULL, 
    [Text] NVARCHAR(MAX) NOT NULL, 
    [UserUUID] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Sentence] PRIMARY KEY ([UUID])
)