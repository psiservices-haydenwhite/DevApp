CREATE PROCEDURE [dbo].[UpdateGame]
	@Name VARCHAR(50),
	@Developer VARCHAR(50),
	@ReleaseDate DATE,
	@ESRBRating VARCHAR(10)
AS
SET NOCOUNT ON
BEGIN
	UPDATE dbo.Games
	SET DevId = (SELECT Id
				 FROM dbo.Developers
				 WHERE Name = @Developer),
		Name = @Name,
		Developer = @Developer,
		ReleaseDate = @ReleaseDate,
		ESRBRating = @ESRBRating
	WHERE Name = @Name
END
GO