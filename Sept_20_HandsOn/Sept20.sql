create database Sept20
use Sept20

-- Problem 1
--1) Create the table Member, Book and Issue without any constraints as mentioned in the schema description above.
create table Member
(Member_ID numeric(5) primary key, 
Member_Name Char(25), 
Acc_Open_Date Date,
Max_Books_Allowed numeric(2), 
Penalty_Amount numeric(7,2)
)

create table Book
(Book_No numeric(6) primary key, 
Book_Name varchar(30), 
Author Char(30), 
Cost numeric(7,2), 
Category Char(10))

create table Issue
(Lib_Issue_Id	numeric(10) primary key, 
Book_No numeric(6) foreign key references Book(Book_No),
Member_Id numeric(5) foreign key references Member(Member_Id), 
Issue_Date Date, 
Return_date�Date)

--2) View the structure of the tables.
sp_help Member
sp_help Book
sp_help Issue

--3) Add column Comments to table Issue of width 100 characters.
alter table Issue
add Comment varchar(100) 

--4) Modify the table Member increase the width of the member name to 30 characters.
alter table Member 
alter column Member_Name�Char(30)

--5) Add a column Reference Char(30) to Issue table.
alter table Issue
add Reference varchar(30)

--6) Delete/Drop the column Reference from Issue.
alter table Issue
drop column Reference 

--7) Rename the table Issue to Lib_Issue.
exec sp_rename 'Issue',  'Lib_Issue';

--8) Insert following data in table Member
insert into Member values(10,'Richa Sharma','2005-12-10',5,50)
insert into Member values(2,'Shailaja','2000-01-07',9,100)
insert into Member values(3,'Ramya','2005-01-14',7,101)
insert into Member values(4,'Bhargavi','2000-04-17',3,108)
insert into Member values(5,'Mayuri','2000-03-13',2,500)
insert into Member values(6,'Radha','2000-04-19',5,50)
insert into Member values(70,'Garima Sen',CURRENT_TIMESTAMP,3,null)

--9) Modify the column Member Decrease the width of the member name to 20 characters. (If it does not allow state the reason for that)
alter table Member 
alter column Member_Name�Char(20)


--10) Try to insert a record with Max_Books_Allowed = 110, Observe   the error that comes. Report the reason for this error.

insert into Member values(5,'Geetha','2000-03-13',110,500)
--Compilation not completed successfully.
--Reason: Msg 8115, Level 16, State 8, Line 67
----------Arithmetic overflow error converting int to data type numeric.
----------The statement has been terminated.

--11) Generate another table Member101 using a Create command along with a simple SQL query on member table.
select * into Member101 from Member
select * into Member102 from Member where 1=2 --//without data


--12)	Insert data in Book table as follows:
insert into Book values(101,'Let us C',	'Denis Ritchie', 450 , 'System')
insert into Book values(102, 'Oracle � Complete Ref', 'Loni', 550	,'Database')
insert into Book values(103, 'Mastering SQL', 'Loni', 250, 'Database')
insert into Book values(104, 'PL SQL-Ref', 'Scott Urman', 750, 'Database')

--13)	Skip

--14) Create table Book101 similar to Book in structure with no data in it.
select * into Book101 from Book where 1=2

--15) Insert into Book101 all the data in Book table using Select statement.
insert into Book101 select * from Book

--16) Save all the data so far inserted in the tables.

--17) View the data in the tables using simple SQL query.
select * from Member
select * from Member101
select * from Book
select * from Book101
select * from Issue 

--18) Insert into Book following data. 105,  National Geographic, Adis Scott, 1000,  Science
insert into Book values(107,'National Geographic', 'Adis Scott', 1000,  'Science')

--19) Undo the last changes.
delete from book where Book_no = 105

--20) Modify the price of book with id 103 to Rs 300 and category to RDBMS.
update Book set Cost = 300, Category = 'RDBMS' where Book_No = 103

--21) Rename the table Lib_Issue to Issue.
exec sp_rename 'Lib_Issue', 'Issue'  --caution
 

