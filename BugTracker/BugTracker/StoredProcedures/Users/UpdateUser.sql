CREATE PROCEDURE [dbo].[UpdateUser]

	@UserID int,
	@UserName varchar(80),
	@UserEmail varchar(80),
	@UserTel varchar(40)
AS
	UPDATE Users 
	SET UserName = @UserName, 
	UserEmail = @UserEmail,
	UserTel = @UserTel
	WHERE UserID = @UserID;
