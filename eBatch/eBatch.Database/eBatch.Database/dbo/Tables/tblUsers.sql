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






GO
CREATE trigger tblTriggerAuditRecord on tblUsers
after update,insert
as
begin


IF EXISTS (SELECT 1 FROM inserted)
BEGIN
  IF EXISTS (SELECT 1 FROM deleted)
  BEGIN
  INSERT INTO dbo.Audit ([Type], TableName, PK, FieldName, OldValue, NewValue, Username)
      SELECT 
            CASE  WHEN NOT EXISTS (SELECT ID FROM deleted WHERE ID = ISNULL(ins.PK,del.PK)) THEN 'I' 
                WHEN NOT EXISTS (SELECT ID FROM inserted WHERE ID = ISNULL(ins.PK,del.PK)) THEN 'D' 
                  ELSE 'U' END as [Type],
            'tblUsers' as TableName, 
            ISNULL(ins.PK,del.PK) as PK,
            ISNULL(ins.FieldName,del.FieldName) as FieldName,
            del.FieldValue as OldValue,
            ins.FieldValue as NewValue,
            ISNULL(ins.Username,del.Username) as Username 
FROM (SELECT
      insRowTbl.PK,
      insRowTbl.Username,
      attr.insRow.value('local-name(.)', 'nvarchar(128)') as FieldName,
      attr.insRow.value('.', 'nvarchar(max)') as FieldValue
  FROM (Select
            i.ID as PK,
            i.updatedby as Username,
            convert(xml, (select i.* for xml raw)) as insRowCol
        from inserted as i
       ) as insRowTbl
       CROSS APPLY insRowTbl.insRowCol.nodes('/row/@*') as attr(insRow)
  ) as ins
FULL OUTER JOIN (SELECT
      delRowTbl.PK,
      delRowTbl.Username,
      attr.delRow.value('local-name(.)', 'nvarchar(128)') as FieldName,
      attr.delRow.value('.', 'nvarchar(max)') as FieldValue
  FROM (Select      
               d.ID as PK,
               d.updatedby as Username,
               convert(xml, (select d.* for xml raw)) as delRowCol
         from deleted as d
         ) as delRowTbl
        CROSS APPLY delRowTbl.delRowCol.nodes('/row/@*') as attr(delRow)
      ) as del
            on ins.PK = del.PK and ins.FieldName = del.FieldName
 WHERE 
      isnull(ins.FieldName,del.FieldName) not in ('updatedby', 'ID', 'TimeStamp') 
 and  ((ins.FieldValue is null and del.FieldValue is not null) 
      or (ins.FieldValue is not null and del.FieldValue is null) 
      or (ins.FieldValue != del.FieldValue))

  END
  ELSE
  BEGIN
    -- I am an insert
	  INSERT INTO dbo.Audit ([Type], TableName, PK, FieldName, OldValue, NewValue, Username)
select 'I','tblUsers',auditrec.PK,auditrec.FieldName,null,auditrec.FieldValue,auditrec.Username from 
(
SELECT
      insRowTbl.PK,
      insRowTbl.Username,
      attr.insRow.value('local-name(.)', 'nvarchar(128)') as FieldName,
      attr.insRow.value('.', 'nvarchar(max)') as FieldValue
  FROM (Select
            i.ID as PK,
            i.updatedby as Username,
            convert(xml, (select i.* for xml raw)) as insRowCol
        from inserted as i
       ) as insRowTbl
       CROSS APPLY insRowTbl.insRowCol.nodes('/row/@*') as attr(insRow) ) auditrec
	   where FieldName in ('username')--,'difficult_level','active')


  END
END
--ELSE
--BEGIN
--  -- I am a delete
--END
end