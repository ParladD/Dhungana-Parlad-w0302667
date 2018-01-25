CREATE PROCEDURE [dbo].[InsertBug]
	@AppID int,
	@UserID int,
	@BugSignOff int,
	@BugDate datetime,
	@BugDesc varchar(40),
	@BugDetails text,
	@RepSteps text,
	@FixDate datetime,
	@StatusCodeID int
AS
	--DECLARE @BugID int = 1 + (SELECT MAX(BugID) FROM Bugs);
	DECLARE @BugID int;

	BEGIN 
		SET NOCOUNT ON;

			BEGIN TRY		
				BEGIN TRANSACTION 
					
						INSERT INTO Bugs
						VALUES(@AppID,@UserID,@BugSignOff,@BugDate,@BugDesc,@BugDetails,@RepSteps,@FixDate);

							SET @BugID = SCOPE_IDENTITY()

						INSERT INTO BugLog 
						VALUES(@BugDate, @StatusCodeID, @UserID, @BugDesc, @BugID);

						COMMIT TRANSACTION;
			END TRY

			BEGIN CATCH
				
					IF @@TRANCOUNT > 0
						ROLLBACK TRANSACTION
			END CATCH;
					
    END;