CREATE PROCEDURE SkapaRegionReturnRegionId (@RegionDescription nchar(50), @TerritoryID nvarchar(20), @TerritoryDescription nchar(50), @RegionenID int OUTPUT)
AS
DECLARE @theRegionID INT
Select @theRegionID =  MAX(RegionID)+1 FROM Region
INSERT INTO [dbo].[Region]
           ([RegionID],
		   [RegionDescription])
     VALUES
           (@theRegionID,
		    @RegionDescription)
		 
			
 INSERT INTO [dbo].[Territories]
           ([TerritoryID]
           ,[TerritoryDescription]
           ,[RegionID])
     VALUES
           (@TerritoryID,
            @TerritoryDescription,
            @theRegionID)	

SELECT @RegionenID = MAX(RegionID) FROM Region
