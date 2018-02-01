CREATE PROCEDURE [dbo].[GetBug]
	@BugID int
AS
	SELECT bgl.BugLogDate, bgl.BugLogDesc, bgl.BugID, bgl.UserID, bgl.StatusCodeID
		   ,bug.BugDetails,bug.RepSteps, bug.FixDate,  s.StatusCodeDesc, u.UserName,
		   app.AppName, app.AppVersion, app.AppDesc

		   FROM Bugs bug 
		   INNER JOIN BugLog bgl ON bgl.BugID = bug.BugID
		   INNER JOIN Applications app ON app.AppID = bug.UserID
		   INNER JOIN Users u ON u.UserID = bgl.UserID
		   INNER JOIN statusCodes s ON s.StatusCodeID = bgl.StatusCodeID
		   WHERE bug.BugID = @BugID;


					
			
	