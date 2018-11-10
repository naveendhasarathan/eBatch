CREATE TABLE [dbo].[tblUsers] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [username]        VARCHAR (50) NULL,
    [difficult_level] INT          NULL,
    [active]          BIT          NULL,
    [createdby]       INT          NULL,
    [createddate]     DATETIME     NULL,
    [updatedby]       INT          NULL,
    [updateddate]     DATETIME     NULL,
    CONSTRAINT [PK_tblUsersNew] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblUsers_tblCodeValue] FOREIGN KEY ([difficult_level]) REFERENCES [dbo].[tblCodeValue] ([id])
);



