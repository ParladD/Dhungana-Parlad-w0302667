CREATE PROCEDURE [dbo].[InsertUser]
	@UserName varchar(80),
	@UserEmail varchar(80),
	@UserTel varchar(40) 
AS
	INSERT INTO Users
	VALUES(@UserName, @UserEmail, @UserTel);