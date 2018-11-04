CREATE TABLE [dbo].[tbluser_module] (
    [userid]      INT          NOT NULL,
    [moduleid]    VARCHAR (50) NOT NULL,
    [active]      BIT          NULL,
    [createddate] DATETIME     NULL,
    [createdby]   INT          NULL,
    [updatedby]   INT          NULL,
    [updateddate] DATETIME     NULL,
    CONSTRAINT [FK_tbluser_module_tblUsers] FOREIGN KEY ([userid]) REFERENCES [dbo].[tblUsers] ([id])
);

