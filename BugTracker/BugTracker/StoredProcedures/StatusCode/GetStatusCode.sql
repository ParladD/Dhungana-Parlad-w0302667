CREATE PROCEDURE [dbo].[GetStatusCode]
	
AS
	SELECT StatusCodeID, StatusCodeDesc 
	FROM statusCodes;

