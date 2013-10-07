﻿CREATE TABLE [dbo].[Event]
(
	[UUID] NVARCHAR(50) NOT NULL , 
    [Type] NVARCHAR(50) NOT NULL, 
    [Key] NVARCHAR(50) NOT NULL, 
    [Value] NVARCHAR(50) NOT NULL, 
    [CreatedAt] TIME NOT NULL, 
    CONSTRAINT [PK_Event] PRIMARY KEY ([UUID]) 
)
