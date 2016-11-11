CREATE TABLE [dbo].[Order Details] (
    [OrderID]   INT      NOT NULL,
    [ProductID] INT      NOT NULL,
    [UnitPrice] MONEY    CONSTRAINT [DF_Order_Details_UnitPrice] DEFAULT (0) NOT NULL,
    [Quantity]  SMALLINT CONSTRAINT [DF_Order_Details_Quantity] DEFAULT (1) NOT NULL,
    [Discount]  REAL     CONSTRAINT [DF_Order_Details_Discount] DEFAULT (0) NOT NULL,
    CONSTRAINT [PK_Order_Details] PRIMARY KEY CLUSTERED ([OrderID] ASC, [ProductID] ASC),
    CONSTRAINT [CK_Discount] CHECK ([Discount] >= 0 and [Discount] <= 1),
    CONSTRAINT [CK_Quantity] CHECK ([Quantity] > 0),
    CONSTRAINT [CK_UnitPrice] CHECK ([UnitPrice] >= 0),
    CONSTRAINT [FK_Order_Details_Orders] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([OrderID]),
    CONSTRAINT [FK_Order_Details_Products] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ProductID])
);


GO
CREATE NONCLUSTERED INDEX [OrderID]
    ON [dbo].[Order Details]([OrderID] ASC);


GO
CREATE NONCLUSTERED INDEX [OrdersOrder_Details]
    ON [dbo].[Order Details]([OrderID] ASC);


GO
CREATE NONCLUSTERED INDEX [ProductID]
    ON [dbo].[Order Details]([ProductID] ASC);


GO
CREATE NONCLUSTERED INDEX [ProductsOrder_Details]
    ON [dbo].[Order Details]([ProductID] ASC);


GO
-- =============================================
-- Author:		Andres
-- Create date: 
-- Description:	
-- =============================================
CREATE TRIGGER UpdateProductUnitInStock 
   ON  [Order Details] 
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

UPDATE    Products
SET    UnitsInStock =( [UnitsInStock] - i.Quantity)
FROM   Products INNER JOIN
       [Order Details] ON Products.ProductID = [Order Details].ProductID INNER JOIN
       inserted i ON [Order Details].ProductID = i.ProductID

END


GO
-- =============================================
-- Author:		Andres
-- Create date: 
-- Description:	
-- =============================================
CREATE TRIGGER UpdateProductUnitInStockAfterUpdate
   ON  [Order Details] 
   AFTER UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

	
	UPDATE    Products
	SET    UnitsInStock =( [UnitsInStock] - (i.Quantity-d.Quantity))
	FROM   Products INNER JOIN  inserted i ON Products.ProductID = i.ProductID 
		   INNER JOIN	deleted d ON i.ProductID=d.ProductID

END


GO
-- =============================================
-- Author:		Andres Hurtado
-- Create date: 
-- Description:	
-- =============================================
CREATE TRIGGER UpdateProductUnitInStockAfterDelete
   ON  [Order Details] 
   AFTER DELETE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

		
	UPDATE    Products
	SET    UnitsInStock =( [UnitsInStock] + d.Quantity)
	FROM   Products p INNER JOIN	deleted d ON p.ProductID=d.ProductID
END

GO
CREATE TRIGGER [OrderDetailsDeleteTrigger]
ON [dbo].[Order Details]
FOR DELETE
AS
BEGIN
    SET NOCOUNT ON
    UPDATE [dbo].[Products]
      SET [UnitsInStock]=[UnitsInStock]+d.[Quantity]
      FROM deleted d
        INNER JOIN [dbo].[Products] p ON p.[ProductID]=d.[ProductID]
END
GO
CREATE TRIGGER [OrderDetailsInsertTrigger]
ON [dbo].[Order Details]
FOR INSERT
AS
BEGIN
    SET NOCOUNT ON
    UPDATE [dbo].[Products]
      SET [UnitsInStock]=[UnitsInStock]-i.[Quantity]
      FROM inserted i
        INNER JOIN [dbo].[Products] p ON p.[ProductID]=i.[ProductID]
END
GO
CREATE TRIGGER [OrderDetailsUpdateTrigger]
ON [dbo].[Order Details]
FOR UPDATE
AS
BEGIN
    SET NOCOUNT ON
    UPDATE [dbo].[Products]
      SET [UnitsInStock]=[UnitsInStock]-(i.[Quantity]-d.[Quantity])
      FROM inserted i
        INNER JOIN deleted d ON i.[OrderID]=d.[OrderID] AND i.[ProductID]=d.[ProductID]
        INNER JOIN [dbo].[Products] p ON p.[ProductID]=i.[ProductID]
END