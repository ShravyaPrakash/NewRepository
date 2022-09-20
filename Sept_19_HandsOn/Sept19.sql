--Problem 1
create database Shopping
use Shopping

--Problem 2
--a
create table Customer
(
Custid int primary key,
CustName varchar(20) ,
City varchar(20) , 
StateName varchar(20)
);

--b
create table products
(Prodid int primary key,
ProdName varchar(20),
UnitPrice int ,
UnitOfMeasurement varchar(20),
QtyinStock int
);

--c
create table Sales_Header
(
InvoiceNo int primary key,
InvoiceDate date,
InvoiceAmt int,
DiscountPercent int
);

--d
create table Sales_Detail
(
InvoiceNo int,
Custid int,
Prodid int,
QtySold int
);

--e
alter table Sales_Detail
add foreign key(InvoiceNo) references Sales_Header(InvoiceNo)

--Problem 3
alter table Sales_Detail
add foreign key(Custid) references Customer(Custid), foreign key(Prodid) references products(Prodid)

--Problem 4
alter table Sales_Detail
drop column QtySold


--Problem 5
alter table Sales_Detail
add Qty int


--Problem 6
exec sp_rename 'Sales_Detail.qty',  'Quality', 'column';


