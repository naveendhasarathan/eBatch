CREATE procedure spSaveUsers
@UserId int=0,
@UserName varchar(50),
@RoleId int,
@DifficultyLevel int,
@Active bit
as 
begin

if(@UserId = 0)
begin
	insert into tblUsers (username,difficult_level,active) values
	(@UserName,@DifficultyLevel,@Active)
	insert into tbluser_role (userid,roleid)
	values(scope_identity(), @RoleId)
end
else
begin

	update tblUsers set username = @UserName, @DifficultyLevel =difficult_level, active = @Active where
	id =  @UserId
	update tbluser_role set roleid = @RoleId where userid= @UserId

end


end