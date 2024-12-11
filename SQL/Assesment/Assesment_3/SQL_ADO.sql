create database SQL_Assesment_3


create table Course_Details
(C_id varchar(20),
C_Name varchar(20),
Start_date DATE,
End_date DATE,
Fee int)



insert into Course_Details
values
('DN003','DotNet','2018-02-01','2018-02-28',15000),
('DV004','Data Visualization','2018-03-01','2018-04-15',15000),
('JA002','AdvancedJava','2018-01-02','2018-01-20',10000),
('JC001','CoreJava','2018-01-02','2018-01-12',3000)

select * from Course_Details




create function calculate_course_Duration
(@StartDate date,
@EndDate date)
returns int
as
begin
return DATEDIFF(DAY, @StartDate,@EndDate)
end;

select C_id,C_Name,Fee,dbo.calculate_course_Duration(Start_date,End_date) as Course_duration from Course_Details





create trigger tgrCourseDetails
on Course_Details
for insert
as 
begin
insert into Course_Details(C_Name,Start_date)
select C_Name, Start_date 
from inserted
end;

insert into  Course_Details
(C_id,
C_Name,
Start_date,
End_date,
Fee)
values
('SQL04','SQL','2024-10-16','2024-12-30',15000);



select C_Name, Start_date from Course_Details


-----------------------------------

create table ProductsDetails(ProductId int, ProductName varchar(30), Price Float, DiscountedPrice Float);

create procedure sp_productdetails
@ProductId int,
@ProductName varchar(30),
@Price Float,
@DiscountedPrice Float
as
Begin
insert into ProductsDetails(ProductId, ProductName, Price, DiscountedPrice) 
values
(@ProductId, @ProductName, @Price, @DiscountedPrice);
end

create procedure sp_productdetails2
@ProductId int,
@ProductName varchar(30),
@Price Float,
@DiscountedPrice Float
as
Begin
 
select * from ProductsDetails;
 
end

 
select * from ProductsDetails;
