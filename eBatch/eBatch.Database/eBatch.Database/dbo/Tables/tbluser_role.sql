CREATE TABLE [dbo].[tbluser_role] (
    [userid] INT NOT NULL,
    [roleid] INT NOT NULL,
    CONSTRAINT [FK_tbluser_role_tblUsers] FOREIGN KEY ([userid]) REFERENCES [dbo].[tblUsers] ([id])
);

