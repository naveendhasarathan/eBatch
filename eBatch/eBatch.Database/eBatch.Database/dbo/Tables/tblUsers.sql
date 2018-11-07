CREATE TABLE [dbo].[tblUsers] (
    [Id]              INT          IdENTITY (1, 1) NOT NULL,
    [UserName]        VARCHAR (50) NULL,
    [DifficultyLevel] INT          NULL,
    [Status]          BIT          NULL,
    [CreatedBy]       INT          NULL,
    [CreatedDate]     DATETIME     NULL,
    [UpdatedBy]       INT          NULL,
    [UpdatedDate]     DATETIME     NULL,
    CONSTRAINT [PK_tblUsersNew] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblUsers_tblCodeValue] FOREIGN KEY ([DifficultyLevel]) REFERENCES [dbo].[tblCodeValue] ([Id])
);