--22) Insert following data into Issue table. Note leave the column Return_Date blank.
alter table Issue drop column Comment
insert into Issue values(7001,101,1,'10-Dec-06','')
insert into Issue values(7002,102,2,'25-Dec-06','')
insert into Issue values(7003,104,1,'15-Jan-06','')
insert into Issue values(7004,101,1,'04-Jul-06','')
insert into Issue values(7005,104,2,'15-Nov-06','')
insert into Issue values(7006,101,3,'18-Feb-06','')

--23) Insert 2 records in Issue table.
insert into Issue values(7007,103,3,'12-Oct-06','')
insert into Issue values(7008,102,1,'28-Mar-06','')

--24) Modify the Return_Date of 7004,7005 to 15 days after the Issue_date.
update Issue set Return_date = '19-Jul-06' where Lib_Issue_Id = 7004
update Issue set Return_date = '30-Nov-06' where Lib_Issue_Id = 7005

--25) Modify the Penalty_Amount for Garima Sen to Rs 100.
update Member set Penalty_Amount = 300 where Member_Name = 'Shravya'

--26) Remove all the records from Issue table where member_ID is 1 and Issue date in before 10-Dec-06.
delete from Issue where Member_Id = 1 and Issue_Date < '10-Dec-06'

--27) Remove all the records from Book table with category other then RDBMS and Database.
delete from Book where Category != 'RDBMS' and  Category != 'Database' --error

--28) Remove the table Member101.
drop table Member101

--29) Remove the table Book101.
drop table Book101

--30) View the data and structure of all the three tables Member, Issue, Book.
select * from Member
select * from Book
select * from Issue

--31) List all the tables created by the user
show tables



-- Problem 2 
--1) List all the members that became the member in the year 2006.
select * from Member where Year(Acc_Open_Date) = 2006

--2) List all the books that are written by Author Loni and has price less then 600
select * from Book where Author = 'Loni' and Cost < 600

--3) List the Issue details for the books that are not returned yet.
select * from Issue where Return_date > GETDATE()

--4) Update all the blank return_date with 31-Dec-06 excluding 7005 and 7006.
update Issue set Return_date = '31-Dec-06 ' where Lib_Issue_Id != 7005 and Lib_Issue_Id != 7006

--5) List all the Issue details that have books issued for more then 30 days.
select * from Issue where (Day(Return_date) - Day(Issue_Date)) > 30

--6) List all the books that have price in range of 500 to 750 and has category as Database.
select * from Book where (Cost >= 500 and Cost <= 750) and Category = 'Database'

--7) List all the books that belong to any one of the following categories Science, Database, Fiction, Management.
select * from Book where Category = 'Science' or Category = 'Database'or  Category ='Fiction'or  Category = 'Management'

--8) List all the members in the descending order of Penalty due on them.
select * from Member order by Penalty_Amount desc

--9) List all the books in ascending order of category and descending order of price.
select * from Book order by Category, Cost desc

--10)	List all the books that contain word SQL in the name of the book.
select * from Book where Book_Name like '%SQL%'

--11) List all the members whose name starts with R or G and contains letter I in it.
select * from Member where Member_Name like 'R%' or Member_Name  like 'G%' and Member_Name  like '%I%'

--12) List the entire book name in Init cap and author in upper case in the descending order of the book name.
select upper(Author) as Author_In_Upper from Book order by Book_Name desc

--13) Show the data in the following format :
select Book_No,('is written by') as '--------------------',Book_Name from Book



--20)	Display the count of total no of books issued to Member 101.
select count(Book_No) from Issue where Member_Id = 101

--21) Display the total penalty due for all the members.
select sum(Penalty_Amount) as Total_Penalty from Member

--22) Find the total cost of all the books that come under category Database.
select sum(Cost) as Total_Cost from Book where Category = 'Database'

--23) Find the cheapest book price in the library.
select min(Cost) as Cheapest_Book from Book



select * from Member
select * from Issue
select�*�from�Book
