CREATE PROCEDURE [dbo].[UserConfirmation]
	@UserName varchar(80),
	@Exits bit OUTPUT
	

AS

BEGIN

	IF EXISTS (SELECT UserName FROM Users
	WHERE UserName = @UserName)
	
		SET @Exits = 1;

	ELSE
		SET @Exits = 0;

END;


	
 
 
 