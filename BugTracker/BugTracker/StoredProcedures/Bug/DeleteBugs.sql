CREATE PROCEDURE [dbo].[DeleteBugs]
	@BugID int --parameter

AS

	BEGIN  --begining the block
		SET NOCOUNT ON; --not counting anything

			BEGIN TRY -- begining transactio with try		
				BEGIN TRANSACTION 

				--deleting from the buglog table first because its a child table
					DELETE FROM BugLog
						WHERE BugID = @BugID;
				-- delteting from the bugs table	
					DELETE FROM Bugs 
						WHERE BugID = @BugID;

						COMMIT TRANSACTION; --committing the transations
			END TRY

			BEGIN CATCH -- if error than catching 
				
					IF @@TRANCOUNT > 0 --if no transcation is currently happing than rolling bcack
						ROLLBACK TRANSACTION;
			END CATCH; --end catch
					
    END; --end beginging
