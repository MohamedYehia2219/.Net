-- schema
-- server --> databases --> schemas --> database objects [tables, fn, views, procedures, index, trigger]
-- the default schema is dbo (data base owner)

use iti

print @@servername
select * from [DESKTOP-KDRVG53].[mycompany].[dbo].employee

--create schema
go
create schema sales
go

--trensfer table to another schema
alter schema sales 
transfer dbo.department

-- create new table in schema
create table sales.test(id int)

-- to drop schema --> first drop or transfer all objects inside it
alter schema dbo 
transfer sales.department

drop table sales.test

drop schema sales
----------------------------------------------------------------------------
-- unioun family (union, union all, intersect, except)
-- 1. same data type
-- 2. the same number of the selected columns

--union (without repetation on record level) 
select St_Id, St_Fname from Student
union
select Ins_Id, Ins_Name from Instructor

--union all (with repetation)
select St_Id, St_Fname from Student
union all
select Ins_Id, Ins_Name from Instructor

--intersect (same records)
select St_Id, St_Fname from Student
intersect 
select Ins_Id, Ins_Name from Instructor

--except (what is existed in the first table and not existed in the second)
select St_Id, St_Fname from Student
except 
select Ins_Id, Ins_Name from Instructor
---------------------------------------------------------------------------------------
-- [DDL] (insert into, insert based on select)
-- take copy of a table (structure and its all data) --> all constrains are copid except PK and FK (table with out relations)
select * into newTable
from Student

--create table with same structure of another table but with out data 
select * into newTable2
from student
where 1=2		--can also take some data (records) depend on the condition

-- copy just data of a table to another table
-- the 2 tables must have the same structure
insert into newTable2
select * from Student

delete from newTable2

insert into newTable2				--Invalid
select St_Id, St_Fname from Student --Column name or number of supplied values does not match table definition

drop table newTable
drop table newTable2
----------------------------------------------------------------------------------------
-- functions: built in functions and user defined functions
-- user defined functions: scaler fn (return one value) and table valued fn (return table)
-- user defined fn --> 1.signature or declaration (fn name, parameters, return type)	2.body (defination)
-- fn body must be select statement or insurt base on select

-- 1.scaler function
create function getStudentNameById(@st_id int) returns nvarchar(100) --signature
begin
	--body
	declare @fullname nvarchar(100)

	select @fullname = St_Fname + ' ' + St_Lname
	from Student
	where St_Id = @st_id

	return @fullname
end

select dbo.getStudentNameById(1)
select dbo.getStudentNameById(10000)  --null
-------------------------------------------------------------------------
use MyCompany

create function getDepManagerByDepName (@depName varchar(100)) returns nvarchar(100)
begin
	declare @manager_name nvarchar(100)
	select @manager_name = e.fname + ' ' + e.lname
	from Employee e, Departments d
	where e.ssn = d.mgrssn and d.Dname = @depName
	return @manager_name
end

select dbo.getDepManagerByDepName('dp1')
drop function getDepManagerByDepName
------------------------------------------------------------------------------------
--2.1 Inline table valued function 
use iti
create function getAllInsofDepaertment(@dep_id int) returns table
as
return(
select Ins_Name, Dept_Id
from Instructor
where Dept_Id=@dep_id)

select * from dbo.getAllInsofDepaertment(10)
-----------------------------------------------------------------------------------
--2.2 Multi statement table function --> return table depend on LOGIC(if, while, declare)
create function getStudentsDataBasedOnFormat(@format varchar(50))
returns @resultTable table(st_id int ,st_name varchar(100))
as
	begin
		if @format = 'first'
			insert into @resultTable
			select St_Id, St_Fname from Student
		else if @format = 'last'
			insert into @resultTable
			select St_Id, St_Lname from Student
		else if @format = 'full name'
			insert into @resultTable
			select St_Id, concat(St_Fname, ' ', St_Lname) from Student
	return	
	end

select * from dbo.getStudentsDataBasedOnFormat('first')
select * from dbo.getStudentsDataBasedOnFormat('last')
select * from dbo.getStudentsDataBasedOnFormat('full name')
-----------------------------------------------------------------------------------------
-- View --> saved query, virtual table
-- pro  --> 1.Encapsulation (encapsulate query statements with view)
		--- 2.Abstraction (hide data base objects) --> security
-- its body is select statement only --> body can't contain DML
-- view types --> 1.standared view	2.partitioned view	3.Indexed view

--1. standared view (contain just only one select statement)
create view alexStudentsView
as 
select * from Student
where St_Address = 'alex'

select * from alexStudentsView

create view cairoStudentsView (id, name, address)
as 
select St_Id, St_Fname, St_Address from Student
where St_Address = 'cairo'

select * from cairoStudentsView
------------------------------------------------------------
-- 2. partitioned view (contain more than select statement)
create view cairoAlexstudentsView
as
select * from cairoStudentsView
union
select St_Id, St_Fname, St_Address from Student where St_Address='alex'

select * from cairoAlexstudentsView 
------------------------------------------------------------------
create schema test

alter schema test
transfer dbo.cairoAlexStudentsView

alter schema dbo
transfer test.cairoAlexStudentsView

drop schema test

-- drop view cairoStudentsView		-- drop view
-------------------------------------------------------------------
create or alter view cairoAlexStudentsGrades 
with encryption
as
select  concat (s.St_Fname, ' ',s.St_Lname) as 'full name', c.Crs_Name, sc.Grade 
from Student s, Course c, Stud_Course sc
where s.St_Id = sc.St_Id and c.Crs_Id = sc.Crs_Id and s.St_Address in ('alex', 'cairo')

select * from cairoAlexStudentsGrades

sp_helptext 'cairoAlexStudentsGrades'
------------------------------------------------------------------------
-- we can apply DML on views
-- changes affects the original table
-- =>DML in views with one table
select * from cairoStudentsView

insert into cairoStudentsView
values (1010, 'mo', 'cairo')

update cairoStudentsView
set name = 'mohamed'
where id = 1010

delete from cairoStudentsView 
where id =1010

---------------------------------
-- => DML in views with multible tables



