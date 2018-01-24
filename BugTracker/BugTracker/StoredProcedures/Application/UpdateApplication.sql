CREATE PROCEDURE [dbo].[UpdateApplication]
	@AppID int,
	@AppName varchar(40),
	@AppVersion varchar(40),
	@AppDesc varchar(255)
AS
	UPDATE Applications 
	SET AppName = @AppName,
	AppVersion = @AppVersion,
	AppDesc = @AppDesc
	WHERE AppID = @AppID;