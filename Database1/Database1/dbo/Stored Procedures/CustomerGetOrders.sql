CREATE PROCEDURE CustomerGetOrders
AS
	SELECT        Customers.CompanyName, Customers.ContactName, Orders.OrderID
FROM            Customers INNER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID
