CREATE PROCEDURE [dbo].[GetGameByName]
	@Name VARCHAR(50),
	@Developer VARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.Games
	WHERE Name = @Name AND Developer = @Developer
END
GO