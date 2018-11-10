CREATE TABLE [dbo].[tblAuditTrail] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [TableName]     VARCHAR (50)   NULL,
    [ColumnName]    VARCHAR (50)   NULL,
    [RowIdentifier] INT            NULL,
    [OldValue]      NVARCHAR (MAX) NULL,
    [NewValue]      NVARCHAR (MAX) NULL,
    [comments]      NVARCHAR (MAX) NULL,
    [createdby]     INT            NULL,
    [createddate]   DATETIME       NULL,
    CONSTRAINT [PK_tblAuditTrail] PRIMARY KEY CLUSTERED ([id] ASC)
);



