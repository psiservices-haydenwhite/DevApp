CREATE PROCEDURE [dbo].[GetDeveloperByName]
	@Name VARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.Developers
	WHERE Name = @Name
END
GO