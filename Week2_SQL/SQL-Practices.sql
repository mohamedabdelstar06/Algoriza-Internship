/* create table Employee(
Id int not null primary key,
Name nvarchar(50) not null,
Email nvarchar(50) not null,
GenderId int  )

create table Gender (
Id int primary key not null,
Gender nvarchar(50)  ,
)
use [sample6]
go
Alter table Employee 
Add constraint Employee_Gender_FK foreign key (GenderId) references Gender(Id)
*/

/* Default Constraint */
select * from Employee ;
select * from Gender;
insert into Employee(Id,Name,Email,GenderId) Values (2,'Yassir' ,'ghj@gmail.com',NULl)

Alter table Employee 
Add constraint DF_Employee_Gender default 3 for GenderId 

Alter table Employee
Drop DF_Employee_Gender 

/* Cascading Refrential constraint */

/* Check Constraint */
select * from Employee ;
Insert into Employee Values (1, 'Mohamed ' , 'mohamedabdelstar06@gmail.com', NULL,20)
Insert into Employee Values (2, 'Tala ' , 'mohamedabdelstar06@gmail.com', NULL,-200)
Insert into Employee Values (3, 'Rana' , 'Rana56@gmail.com', NULL,-200)
Alter table Employee
Add constraint cK_Employee_Age_Two check (Age <150 And Age > 0 )

Alter table Employee Add Age int 
DELETE FROM Employee
WHERE Age IS NULL OR Age <= 0 OR Age >= 150;


/* Identity Column */

CREATE TABLE Employee1 (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(100),
    Email nvarchar(100),
    GenderId int,
    Age int
);
use[sample6]
go
select * from Employee1

INSERT INTO Employee1(Name, Email, GenderId, Age)
VALUES 
('Omar', 'omar@gmail.com', 1, 25),
('Sara', 'sara@gmail.com', 2, 30),
('Ali', 'ali@gmail.com', 1, 28),
('Mona', 'mona@gmail.com', 2, 27),
('Khaled', 'khaled@gmail.com', 1, 35),
('Laila', 'laila@gmail.com', 2, 22),
('Tarek', 'tarek@gmail.com', 1, 40),
('Nada', 'nada@gmail.com', 2, 24),
('Hassan', 'hassan@gmail.com', 1, 33),
('Rania', 'rania@gmail.com', 2, 26);

/* Unique key constrain */
/*Both Primary key and unique are used to enforce 
1. A Table can have only one Primary key , but more than one unique key 
2. Primary key dosnt allow null where as unique key allow null
*/


alter table Employee1
add City  nvarchar(20) 
drop Constraint UQ_employee_Email 

insert into  Employee1(Name,GenderId,Age)values('Aliii',1,23)

/*Select Statement */
select Email from Employee1 

select distinct Email ,City from Employee1
select * from Employee1 where city <>'London'; 
select * from Employee1 where city !='London'; 
delete from employee1 Where id = 14 ; 

select * from Employee1 Where Age Between 22 and 30;

Select * from Employee1 Where Age between 10 and 25;

Select * from Employee1 where Name like '[^MST]%';

Select top 50 percent * from Employee1 order by Age desc;

/* Group By */
Select * from Employee1;
/* Aggregate Function */

select Top 2  Sum (Salary) as [Total Salary],City  
from Employee1 ,Gender
Where city ='london' /* Filtering is first */
/* Can use with insert , update slect statement
Aggregate fun can not use in wher but can used in having */

group by City


select Top 2  Sum (Salary) as [Total Salary],City  
from Employee1 ,Gender
group by City   /* Grouping is first */
having city ='london' /* Used with select statement only */



Alter table Employee1
Add Salary int 

delete  from Employee1 where id =15;


/* Joins in SQL Server - Intellegent join */
/* Lesson 3 , 5 */
select * from Instructor
Select * from Department

select  Ins_Name , Ins_Degree , Salary ,Dept_Name 
From Instructor I
right Join Department D
on I.Dept_id = D.Dept_id

where I.Dept_id is null;

select  Ins_Name , Ins_Degree , Salary ,Dept_Name 
From Instructor I
Full Join Department D
on I.Dept_id = D.Dept_id

