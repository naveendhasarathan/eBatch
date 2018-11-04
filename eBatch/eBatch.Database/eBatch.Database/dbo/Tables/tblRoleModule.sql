CREATE TABLE [dbo].[tblRoleModule] (
    [id]           INT      IDENTITY (1, 1) NOT NULL,
    [roleid]       INT      NULL,
    [moduleid]     INT      NULL,
    [createdby]    INT      NULL,
    [createddate]  DATETIME NULL,
    [modifiedby]   INT      NULL,
    [modifieddate] DATETIME NULL,
    CONSTRAINT [PK_tblRoleModule] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblRoleModule_tblCodeValue] FOREIGN KEY ([roleid]) REFERENCES [dbo].[tblCodeValue] ([id]),
    CONSTRAINT [FK_tblRoleModule_tblCodeValue1] FOREIGN KEY ([moduleid]) REFERENCES [dbo].[tblCodeValue] ([id])
);

