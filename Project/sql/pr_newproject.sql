CREATE PROCEDURE dbo.PR_NewProject
	@title        VARCHAR(20),
	@description  TEXT = NULL,
	@startdate    DATETIME,
	@enddate      DATETIME = NULL,
	@priority     INT,
	@leaderid     INT,
	@status       INT = NULL,
	@totalhours   TIME(0) = NULL,

	@p_result     INT OUTPUT,
	@p_projectID  INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION;

	BEGIN TRY
		INSERT INTO Projects (Title, Description, StartDate, EndDate, Priority, LeaderID, Status, TotalHours)
		VALUES (@title, @description, @startdate, @enddate, @priority, @leaderid, @status, @totalhours);

		SET @p_projectID = SCOPE_IDENTITY();
		SET @p_result = 1;

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		SET @p_result = ERROR_NUMBER();
	END CATCH
END;
GO
