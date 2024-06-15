use Library
--1
select e.Fname + ' ' + e.Lname
from Employee e
where e.Fname like '____%'
----------------------------------------
--2
select count(*) as 'NO OF PROGRAMMING BOOKS'
from book b, Category c
where c.Id = b.Cat_id and c.Cat_name = 'programming'
-----------------------------------------
--3
select count(*) as 'NO OF BOOKS'
from book b, Publisher p
where p.Id = b.Publisher_id and p.Name = 'HarperCollins'
--------------------------------------------
--4
select u.SSN,u.User_Name,br.Borrow_date,br.Due_date
from Borrowing br, Users u
where u.SSN = br.User_ssn and br.Due_date < '7/1/2022'
-------------------------------------------------
--5
select b.Title + ' is written by '+ a.Name
from book b, Author a, Book_Author ba
where b.Id = ba.Book_id and a.Id = ba.Author_id
--------------------------------------------------
--6
select u.User_Name
from Users u
where u.User_Name like '%a%'
-------------------------------------------------
--7
select top(1) * from
(select br.User_ssn, count(*) as 'times'
from Borrowing br
group by br.User_ssn) as newTtable
order by times desc
-----------------------------------------------
--8
select br.User_ssn, sum(br.Amount) as 'money paid'
from Borrowing br
group by br.User_ssn 
-------------------------------------------------
--9
select top(1) newTable.* , c.Cat_name
from Category c, Book b,
	(select br.Book_id, sum(br.Amount) as 'money_for_borrowing'
	from Borrowing br
	group by br.Book_id) as newTable
where c.Id = b.Cat_id and b.Id = newTable.Book_id
order by money_for_borrowing asc
---------------------------------------------------
--10
select ISNULL(e.Email, ISNULL(e.Address,e.DOB))
from Employee e
------------------------------------------------
--11
select b.Cat_id, c.Cat_name, COUNT(*) as 'Count Of Books'
from Book b, Category c
where c.Id = b.Cat_id
group by Cat_id, c.Cat_name
-----------------------------------------------------
--12
select b.Id
from Book b, Shelf s, Floor f
where s.Code = b.Shelf_code and f.Number = s.Floor_num and b.Shelf_code != 'A1' and f.Number != 1
-----------------------------------------------------
--13
select e.Floor_no, f.Num_blocks, COUNT(*) as '# employees'
from floor f, Employee e
where f.Number = e.Floor_no
group by e.Floor_no, f.Num_blocks
-----------------------------------------------------
--14
select b.Title, u.User_Name
from Borrowing br, Users u, Book b
where b.id = br.Book_id and u.SSN =  br.User_ssn 
and br.Borrow_date >= '3/1/2022' and br.Borrow_date <= '10/1/2022'
----------------------------------------------------
--15
select e.Fname + ' ' + e.Lname as [EmpName], concat (super.Fname, ' ', super.Lname) as 'supervisor name'
from Employee e, Employee super
where super.Id = e.Super_id
-----------------------------------------------
--16
select e.Fname + ' '+ e.Lname [fullname], ISNULL(Salary,Bouns)
from Employee e
---------------------------------------------
--17 
select MAX(Salary) as 'max salary', min(Salary) as 'min salary' 
from Employee
----------------------------------------------
--18
create or alter function evenORodd (@num int) returns varchar(50)
begin
	declare @result nvarchar(100)
	if @num % 2 = 0
	set @result = 'even'
	else
	set @result = 'odd'
	return @result
end
select dbo.evenORodd(0)
select dbo.evenORodd(1)
----------------------------------------------------
--19
create or alter function getBooksByCategory(@category varchar(50)) returns table
as
return(
select b.Title
from Book b, Category c
where c.Id = b.Cat_id and c.Cat_name = @category)

select * from dbo.getBooksByCategory('programming')
select * from dbo.getBooksByCategory('medical')
-----------------------------------------------------------
--20
create or alter function getBorrowedBookByUserPhone(@phone varchar(50)) returns table
as
return(
select u.User_Name, b.Title, br.Due_date, br.Amount
from Book b, Users u, Borrowing br, User_phones ph
where u.SSN = ph.User_ssn and ph.Phone_num = @phone and u.SSN = br.User_ssn and b.Id = br.Book_id)

