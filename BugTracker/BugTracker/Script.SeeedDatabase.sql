/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS ( SELECT 1 FROM StatusCodes WHERE StatusCodeDesc = 'Unassigned')

BEGIN
	INSERT INTO StatusCodes VALUES ('Unassigned');
	INSERT INTO UserS VALUES ('ata','ata@yahoo.com','9025632312')
	INSERT INTO Applications VALUES ('microsoft','1.23','microsoft sucks')
	INSERT INTO Bugs Values(1,1,1,GETDATE(),'This bug is a test','is testing working','steps one',GETDATE());
	INSERT INTO BugLog Values(GETDATE(), 1, 1,'This bug is a test', 1);
	
	


END
