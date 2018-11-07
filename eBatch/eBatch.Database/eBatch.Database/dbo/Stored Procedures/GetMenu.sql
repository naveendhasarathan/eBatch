create procedure GetMenu
(@UserId int)
as begin
select UserId,moduleId,moduleName from
(select UR.UserId ,RM.moduleId, cv.codevalue as moduleName, cv.sortorder 
from tblUsers U 
JOIN  tblUser_role UR ON U.Id= UR.UserId
JOIN  tblrolemodule RM ON UR.roleId=RM.roleId
JOIN tblCodeValue cv ON cv.Id= RM.moduleId
where u.Id = @UserId
UNION ALL
Select  UserId, moduleId,  cv.codevalue as moduleName,cv.sortorder from  tblUser_module um
JOIN tblCodeValue cv ON cv.Id= um.moduleId
where um.UserId = @UserId) A
order by sortorder
end