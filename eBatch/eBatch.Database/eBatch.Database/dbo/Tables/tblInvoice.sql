CREATE TABLE [dbo].[tblInvoice] (
    [Id]          INT          IdENTITY (1, 1) NOT NULL,
    [SupplierId]  INT          NULL,
    [InvoiceName] VARCHAR (50) NULL,
    [CreatedBy]   INT          NULL,
    [CreatedDate] DATETIME     NULL,
    [UpdatedBy]   INT          NULL,
    [UpdatedDate] DATETIME     NULL,
    CONSTRAINT [PK_tblInvoice] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblInvoice_tblSupplier] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[tblSupplier] ([Id])
);

