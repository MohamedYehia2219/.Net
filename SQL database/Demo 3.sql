create database company
use company

create table employees
(
	ssn int primary key identity(1,1),
	fname varchar(100) not null,
	lname varchar(100),
	gender char(1) default 'm',
	BOD date,
	address varchar(100) not null default 'cairo',
	supersnn int references employees(ssn),
	Dnum int
)

create table departments
(
	Dnum int primary key identity(1,1),
	Dname varchar(100) not null unique,
	MGssn int references employees(ssn),
	hiringDate date
)

create table departmentsLocations
(
	Dnum int references departments(Dnum),
	location varchar(100) not null,
	primary key(Dnum, location)
)

create table projects
(
	Pnum int primary key identity(1,1),
	Pname varchar(100) not null unique,
	location varchar(70) not null,
	city varchar(50)  not null,
	Dnum int references departments(Dnum),
)

create table dependants
(
	name varchar(100) not null unique,
	BOD date,
	gender char(1) default 'f',
	Essn int references employees(ssn),
	primary key(Essn, name)
)

create table employeesProjects
(
	Essn int references employees(ssn),
	Pnum int references projects(Pnum),
	numOfHours int, 
	primary key(Essn, Pnum)
)

alter table employees
add foreign key(Dnum) references departments(Dnum)   