where I.Dept_id is null or D.Dept_Id is null

/* joinning a table with it self is called a self join */

select * from Instructor;
select * from Course;
SELECT A.Ins_Id, A.Crs_Id AS Course1, B.Crs_Id AS Course2
FROM ins_Course A
JOIN ins_Course B
  ON A.Ins_Id = B.Ins_Id
WHERE A.Crs_Id < B.Crs_Id


/* Replace Null different join */
select  A.St_Fname +' ' + A.St_SName as [Full Name] ,IsNULL (B.St_Address,'No Department ' )
From dev.Student A
left Join dev.Student B
on A.St_id = B.St_id


sp_columns Student

SELECT  
  A.St_Fname + ' ' + A.St_Lname AS [Full Name],
  ISNULL(A.St_Address, 'ISNULL') as [Student Address]
FROM dev.student A
use Ruaaad 
go
SELECT  
  A.St_Fname + ' ' + A.St_Lname AS [Full Name],
  Coalesce(A.St_Address, 'Coalesce') as [Student Address] 
FROM dev.student A
/* Coalesce Function ??????? ??? NULL Value */
SELECT  
  A.St_Fname + ' ' + A.St_Lname AS [Full Name],
  Case When A.St_Address is NULL Then  'Case When' ELSE A.St_Address END as [Student Address]  
FROM dev.student A
select st_FName , st_LName, st_Address from dev.student

Select st_id ,Coalesce(st_FName , st_LName, st_Address) from dev.student 


/* Union & Union All */



select * from dev.Student
where st_fname is not  null
union All
Select * from dev.Saudi_Dogs
where st_fname is not  null
order by st_Fname


select * from dev.Student
where st_fname is not  null
union 
Select * from dev.Saudi_Dogs
where st_fname is not  null
order by st_Fname


Select * from dev.Saudi_Dogs
union 
select * from dev.Student

select * from union instructor And dev.Student



sp_columns Student

CREATE TABLE dev.Saudi_Dogs (
    St_Id INT,
    St_Fname NVARCHAR(50),
    St_Lname NCHAR(10),
    St_Address NVARCHAR(100),
    St_Age INT,
    Dept_Id INT,
    St_super INT
);

INSERT INTO dev.student (st_id, St_Fname, St_Lname, St_Address, St_Age, Dept_Id, St_super)
VALUES
(17 ,'Saud', 'Alshamrani', 'Jeddah', 22, 20, NULL),
(18,'Nasser', 'Alghamdi', 'Dammam', 23, 30, NULL),
(19,'Turki', 'Alzahrani', 'Khobar', 20, 10, NULL),
(20,'Abdullah', 'Alharbi', 'Qassim', 24, 20, NULL),
(21,'Nawaf', 'Almutairi', 'Tabuk', 22, 10, NULL),
(22, 'Badr', 'Alshehri', 'Abha', 23, 30, NULL),
(23,'Talal', 'Alqahtani', 'Hail', 25, 20, NULL)




/* Stored Procedure */
select * from dev.student
 
Exec SPGETInstructor

alter Proc SPGETInstructor 
/* NOT Recommended to naming with underscore _ _ */
with encryption
As
Begin
Select st_Fname + ' '+ st_LName as [Full Name] ,st_Address,st_Age  from dev.Student
End 

sp_help SPGETInstructor
Create Proc spGetInstuctorByGenderAndDepartment 
@instuctorDegree nvarchar (20),
@DepartmentId int
As begin 
select ins_id , ins_name ,ins_degree ,dept_id from instructor 
where dept_id = @DepartmentId and ins_degree = @instuctorDegree
End


exec spGetInstuctorByGenderAndDepartment  @DepartmentId = 10, @instuctorDegree = 'Master'
sp_helptext 'spGetInstuctorByGenderAndDepartment'


/* Alter Stored Procedure */
Alter proc spGetInstuctorByGenderAndDepartment

