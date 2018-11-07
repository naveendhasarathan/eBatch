CREATE TABLE [dbo].[tblUser_role] (
    [UserId] INT NOT NULL,
    [roleId] INT NOT NULL,
    CONSTRAINT [FK_tblUser_role_tblUsers] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id])
);

