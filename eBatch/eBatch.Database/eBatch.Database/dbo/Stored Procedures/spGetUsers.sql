CREATE procedure [dbo].[spGetUsers]
as 
begin
select a.id,a.username,a.difficult_level,a.active, b.userid ,b.roleid,c.codevalue as rolename from tblusers a inner join tbluser_role b
inner join tblCodeValue c on b.roleid=c.id on 
a.id=b.userid
end