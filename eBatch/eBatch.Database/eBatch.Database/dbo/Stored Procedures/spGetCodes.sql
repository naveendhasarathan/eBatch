create procedure spGetCodes
@codecategory varchar(50)
as 
begin
select cv.Id,codevalue,[description],sortorder from tblcodevalue cv join
tblcodecategory cc on cc.Id = cv.categoryId 
where
cc.category = @codecategory
end