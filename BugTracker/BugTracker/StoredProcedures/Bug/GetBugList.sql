CREATE PROCEDURE [dbo].[GetBugList]
	@AppID int,
	@Status int
AS

	BEGIN 
		IF (@Status != 0 OR @Status != 1)
			   SELECT DISTINCT b.BugID,b.AppID, b.UserID, bgl.StatusCodeID
			   ,b.BugDesc,b.BugDetails,b.RepSteps, b.FixDate
			   FROM Bugs b   
			   INNER JOIN BugLog bgl ON b.BugID = bgl.BugID
			   WHERE b.BugID = @AppID
			   And  bgl.StatusCodeID = @Status;

		ELSE 
				SELECT DISTINCT b.BugID,b.AppID, b.UserID, bgl.StatusCodeID
			   ,b.BugDesc,b.BugDetails,b.RepSteps, b.FixDate
			   FROM Bugs b   
			   INNER JOIN BugLog bgl ON b.BugID = bgl.BugID
			   WHERE b.BugID = @AppID;
			   
END
			