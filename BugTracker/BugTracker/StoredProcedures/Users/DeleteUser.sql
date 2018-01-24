CREATE PROCEDURE [dbo].[DeleteUser]
	@UserID int
	
AS

	DELETE FROM Users
	WHERE UserID = @UserID;
