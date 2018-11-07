CREATE TABLE [dbo].[tblUser_module] (
    [UserId]      INT          NOT NULL,
    [moduleId]    VARCHAR (50) NOT NULL,
    [Status]      BIT          NULL,
    [CreatedDate] DATETIME     NULL,
    [CreatedBy]   INT          NULL,
    [UpdatedBy]   INT          NULL,
    [UpdatedDate] DATETIME     NULL,
    CONSTRAINT [FK_tblUser_module_tblUsers] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id])
);

