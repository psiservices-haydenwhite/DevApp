CREATE PROCEDURE [dbo].[UpdateDeveloper]
	@Id INT,
	@Name VARCHAR(50),
	@Founded DATE,
	@Headquarters VARCHAR(50) = NULL
AS
SET NOCOUNT ON
BEGIN
	UPDATE dbo.Developers
	SET Name = @Name, Founded = @Founded, Headquarters = @Headquarters
	WHERE Id = @Id
END
GO