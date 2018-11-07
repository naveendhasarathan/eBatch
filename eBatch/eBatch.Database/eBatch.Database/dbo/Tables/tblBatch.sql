CREATE TABLE [dbo].[tblBatch] (
    [Id]          INT      IdENTITY (1, 1) NOT NULL,
    [UserId]      INT      NULL,
    [Status]      INT      NULL,
    [CreatedBy]   INT      NULL,
    [CreatedDate] DATETIME NULL,
    [UpdatedBy]   INT      NULL,
    [UpdatedDate] DATETIME NULL,
    CONSTRAINT [PK_tblBatch] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblBatch_tblCodeValue] FOREIGN KEY ([Status]) REFERENCES [dbo].[tblCodeValue] ([Id]),
    CONSTRAINT [FK_tblBatch_tblUsers] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]),
    CONSTRAINT [FK_tblBatch_tblUsers1] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id])
);

