CREATE TABLE [dbo].[tblCodeCategory] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [category]    VARCHAR (50) NULL,
    [createdby]   INT          NULL,
    [createddate] DATETIME     NULL,
    [updatedby]   INT          NULL,
    [updateddate] DATETIME     NULL,
    CONSTRAINT [PK_tblCodeCategory] PRIMARY KEY CLUSTERED ([id] ASC)
);

