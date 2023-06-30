CREATE PROCEDURE [dbo].[AddGame]
	@Name VARCHAR(50),
	@Developer VARCHAR(50),
	@ReleaseDate DATE,
	@ESRBRating VARCHAR(10)
AS
SET NOCOUNT ON
BEGIN
	INSERT INTO dbo.Games(DevId, Name, Developer, ReleaseDate, ESRBRating)
	VALUES ((SELECT Id
			 FROM dbo.Developers u
			 WHERE u.Name = @Developer), 
			 @Name, 
			 @Developer, 
			 @ReleaseDate, 
			 @ESRBRating)
END
GO