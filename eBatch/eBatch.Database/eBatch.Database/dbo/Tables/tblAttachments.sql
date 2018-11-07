CREATE TABLE [dbo].[tblAttachments] (
    [Id]          INT             IdENTITY (1, 1) NOT NULL,
    [fileId]      INT             NOT NULL,
    [attachment]  VARBINARY (MAX) NULL,
    [CreatedDate] DATETIME        NULL,
    [CreatedBy]   INT             NULL,
    [udpatedby]   INT             NULL,
    [UpdatedDate] DATETIME        NULL,
    [Status]      BIT             NULL,
    CONSTRAINT [PK_tblAttachments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblAttachments_tblFilelist] FOREIGN KEY ([fileId]) REFERENCES [dbo].[tblFilelist] ([Id])
);

