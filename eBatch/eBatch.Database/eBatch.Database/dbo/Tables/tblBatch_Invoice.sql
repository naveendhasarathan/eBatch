CREATE TABLE [dbo].[tblBatch_Invoice] (
    [Id]          INT           IdENTITY (1, 1) NOT NULL,
    [BatchId]     INT           NOT NULL,
    [InvoiceId]   INT           NOT NULL,
    [Status]      INT           NULL,
    [reason]      VARCHAR (MAX) NULL,
    [CreatedBy]   INT           NULL,
    [CreatedDate] DATETIME      NULL,
    [UpdatedBy]   INT           NULL,
    [UpdatedDate] DATETIME      NULL,
    CONSTRAINT [PK_tblBatch_Invoice] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblBatch_Invoice_tblCodeValue] FOREIGN KEY ([Status]) REFERENCES [dbo].[tblCodeValue] ([Id]),
    CONSTRAINT [FK_tblBatch_Invoice_tblInvoice] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[tblInvoice] ([Id])
);

