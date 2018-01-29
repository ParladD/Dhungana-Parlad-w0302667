CREATE PROCEDURE [dbo].[UserConfirmation]
	@UserName varchar(80)
AS
	SELECT UserName, UserEmail, UserTel FROM Users
	WHERE UserName = @UserName;
