CREATE PROCEDURE [dbo].[CustomerUpdate] (@CustomerID nchar(5), @CompanyName nvarchar(40), @ContactName nvarchar(30))
  AS
  UPDATE [dbo].[Customers]
   SET	[CompanyName] = @CompanyName,
   [ContactName] = @ContactName
     
 WHERE ([CustomerID]= @CustomerID)