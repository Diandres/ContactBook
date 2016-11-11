﻿CREATE FUNCTION fx_OrdersByDateRangeAndCount
( @OrderDateStart smalldatetime, 
  @OrderDateEnd smalldatetime, 
  @OrderCount smallint )
RETURNS @OrdersByDateRange TABLE
  (  CustomerID nchar(5),
     CompanyName nvarchar(40),
     OrderCount smallint,
     Ranking char(1) )
AS
BEGIN
 --Statement 1
 INSERT @OrdersByDateRange
 SELECT a.CustomerID,
        a.CompanyName,
        COUNT(a.CustomerID)AS OrderCount,
       'B'
 FROM Customers a
 JOIN Orders b ON a.CustomerID =b.CustomerID
 WHERE OrderDate BETWEEN @OrderDateStart AND @OrderDateEnd
 GROUP BY a.CustomerID,a.CompanyName
 HAVING COUNT(a.CustomerID)>@OrderCount

--Statement 2
UPDATE @OrdersByDateRange
SET Ranking ='A'
WHERE CustomerID IN (SELECT TOP 5 WITH TIES CustomerID
                     FROM (SELECT a.CustomerID,
                                  COUNT(a.CustomerID)AS OrderTotal
                           FROM Customers a
                           JOIN Orders b ON a.CustomerID =b.CustomerID
                           GROUP BY a.CustomerID) AS DerivedTable
                           ORDER BY OrderTotal DESC)
RETURN
END