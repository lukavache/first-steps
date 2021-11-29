create table dbo.Employee(
EmployeeID int identity(1,1),
EmployeeName varchar(500),
Department varchar(500),
DateOfJoining date,
PhotoFileName varchar(500)
)

insert into dbo.Employee values
('David','IT', '2019-11-25', 'anonymous.png')

select * from dbo.Employee