Create Proc spGetInstuctorByGenderAndDepartment   
@instuctorDegree nvarchar (20),  
@DepartmentId int  
As begin   
select ins_id , ins_name ,ins_degree ,dept_id from instructor   
where dept_id =@DepartmentId and ins_degree = @instuctorDegree  order by ins_name
End  


drop proc spGetInstuctorByGenderAndDepartment


alter proc spGetInstructorCountByGender
@ins_Degree nvarchar(20),
@InstructorCount int outPut
As
Begin 
select @InstructorCount=count(ins_id)   from instructor where ins_Degree =@ins_Degree
end
Declare  @TotalCount int 
Exec spGetInstructorCountByGender 'master' , @TotalCount out
if(@TotalCount is null)
print  '@TotalCount is NULL'
else print '@TotalCount is NOT NULL'
print  @TotalCount

create proc sp_MaxSalaryIns
@MaxSalary decimal(10,2) output
As begin 
select @MaxSalary = Max(salary) from Instructor 
end

Declare @result decimal(10,2)
exec sp_MaxSalaryIns @MaxSalary = @result out
Print @result --as MAXSalary  SELECT @result AS MaxSalary


sp_help sp_MaxSalaryIns
sp_helptext sp_MaxSalaryIns --show query to create SP
sp_depends sp_MaxSalaryIns
sp_depends instructor
 --Lesson 20 
create Proc spGetTotalCountOfEmployees2

as begin 
return(select Count(ins_id) from instructor) 
end

Declare @TotalInstructor int 
exec @TotalInstructor = spGetTotalCountOfEmployees2  
select @TotalInstructor as [Total Instructor]
use [Ruaaad]
go
create Proc spGetNameFromId2
@ID int 
as begin 
return (select ins_Name from instructor where ins_id = @id )
end

Declare @InstructorName nvarchar(20)
exec @InstructorName  =spGetNameFromId2 4  
select @InstructorName as [Instructor Name]

-- Built in function String function 
SELECT ASCII ('M')
SELECT char(65) -- 0 to 255

Declare @start int
set @start =65
while ( @start < 91)
begin 
print char (@start)
set @start =@start + 1 
end


SELECT LTRIM ('         Abdelstar               ')
select rTrim ('         Abdelstar               ')
select Trim ('         Abdelstar               ')
select ins_name from instructor

select Upper(ins_name)from instructor
select Lower(ins_name)from instructor
select reverse(ins_name)from instructor
select Len(ins_name)from instructor

select Left(ins_name,2)from instructor --return first 2 character
select right(ins_name,2)from instructor --return last 2 character

select  Charindex('@','SARA@aaa.com') -- index 5
select  SUBSTRING('Sara@aaa.com',6,6) ----aaa
select * from  Instructor 

select Substring(Email,CHARINDEX('@',Email)+1,LEN(Email)
-CHARINDEX('@',Email)), count(Email)
from employee1 
group by substring(Email,CHARINDEX('@',Email)+1,LEN(Email)
-CHARINDEX('@',Email)) 

--REPlicate - Space - STUFF 
select id,Name ,Substring(Email,1,2) +Replicate('*',5) +
substring(Email,CHARINDEX('@',Email),LEN(Email) - CHARINDEX('@',Email) +1) As Email 
from employee1 
 

 Select email ,STUFF(Email,3,3,'*****') as stuffedEmailed
 from employee1 


 use sample6
go

select name +Space(2)+ Email from Employee1
select email ,Replace(Email,'.com','.net') 
from employee1 

--DateTime --DatePart --DateAdd-- dateDiff

select ISDATE(GetDate())
select SYSDATETIMEOFFSET()
select GETDATE();
select ISDATE('2025-07-15 07:57:35.4742638')
select ISDATE('2025-07-15 07:58:42.4002582 +03:00')
select isDate('2025-07-15 07:56:02.263')
select year(GETDATE())
select dateName(month,getdate())
select dateName(m,getdate())
select dateName(WEEKDAY,getdate()) --tuesday

select DatePart(weekDay,getDate()) --3
select (getDate())
select DateAdd(Day,-20,'2025-07-15 08:14:06.157') --3

select DateDiff(year,'2025-12-25 08:14:06.157', '2026-01-15 08:14:06.157')

