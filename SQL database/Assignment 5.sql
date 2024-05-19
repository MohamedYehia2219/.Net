--part 1
use ITI

--Display max, min and average salary for instructors
select max(Salary) as 'max salary' from Instructor
select min(Salary) as 'min salary' from Instructor
select avg(Salary) as 'avg salary' from Instructor
-------------------------------------------------------------------------------------
--part 2
use MyCompany

--DQL
select e.*, p.*
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno
order by e.Dno , e.Fname, e.Lname 

--update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 
update e
set e.Salary = e.Salary + (e.Salary*0.3)
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno and p.Pname = 'Al Rabwah'

--DML
--1 insert new department
Insert into Departments values('DEPT IT', 100, 112233, '1-11-2006')
  
--2.1
update Departments
set MGRSSN=968574
where Dnum = 100

update Employee
set Dno = 100
where SSN=968574
 
 --2.2
insert into Employee values('mohamed', 'yehia', 102672, '1/1/2000', 'cairo', 'M',1000, null, null)

update Employee
set Dno = 20
where SSN=102672

--2.3
update Departments
set MGRSSN=102672
where Dnum = 20

update Employee
set Superssn = 102672
where SSN=321654

--3. Unfortunately 
update Departments
set MGRSSN=102672
where MGRSSN = 223344

update Employee
set Superssn = 102672
where Superssn = 223344

update Works_for
set ESSn = 102672
where ESSn = 223344

delete from Employee where SSN=223344

delete from Dependent where ESSN = 223344
----------------------------------------------------------------------------------------------------
--part3
--Retrieve the names of all employees in department 10 
--who work more than or equal 10 hours per week on the "AL Rabwah" project.
select e.Fname + ' ' + e.Lname [fullname], e.Dno, p.Pname, w.Hours
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber=w.Pno and e.Dno=10 and w.Hours>=10 and p.Pname='AL Rabwah'

--Find the names of the employees who were directly supervised by mohamed yehia.
select e.SSN, e.Fname + ' ' + e.Lname [fullname], e.Superssn
from Employee e, Employee super
where super.SSN = e.Superssn and super.Fname = 'mohamed' and super.Lname='yehia'

--Display All Data of the managers.
select distinct e.*
from Employee e, Departments d
where e.SSN = d.MGRSSN 

--Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select e.SSN, e.Fname + ' ' + e.Lname [fullname], p.Pname
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno
order by p.Pname

--For each project located in Cairo City, find the project number, 
--the controlling department name, the department manager last name ,address and birthdate.
select p.Plocation, p.Pnumber, p.Dnum, d.Dname, d.MGRSSN, e.Lname, e.Address, e.Bdate 
from Employee e, Departments d, Project p
where p.Dnum = d.Dnum and d.MGRSSN = e.SSN and p.City='cairo'

--Display All Employees data and the data of their dependents even if they have no dependents.
select e.*, d.*
from Employee e left outer join Dependent d
on e.SSN = d.ESSN 
------------------------------------------------------------------------------------------
--part 4
--Display the Department id, name and id and the name of its manager.
select d.Dnum, d.Dname, e.SSN, e.Fname + ' ' +e.Lname as [fullname]
from Departments d, Employee e
where e.SSN = d.MGRSSN

--Display the name of the departments and the name of the projects under its control.
select p.Pnumber, p.Pname, d.Dnum, d.Dname 
from Departments d, Project p
where p.Dnum = d.Dnum 

--Display the full data about all the dependence associated with the name of the employee they depend on .
select e.SSN,  e.Fname + ' ' +e.Lname as [fullname], d.*
from Employee e, Dependent d
where e.SSN = d.ESSN

--Display the Id, name and location of the projects in Cairo or Alex city.
select Pnumber, Pname, Plocation, City
from Project
where City in ('cairo', 'alex')

--Display the Projects full data of the projects with a name starting with "a" letter.
select *
from Project
where Pname like 'a%'

--display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from Employee
where Dno=30 and Salary between 1000 and 2000

--Retrieve the names of all employees in department 10
--who work more than or equal 10 hours per week on the "AL Rabwah" project.
select e.Fname + ' ' + e.Lname [fullname], e.Dno, p.Pname, w.Hours
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber=w.Pno and e.Dno=10 and w.Hours>=10 and p.Pname='AL Rabwah'

--Retrieve the names of all employees and the names of the projects they are working on,sorted by the project name.
select e.SSN, e.Fname + ' ' + e.Lname [fullname], p.Pname
from Employee e, Project p, Works_for w
where e.SSN = w.ESSn and p.Pnumber = w.Pno
order by p.Pname

--For each project located in Cairo City , find the project number, 
--the controlling department name ,the department manager last name ,address and birthdate.
select p.City, p.Pnumber, p.Dnum, d.Dnum, d.Dname, d.MGRSSN, e.SSN, e.Lname, e.Address, e.Bdate
from Project p, Departments d, Employee e
where d.Dnum=p.Dnum and e.SSN=d.MGRSSN and p.City='cairo'

