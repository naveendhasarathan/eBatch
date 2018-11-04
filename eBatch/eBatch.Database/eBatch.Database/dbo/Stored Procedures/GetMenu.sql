create procedure GetMenu
(@userid int)
as begin
select userid,moduleid,modulename from
(select UR.userid ,RM.moduleid, cv.codevalue as modulename, cv.sortorder 
from tblUsers U 
JOIN  tbluser_role UR ON U.id= UR.userid
JOIN  tblrolemodule RM ON UR.roleid=RM.roleid
JOIN tblCodeValue cv ON cv.id= RM.moduleid
where u.id = @userid
UNION ALL
Select  userid, moduleid,  cv.codevalue as modulename,cv.sortorder from  tbluser_module um
JOIN tblCodeValue cv ON cv.id= um.moduleid
where um.userid = @userid) A
order by sortorder
end