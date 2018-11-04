CREATE TABLE [dbo].[tblAttachments] (
    [id]          INT             IDENTITY (1, 1) NOT NULL,
    [fileid]      INT             NOT NULL,
    [attachment]  VARBINARY (MAX) NULL,
    [createddate] DATETIME        NULL,
    [createdby]   INT             NULL,
    [udpatedby]   INT             NULL,
    [updateddate] DATETIME        NULL,
    [active]      BIT             NULL,
    CONSTRAINT [PK_tblAttachments] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblAttachments_tblFilelist] FOREIGN KEY ([fileid]) REFERENCES [dbo].[tblFilelist] ([id])
);

