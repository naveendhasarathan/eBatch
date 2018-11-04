create procedure spGetCodes
@codecategory varchar(50)
as 
begin
select cv.id,codevalue,[description],sortorder from tblcodevalue cv join
tblcodecategory cc on cc.id = cv.categoryid 
where
cc.category = @codecategory
end