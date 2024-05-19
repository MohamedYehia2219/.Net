create database ITI
use iti

create table students
(
	id int primary key identity(1,1),
	fname varchar(100) not null,
	lname varchar(100),
	age smallint,
	address varchar(100) default 'cairo',
	Dep_id int
)

create table department
(
	id int primary key identity(1,1),
	name varchar(100) not null,
	hiringDate date,
	Ins_id int
)

create table instructor
(
	id int primary key identity(1,1),
	name varchar(100) not null,
	address varchar(100),	
	salary int,
	bonus float,
	hourRate float,
	dep_ID int references department(id)
)

create table courses
(
	id int primary key identity(1,1),
	name varchar(100) not null,
	description varchar(100),
	duration float,
	topic_id int,
)

create table topics
(
	id int primary key identity(1,1),
	name varchar(100) not null,
)

create table students_courses
(
	student_ID int references students(id),
	course_ID int references courses(id),
	grade char(2),			--B+
	primary key (student_ID, course_ID)
)

create table instructors_courses
(
	instructor_ID int references instructor(id),
	course_ID int references courses(id),
	evaluation float,				
	primary key (instructor_ID, course_ID)
)

alter table students
add foreign key(Dep_id) references department(id)

alter table department
add foreign key(Ins_id) references instructor(id)

alter table courses
add foreign key(topic_id) references topics(id)

---------------------------------------------------------------------------------------------
-- assignment2
-----------------------

create database music
use music

create table musician
(
	id int primary key identity(1,1),
	name varchar(100) not null,
	phone varchar(50),
	city varchar(100) default 'cairo',
	street varchar(100)
)

create table instrument
(
	name varchar(100) primary key,
	instrument_key varchar(100) not null,
)

create table album
(
	id int primary key identity(1,1),
	title varchar(100) not null,
	albumDate date,
	musician_ID int references musician(id)
)

create table song
(
	title varchar(100) primary key,
	author varchar(100) not null,
)

create table album_songs
(
	album_ID int references album(id),
	song_title varchar(100) references song(title),
	primary key (album_ID,song_title)
)

create table musician_songs
(
	musician_ID int references musician(id),
	song_title varchar(100) references song(title),
	primary key (musician_ID,song_title)
)

create table musician_instrument
(
	musician_ID int references musician(id),
	ins_name varchar(100) references instrument(name),
	primary key (musician_ID,ins_name)
)