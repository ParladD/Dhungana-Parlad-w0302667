﻿CREATE TABLE [dbo].[Users]
(
	[UserID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] VARCHAR(80) NOT NULL, 
    [UserEmail] VARCHAR(80) NOT NULL, 
    [UserTel] VARCHAR(40) NOT NULL,
	
);
