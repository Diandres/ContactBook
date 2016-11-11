CREATE PROCEDURE CustomerGetOrders1 @CustomerID nchar(5)
AS
	SELECT        Customers.CompanyName, Customers.ContactName, Orders.OrderID
FROM            Customers INNER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID
WHERE Customers.CustomerID=@CustomerID
