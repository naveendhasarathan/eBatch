CREATE TABLE [dbo].[tblCodeValue] (
    [Id]             INT           IdENTITY (1, 1) NOT NULL,
    [categoryId]     INT           NOT NULL,
    [codevalue]      VARCHAR (100) NULL,
    [description]    VARCHAR (100) NULL,
    [CreatedBy]      INT           NULL,
    [CreatedDate]    DATETIME      NULL,
    [UpdatedBy]      INT           NULL,
    [UpdatedDate]    DATETIME      NULL,
    [parentId]       INT           NULL,
    [codeShortValue] VARCHAR (10)  NULL,
    [sortorder]      INT           NULL,
    CONSTRAINT [PK_tblCodeValue] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblCodeValue_tblCodeCategory] FOREIGN KEY ([categoryId]) REFERENCES [dbo].[tblCodeCategory] ([Id])
);