-- Age Problem using sql

select dbo.fnCompute ('03/19/1992')as [Date of birth] -- 33Years 3Months 26 day old 
use Company_SD
go 
create function fnCompute(@DOB dateTime)

returns nvarchar(50)

as 
begin

Declare  @tempdate DateTime , @Years int , @month int ,@day int 

select @tempdate = @Dob

select @Years = DATEDIFF(Year,@tempdate,GetDate()) -

CASE
WHEN (month(@Dob) > Month (GETDATE()) OR (MONTH(@DOB) = MONTH(GETDATE()))
AND dAY(@DOB) > dAY(GETDATE()))
THEN 1 ELSE 0 END

SELECT @tempdate =DATEADD(YEAR ,@Years,@tempdate)

select @month = DATEDIFF(MONTH,@tempdate,GetDate())
- CASE WHEN dAY(@DOB) > dAY(GETDATE()) THEN 1 ELSE 0 
END 

SELECT @tempdate = dATEaDD(MONTH ,@MONTH ,@TEMPDATE)
SELECT @DAY =DATEDIFF(DAY ,@TEMPDATE,GETDATE())

declare @age nvarchar(50)

SET @age =cast ( @Years as nvarchar(4))+ ' Years ' + cast (@month as nvarchar(2)) +' Months '+ cast(@day as nvarchar(2))+ ' day old '

return @age
End 


---Cast and Convert

SELECT CAST('2025-07-15' AS date) AS RealDate
DECLARE @date date = '2025-12-15'

SELECT LEFT(DATENAME(month, @date), 3) AS ShortMonth

--- Mathematical function
select Ceiling(-15.4) -- ????? ?????? ?????? 
select floor(15.6)-- ????? ?????? ??????
select abs(-15.4) -- ????? ?????? 
select SQUARE(7) --
select sqrt(49)
select Rand ()--*1000000000000000
select floor(Rand ()*100)

Declare @counter int
set @counter =1

while(@counter<=10)
begin 
print floor(Rand()*100) 
set @counter = @counter +1

end 


SELECT ROUND(128.4567, -1)


SELECT ROUND(163.4567, -2)
-- 200
SELECT ROUND(27.537, 2)
-- ??????: 27.53
-- 22 to 29 built in function
-- 30 User defined function
-- in line Table valued function 
-- scalar valued function 
-- aggregate function 
-- multi statement table valued function 
-- system function
select square(9) -- return scalar function : return single value 
alter function CountAge2 (@DOB datetime)

returns nvarchar(50)

as 
begin

Declare  @tempdate DateTime , @Years int , @month int ,@day int 

select @tempdate = @Dob

select @Years = DATEDIFF(Year,@tempdate,GetDate()) -

CASE
WHEN (month(@Dob) > Month (GETDATE()) OR (MONTH(@DOB) = MONTH(GETDATE()))
AND dAY(@DOB) > dAY(GETDATE()))
THEN 1 ELSE 0 END

SELECT @tempdate =DATEADD(YEAR ,@Years,@tempdate)

select @month = DATEDIFF(MONTH,@tempdate,GetDate())
- CASE WHEN dAY(@DOB) > dAY(GETDATE()) THEN 1 ELSE 0 
END 

SELECT @tempdate = dATEaDD(MONTH ,@MONTH ,@TEMPDATE)
SELECT @DAY =DATEDIFF(DAY ,@TEMPDATE,GETDATE())

declare @age nvarchar(50)

SET @age =cast ( @Years as nvarchar(4))+ ' Years ' + cast (@month as nvarchar(2)) +' Months '+ cast(@day as nvarchar(2))+ ' day old '

return @age
End 

select * , dbo.CountAge2(bdate)  Age from Employee
where  > 50
-- Transact sql 
Declare @DOB datetime ,@years int 

set @DOB = '09/25/2026'
select @years = DATEDIFF(YEAR, @DOB ,GETDate())-
case 
when (month (@DOB) > month(getdate())) or 
(month(@DOB) =month(getdate()) and day(@DOB) > day(getdate()))
then 1 else 0 end




