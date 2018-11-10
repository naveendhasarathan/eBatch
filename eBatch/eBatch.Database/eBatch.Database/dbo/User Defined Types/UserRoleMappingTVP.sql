CREATE TYPE [dbo].[UserRoleMappingTVP] AS TABLE (
    [Id]         INT          NULL,
    [ModuleName] VARCHAR (50) NULL,
    [IsDefault]  BIT          NULL,
    [IsActive]   BIT          NULL);

