CREATE TABLE [dbo].[tblSupplier] (
    [Id]              INT          NOT NULL,
    [SupplierName]    VARCHAR (50) NULL,
    [Email]           VARCHAR (50) NULL,
    [DifficultyLevel] INT          NULL,
    [Approval_Number] VARCHAR (50) NULL,
    [Status]          BIT          NULL,
    [Invoice_Type]    INT          NULL,
    [CreatedDate]     DATETIME     NULL,
    [CreatedBy]       INT          NULL,
    [UpdatedBy]       INT          NULL,
    [UpdatedDate]     DATETIME     NULL,
    CONSTRAINT [PK_tblSupplier] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblSupplier_tblCodeValue] FOREIGN KEY ([Invoice_Type]) REFERENCES [dbo].[tblCodeValue] ([Id]),
    CONSTRAINT [FK_tblSupplier_tblCodeValue_difflevel] FOREIGN KEY ([DifficultyLevel]) REFERENCES [dbo].[tblCodeValue] ([Id]),
    CONSTRAINT [FK_tblSupplier_tblCodeValue1] FOREIGN KEY ([DifficultyLevel]) REFERENCES [dbo].[tblCodeValue] ([Id])
);

