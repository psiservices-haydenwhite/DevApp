﻿CREATE PROCEDURE [dbo].[GetDeveloperById]
	@Id INT
AS
SET NOCOUNT ON
BEGIN
	SELECT *
	FROM dbo.Developers
	WHERE Id = @Id
END
GO