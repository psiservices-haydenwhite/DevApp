﻿CREATE PROCEDURE [dbo].[GetAllGames]
AS
SET NOCOUNT ON
BEGIN
	SELECT *
	FROM dbo.Games
END
GO