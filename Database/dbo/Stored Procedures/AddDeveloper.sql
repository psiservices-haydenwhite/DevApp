CREATE PROCEDURE [dbo].[AddDeveloper]
	@Name VARCHAR(50),
	@Founded DATE,
	@Headquarters VARCHAR(50) = NULL
AS
SET NOCOUNT ON
BEGIN
	INSERT INTO dbo.Developers(Name, Founded, Headquarters)
	VALUES (@Name, @Founded, @Headquarters)
END
GO