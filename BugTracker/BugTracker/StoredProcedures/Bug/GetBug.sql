CREATE PROCEDURE [dbo].[GetBug]
	@BugID int
AS
	
	SELECT bgl.BugLogDate, bgl.BugLogDesc, b.BugID,b.AppID, b.UserID, bgl.StatusCodeID
		   ,b.BugDetails,b.RepSteps, b.FixDate,  bgl.StatusCodeID
		   FROM Bugs b
		   INNER JOIN BugLog bgl ON b.BugID = bgl.BugID
		   WHERE b.BugID = @BugID;


					
			
	