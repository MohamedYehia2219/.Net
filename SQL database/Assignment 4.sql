--part2 DML
use [ITI_wizard ]

--1.Insert your personal data to the student table as a new Student in department number 30.
insert into students
values ('mohamed', 'yehia', 23, 'cairo', 30)

--2.Insert Instructor with personal data of your friend as new Instructor in department number 30,
--Salary= 4000, but don’t enter any value for bonus.
insert into instructorss (name, address, salary, hourrate,dep_id)
values('sam', 'alex', 4000, 40, 30)

--3.Upgrade Instructor salary by 20 % of its last value.
update instructorss 
set salary = salary + salary*0.2
where id = 6
-------------------------------------------------------------------------
--part3
use MyCompany

-- Display all the employees Data.
select * from Employee

-- Display the employee First name, last name, Salary and Department number
select Fname, Lname,Salary,Dno
from Employee

--Display all the projects names, locations and the department which is responsible for it.
select Pname,Plocation,Dnum
from Project

--If you know that the company policy is to pay an annual commission for each employee
--with specific percent equals 10% of his/her annual salary
--Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
select Fname + ' ' + Lname as 'full name', salary * 0.1 as 'ANNUAL COMM'
from Employee

--Display the employees Id, name who earns more than 1000 LE monthly.
select SSN, Fname + ' ' + Lname as fullname, Salary
from Employee
where Salary>1000

--Display the employees Id, name who earns more than 10000 LE annually.
select SSN, Fname + ' ' + Lname as fullname, Salary*12
from Employee
where Salary*12>10000

--Display the names and salaries of the female employees 
select Fname + ' ' + Lname  [fullname], Salary
from Employee
where sex='f'

--Display each department id, name which is managed by a manager with id equals 968574.
select Dnum, Dname
from Departments
where MGRSSN = 968574

--Display the ids, names and locations of  the projects which are controlled with department 10.
select Pnumber,Pname,Plocation,Dnum
from Project
where Dnum = 10

--Display the Projects full data of the projects with a name starting with "a" letter.
select * from Project
where Pname like 'a%'
---------------------------------------------------------------------------------
--part 4
use ITI

--Get all instructors Names without repetition
select distinct Ins_Name from Instructor

--meaning of @@ refers to a Global variable
select @@VERSION	  
print @@SERVERNAME

