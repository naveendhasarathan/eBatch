CREATE TABLE [dbo].[Audit] (
    [ID]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [Type]       CHAR (1)       COLLATE Latin1_General_CI_AS NULL,
    [TableName]  NVARCHAR (128) COLLATE Latin1_General_CI_AS NULL,
    [PK]         INT            NULL,
    [FieldName]  NVARCHAR (128) COLLATE Latin1_General_CI_AS NULL,
    [OldValue]   NVARCHAR (MAX) COLLATE Latin1_General_CI_AS NULL,
    [NewValue]   NVARCHAR (MAX) COLLATE Latin1_General_CI_AS NULL,
    [UpdateDate] DATETIME2 (7)  DEFAULT (getdate()) NULL,
    [Username]   NVARCHAR (8)   COLLATE Latin1_General_CI_AS NULL,
    CONSTRAINT [PK_AuditB] PRIMARY KEY CLUSTERED ([ID] ASC)
);