select *, DATEDIFF(year, bdate, GETDATE()) - 
    CASE
        WHEN (MONTH(bdate) > MONTH(GETDATE())) 
             OR (MONTH(bdate) = MONTH(GETDATE()) AND DAY(bdate) > DAY(GETDATE()))
        THEN 1 ELSE 0 
    END as Age
from Employee
where 
    DATEDIFF(year, bdate, GETDATE()) - 
    CASE
        WHEN (MONTH(bdate) > MONTH(GETDATE())) 
             OR (MONTH(bdate) = MONTH(GETDATE()) AND DAY(bdate) > DAY(GETDATE()))
        THEN 1 ELSE 0 
    END > 50



-- inline table vlued function
SELECT * FROM fn_employeeByGender('f')

-- scalar function return single value 
-- intable vlued function return a table 
Create function fn_employeeByGender (@sex nvarchar(20))
returns  table
as 
return (select ssn , fname +space(2)+lname as [Full Name]  ,Address ,sex, bdate, salary 
from Employee where sex = @sex )
-- as a table after from is table
select [Full Name] ,sex, DName
from  fn_employeeByGender('f') E join Departments D 
on d.Dnum = e.dno

ALTER FUNCTION fn_employeeByGender (@sex nvarchar(20))
RETURNS TABLE
AS
RETURN (
    SELECT ssn, fname + space(2) + lname AS [Full Name], Address, sex, bdate, salary, Dno
    FROM Employee
    WHERE sex = @sex
)




----Multi statement table valued function 
Create function fnGetEmployee()
returns @table Table (SSN int , fname nvarchar(20) , lname nvarchar(20), bdate date)
as 
begin
insert into @table
select ssn ,fname , lname ,cast(bdate as date)
from employee
return end

select * from fnGetEmployee()

select  ssn , fname , lname ,bdate from employee

-- Differences 
-- inline no determine structure of the table 
-- multi must determine structure of the table 
-- -------------------------------------
-- begin and end is requred at multi not required for inline 
-- ------------------------------------------
-- inline are always better for performance than multi statement value function
      --- Why ? the reason is ==> (1) SQL server treats an inline as view 
	  --- and treat multi as stored procedure 
	  --- (2) inline create t-sql direct to the table but multi create table structure 
	  --- multi return data at another table
      --- (3) you can update column data inline directly but multi cannot be  and will give you error 


-- important concept related to functions in sql server 
-------------------------------------------------------
-- non deterministic like getDate , rand , current_timeStamp
select rand(1) -- seed value => non deterministic 
select rand() --- deterministic 

create  function fn_GetNameFromId (@ssn int)
returns nvarchar(20)
with Schemabinding
as
begin
return (select fname from dbo.employee where ssn =@ssn)
end 
sp_helptext fn_GetNameFromId
drop table employee
select dbo.fn_GetNameFromId(1)

-- Local Temporary table  include in this session 
-- is automatically dropped when connection that has created it is closed
drop table #PersonDetails
Create table #PersonDetails (
id int ,
Person_Name nvarchar(25)
)

INSERT INTO #PersonDetails (id, Person_Name)
VALUES 

(5, 'Ahmed'),
(6, 'Fatma'),
(7, 'Ibrahim'),
(8, 'Sara'),
(9, 'Khaled'),
(10,'Nour')

Select * from #PersonDetails

----------------------------------
----------------------------------
create procedure spTempTable 

as begin 
Create table #eDetails (
id int ,
Person_Name nvarchar(25)
)

INSERT INTO #eDetails(id, Person_Name)
VALUES 

(5, 'mohAmed'),
(6, 'Fatma'),
(7, 'Ibrahim'),
(8, 'Sara'),
(9, 'Khaled'),
(10,'Nour')

Select * from ##EmployeeDetails
end
exec spTempTable



---------------------------------------
---------------------------------------
-- Indexes
-- Table Scan 
-- Index seek -- clustered index -- non clustered --primary -- secondary
-- spatial index--non clustered cloumnstore --clustered cloumnstore
-- unique -- filtered - xml -- spatial -- full text 
select * from Employee where salary > 15000 and salary < 26000
Create index IX_Employee_Salary 
on Employee (salary Asc)




