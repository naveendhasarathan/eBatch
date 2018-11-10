CREATE PROCEDURE [dbo].[spSaveUserRoleMapping]
@UserRoleMappingTVP UserRoleMappingTVP READONLY,
@UserId int
AS 
BEGIN
--SET NOCOUNT ON 
SET NOCOUNT OFF;


MERGE  [dbo].[tbluser_module] TRG
USING @UserRoleMappingTVP SRC
ON (TRG.UserId = @UserId AND TRG.moduleid = SRC.id)
WHEN MATCHED AND TRG.Active <> SRC.IsActive
THEN

UPDATE SET TRG.Active = SRC.IsActive

WHEN NOT MATCHED  THEN

INSERT (userid,moduleid,active,createddate,createdby,updatedby,updateddate)
VALUES (@UserId, SRC.id, SRC.isActive,getdate(),1,1,getdate())
;
END