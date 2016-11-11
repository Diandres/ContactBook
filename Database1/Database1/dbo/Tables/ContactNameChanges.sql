CREATE TABLE [dbo].[ContactNameChanges] (
    [CustomerChangeID] INT           IDENTITY (1, 1) NOT NULL,
    [CustomerID]       NCHAR (50)    NOT NULL,
    [OldContactName]   NVARCHAR (30) NOT NULL,
    [NewContactName]   NVARCHAR (30) NOT NULL
);

