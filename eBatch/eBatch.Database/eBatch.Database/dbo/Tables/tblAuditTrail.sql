CREATE TABLE [dbo].[tblAuditTrail] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [batchid]     INT            NULL,
    [invoiceid]   INT            NULL,
    [assignedto]  INT            NULL,
    [assignedby]  INT            NULL,
    [status]      INT            NULL,
    [verifiedby]  INT            NULL,
    [comments]    NVARCHAR (MAX) NULL,
    [createdby]   INT            NULL,
    [createddate] DATETIME       NULL,
    CONSTRAINT [PK_tblAuditTrail] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblAuditTrail_tblBatch] FOREIGN KEY ([batchid]) REFERENCES [dbo].[tblBatch] ([id]),
    CONSTRAINT [FK_tblAuditTrail_tblInvoice] FOREIGN KEY ([invoiceid]) REFERENCES [dbo].[tblInvoice] ([id]),
    CONSTRAINT [FK_tblAuditTrail_tblUsers] FOREIGN KEY ([assignedto]) REFERENCES [dbo].[tblUsers] ([id]),
    CONSTRAINT [FK_tblAuditTrail_tblUsers1] FOREIGN KEY ([assignedby]) REFERENCES [dbo].[tblUsers] ([id]),
    CONSTRAINT [FK_tblAuditTrail_tblUsers2] FOREIGN KEY ([verifiedby]) REFERENCES [dbo].[tblUsers] ([id])
);

