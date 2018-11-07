CREATE procedure spSaveUsers
@UserId int=0,
@UserName varchar(50),
@RoleId int,
@DifficultyLevel int,
@Status bit
as 
begin

if(@UserId = 0)
begin
	insert into tblUsers (UserName,DifficultyLevel,Status) values
	(@UserName,@DifficultyLevel,@Status)
	insert into tblUser_role (UserId,roleId)
	values(scope_Identity(), @RoleId)
end
else
begin

	update tblUsers set UserName = @UserName, @DifficultyLevel =DifficultyLevel, Status = @Status where
	Id =  @UserId
	update tblUser_role set roleId = @RoleId where UserId= @UserId

end


end