CREATE TABLE [dbo].[tblFilelist] (
    [Id]          INT      NOT NULL,
    [SupplierId]  INT      NULL,
    [receiptdate] DATETIME NULL,
    [CreatedBy]   INT      NULL,
    [CreatedDate] DATETIME NULL,
    [UpdatedBy]   INT      NULL,
    [UpdatedDate] DATETIME NULL,
    CONSTRAINT [PK_tblFilelist] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblFilelist_tblSupplier] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[tblSupplier] ([Id]),
    CONSTRAINT [FK_tblFilelist_tblSupplier1] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[tblSupplier] ([Id])
);

