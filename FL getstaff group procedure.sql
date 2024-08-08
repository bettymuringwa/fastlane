
go
create procedure getstaffgroup
as 
select * from UserGroup
where not groupID = 'CM'
return 0