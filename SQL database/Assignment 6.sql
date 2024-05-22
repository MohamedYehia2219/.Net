use iti

--Retrieve a number of students who have a value in their age. 
select COUNT(*)
from Student 
where St_Age is not null

--Display number of courses for each topic name 
select c.Top_Id,t.Top_Name, COUNT(*) as 'number of courses'
from Course c, Topic t
where t.Top_Id = c.Top_Id
group by c.Top_Id, t.Top_Name

--Select Student first name and the data of his supervisor 
select s.St_Fname, super.*
from Student s, Student super
where super.St_Id= s.St_super

--4
select s.St_Id, isnull(s.St_Fname, isnull(s.St_Lname, 'no name')) +' '+ coalesce(s.St_Lname, 'no name') as 'full name', isnull(d.Dept_Name, 'no department')  
from Student s left outer join Department d
on d.Dept_Id = s.Dept_Id

--Select instructor name and his salary but if there is no salary display value ‘0000’ . “use one of Null Function” 
select Ins_Name, isnull(Salary, 0000)
from Instructor

--Select Supervisor first name and the count of students who supervises on them
select super.St_Fname, count(*)
from Student s, Student super
where super.St_Id = s.St_super
group by super.St_Fname

--Display max and min salary for instructors
select max(salary) from Instructor 
select min(salary) from Instructor 

--Select Average Salary for instructors 
select avg(salary) from Instructor 
----------------------------------------------------------------------------------
--part2
use MyCompany

--For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.Pname, sum(w.Hours) as 'total hours' 
from Project p , Works_for w
where p.Pnumber = w.Pno
group by p.Pname

--For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.Dname, max(e.Salary) as 'maximum salary', min(e.Salary) as 'minmum salary' ,avg(e.Salary) as 'avg salary' 
from Employee e , Departments d
where d.Dnum = e.Dno
group by d.Dname

--Retrieve a list of employees and the projects they are working on ordered by department and within each department,
--ordered alphabetically by last name, first name.
select e.*, p.*
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno
order by e.Dno , e.Fname, e.Lname 

--Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 
update e
set e.Salary = e.Salary + (e.Salary*0.3)
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno and p.Pname = 'Al Rabwah'