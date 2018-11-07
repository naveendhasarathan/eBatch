CREATE TABLE [dbo].[tblAuditTrail] (
    [Id]          BIGINT            IdENTITY (1, 1) NOT NULL,
    [TableName] VARCHAR(100) NULL, 
    [ColumnName] VARCHAR(100) NULL, 
    [RowIdentifier] INT NULL, 
    [OldValue] NVARCHAR(1000) NULL, 
    [NewValue] NVARCHAR(1000) NULL, 
    [Comment] NVARCHAR(MAX) NULL, 
    [ActionBy] INT NULL, 
    [ActionByName] VARCHAR(100) NULL, 
    [ActionDate] TIMESTAMP NULL, 
    [ActionType] VARCHAR(100) NULL, 
    CONSTRAINT [PK_tblAuditTrail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblAuditTrail_tblBatch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[tblBatch] ([Id]),
    CONSTRAINT [FK_tblAuditTrail_tblInvoice] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[tblInvoice] ([Id]),
    CONSTRAINT [FK_tblAuditTrail_tblUsers] FOREIGN KEY ([assignedto]) REFERENCES [dbo].[tblUsers] ([Id]),
    CONSTRAINT [FK_tblAuditTrail_tblUsers1] FOREIGN KEY ([assignedby]) REFERENCES [dbo].[tblUsers] ([Id]),
    CONSTRAINT [FK_tblAuditTrail_tblUsers2] FOREIGN KEY ([verifiedby]) REFERENCES [dbo].[tblUsers] ([Id])
);

