CREATE PROCEDURE [dbo].[GetAllDevelopers]
	@PageIndex INT = 1,
	@PageSize INT = 10
AS
SET NOCOUNT ON
BEGIN
	SELECT *
	FROM dbo.Developers
	ORDER BY Name
	OFFSET (@PageIndex - 1)*@PageSize ROWS FETCH NEXT @PageSize ROWS ONLY;
END
GO