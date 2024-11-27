create table books 
( id  int primary key,
title varchar(20),
author varchar(20),
isbn varchar(20) unique not null,
published_date datetime)

insert into books 
values
(1,'My First SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My Third SQL book', 'Cary Flint',523120967812,'2015-10-18 14:05:44')




select *
from books
where author Like '%er';
-----------------------------------------------------------------------------------
create table reviews 
(id int primary key,
book_id int ,
reviewer_name varchar(20),
content varchar (40),
rating int,
published_date datetime
foreign key(book_id) references books(id))

insert into reviews(id,book_id, reviewer_name,content,rating,published_date)
values
(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','My second review',5,'2017-10-13 15:05:12'),
(3,2,'Alice Walker','Another review',1,'2017-10-22 23:47:10')

select title,
author,
reviewer_name
from books 
join reviews 
on 
books.id = reviews.book_id;

------------------------------------------------------------------------------------------



create table customer_table
(id int primary key,
name varchar(20),
age int,
address varchar(20),
salary float)

insert into customer_table
values 
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopla',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

select name 
from customer_table
where address like '%o%'
------------------------------------------------------------------------------------

select reviewer_name,
COUNT(book_id) as review_count
from reviews 
group by reviewer_name
having COUNT(book_id) > 1

--------------------------------------------------------------------------------------------
create table orders_table
(oid int primary key,
date datetime,
customer_id int,
amount int)



insert into orders_table
values
(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00' ,3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060)

select date,count(*) as total_customer
from orders_table
group by date;

--------------------------------------------
create table employee
(id int primary key,
name varchar(20),
age int,
address varchar(20),
salary float)



insert into employee
values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

select lower(name)
from employee
where salary is null;

--------------------------------
create table Student_details
(
Register_no int primary key,
Name varchar(30) not null,
Age int not null,
Qualification varchar(20),
Mobile_no float not null,
Mail_id varchar(30),
locationn varchar(30),
Gender varchar(1)
)
insert into Student_details values
(2,'Sai',22,'B.E',9952836779,'sai@gmail,com','Chennai','M'),
(3,'Kumar',20,'BSC',7252836779,'kumar@gmail,com','Madurai','M'),
(4,'Selvi',22,'B.TECH',8952836779,'selvi@gmail,com','Selam','F'),
(5,'Nisha',25,'M.E',6352836779,'nisha@gmail,com','Theni','F'),
(6,'SaiSaran',21,'B.A',9865836779,'saisaran@gmail,com','Madurai','F'),
(7,'Tom',23,'BCA',6552836779,'tom@gmail,com','Pune','M')

select Gender,
count(*) as total
from Student_details
group by Gender
 