CREATE PROCEDURE [dbo].[GetUser]

AS

SELECT UserID,UserName,UserEmail, UserTel
FROM Users;