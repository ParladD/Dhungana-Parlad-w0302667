CREATE TABLE [dbo].[BugLog]
(
	[BugLogID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BugLogDate] DATETIME NOT NULL, 
    [StatusCodeID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    [BugLogDesc] TEXT NOT NULL, 
    [BugID] INT NOT NULL, 
    CONSTRAINT [PK_StatusCodes] FOREIGN KEY (StatusCodeID) REFERENCES StatusCodes(StatusCodeID), 
    CONSTRAINT [PK_Users_id] FOREIGN KEY (UserID) REFERENCES Users(UserID), 
    CONSTRAINT [PK_Bugs] FOREIGN KEY (BugID) REFERENCES Bugs(BugID) 
);
