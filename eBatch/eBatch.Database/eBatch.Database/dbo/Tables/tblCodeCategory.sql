CREATE TABLE [dbo].[tblCodeCategory] (
    [Id]          INT          IdENTITY (1, 1) NOT NULL,
    [category]    VARCHAR (50) NULL,
    [CreatedBy]   INT          NULL,
    [CreatedDate] DATETIME     NULL,
    [UpdatedBy]   INT          NULL,
    [UpdatedDate] DATETIME     NULL,
    CONSTRAINT [PK_tblCodeCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

