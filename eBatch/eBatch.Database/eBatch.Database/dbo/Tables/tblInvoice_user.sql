CREATE TABLE [dbo].[tblInvoice_User] (
    [Id]          INT      IdENTITY (1, 1) NOT NULL,
    [InvoiceId]   INT      NULL,
    [UserId]      INT      NULL,
    [Status]      INT      NULL,
    [Active]      BIT      NULL,
    [CreatedBy]   INT      NULL,
    [CreatedDate] DATETIME NULL,
    [UpdatedBy]   INT      NULL,
    [UpdatedDate] DATETIME NULL,
    CONSTRAINT [PK_tblInvoice_User] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblInvoice_User_tblBatch_Invoice] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[tblBatch_Invoice] ([Id]),
    CONSTRAINT [FK_tblInvoice_User_tblCodeValue] FOREIGN KEY ([Status]) REFERENCES [dbo].[tblCodeValue] ([Id]),
    CONSTRAINT [FK_tblInvoice_User_tblEBatchDetails] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[tblEBatchDetails] ([Id])
);

