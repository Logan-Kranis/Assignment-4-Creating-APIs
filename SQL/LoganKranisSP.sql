use[SmartCrop] 
go
CREATE or Alter PROCEDURE [dbo].[GetWeatherByID]
    @WEATHER_ID int
AS
BEGIN
    SELECT * FROM [dbo].[Weather]
    WHERE [Id] = @WEATHER_ID;
END;
GO


CREATE or Alter PROCEDURE [dbo].[SelectFarmsByCity]
    @city NVARCHAR(MAX)
AS
BEGIN
    SELECT * FROM [dbo].[Farm]
    WHERE [city] = @city;
END;
GO
/*EXEC [dbo].[SelectFarmsByCity] @city = N'Farmville';
*/