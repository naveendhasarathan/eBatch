CREATE TABLE [dbo].[tblBatch] (
    [id]          INT      IDENTITY (1, 1) NOT NULL,
    [userid]      INT      NULL,
    [status]      INT      NULL,
    [createdby]   INT      NULL,
    [createddate] DATETIME NULL,
    [updatedby]   INT      NULL,
    [updateddate] DATETIME NULL,
    CONSTRAINT [PK_tblBatch] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblBatch_tblCodeValue] FOREIGN KEY ([status]) REFERENCES [dbo].[tblCodeValue] ([id]),
    CONSTRAINT [FK_tblBatch_tblUsers] FOREIGN KEY ([userid]) REFERENCES [dbo].[tblUsers] ([id]),
    CONSTRAINT [FK_tblBatch_tblUsers1] FOREIGN KEY ([userid]) REFERENCES [dbo].[tblUsers] ([id])
);

