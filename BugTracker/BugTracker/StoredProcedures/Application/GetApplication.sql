CREATE PROCEDURE [dbo].[GetApplication]
	
AS
	SELECT AppID, AppName, AppVersion, AppDesc
	FROM Applications;