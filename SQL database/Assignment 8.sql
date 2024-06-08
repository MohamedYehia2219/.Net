-- assignment 7  part 2 schema
use AdventureWorks2012

select SalesOrderID, ShipDate
from sales.SalesOrderHeader
where ShipDate between '7/28/2002' and '7/29/2014'

select ProductID, Name, StandardCost
from Production.Product
where StandardCost < 110

select ProductID, Name, Weight
from Production.Product
where Weight is null

select ProductID, Name, Color
from Production.Product
where color in ('Silver', 'Black', 'Red')

select ProductID, Name
from Production.Product
where Name like 'B%'

UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select Description
from Production.ProductDescription
where Description like '%[_]%'

select distinct HireDate
from HumanResources.Employee

select Name + ' is only! ' + convert (varchar(50),ListPrice)
from Production.Product
where ListPrice between 100 and 120
order by ListPrice
-------------------------------------------------------------------------------------
--assignmnet 8
--part 1 functions
 use iti

--Create a scalar function that takes a date and returns the Month name of that date.
create or alter function getMonthNameBasedOnDate (@date date) returns nvarchar(100)
begin
	declare @monthName nvarchar(100)
	select @monthName = FORMAT (@date, 'MMMM')
	return @monthName
end
select dbo.getMonthNameBasedOnDate('11/2/2020')
---------------------------------------------------------
--Create a multi-statements table-valued function that takes 2 integers and returns the values between them
create or alter function getRange (@num1 int, @num2 int) returns @resultTable table(range int)
as
begin
	declare @min int
	declare @max int
	if @num1 <= @num2
		begin
			set @min = @num1
			set @max = @num2
		end
	else 
		begin
			set @min = @num2
			set @max = @num1
		end
	while (@min < @max-1)
		begin
			set @min += 1
			insert into @resultTable values (@min)
		end
return
end
select * from dbo.getRange(1,15) 
-----------------------------------------------------------------
-- Create a table-valued function that takes Student No and returns Department Name with Student full name.
create function getStudentDepaertment(@st_id int) returns table
as
return(
select s.St_Fname + ' ' + s.St_Lname as 'full name', d.Dept_Name
from Student s, Department d
where d.Dept_Id = s.Dept_Id and s.St_Id = @st_id)

select * from dbo.getStudentDepaertment(1)
select * from dbo.getStudentDepaertment(12)
-----------------------------------------------------------------
--4 Create a scalar function that takes Student ID and returns a message to user 
create or alter function getStudentName (@id int) returns nvarchar(100)
begin
	declare @message nvarchar(100)
	declare @fname varchar(100)
	declare @lname varchar(100)

	select @fname = St_Fname, @lname = St_Lname from Student
	where St_Id = @id

	if @fname is null and @lname  is null
		set @message = 'first name and last name are null'
	else if @fname is null and @lname  is not null
		set @message = 'first name is null'
	else if @fname is not null and @lname  is null
		set @message = 'last name is null'
	else if @fname is not null and @lname  is not null
		set @message = 'first name and last name are not null'
	return @message
end
select dbo.getStudentName(1)
select dbo.getStudentName(13)
select dbo.getStudentName(700)
select dbo.getStudentName(701)
------------------------------------------------------------------
--5 Create a function that takes an integer which represents the format of the Manager hiring date
create function getDepaertmentInfo(@format int) returns table
as
return(
select d.Dept_Name, i.Ins_Name, convert(nvarchar(max), d.Manager_hiredate, @format) as 'hiring date'
from Instructor i, Department d
where i.Ins_Id = d.Dept_Manager )

select * from dbo.getDepaertmentInfo(101)
select * from dbo.getDepaertmentInfo(130)
----------------------------------------------------------------------
create function getStudentsNameBasedOnFormat(@format varchar(50))
returns @resultTable table(st_name varchar(100))
as
	begin
		if @format = 'first name'
			insert into @resultTable
			select ISNULL(St_Fname,ISNULL(St_Lname, 'no name')) from Student
		else if @format = 'last name'
			insert into @resultTable
			select ISNULL(St_Lname, 'no name') from Student
		else if @format = 'full name'
			insert into @resultTable
			select CONCAT( ISNULL(St_Fname,ISNULL(St_Lname, 'no name')), ' ', ISNULL(St_Lname, 'no name') )from Student
	return	
	end

select * from dbo.getStudentsNameBasedOnFormat('first name')
select * from dbo.getStudentsNameBasedOnFormat('last name')
select * from dbo.getStudentsNameBasedOnFormat('full name')
--------------------------------------------------------------------------------
-- Create function that takes project number and display all employees in this project (Use MyCompany DB)
use MyCompany

