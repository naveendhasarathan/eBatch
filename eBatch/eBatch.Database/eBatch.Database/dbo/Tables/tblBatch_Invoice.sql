CREATE TABLE [dbo].[tblBatch_Invoice] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [batchid]     INT           NOT NULL,
    [invoiceid]   INT           NOT NULL,
    [status]      INT           NULL,
    [reason]      VARCHAR (MAX) NULL,
    [createdby]   INT           NULL,
    [createddate] DATETIME      NULL,
    [updatedby]   INT           NULL,
    [updateddate] DATETIME      NULL,
    CONSTRAINT [PK_tblBatch_Invoice] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblBatch_Invoice_tblCodeValue] FOREIGN KEY ([status]) REFERENCES [dbo].[tblCodeValue] ([id]),
    CONSTRAINT [FK_tblBatch_Invoice_tblInvoice] FOREIGN KEY ([invoiceid]) REFERENCES [dbo].[tblInvoice] ([id])
);

