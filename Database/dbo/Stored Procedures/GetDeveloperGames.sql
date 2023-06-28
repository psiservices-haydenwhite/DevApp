CREATE PROCEDURE [dbo].[GetDeveloperGames]
	@Name VARCHAR(50),
	@Rating VARCHAR(10) NULL
AS
SET NOCOUNT ON
BEGIN
	IF @Rating = 'All'
	BEGIN
	SELECT *
	FROM dbo.Games
	WHERE DevId = (SELECT Id
				   FROM dbo.Developers
				   WHERE Name = @Name)
	END
	ELSE
	BEGIN
	SELECT *
	FROM dbo.Games
	WHERE DevId = (SELECT Id
				   FROM dbo.Developers
				   WHERE Name = @Name AND ESRBRating = @Rating)
	END
END
GO