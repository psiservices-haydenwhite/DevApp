CREATE PROCEDURE [dbo].[DeleteDeveloper]
	@Id INT
AS
BEGIN
	DELETE FROM dbo.Developers
	WHERE Id = @Id
END
GO