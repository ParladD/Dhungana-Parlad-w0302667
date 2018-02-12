CREATE PROCEDURE [dbo].[DataTableProcedure]
		@bugId int
AS
	
	SELECT b.BugLogDate, b.BugLogDesc, u.UserName, s.StatusCodeDesc
		   FROM BugLog b
		   INNER JOIN Users u ON b.UserID = b.UserID
		   INNER JOIN StatusCodes s ON s.StatusCodeID = b.StatusCodeID
		   WHERE b.BugLogID = @bugId;