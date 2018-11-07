CREATE TABLE [dbo].[tblEBatchDetails] (
    [Id]            INT             IdENTITY (1, 1) NOT NULL,
    [InvoiceId]     INT             NULL,
    [BatchId]       INT             NULL,
    [UserId]        INT             NULL,
    [Invoiceamount] MONEY           NULL,
    [refplan]       NVARCHAR (1000) NULL,
    [dealerplan]    NVARCHAR (1000) NULL,
    [items]         NVARCHAR (MAX)  NULL,
    [shipto]        NVARCHAR (MAX)  NULL,
    [CreatedBy]     INT             NULL,
    [CreatedDate]   DATETIME        NULL,
    [udpatedby]     INT             NULL,
    [UpdatedDate]   DATETIME        NULL,
    CONSTRAINT [PK_tblEBatchDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblEBatchDetails_tblBatch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[tblBatch] ([Id]),
    CONSTRAINT [FK_tblEBatchDetails_tblInvoice] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[tblInvoice] ([Id]),
    CONSTRAINT [FK_tblEBatchDetails_tblUsers] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id])
);

