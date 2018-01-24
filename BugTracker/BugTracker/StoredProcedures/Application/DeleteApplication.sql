CREATE PROCEDURE [dbo].[DeleteApplication]
	@AppID int
	
AS
	DELETE FROM Applications 
	WHERE AppID = @AppID;