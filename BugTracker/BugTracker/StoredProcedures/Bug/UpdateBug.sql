CREATE PROCEDURE [dbo].[UpdateBug]
	@AppID int,
	@UserID int,
	@BugSignOff int,
	@BugDate datetime,
	@BugDesc varchar(40),
	@BugDetails text,
	@RepSteps text,
	@FixDate datetime,
	@BugID int,
	@StatusCodeID int
AS
	
	BEGIN 
		SET NOCOUNT ON;
			BEGIN TRY		
				BEGIN TRANSACTION 
					
						UPDATE Bugs SET
							
								AppID = @AppID,
								UserID = @UserID,
								BugSignOff = @BugSignOff,
								BugDate = @BugDate,
								BugDesc = @BugDesc,
								BugDetails = @BugDetails,
								RepSteps = @RepSteps, 
								@FixDate = @FixDate
								WHERE BugID = @BugID;

						INSERT INTO BugLog 
						VALUES(GETdATE(), @StatusCodeID, @UserID, @BugDesc, @BugID);

						COMMIT TRANSACTION;
			END TRY

			BEGIN CATCH
				
					IF @@TRANCOUNT > 0
						ROLLBACK TRANSACTION
			END CATCH;
					
    END;



							
				
