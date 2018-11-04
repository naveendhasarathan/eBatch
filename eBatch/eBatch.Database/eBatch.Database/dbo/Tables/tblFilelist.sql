CREATE TABLE [dbo].[tblFilelist] (
    [id]          INT      NOT NULL,
    [supplierid]  INT      NULL,
    [receiptdate] DATETIME NULL,
    [createdby]   INT      NULL,
    [createddate] DATETIME NULL,
    [updatedby]   INT      NULL,
    [updateddate] DATETIME NULL,
    CONSTRAINT [PK_tblFilelist] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblFilelist_tblSupplier] FOREIGN KEY ([supplierid]) REFERENCES [dbo].[tblSupplier] ([id]),
    CONSTRAINT [FK_tblFilelist_tblSupplier1] FOREIGN KEY ([supplierid]) REFERENCES [dbo].[tblSupplier] ([id])
);

