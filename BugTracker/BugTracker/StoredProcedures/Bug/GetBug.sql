CREATE PROCEDURE [dbo].[GetBug]
	
AS
	SELECT bgl.BugDate, bgl.BugDesc, bug.BugDetails, bug.RepSteps, bug.FixDate
		   ,bgl.BugLogDesc, 
	
	