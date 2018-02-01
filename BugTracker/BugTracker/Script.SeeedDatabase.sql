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

--IF NOT EXISTS ( SELECT 1 FROM StatusCodes WHERE StatusCodeDesc = 'Unassigned')

BEGIN
----	INSERT INTO StatusCodes VALUES ('Unassigned');
	---INSERT INTO StatusCodes VALUES ('In Progress');
	
	INSERT Bugs Values(1,1,1,GETDATE(),'This bug is a test','is testing working','steps one',GETDATE());
	INSERT BugLog Values(GETDATE(), 1, 1,'This bug is a test', 1);
	INSERT Users Values('Adil','adil@yahoo.com','9024567778');
	INSERT Applications Values('microsoft','1.0','new made app');


	
	INSERT Bugs Values(2,2,2,GETDATE(),'The second test','second test for facebok','no stepes needs',GETDATE());
	INSERT BugLog Values(GETDATE(), 2, 2,'The second test', 2);
	INSERT Users Values('Ata','ata@yahoo.com','9024511178');
	INSERT Applications Values('facebook','3.0','fb makes lots of money');
	
END
