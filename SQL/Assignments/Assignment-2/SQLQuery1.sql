create database Assignment_2

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

--List all employees whose name begins with 'A'.

select ENAME 
from EMP
where ENAME like 'A%'

--Select all those employees who don't have a manager.
select ENAME,MGR_ID 
from EMP 
where MGR_ID is null

--List employee name, number and salary for those employees who earn in the range 1200 to 1400

select ENAME,EMPNO,SAL
from EMP
where (SAL > 1200) and (SAL < 1400)

--Give all the employees in the RESEARCH department a 10% pay rise. 
--Verify that this has been done by listing all their details before and after the rise

select SAL,SAL +(0.10*SAL) as PAY_RISE
from emp 
where DEPTNO = (select DEPTNO from DEPT where DNAME = 'RESEARCH')`

-- Find the number of CLERKS employed. Give it a descriptive heading.
select count(job) as Clierks_Employed
from EMP 
where JOB = 'CLERK'


--Find the average salary for each job type and the number of people employed in each job. 

select avg(SAL) as Average_Salary , count(*) as EMP_Count
from EMP 
group by job 

--List the employees with the lowest and highest salary. 
select 
min(SAL) as lowest_salary, 
max(SAL) as highest_salary
from EMP 

--List full details of departments that don't have any employees.
select * 
from DEPT left join EMP on DEPT.DEPTNO = EMP.DEPTNO
where EMP.DEPTNO is null

--Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ENAME, SAL
from EMP 
where JOB = 'ANALYST' and SAL > 1200 and DEPTNO = 20
order by ENAME asc

--For each department, list its name and number together with the total salary paid to employees in that department. 
select E.ENAME, E.EMPNO,E.DEPTNO,sum(E.SAL) as total_salary
from EMP E join EMP E1 
on E.DEPTNo = E1.DEPTNO
group by E.ENAME,
E.EMPNO,
E.DEPTNO

---11. Find out salary of both MILLER and SMITH.
select SAL from EMP 
where ENAME in ('MILLER','SMITH')

--Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ENAME 
from EMP 
where ENAME like ('A%') or ENAME like ('M%')

--Compute yearly salary of SMITH. 
select SAL,SAL * 12 as yearly_salary
from EMP
where ENAME like 'SMITH'

---List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ENAME , SAL 
from EMP 
where SAL not between 1500 and 2850

---15. Find all managers who have more than 2 employees reporting to them

select MGR_ID, count(*) as Employee_Count
from EMP 
group by MGR_ID 
having count(*) > 2