create function getProjectEmployeesBasedonPNum(@pnum int) returns table
as
return(
select e.*
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno and p.Pnumber = @pnum)

select * from dbo.getProjectEmployeesBasedonPNum(100)
--------------------------------------------------------------------------------------------
--part2
use iti
-- Create a view that displays the student's full name, course name if the student has a grade more than 50. 
create or alter view studentsGradesView 
as
select  concat (s.St_Fname, ' ',s.St_Lname) as 'full name', c.Crs_Name, sc.Grade 
from Student s, Course c, Stud_Course sc
where s.St_Id = sc.St_Id and c.Crs_Id = sc.Crs_Id and sc.Grade > 50

select * from dbo.studentsGradesView
-----------------------------------------------------
--Create an Encrypted view that displays manager names and the topics they teach. 
create view getTopicsInfoView
with encryption
as
select i.Ins_Name, c.Crs_Name, t.Top_Name
from Instructor i, Course c, Ins_Course ic , Topic t
where i.Ins_Id = ic.Ins_Id and c.Crs_Id = ic.Crs_Id and t.Top_Id = c.Top_Id 

select * from dbo.getTopicsInfoView
sp_helptext 'getTopicsInfoView'
------------------------------------------------------------
--3
create or alter view insDepView
with schemabinding
as 
select i.Ins_Name, d.Dept_Name
from dbo.Instructor i, dbo.Department d		--tables names must be of (two) parts in schemabinding
where d.Dept_Id = i.Dept_Id and d.Dept_Name in ('java', 'sd')

--schemabinding: means that this view is bound to the schema of these tables 
select * from insDepView
------------------------------------------------------------------
--Create a view that will display the project name and the number of employees working on it. 
use mycompany

create view numberOfEMployeesInProjectView
as
select Pname, COUNT(*) as 'number of employees'
from Project p, Employee e, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno
group by Pname

select * from numberOfEMployeesInProjectView
-----------------------------------------------------------------------------------------
use [SD32-Company]
--Create a view named   “v_clerk” that will display employee Number ,project Number, 
--the date of hiring of all the jobs of the type 'Clerk'.
create view [company].v_clerk
as 
select e.EmpNo, p.ProjectNo, w.Enter_Date
from [HR].Employee e, hr.Project p, Works_on w
where e.EmpNo = w.EmpNo and p.ProjectNo = w.ProjectNo and w.Job = 'clerk'

select * from Company.v_clerk
-----------------------------------------------------------------------
-- Create view named “v_without_budget” that will display all the projects data without budget
create view company.v_without_budget
as
select p.ProjectName, p.ProjectNo
from hr.Project p

select * from Company.v_without_budget
--------------------------------------------------------------------------
--Create view named  “v_count “ that will display the project name and the Number of jobs in it
create view company.v_count
as
select p.ProjectName,COUNT (w.Job) as 'Number of jobs'
from hr.Project p , Works_on w
where p.ProjectNo = w.ProjectNo
group by w.ProjectNo, p.ProjectName 

select * from company.v_count
---------------------------------------------------------------------------
-- Create view named ” v_project_p2” that will display the emp# s for the project# ‘p2’
-- (use the previously created view  “v_clerk”)
create or alter view company.v_project_p2
as
select EmpNo
from company.v_clerk
where ProjectNo = 2

select * from company.v_project_p2
---------------------------------------------------------------------------
--modify the view named  “v_without_budget”  to display all DATA in project p1 and p2.
create or alter view company.v_without_budget
as
select *
from hr.Project 

select * from Company.v_without_budget
--------------------------------------------------------------------------
-- Delete the views  “v_ clerk” and “v_count”
drop view company.v_clerk
drop view Company.v_count
------------------------------------------------------------------
-- Create view that will display the emp# and emp last name who works on deptNumber is ‘d2’
create or alter view empDepView
as
select e.EmpNo, e.EmpLname
from hr.Employee e, Company.Department d
where d.DeptNo = e.DeptNo and e.DeptNo = 1

select * from empDepView
-----------------------------------------------------------------
--Display the employee lastname that contains letter “J” (Use the previous view created in Q#7)
create view empWithLetterJ
as
select EmpLname
from empDepView
where EmpLname like '%j%'

select * from empDepView
-------------------------------------------------------------
--Create view named “v_dept” that will display the department# and department name
create view company.v_dept
as
select d.DeptNo, d.DeptName
from Company.Department d

select * from company.v_dept