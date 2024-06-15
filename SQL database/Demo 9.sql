-- DML in view
-- DML in view affects the original table
-- [One Table]

use iti
select * from cairoStudentsView

insert into cairoStudentsView
values (1000,'mo','cairo')

update cairoStudentsView
set name = 'mohamed'
where id = 1000

delete from cairoStudentsView where id = 1000
------------------------------------------------------------------
-- view with [multiple tables]

select * from studentsGradesView
sp_helpText 'studentsGradesView'

create or alter view studentsDepView
as
select s.St_Id, s.St_Fname, d.Dept_Id, d.Dept_Name
from Student s, Department d
where d.Dept_Id = s.Dept_Id

select * from studentsDepView

insert into studentsDepView
values (1000,'mo',100,'pl')			-- Invalid

insert into studentsDepView (st_id, st_fname) -- insert the columns of the same table
values (1000,'mo')

insert into studentsDepView (Dept_Id,Dept_Name) -- insert the columns of the same table
values (100,'PI')

update Student 
set Dept_Id = 100
where St_Id = 1000

select * from studentsDepView

-- update columns of the same table
update studentsDepView
set St_Fname = 'yehia'
where St_Id = 1000

-- delete in view with multible table is INVALID !!!!
delete from studentsDepView
where St_Id = 1000
------------------------------------------------------------------------------
-- check option : to validate conditions in view when do DML operation
sp_helptext 'cairoStudentsView'
select * from cairoStudentsView 

insert into cairoStudentsView
values (1001, 'osama', 'alex')

create or alter view cairoStudentsView(id,name, address)
as 
select St_Id, St_Fname, St_Address
from Student
where St_Address='cairo' with check option


insert into cairoStudentsView
values (1002, 'sam')	-- Invalid : number of supplied values does not match table definition.

insert into cairoStudentsView
values (1002, 'sam', 'alex')	--Invalid :  as ckeck option

insert into cairoStudentsView
values (1002, 'sam', 'cairo')		--Valid
--------------------------------------------------------------------------
-- Stored Procedure
-- improve performance, handle errors 
create procedure sp_getStudentById @id int
as
select * from student 
where St_Id = @id

sp_getStudentById 1

declare @id int = 1
execute sp_getStudentById @id
-----------------------------------------------
create or alter proc deleteTopic @t_id int
with encryption
as 
begin try
	delete from Topic
	where Top_Id = @t_id
end try
begin catch
	select 'ERROR'
end catch

exec deleteTopic 1
sp_helpText 'deleteTopic'
--------------------------------------------
create or alter proc sp_sum @x int = 1 , @y int = 0
as
select @x + @y

sp_sum 1,2	--passing by possition
sp_sum 7
sp_sum @y=5, @x=4 --passing by name
sp_sum	--default values
------------------------------------------------------
-- dynamic queries
create or alter proc sp_getDatafromTable @tableName varchar(50), @columnName varchar(50)
with encryption
as
	--select @columnName from @tableName	--	Invalid
	execute('select ' +@columnName+ ' from '+@tableName)

exec sp_getDatafromTable 'student', '*'
exec sp_getDatafromTable 'student', 'st_fname'
-------------------------------------------------------------
--Insert based on execute
create or alter proc getStudentsByAddress @address varchar(50)
as
select st_id,St_Fname, St_Address
from Student
where St_Address = @address

getStudentsByAddress 'alex'

create table alexstudents
(
	st_id int primary key,
	st_fname varchar(50),
	st_address varchar(50)
)

-- insert based on select
insert into alexstudents
select St_Id, St_Fname,St_Address from Student
where St_Address = 'alex'

delete from alexstudents

--insert based on exec
insert into alexstudents
exec getStudentsByAddress 'alex'
---------------------------------------------------------
-- output parameter in procedure
create or alter proc getStdDataById @st_id int, @st_name varchar(50) output, @st_age int output
as
select @st_name = St_Fname, @st_age = St_Age
from Student
where St_Id = @st_id

declare @name varchar(50), @age int
exec getStdDataById 1, @name out, @age out 
select @name, @age
-------------------------------------------------
create or alter proc getStdDataById02 @st_name varchar(50) output, @st_data int output
as
select @st_name = St_Fname, @st_data = St_Age
from Student
where St_Id = @st_data

declare @name varchar(50), @data int = 2
exec getStdDataById02 @name out, @data out
select @name, @data
-----------------------------------------------------------
-- Trigger