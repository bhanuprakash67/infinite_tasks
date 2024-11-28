create database Assignment_3

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

--Retrieve a list of MANAGERS
select *
from EMP 
where job = 'Manager'

--2. Find out the names and salaries of all employees earning more than 1000 per month
select ename,sal 
from EMP 
where sal > 1000

--3. Display the names and salaries of all employees except JAMES.

select ename, sal 
from EMP 
where ename != 'JAMES'

--4. Find out the details of employees whose names begin with ‘S’. 

select *
from emp
where ename like 's%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name.

select ename 
from emp 
where ename like '%A%'

-- Find out the names of all employees that have ‘L’ as their third character in their name.

select ename 
from emp
where ename like '__L%'

--7. Compute daily salary of JONES. 

select 
ename,
sal/30 as daily_salary
from EMP 
where ename = 'JONES'

--8. Calculate the total monthly salary of all employees. 
select sum(sal)
from EMP 

--9. Print the average annual salary .
select avg(sal * 12) as avg_annual_salary
from emp 

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename,
job,
sal,
deptno 
from emp
where job != 'SALESMAN' and deptno = 30

--11. List unique departments of the EMP table. 

select DISTINCT(deptno) as unique_departments
from emp 

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as employee,
sal as monthly_salary
from emp 
where (sal > 1500) and (deptno = 10 or deptno = 30)

--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename,
job,
sal
from emp 
where job = 'Manager' or job = 'Analyst' and (sal !=1000 and sal != 3000 and sal != 5000)

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 

select ename,
sal,
comm
from emp 
where comm > sal * 0.10

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 

select ename
from emp 
where ename like '%LL%' and (deptno = 30 or mgr_id = 7782) 

--16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 
select
count(empno) as total_number_employess,
ename
from emp 
where datediff (year,hiredate,getdate()) Between 30 and 40
group by ename

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select d.dname,
e.ename 
from emp e,dept d
order by d.dname asc,
e.ename desc

--18. Find out experience of MILLER. 
select datediff(year,hiredate,getdate()) as miller_exp
from emp 
where ename = 'MILLER'
 

