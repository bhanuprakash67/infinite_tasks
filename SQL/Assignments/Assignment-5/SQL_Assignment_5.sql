use Assignment_5

create table DEPT(DEPTNO int primary key,
DNAME varchar(20),
LOC varchar(20))

insert into DEPT values
(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')

create table EMP
(EMPNO int primary key,
ENAME varchar(20),
JOB varchar(20),
MGR_ID int,
HIREDATE date,
SAL int,
COMM int,
DEPTNO int foreign key references DEPT(DEPTNO)
)

insert into EMP values
(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81', 1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
(7900,'JAMES', 'CLERK',7698,'03-DEC-81',950,null,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)


select * from DEPT

select * from EMP
--Print the payslip neatly with all details

select * from emp
create or alter procedure payslip @empno int
as
begin
declare @sal int
declare @HRA int
declare @DA int
declare @PF int
declare @IT int
declare @deduct int
declare @gross int
declare @netsal int
 
	begin
	select @sal =sal from emp where empno=@empno
	set @HRA=@sal*10/100
	set @DA=@sal*20/100
	set @PF=@sal*8/100
	set @IT=@sal*5/100
	set @deduct=@PF+@IT
	set @gross=@sal+@HRA+@DA
	set @netsal=@gross-@deduct
	select empno,ename,@HRA as HRA,@DA as DA,@PF as PF,@IT as IT,@deduct as DEDUCTION,@gross as [GROSS SALARY],@netsal as [NET SALARY] from emp where empno=@empno
	end
 
end
 
exec payslip @empno=7369

--drop table Holidays



CREATE TABLE Holidays (
    holiday_date DATE PRIMARY KEY,
    holiday_name VARCHAR(20) NOT NULL
);
INSERT INTO Holidays (holiday_date, holiday_name) VALUES
('2024-01-26', 'Republic Day'),
('2024-03-29', 'Holi'),
('2024-08-15', 'Independence Day'),
('2024-11-12', 'Diwali');
insert into holidays values('2024-12-06','Holiday');
CREATE or alter TRIGGER RestrictManipulationOnHolidays
ON emp
for insert,update,delete
as
BEGIN
    DECLARE @holiday_name VARCHAR(20);
	declare @current_date date = cast(getdate() as date)
    SELECT @holiday_name =holiday_name
    FROM Holidays
    WHERE holiday_date = @current_date;
    IF @holiday_name IS NOT NULL
	begin
        raiserror('Data manipulation is restricted due to %s',16,1, @holiday_name)
		rollback transaction
    END 
END
update emp set Sal=1000 where EMPNO = 7369
select * from emp