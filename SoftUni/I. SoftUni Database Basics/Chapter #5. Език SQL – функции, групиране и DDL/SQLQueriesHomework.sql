--Problem 1.
--Find the names and salaries of the employees that take the minimal salary in the company.

--select 	FirstName, LastName, Salary 
--from Employees
--where Salary = 
--	(
--	select min(Salary) 
--	from Employees
--	)
---------------------------------------------------------------------------------

--Problem 2.	
--Find the names and salaries of the employees that have a salary that is up to 10% higher than 
--the minimal salary for the company.

declare @percentage decimal;
set @percentage = 
	(
	select  min(Salary) + (min(Salary) * 10/100)
	from Employees
	)
select e.FirstName, e.LastName, e.Salary, d.Name as Department
from Employees e
	join Departments d
	on e.DepartmentID = d.DepartmentID
where e.Salary < @percentage
order by  d.Name
-----------------------------------------------------------------------------------------------------------

--Problem 3.	
--Find the full name, salary and department 
--of the employees that take the minimal salary in their department.

select
	FirstName + ' ' + LastName as [Full Name],
	d.Name as Department,
	Salary as Salary
from Employees e
	join Departments d
	on e.DepartmentID = d.DepartmentID
where Salary = 
	(
	select MIN(Salary) from Employees e
	where d.DepartmentID  = e.DepartmentID
	)
order by Salary
-----------------------------------------------------------------------------------------

--Problem 4.	Find the average salary in the department #1.
select
	d.Name as Department,
	AVG(Salary) as [Average Salary]
from Employees e
	join Departments d
	on e.DepartmentID = d.DepartmentID
where d.DepartmentID = 1
group by d.Name
-------------------------------------------------------------------------------------------

--Problem 5.	Find the average salary in the "Sales" department.
select
	AVG(Salary)
from Employees e
	join Departments d
	on e.DepartmentID = d.DepartmentID
where d.Name = 'Sales'
--------------------------------------------------------------------------------------------

--Problem 6.	Find the number of employees in the "Sales" department.
select 
	count(*) [Number of Employees]
from Employees
where DepartmentID = 3
---------------------------------------------------------------------------

--Problem 7.	Find the number of all employees that have manager.
select 
	count(*) [Employees with manager]
from Employees
where ManagerID  IS NOT NULL
--------------------------------------------------------------------------

--Problem 8.	Find the number of all employees that have no manager.
select
	count(*) [Employees with no manager]
from Employees
where ManagerID IS NULL
------------------------------------------------------------------------

--Problem 9.	Find all departments and the average salary for each of them.
select
	d.Name as [Department Name],
	AVG(Salary) as [Average Salary]
from Employees e
	join Departments d
	on e.DepartmentID = d.DepartmentID
where  e.DepartmentID = d.DepartmentID
group by d.Name
---------------------------------------------------------------------------------

--Problem 10.	Find the count of all employees in each department and for each town.