--- Clustered index sort 
use company_sd 
go
exec sp_helpindex employee

-- table contain one clustered index
create nonclustered index IX_Employee_Sex_Salary
on employee(sex desc ,salary asc)

select exec sp_helpindex  employee
 
drop index employee.PK_Employee

create NonClustered index 
SELECT Sex, Salary FROM Employee

--unique -- non unique index 
drop index   UIX_Employyee_firstName_lastName
on employee

-- difference between unique constraint unique indexes

--1) by default primary key constraints creates a unique clustered index
-- but unique constraint creates a unique non clustered index 
--(2) cannot create a unique constraint or a unique index on an existing
-- table if table contains duplicate values 

---- Advantages and disadvantage 
select * from employee where salary >15000 and salary < 26000

delete from employee where superssn  in(
select ssn from employee where salary = 1500 )


DELETE FROM Works_for WHERE ESSn IN (
    SELECT ssn FROM Employee WHERE Salary = 1500
);

DELETE FROM Employee WHERE Salary = 1500;

-- Covering query 

create view VWEmployeeDepartmentsWithIT
as 
select Fname + ' ' + lname as [ Full Name ] , address ,salary , dno ,Dname
from employee E join Departments D
on e.dno = d.dnum
where d.dname = 'Aviation'

select * from VWEmployeeDepartmentsWithIT -- virtual table 
sp_helptext VWEmployeeDepartments

-- reduce complexity of the database schema 
create view VWCountEmployeeDepartment 
as 
select dname , count (ssn) as TotalEmployees
from employee e join departments d
on e.dno =d.dnum

group by dname
HAVING COUNT(ssn) > 5  

----Updateable views
create view VWEmployeeDataEceptSalary1
as 
select  Fname , lname ,sex, bdate, address, SSn 
from employee 

update  VWEmployeeDataEceptSalary1
set  Fname = 'Israa  Abdelstar ', sex = 'f'
where ssn = 223344

select * from VWEmployeeDataEceptSalary1
select * from employee

delete from VWEmployeeDataEceptSalary1 where  address ='18 Abaas El 3akaad St. Nasr City.Cairo'


-- Indexed View 




-- view Limitation
create view VWEmployeeDetails
@gender nvarchar(20)
as
select Fname , lname ,address , ssn ,dno
from employee where @Gender = ssn

alter function fnEmployeeDetails(@gender char(20))
returns table 
as 
return
(select ssn , fname , lname ,address from employee where @gender = ssn)

