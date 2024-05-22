-- dispaly data of all managers 
use MyCompany
select distinct super.*
from Employee e, Employee super
where super.SSN = e.Superssn
------------------------------------------------
use iti
--Functions
--Built In functions && User defined function
--Scaler function and Table valued function

--1. aggregate function:
--1.1 count()
select count(*) from Instructor
select count(Ins_Id) from Instructor
select count(Salary) from Instructor

--1.2 sum() --> numeric datatype
select SUM(Salary) from Instructor
select SUM(Ins_Name) from Instructor -- invalid

--1.3 avg() --> numeric datatype
select avg(Salary) from Instructor
select avg(Ins_Name) from Instructor -- invalid

--1.4 max()
select max(Salary) from Instructor
select max(Ins_Name) from Instructor -- alphapetic

--1.5 min()
select min(Salary) from Instructor
select min(Ins_Name) from Instructor -- alphapetic
-----------------------------------------------------------------
--2. null functions
--2.1 isnunll(expression, replacement value)
select St_Id, ISNULL(St_Fname,St_Lname)
from Student

select St_Id, ISNULL(St_Fname,ISNULL(St_Lname,'no name'))
from Student

--2.2 coalesce(p1,p2,...,pn)
select St_Id, coalesce(St_Fname,st_lname, 'noname'), St_Lname
from Student
---------------------------------------------------------------
--3. casting function
--3.1 convert(datatype, expression)
select St_Fname + ' ' + CONVERT(varchar(100), St_Age)
from Student
-- string + null = null
select St_Id ,St_Fname+ ' ' + St_Age from Student --Invalid

select St_Id ,St_Fname + ' ' + CONVERT(varchar(100), ISNULL(St_Age,0))
from Student

select St_Id ,ISNULL(St_Fname,ISNULL(St_Lname,'no name')) + ' ' + CONVERT(varchar(100), ISNULL(St_Age,0))
from Student

--3.2 cast(expression AS datatype)
select St_Id ,St_Fname + ' ' + cast(ISNULL(St_Age,0) as varchar(100))
from Student

-- difference between convert and cast
select convert(varchar(max), getdate())
select cast(getdate()as varchar(100))
select convert(varchar(max), getdate(),101)
select convert(varchar(max), getdate(),104)
select convert(varchar(max), getdate(),130) --???
select convert(nvarchar(max), getdate(),130)

--3.3 concat() --> convert parameters to string then concatenating 
-- it converts null to an empty string
select CONCAT(St_Fname , ' ', St_Age)
from student
----------------------------------------------------------------
--4. date time function
select GETDATE()
select day(getdate())
select month(getdate())
select year(getdate())
select eomonth(getdate())
select format(getdate(), 'ddd/MMM/yy hh:mm:ss tt')
select format(getdate(), 'ddd/MMM/yy hh:mm:ss tt', 'ar')
select format(getdate(), 'dddd/MMMM/yyyy hh:mm:ss tt', 'en')
------------------------------------------------------------------
--5. string function
select upper('ahmEd')
select lower ('AHMED')
select len(St_Fname) from Student
select SUBSTRING('mohamed',1,5)
----------------------------------------------------------------
--6. system function
select DB_NAME()
select SUSER_NAME()
select @@SERVERNAME
select NEWID()
----------------------------------------------
--7.math function
select power(2,5)
select pi()
select rand()
select abs(-10)
---------------------------------------------------
--Group by
select Dept_Id, min(Salary)
from Instructor
group by Dept_Id

select Dept_Id, St_Address, count(*)
from student
group by Dept_Id, St_Address

select Dept_Id, count(*)
from student
group by Dept_Id
having count(*)>3

select s.Dept_Id,d.Dept_Name, count(*)
from student s, Department d
where d.Dept_Id = s.Dept_Id
group by s.Dept_Id, d.Dept_Name

select Dept_Id, sum(Salary) as 'salary', count(*) as 'number os ins'
from Instructor
group by Dept_Id
having count(*)>1

select avg(Salary)
from Instructor
having avg(salary)>5000

select s.St_super, super.St_Fname, count(*)
from Student s, Student super
where super.St_Id = s.St_super
group by s.St_super, super.St_Fname






