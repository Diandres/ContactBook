CREATE PROCEDURE UpdateProductPrice (@ProductID int, @UnitPrice money)
  AS
  UPDATE [dbo].[Products]
   SET	[UnitPrice] = @UnitPrice
        
 WHERE ([ProductID]= @ProductID)