CREATE TABLE [dbo].[tblEbatchDetails] (
    [id]            INT             IDENTITY (1, 1) NOT NULL,
    [invoiceid]     INT             NULL,
    [batchid]       INT             NULL,
    [userid]        INT             NULL,
    [invoiceamount] MONEY           NULL,
    [refplan]       NVARCHAR (1000) NULL,
    [dealerplan]    NVARCHAR (1000) NULL,
    [items]         NVARCHAR (MAX)  NULL,
    [shipto]        NVARCHAR (MAX)  NULL,
    [createdby]     INT             NULL,
    [createddate]   DATETIME        NULL,
    [udpatedby]     INT             NULL,
    [updateddate]   DATETIME        NULL,
    CONSTRAINT [PK_tblEbatchDetails] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblEbatchDetails_tblBatch] FOREIGN KEY ([batchid]) REFERENCES [dbo].[tblBatch] ([id]),
    CONSTRAINT [FK_tblEbatchDetails_tblInvoice] FOREIGN KEY ([invoiceid]) REFERENCES [dbo].[tblInvoice] ([id]),
    CONSTRAINT [FK_tblEbatchDetails_tblUsers] FOREIGN KEY ([userid]) REFERENCES [dbo].[tblUsers] ([id])
);

