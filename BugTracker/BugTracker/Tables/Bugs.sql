CREATE TABLE [dbo].[Bugs]
(
	[BugID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AppID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    [BugSignOff] INT NOT NULL, 
    [BugDate] DATETIME NOT NULL, 
    [BugDesc] VARCHAR(40) NOT NULL, 
    [BugDetails] NTEXT NOT NULL, 
    [RepSteps] NTEXT NOT NULL, 
    [FixDate] DATETIME NULL, 
    CONSTRAINT [PK_Applications] FOREIGN KEY (AppID) REFERENCES Applications(AppID), 
    CONSTRAINT [PK_Users] FOREIGN KEY (UserID) REFERENCES Users(UserID),
	CONSTRAINT [IdxUserName] FOREIGN KEY (BugSignOff) REFERENCES Users(UserID) 
);
