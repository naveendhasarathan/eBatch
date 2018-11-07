CREATE TABLE [dbo].[tblRoleModule] (
    [Id]           INT      IdENTITY (1, 1) NOT NULL,
    [roleId]       INT      NULL,
    [moduleId]     INT      NULL,
    [CreatedBy]    INT      NULL,
    [CreatedDate]  DATETIME NULL,
    [modifiedby]   INT      NULL,
    [modifieddate] DATETIME NULL,
    CONSTRAINT [PK_tblRoleModule] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblRoleModule_tblCodeValue] FOREIGN KEY ([roleId]) REFERENCES [dbo].[tblCodeValue] ([Id]),
    CONSTRAINT [FK_tblRoleModule_tblCodeValue1] FOREIGN KEY ([moduleId]) REFERENCES [dbo].[tblCodeValue] ([Id])
);

