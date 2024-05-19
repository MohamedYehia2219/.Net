use company

--simple Insert
insert into employees values ('ahmed', 'ali',  'M', '1/1/2000', 'cairo',null,null)
insert into employees values ('mona', 'samy',  'F', '2/2/2000', 'cairo',1,null)

-- insert into employees values ('mona', 'samy', '2/2/2000', 'cairo',1,null)	--Invalid

insert into employees(fname,lname,supersnn,address)
values ('nour', 'osama',3,'Alex')

/*insert into employees(lname,supersnn,address)
values ('hema', null,'Alex')*/					--Invalid as fname is required

--Row constructor Insert
Insert into departments values
('HR',1,'4/4/2022'),
('IT',1,'5/5/2023'),
('SD',1,'7/11/2020')

--Insert into departments values('PR',100,'4/12/2022')	--iInvalid as incorrect MGssn
----------------------------------------------------------------------------------------------
update employees
set Dnum = 2
where ssn =1

/*update departments
set MGssn = 100					--Invalid as incorrect FK
where Dnum=1*/
-----------------------------------------------------------------------------------------
--Delete from employees			-- delete all rows

/*Delete from employees 
where ssn = 3*/				-- DELETE statement conflicted with the SAME TABLE REFERENCE
-----------------------------------------------------------------------------------------
select fname, lname,gender from employees

select * from employees

select fname + ' ' + lname as 'full name' from employees
select fname + ' ' + lname as [fullname] from employees
select fname + ' ' + lname fullname from employees
select fname + ' ' + lname [fullname] from employees
select fullname = fname + ' ' + lname from employees

use ITI

select St_Fname, St_Id, St_Age from Student
where St_Age >= 20 and St_Age <= 30

select St_Fname, St_Id, St_Age from Student
where St_Age between 20 and 30

select St_Fname, St_Id, St_Address from Student
where St_Address = 'cairo' or St_Address = 'alex'

select St_Fname, St_Id, St_Address from Student
where St_Address in ('cairo','alex','mansoura')

select St_Fname, St_Id, St_Address from Student
where St_Address not in ('cairo','alex','mansoura')

select St_Fname, St_Id, St_Address from Student
where St_Address != 'cairo'

select St_Fname, St_Id, St_super from Student
where St_super is null

select St_Fname, St_Id, St_super from Student
where St_super is not null

select St_Fname, St_Id from Student
where St_Fname like 'a%'

select St_Fname, St_Id from Student
where St_Fname like '%[%]'

select St_Fname, St_Id from Student
where St_Fname like 'ah%'

select St_Fname, St_Id from Student
where St_Fname like '[^ah]%'

select St_Fname, St_Id from Student
where St_Fname like '[a-h]%'

select St_Fname, St_Id, St_Age from Student
order by St_Age 

select St_Fname, St_Id, St_Age from Student
order by St_Age desc

select St_Fname, St_Id from Student
order by St_Fname desc

select St_Fname, St_Id, St_Age from Student
order by St_Fname desc, St_Age asc

select distinct st_address from Student 

select distinct st_address from Student 
where St_Address is not null