select * from  fnEmployeeDetails('f')
-- Triggers 
-- DML - DDL - Logon trigger 
-- DML (Insert , Update , Delete )
-- DML can classified into 2types
-- After triggers , fires after the triggering action ( 
-- Instead of Triggers
-- after triggerers
Create table EmployeeData(
ID int identity(1,1) primary key ,
AuditData nvarchar (1000) )

select * from EmployeeData 
create trigger tr_Employee_For_Insert
on Employee 
for insert 
as 
begin 
Declare @id int 
select @id = Id from inserted 
insert into employeeAudit 
values ('New employee with Id = ' + cast (@id as nvarchar(5)) +'is added at ' +
cast(GETDATE() as nvarchar(20)) ) end

select * tr_Employee_For_Insert
create table employeeAudit (
    ID int identity(1,1) primary key,
    AuditData nvarchar(1000)
)
delete  from  Employee where salary =1000;

select * from employeeAudit


(Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno, Id)
values
('Omar',    'Ahmed',   10301, '1990-05-10', 'Cairo, Egypt',       'M', 50000, null, 20, 1001),
('Sara',   'Hassan',  1002, '1992-03-12', 'Alexandria, Egypt',  'F', 5200, null, 20, 1002),
('Omar',   'Khaled',  1003, '1988-08-22', 'Giza, Egypt',        'M', 4800, null, 10, 1003),
('Mona',   'Sami',    1004, '1995-11-03', 'Tanta, Egypt',       'F', 5100, null, 30, 1004),
('Youssef','Mahmoud', 1005, '1991-02-17', 'Mansoura, Egypt',    'M', 5300, null, 20, 1005)

select * from employee
select * from employeeAudit

sp_help employeeAudit

create trigger tr_Employee_For_delete
on Employee 
for delete
as 
begin 
Declare @id int 
select @id = Id from deleted 
insert into employeeAudit 
values ('An Existing employee with Id = ' + cast (@id as nvarchar(5)) +'is deleted at ' +
cast(GETDATE() as nvarchar(20)) ) end

select * from employeeaudit



-- DML Triggers 
-- After update tigger
create trigger tr_EmployeeForUpdate 
on employee 
for update 
as 
begin 
select * from deleted
select * from inserted
end

update employee set fname ='Abdelstar' , lname ='Abdelkader' ,sex ='m',
Address ='Buirdien' where id = 7

Employee with id  changed name from to 

for(i int; i <= 50; i++)
select(i)
sp_help employee

-- Create AFTER UPDATE trigger on Employee table
create trigger tr_Employee_AfterUpdate
on Employee
after update
as
begin
    -- ????? ??? ????? ????? ?????? ?? EmployeeAudit
    -- deleted: ??? ???????? ??? ???????
    -- inserted: ??? ???????? ??? ???????

    -- Fname
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Fname from ' + isnull(d.Fname,'NULL') +
        ' to ' + isnull(i.Fname,'NULL') +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Fname,'') <> isnull(i.Fname,'')

    -- Lname
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Lname from ' + isnull(d.Lname,'NULL') +
        ' to ' + isnull(i.Lname,'NULL') +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Lname,'') <> isnull(i.Lname,'')

    -- Address
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Address from ' + isnull(d.Address,'NULL') +
        ' to ' + isnull(i.Address,'NULL') +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Address,'') <> isnull(i.Address,'')

    -- Sex
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Sex from ' + isnull(d.Sex,'NULL') +
        ' to ' + isnull(i.Sex,'NULL') +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Sex,'') <> isnull(i.Sex,'')

    -- Salary
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Salary from ' + cast(isnull(d.Salary,0) as nvarchar(20)) +
        ' to ' + cast(isnull(i.Salary,0) as nvarchar(20)) +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Salary,0) <> isnull(i.Salary,0)

    -- Superssn
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Superssn from ' + cast(isnull(d.Superssn,0) as nvarchar(20)) +
        ' to ' + cast(isnull(i.Superssn,0) as nvarchar(20)) +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Superssn,0) <> isnull(i.Superssn,0)

    -- Dno
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Dno from ' + cast(isnull(d.Dno,0) as nvarchar(20)) +
        ' to ' + cast(isnull(i.Dno,0) as nvarchar(20)) +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Dno,0) <> isnull(i.Dno,0)

    -- Bdate
    insert into EmployeeAudit (AuditData)
    select 
        'Employee with id ' + cast(i.Id as nvarchar(10)) +
        ' changed Bdate from ' + cast(d.Bdate as nvarchar(20)) +
        ' to ' + cast(i.Bdate as nvarchar(20)) +
        ' at ' + cast(getdate() as nvarchar(20))
    from inserted i
    join deleted d on i.Id = d.Id
    where isnull(d.Bdate,'') <> isnull(i.Bdate,'')
end
--------------------------------------------------------
---------------------------------------------------------
--------------------------------------------------------
-- Temptables -- 
sp_help employee

-- Sample Data with Redundancy and Design Problems
INSERT INTO Employee (Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno, Id)
VALUES 
('Ahmed', 'Ali', 10010, '1990-01-01', '10 El Tahrir St, Cairo', 'M', 7000, 2001, 10, 10),
('Mona', 'Hassan', 10002, '1992-05-12', '12 El Tahrir St, Cairo', 'F', 6800, 2001, 10, 12),
('Mohamed', 'Ibrahim', 10003, '1988-03-15', '15 Mostafa St, Giza', 'M', 7200, 2002, 20, 13),
('Sara', 'Youssef', 10040, '1995-08-25', '5 October St, Giza', 'F', 6900, 2002, 20, 14),
('Ali', 'Sami', 100500, '1991-06-30', '10 El Tahrir St, Cairo', 'M', 7000, 2001, 10, 15),
('Nour', 'Ahmed', 100600, '1993-02-10', '12 El Tahrir St, Cairo', 'F', 6800, 2001, 10, 16),
('Khaled', 'Mahmoud', 100007, '1989-11-20', '20 El Nasr St, Cairo', 'M', 7300, 2003, 30, 17);



