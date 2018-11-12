
CREATE procedure spGetAudtiTrail
@tablename as varchar(100)
as
begin
select us.username as UserName, pk as PrimaryKey, type as ActionType,fieldname,newvalue,updatedate from audit au join
tblusers us on au.pk=us.id
 where au.username='1' order by updatedate desc
 end