--Sub Query
use iti

select St_Fname from Student
where St_Age > avg(St_Age)			--Invalid

select St_Fname + ' '+  St_Lname from Student
where St_Age > (select avg(St_Age) from Student)

select St_Id, COUNT(*) from Student
group by St_Id

select St_Id, ( select COUNT(*) from Student)
from Student

-- get departments name that have students
-- using join
select distinct d.Dept_Name
from Student s, Department d
where d.Dept_Id = s.Dept_Id 

--using sub query
select Dept_Name
from Department
where Dept_Id in ( select distinct Dept_Id from Student
					where Dept_Id is not null)

-- Join in DML
delete from sc
from Student s, Stud_Course sc
where s.St_Id = sc.St_Id and s.St_Address='cairo'

--sub query in DML
delete from Stud_Course
where St_Id in ( select St_Id from Student
				where St_Address = 'cairo')
---------------------------------------------------------------------------------
--TOP
select top(2) *
from Student

--last 5 students
select top(5)*
from Student
order by St_Id desc

--maximum 2 salary
select top(2) salary 
from Instructor
order by Salary desc

-- second maximum salary
select top(1) *
from (select top(2) salary, Ins_Name 
		from Instructor
		order by Salary desc) as newTable
order by Salary

select max(salary)
from Instructor
where Salary != (select max(salary) from Instructor)

--top with ties must come with order by
select top(5) St_Fname, St_Age
from Student
order by St_Age desc

select top(5) with ties St_Fname, St_Age
from Student
order by St_Age desc
----------------------------------------------------------------
--select random --> newID()--> GUID: Global Unique Indentifier
select top(5) St_Fname 
from Student
order by NEWID()
-------------------------------------------------------------------
--Ranking
select Ins_Name, Salary, ROW_NUMBER() over (order by salary desc) as 'row number'
from Instructor

select Ins_Name, Salary, DENSE_RANK() over (order by salary desc) as 'dense rank'
from Instructor

select Ins_Name, Salary, RANK() over (order by salary desc) as 'rank'
from Instructor

--get thr 2 older students
--using top
select top(2) *
from Student
order by St_Age desc

--using rank
select *
from (select St_Fname, St_Age , ROW_NUMBER() over (order by st_Age desc) as 'ranking'
		from Student) as nwTable
where ranking <= 2

-- with repetation
select *
from (select St_Fname, St_Age , DENSE_RANK() over (order by st_Age desc) as 'ranking'
		from Student) as nwTable
where ranking <= 5

--get the 5th younger student
--using top
select top(1) *
from	(select top(5) St_Fname, St_Age
		from Student
		where St_Age is not null
		order by St_Age) as newTable
order by St_Age desc

--using rank
select *
from (select St_Fname, St_Age, ROW_NUMBER() over (order by st_age) as 'ranking'
	  from Student
	  where St_Age is not null) as nwtable 
where ranking = 5


--get the younger student at eatch department using rank
select * 
from
(select St_Fname, St_Age, Dept_Id, ROW_NUMBER() over (partition by Dept_Id order by st_age) as 'ranking'
from Student
where St_Age is not null and Dept_Id is not null) as newTable
where ranking = 1
--------------------------------------------------------------------------------------------
--Ntile
--get lowest 5 salary
select * from
(select Ins_Name, Salary, ntile(3) over (order by salary) as RN 
from  Instructor
where Salary is not null) as newTable
where rn = 1

--using top
select top(5) *
from Instructor
where Salary is not null
order by Salary
---------------------------------------------------------------------------------------------
--executation order
--1. from
--2. join / on
--3. where
--4. groub by
--5. having
--6. select
--7. order by
--8. top
-------------------------------------------------------------------------
