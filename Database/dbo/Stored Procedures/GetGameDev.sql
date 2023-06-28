CREATE PROCEDURE [dbo].[GetGameDev]
	@Name VARCHAR(50)
AS
SET NOCOUNT ON
BEGIN
	SELECT *
	FROM dbo.Developers
	WHERE Id = (SELECT DevId
				FROM dbo.Games
				WHERE Name = @Name)
END
GO