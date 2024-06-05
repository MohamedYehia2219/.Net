use iti

--Display instructors who have salaries less than the average salary of all instructors.
select Ins_Name,Salary from Instructor
where Salary < (select avg(Salary) from Instructor)

--Display the Department name that contains the instructor who receives the minimum salary.
select d.Dept_Name
from Instructor i , Department d
where d.Dept_Id = i.Dept_Id and i.Salary = (select min(Salary) from Instructor)

--Select max two salaries in instructor table. 
select top(2) Salary
from Instructor
order by Salary desc

--Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
select * 
from
(select salary, Dept_Id, ROW_NUMBER() over (partition by Dept_Id order by salary desc) as 'rank'
from Instructor 
where Salary is not null) as newTable
where rank in (1,2)

--Write a query to select a random  student from each department.  “using one of Ranking Functions”
select *
from
(select St_Fname, Dept_Id , ROW_NUMBER() over (partition by Dept_Id order by newID()) as 'rank'
from Student 
where Dept_Id is not null) as newTable
where rank = 1
-----------------------------------------------------------------------------------------
use MyCompany

--Display the data of the department which has the smallest employee ID over all employees' ID.
select d.* 
from Departments d, Employee e
where d.Dnum = e.Dno and e.SSN = (select min(SSN) from Employee)

--List the last name of all managers who have no dependents.
select lname
from Employee
where SSN not in (select distinct essn from Dependent)

--For each department if its average salary is less than the average salary of all employees display its number,
--name and number of its employees.
select e.Dno, d.Dname, count(*) as 'employeess count'
from Employee e, Departments d
where d.Dnum = e.Dno 
group by e.dno, d.Dname
having avg(Salary)  < (select avg(Salary)from Employee)
						
--Try to get the max 2 salaries using subquery
select top(2) *
from (select Salary, ROW_NUMBER() over(order by salary desc) as 'rank'
		from Employee) as newTable

--Display the employee number and name if he/she has at least one dependent (use exists keyword) self-study
select e.SSN ,e.Fname from Employee e
where exists
( select d.essn 
from Dependent d
where e.SSN = d.ESSN )
	