-- 1NF - 6NF Normal form


CREATE TABLE Sales (
    SalesID INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(50),
    SalesMonth NVARCHAR(10),
    QuantitySold INT
);
 select productName , salesmonth , 
 sum(QuantitySold) as Total
 from sales 
 group by productName , salesmonth
 order by salesmonth

 select salesmonth ,phone , tablet, laptop
 from sales 
 pivot (
 sum (QuantitySold)
 for productName 
 in([phone] ,[tablet],[laptop])
 ) as pivotTable

select SalesMonth,Laptop, phone, tablet -- select non pivoted + ,pivoted column
from( select -- select query that produce the data
ProductName, SalesMonth, QuantitySold
from Sales ) as sourceTable -- as alias name source table
pivot (
sum(quantitySold) -- aggregation function
for ProductName -- for clumnn that contains values pivoted 
in ( [phone] ,[tablet],[laptop])) -- in first pivoted , second pivoted 
as pivotedTable

SELECT SalesMonth, ISNULL([Phone], 0) AS Phone, ISNULL([Tablet], 0) AS Tablet, ISNULL([Laptop], 0) AS Laptop
FROM (
    SELECT ProductName, SalesMonth, QuantitySold
    FROM Sales
) AS SourceTable
PIVOT (
    SUM(QuantitySold)
    FOR ProductName IN ([Phone], [Tablet], [Laptop])
) AS PivotedTable
ORDER BY SalesMonth;




INSERT INTO Sales (ProductName, SalesMonth, QuantitySold) VALUES
('Laptop', 'Jan', 10),
('Laptop', 'Feb', 15),
('Laptop', 'Mar', 7),
('Phone', 'Jan', 20),
('Phone', 'Feb', 25),
('Phone', 'Mar', 18),
('Tablet', 'Jan', 8),
('Tablet', 'Feb', 10),
('Tablet', 'Mar', 6),
('Laptop', 'Apr', 12);
--================================================
-- Error handling in sql server 2000
sp_help employee
CREATE VIEW select * from v_DepartmentStats
WITH SCHEMABINDING
AS
SELECT 
    Dno, 
    COUNT_BIG(*) AS EmployeeCount, 
    SUM(Salary) AS TotalSalary
FROM dbo.Employee
GROUP BY Dno;

use company_sD
go 
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100)
);
drop table sales
create TABLE Sales (
    SaleID INT PRIMARY KEY,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
-- ????? ??????
INSERT INTO Products (ProductID, ProductName) VALUES
(1, 'Laptop'),
(2, 'Mouse'),
(3, 'Keyboard'),
(4, 'Monitor'),
(5, 'USB Cable');

-- ????? ??????
INSERT INTO Sales (SaleID, ProductID, Quantity) VALUES
(1, 1, 2),
(2, 2, 5),
(3, 4, 1);

SELECT ProductName
FROM Products
WHERE ProductID NOT IN (
    SELECT ProductID
    FROM Sales
);

-- non correlated subquery 
-- Correlated Sub
SELECT salary
FROM Employee
WHERE Salary = (
    SELECT max(Salary) FROM Employee where
);
SELECT DNo, AVG(Salary) AS AvgSalary
FROM Employee
GROUP BY DNo
--order by AvgSalary desc

SELECT DNo, Salary AS TotalSalary
FROM Employee
--GROUP BY Dno
ORDER BY TotalSalary;

SELECT  top 5 Salary, fname FROM Employee  
ORDER BY Salary DESC  

SELECT MAX(Salary)  
FROM Employee  
WHERE Salary < (SELECT MAX(Salary) FROM Employee);

SELECT MAX(Salary)  
FROM Employee  
WHERE Salary < (SELECT MAX(Salary) FROM Employee);










