use Assignment_2

select * from emp

----------first question---------------
select DATENAME(WEEKDAY,
'2001-06-07') as Birthday_day;

--------second question--------

select datediff(Day,'2001-06-07',getdate()) as Age_in_days;

-------third question------------------

select *
from emp 
where datepart(year,getdate()) - datepart(year,hiredate) >= 5 
and datepart(month,hiredate) = datepart(month,getdate());

----------------------fourth question---------------------------------------

create table employee(
empno int primary key,
ename varchar(50),
sal float,
doj date,);

insert into employee
(empno, ename,sal,doj)
values
(1,'Bobby',7000,'2024-10-16'),
(2,'Murail',9000,'2023-10-25'),
(3,'Santhosh',8000,'2020-10-18');

select * from employee
update employee 
set sal = sal + (sal * 1.15 / 100)
where empno = 2;

select * from employee

delete from employee
where empno = 1

select * from employee

rollback transaction


-------------5th-----------------------

create function CalculateBonus(
@deptno int,
@sal decimal(10,2))
returns decimal(10,2)
as
begin
declare @bonus Decimal(10,2);
if @deptno = 10
set @bonus = @sal * 0.15;
else if @deptno = 20
set @bonus = @sal * 0.20;
else
set @bonus = @sal * 0.5;
return @bonus;
end;

select dbo.CalculateBonus(10,1000.00) as Bonus;



---------------------6th-----------

create proc salary_update
as
begin 
update emp 
set sal = sal + 500
where deptno = (select deptno from dept where dname = 'sales') and sal < 1500
end

exec salary_update

select * from emp






