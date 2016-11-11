CREATE TABLE [dbo].[ProductPriceChanges] (
    [ProductPriceChangeID] INT           IDENTITY (1, 1) NOT NULL,
    [ProductID]            INT           NOT NULL,
    [NewPrice]             MONEY         NULL,
    [OldPrice]             MONEY         NULL,
    [ChangedDate]          DATETIME      NULL,
    [UserId]               NVARCHAR (20) NULL
);

