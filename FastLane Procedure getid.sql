--stored procedure getid--

go
create procedure getcustomergroup
as 
select * from UserGroup
where groupID = 'CM'
return 0