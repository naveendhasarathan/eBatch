create procedure GetAccess (@UserName varchar(100)) as 
begin
select b.roleName,a.UserName from tblUsers a inner join tblRoles b on
a.UserRole = b.Id where UserName = @UserName
end