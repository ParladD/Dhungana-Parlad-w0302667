CREATE PROCEDURE [dbo].[InsertApplication]
	@AppName varchar(40),
	@AppVersion varchar(40),
	@AppDesc varchar(255)
AS
	
	INSERT INTO Applications
	VALUES(@AppDesc, @AppVersion, @AppDesc);