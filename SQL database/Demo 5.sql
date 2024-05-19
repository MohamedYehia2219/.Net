use ITI

--cross join
select s.St_Fname, d.Dept_Name
from Student s, Department d

select s.St_Fname, d.Dept_Name
from Student s cross join Department d
--------------------------------------------------
--inner join
--ANSI
select s.St_Id, s.St_Fname, d.Dept_Name
from Student s, Department d
where d.Dept_Id = s.Dept_Id

--new join
select s.St_Id, s.St_Fname, d.Dept_Name
from Student s inner join Department d
on d.Dept_Id = s.Dept_Id
--------------------------------------------------
--outer join
--Left outer join
select s.St_Id, s.St_Fname, d.Dept_Name
from Student s left outer join Department d
on d.Dept_Id = s.Dept_Id

--Right outer join
select s.St_Id, s.St_Fname, d.Dept_Name
from Student s right outer join Department d
on d.Dept_Id = s.Dept_Id

--Full outer join
select s.St_Id, s.St_Fname, d.Dept_Name
from Student s full outer join Department d
on d.Dept_Id = s.Dept_Id
--------------------------------------------------------------
--self join
select s.St_Fname, super.St_Fname + ' ' + super.St_Lname as 'super visor'
from Student s, Student super 
where super.St_Id = s.St_super

select s.St_Fname, super.*
from Student s join Student super 
on super.St_Id = s.St_super
---------------------------------------------------------------------------
--Multi table join
select s.St_Id,s.St_Fname, c.Crs_Name, sc.Grade
from Student s, Course c, Stud_Course sc 
where s.St_Id = sc.St_Id and c.Crs_Id = sc.Crs_Id
order by s.St_Id

select s.St_Id,s.St_Fname, c.Crs_Name, sc.Grade
from Student s join  Stud_Course sc 
on s.St_Id = sc.St_Id 
join Course c
on c.Crs_Id = sc.Crs_Id
order by s.St_Id
--------------------------------------------------------------
--JOIN + DML
select s.St_Id,s.St_Address,sc.Grade
from Student s, Stud_Course sc 
where s.St_Id = sc.St_Id and s.St_Address ='cairo'

update sc
set sc.Grade = sc.Grade+(sc.Grade * 0.1)
from Student s, Stud_Course sc 
where s.St_Id = sc.St_Id and s.St_Address ='cairo'

update sc
set sc.Grade = sc.Grade+(sc.Grade * 0.1)
from Student s join Stud_Course sc 
on s.St_Id = sc.St_Id
where s.St_Address ='cairo'

delete from sc
from Student s, Stud_Course sc 
where s.St_Id = sc.St_Id and s.St_Address ='cairo'
----------------------------------------------------------