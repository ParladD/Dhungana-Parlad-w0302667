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
	INSERT INTO StatusCodes VALUES ('Unassigned');
	INSERT INTO StatusCodes VALUES ('In Progress');
	INSERT INTO StatusCodes VALUES ('Ready for Review');
	INSERT INTO StatusCodes VALUES ('Closed');
	INSERT INTO Applications VALUES ('D2L', '3.0','D2L is full of bugs');
	
END
