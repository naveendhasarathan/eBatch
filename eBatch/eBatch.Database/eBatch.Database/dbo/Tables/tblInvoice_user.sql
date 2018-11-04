CREATE TABLE [dbo].[tblInvoice_user] (
    [id]          INT      IDENTITY (1, 1) NOT NULL,
    [invoiceid]   INT      NULL,
    [userid]      INT      NULL,
    [status]      INT      NULL,
    [active]      BIT      NULL,
    [createdby]   INT      NULL,
    [createddate] DATETIME NULL,
    [updatedby]   INT      NULL,
    [updateddate] DATETIME NULL,
    CONSTRAINT [PK_tblInvoice_user] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblInvoice_user_tblBatch_Invoice] FOREIGN KEY ([invoiceid]) REFERENCES [dbo].[tblBatch_Invoice] ([id]),
    CONSTRAINT [FK_tblInvoice_user_tblCodeValue] FOREIGN KEY ([status]) REFERENCES [dbo].[tblCodeValue] ([id]),
    CONSTRAINT [FK_tblInvoice_user_tblEbatchDetails] FOREIGN KEY ([invoiceid]) REFERENCES [dbo].[tblEbatchDetails] ([id])
);

