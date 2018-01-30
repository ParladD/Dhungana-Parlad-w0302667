CREATE PROCEDURE [dbo].[DeleteBugs]
	@BugID int

AS

	BEGIN 
		SET NOCOUNT ON;

			BEGIN TRY		
				BEGIN TRANSACTION 

					DELETE FROM BugLog
						WHERE BugID = @BugID;
					
					DELETE FROM Bugs 
						WHERE BugID = @BugID;

						COMMIT TRANSACTION;
			END TRY

			BEGIN CATCH
				
					IF @@TRANCOUNT > 0
						ROLLBACK TRANSACTION
			END CATCH;
					
    END;