select * from dbo.getBorrowedBookByUserPhone('0123654122')
select * from dbo.getBorrowedBookByUserPhone('0123654789')
---------------------------------------------------------------
--21
create or alter function userNameDuplicatedheck (@username varchar(100)) returns varchar(100)
begin
	declare @message varchar(100)
	declare @counter int

	select @counter = count(*)
	from users u
	where u.User_Name = @username

	if @counter = 0
		set @message = @username + ' is not found'
	else if @counter = 1
		set @message = @username + ' is not duplicated'
	else
		set @message = @username + ' is repeated ' + convert(varchar(30), @counter) + ' times'
	return @message
end

select dbo.userNameDuplicatedheck('amr ahmed')
select dbo.userNameDuplicatedheck('osama essam')
select dbo.userNameDuplicatedheck('yehia')
--------------------------------------------------------------------
--22
create or alter function getDateBasedOnFormat(@date date, @format varchar(100)) returns nvarchar(100)
begin
	declare @updatedDate nvarchar(100) 
	select @updatedDate = format (@date, @format)
	return @updatedDate
end

select dbo.getDateBasedOnFormat(getDate(), 'dddd-MMMM-yyyy')
select dbo.getDateBasedOnFormat('1/1/2020', 'dd-MM-yy')
select dbo.getDateBasedOnFormat(getDate(), 'ddd-MMM-yy hh:mm:ss')
------------------------------------------------------------------------------
--22 (another solution)
create or alter function getDateBasedOnFormatv02(@date date, @format int) returns nvarchar(100)
begin
	declare @updatedDate nvarchar(100) 
	select @updatedDate = convert(nvarchar(100), @date, @format)
	return @updatedDate
end

select dbo.getDateBasedOnFormatv02(getDate(), 101)
select dbo.getDateBasedOnFormatv02(getDate(), 130)
-------------------------------------------------------------------------
--23
create or alter proc getNumberOfBooksByCategory
as
select b.Cat_id, c.Cat_name, COUNT(*)
from book b, Category c
where c.Id = b.Cat_id
group by b.Cat_id, c.Cat_name

exec getNumberOfBooksByCategory
---------------------------------------------------------------
--24
create or alter proc updateManeger @oldEID int, @newEID int, @fnum int
as
update Floor 
set MG_ID = @newEID
where Number = @fnum and MG_ID = @oldEID

exec updateManeger 3, 7, 1
---------------------------------------------------------
--25
create or alter view AlexAndCairoEmpView
with encryption
as
select * from Employee
where Address in ('cairo','alex')

select * from AlexAndCairoEmpView
-------------------------------------------------------------
--26
create or alter view booksPerShelfView
with encryption
as
select Shelf_code,COUNT(*) as '#books per shelf'
from book b
group by b.Shelf_code

select * from booksPerShelfView
--------------------------------------------------------------
--27
create or alter view shelfWithMaxNumberOfBooksView
as
select top(1)* 
from booksPerShelfView
order by [#books per shelf] desc

select * from shelfWithMaxNumberOfBooksView
--------------------------------------------------------------------
--28
create table ReturnedBooks(
	userSSN varchar(50) foreign key references users(ssn),
	bookID int foreign key references book(id),
	dueDate date,
	retyrnDate date,
	fees int
	primary key (userssn, bookID)
)
		
create or alter trigger tri_test
on [dbo].[ReturnedBooks]			--problem
instead of insert
as
------------------------------------------------------------
--29
insert into Floor values(7,2,20,getDate())	
update floor
set MG_ID = 5
where Number = 6
update floor
set MG_ID = 12
where MG_ID = 5
----------------------------------------------------------
--30
create or alter view floorView
as
select * from Floor
where Hiring_Date >= '3/1/2022' and Hiring_Date <= '5/1/2022' with check option

select * from floorView
insert into floorView values(8,2,2,'7/8/2023')	-- will not be inserted because of the check option
insert into floorView values(9,1,4,'4/8/2022')	-- inserted successfully
-----------------------------------------------------------------
--31
create or alter trigger tri_Employee
on [dbo].[Employee]
instead of insert, update, delete
as
print('You can not take any action on this table')

insert into Employee (Fname) values ('yehia')
delete from Employee where Id = 1 
update Employee set Fname = 'ali' where id =1
-------------------------------------------------------------
--32

		


