CREATE TABLE [dbo].[tblInvoice] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [supplierid]  INT          NULL,
    [invoicename] VARCHAR (50) NULL,
    [createdby]   INT          NULL,
    [createddate] DATETIME     NULL,
    [updatedby]   INT          NULL,
    [updateddate] DATETIME     NULL,
    CONSTRAINT [PK_tblInvoice] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblInvoice_tblSupplier] FOREIGN KEY ([supplierid]) REFERENCES [dbo].[tblSupplier] ([id])
);

