create procedure GetAccess (@username varchar(100)) as 
begin
select b.rolename,a.username from tblusers a inner join tblRoles b on
a.UserRole = b.id where username = @username
end