create database Sept20
use Sept20

--1
create table Member(Member_ID numeric(5) primary key, Member_Name Char(25), Acc_Open_Date Date,
Max_Books_Allowed numeric(2), Penalty_Amount numeric(7,2))

create table Book(Book_No numeric(6) primary key, Book_Name varchar(30), Author Char(30), 
Cost numeric(7,2), Category Char(10))

create table Issue(Lib_Issue_Id	numeric(10) primary key, Book_No numeric(6) foreign key references Book(Book_No),
Member_Id numeric(5) foreign key references Member(Member_Id), Issue_Date Date, Return_date Date)

--2
sp_help Member
sp_help Book
sp_help Issue

--3
alter table issue
add Comment varchar(100) 

--4
alter table Member 
alter column Member_Name Char(30)

--5
alter table Issue
add Reference varchar(30)

--6
alter table Issue
drop column Reference 

--7
exec sp_rename 'Issue',  'Lib_Issue';

--8
insert into Member values(1,'Shravya','2005-12-10',5,50)
insert into Member values(2,'Shailaja','2000-01-07',9,100)
insert into Member values(3,'Ramya','2005-01-14',7,101)
insert into Member values(4,'Bhargavi','2000-04-17',3,108)
insert into Member values(5,'Mayuri','2000-03-13',2,500)
insert into Member values(6,'Radha','2000-04-19',5,50)
insert into Member values(7,'Sheena',CURRENT_TIMESTAMP,3,null)

--9   
alter table Member 
alter column Member_Name Char(20)



--10

insert into Member values(5,'Geetha','2000-03-13',110,500)
--Compilation not completed successfully.
--Reason: Msg 8115, Level 16, State 8, Line 59
----------Arithmetic overflow error converting int to data type numeric.
----------The statement has been terminated.

--11
select * into Member101 from Member
select * into Member102 from Member where 1=2 --//without data


--12
insert into Book values(101,'Let us C',	'Denis Ritchie', 450 , 'System')
insert into Book values(102, 'Oracle – Complete Ref', 'Loni', 550	,'Database')
insert into Book values(103, 'Mastering SQL', 'Loni', 250, 'Database')
insert into Book values(104, 'PL SQL-Ref', 'Scott Urman', 750, 'Database')

--13
insert into Book values(105 , 'Stellar' , 'Soam Jena' , 500 , 'Trading')
insert into Book values(106 & 'C# Basics' & 'Jolie' & 340 & 'System') --error

--14
select * into Book101 from Book where 1=2

--15
insert into Book101 select * from Book

--16) Save all the data so far inserted in the tables.


--17
select * from Member
select * from Member101
select * from Book
select * from Book101
select * from Issue --error



--18
insert into Book values(107,'National Geographic', 'Adis Scott', 1000,  'Science')

--19
delete from book where Book_no = 105

--20
update Book set Cost = 300, Category = 'RDBMS' where Book_No = 103

--21
exec sp_rename 'Lib_Issue', 'Issue'  --caution


--22
alter table Issue drop column Comment
insert into Issue values(7001,101,1,'10-Dec-06','')
insert into Issue values(7002,102,2,'25-Dec-06','')
insert into Issue values(7003,104,1,'15-Jan-06','')
insert into Issue values(7004,101,1,'04-Jul-06','')
insert into Issue values(7005,104,2,'15-Nov-06','')
insert into Issue values(7006,101,3,'18-Feb-06','')

--23
insert into Issue values(7007,103,3,'12-Oct-06','')
insert into Issue values(7008,102,1,'28-Mar-06','')

--24
update Issue set Return_date = '19-Jul-06' where Lib_Issue_Id = 7004
update Issue set Return_date = '30-Nov-06' where Lib_Issue_Id = 7005

--25
update Member set Penalty_Amount = 300 where Member_Name = 'Shravya'

--26
delete from Issue where Member_Id = 1 and Issue_Date < '10-Dec-06'

--27
delete from Book where Category != 'RDBMS' and  Category != 'Database' --error

--28
drop table Member101

--29
drop table Book101

--30
select * from Member
select * from Book
select * from Issue





-- Problem 2 
select * from Member
select * from Issue
select * from Book

select * from Member where Year(Acc_Open_Date) = 2006

select * from Book where Author = 'Loni' and Cost < 600

select * from Issue where Return_date > GETDATE()

update Issue set Return_date = '31-Dec-06 ' where Lib_Issue_Id != 7005 and Lib_Issue_Id != 7006

select * from Issue where (Day(Return_date) - Day(Issue_Date)) > 30

select * from Book where (Cost >= 500 and Cost <= 750) and Category = 'Database'

select * from Book where Category = 'Science' or Category = 'Database'or  Category ='Fiction'or  Category = 'Management'

select * from Member order by Penalty_Amount desc

select * from Book order by Category, Cost desc

select * from Book where Book_Name like '%SQL%'

select * from Member where Member_Name like 'R%' or Member_Name  like 'G%' and Member_Name  like '%I%'

select upper(Author) as Author_In_Upper from Book order by Book_Name desc

select Book_No,('is written by') as '--------------------',Book_Name from Book


--Task 14

select * from Book where Category like '%D'

select Lib_Issue_Id, Issue_Date, Return_Date, (Return_Date - Issue_Date) as No_of_Days_Book_issued  from Issue --error

select count(Book_No) from Issue where Member_Id = 101

select sum(Penalty_Amount) as Total_Penalty from Member

select sum(Cost) as Total_Cost from Book where Category = 'Database'

select min(Cost) as Cheapest_Book from Book

select avg(Cost) as Average_Price_Book from Book

select * from Member
select * from Issue
select * from Book
