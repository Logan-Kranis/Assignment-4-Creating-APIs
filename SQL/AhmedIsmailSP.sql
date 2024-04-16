CREATE or ALTER PROCEDURE [dbo].[UpdateFarm]
    @FARM_ID INT,
    @address NVARCHAR(MAX),
    @zipcode NVARCHAR(MAX),
    @city NVARCHAR(MAX),
    @state NVARCHAR(MAX),
    @name NVARCHAR(MAX)
AS
BEGIN
    UPDATE [dbo].[farm]
    SET [address] = @address,
        [zipcode] = @zipcode,
        [city] = @city,
        [state] = @state,
        [name] = @name
    WHERE [FARM_ID] = @FARM_ID;
END;
GO

CREATE or ALTER PROCEDURE [dbo].[DeleteFarm]
    @FARM_ID INT
AS
BEGIN
    DELETE FROM [dbo].[farm]
    WHERE [FARM_ID] = @FARM_ID;
END;
GO
