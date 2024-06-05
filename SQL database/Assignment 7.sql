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

--Write a query to select a random  student from each department.  “using one of Ranking Functions”
-----------------------------------------------------------------------------------------
use MyCompany

--Display the data of the department which has the smallest employee ID over all employees' ID.
select d.* 
from Departments d, Employee e
where d.Dnum = e.Dno and e.SSN = (select min(SSN) from Employee)

--