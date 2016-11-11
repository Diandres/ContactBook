CREATE FUNCTION fx_Customers_ByCity
( @City nvarchar(15) )
RETURNS table
AS
RETURN (
        SELECT CompanyName
        FROM Customers
        WHERE City =@City
		 )
