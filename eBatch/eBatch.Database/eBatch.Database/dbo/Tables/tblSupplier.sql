CREATE TABLE [dbo].[tblSupplier] (
    [id]              INT          NOT NULL,
    [suppliername]    VARCHAR (50) NULL,
    [email]           VARCHAR (50) NULL,
    [difficult_level] INT          NULL,
    [approval_number] VARCHAR (50) NULL,
    [active]          BIT          NULL,
    [invoice_type]    INT          NULL,
    [createddate]     DATETIME     NULL,
    [createdby]       INT          NULL,
    [updatedby]       INT          NULL,
    [updateddate]     DATETIME     NULL,
    CONSTRAINT [PK_tblSupplier] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tblSupplier_tblCodeValue] FOREIGN KEY ([invoice_type]) REFERENCES [dbo].[tblCodeValue] ([id]),
    CONSTRAINT [FK_tblSupplier_tblCodeValue_difflevel] FOREIGN KEY ([difficult_level]) REFERENCES [dbo].[tblCodeValue] ([id]),
    CONSTRAINT [FK_tblSupplier_tblCodeValue1] FOREIGN KEY ([difficult_level]) REFERENCES [dbo].[tblCodeValue] ([id])
);

