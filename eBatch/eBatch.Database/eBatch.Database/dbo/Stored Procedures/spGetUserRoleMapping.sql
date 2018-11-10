CREATE procedure [dbo].[spGetUserRoleMapping]
(@userid int)
as begin

declare @tblModule table(
id int, modulename varchar(100),isdefault bit, active bit);

declare @tblDefaultMapping table(
userid int, moduleid int, modulename varchar(100), isDefault bit, Active bit
);

declare @tblCustomMapping table(
userid int, moduleid int, modulename varchar(100), isDefault bit, Active bit
);

insert into @tblModule
select cv.id Id, cv.codevalue as ModuleName,null,null from
tblCodeValue cv join tblCodeCategory tc on tc.id=cv.categoryid where tc.category ='module'

insert into @tblDefaultMapping
select UR.userid ,RM.moduleid, cv.codevalue as modulename, 1,1  Active
from tblUsers U 
JOIN  tbluser_role UR ON U.id= UR.userid
JOIN  tblrolemodule RM ON UR.roleid=RM.roleid
JOIN tblCodeValue cv ON cv.id= RM.moduleid

where u.id = @userid

insert into @tblCustomMapping
Select  um.userid, um.moduleid,  cv.codevalue as modulename,0, isnull(um.active,1) from  tbluser_module um
JOIN tblCodeValue cv ON cv.id= um.moduleid
where um.userid = @userid
order by sortorder


--select * from @tblModule
--select * from @tblDefaultMapping
--select * from @tblCustomMapping

select a.id as Id,a.modulename as ModuleName,isnull(b.isDefault,0) isDefault,
--b.active as b, c.active as c,
 case  
 when (b.active = 1 and c.active is null) then 1 
 when (b.Active = 1 and c.active =0) then 0 
 when (b.Active = 0 and c.active =1) then 1
 when (b.Active = 1 and c.active =1) then 1
 when (b.Active is null and c.active =1) then 1
 else 0
 end as IsActive

 from @tblModule a
left join @tblDefaultMapping b on a.id=b.moduleid
left join @tblCustomMapping c on a.id=c.moduleid




end