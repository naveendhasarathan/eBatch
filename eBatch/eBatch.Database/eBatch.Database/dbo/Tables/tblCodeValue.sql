CREATE TABLE [dbo].[tblCodeValue] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [categoryid]     INT           NOT NULL,
    [codevalue]      VARCHAR (100) NULL,
    [description]    VARCHAR (100) NULL,
    [createdby]      INT           NULL,
    [createddate]    DATETIME      NULL,
    [updatedby]      INT           NULL,
    [updateddate]    DATETIME      NULL,
    [parentId]       INT           NULL,
    [codeShortValue] VARCHAR (10)  NULL,
    [sortorder]      INT           NULL,
    CONSTRAINT [PK_tblCodeValue] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblCodeValue_tblCodeCategory] FOREIGN KEY ([categoryid]) REFERENCES [dbo].[tblCodeCategory] ([id])
);

