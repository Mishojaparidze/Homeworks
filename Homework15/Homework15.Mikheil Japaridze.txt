--Students
--N1
SELECT *FROM [HomeWorkWeek15].[dbo].[Students]
  WHERE DoB>'01-JAN-1990'
 --N2
 SELECT  [StudentsID]
,[Lastname]
,[Firstname],  
     CASE 
         WHEN MONTH(GETDATE()) > MONTH(DoB) OR MONTH(GETDATE()) = MONTH(DoB) AND DAY(GETDATE()) >= DAY(DoB) THEN DATEDIFF(year, DoB, GETDATE()) 
         ELSE DATEDIFF(year, Dob, GETDATE()) - 1 
     END AS Age

 FROM [HomeWorkWeek15].[dbo].[Students]  

 where country='Georgia' or country ='Libya';
 
 --N3
 INSERT [HomeWorkWeek15].[dbo].[Students]  ([Lastname], [Firstname], [DoB], [Email], [Quiz1], [Quiz2], [MiddleTest], [FinalTest], [Country]) VALUES (N'mamoa', N'momoa', CAST(N'1745-09-30' AS Date), N'luctus.felis.purus@convallisdolor.edu', 12, 15, 25, 37, N'Washington')

--N4

 select top 6 with ties Firstname,MiddleTest FROM  [HomeWorkWeek15].[dbo].[Students] order by MiddleTest desc

 --N5

DELETE from [HomeWorkWeek15].[dbo].[Students]  OUTPUT deleted.* WHERE FinalTest=19 

--N6

UPDATE [HomeWorkWeek15].[dbo].[Students]
	SET FinalTest = '0'
	OUTPUT inserted.StudentsID
	WHERE MiddleTest = 1



--Persons

--N1
Select * From [HomeWorkWeek15].[dbo].[Persons]
Where PrivateId LIKE '163%'

--N2
Select * From [HomeWorkWeek15].[dbo].[Persons]
Where Lastname=City

--N3

select  * from [HomeWorkWeek15].[dbo].[Persons] where Country in('Canada','Monaco')

--N4

select  Firstname,Lastname,PrivateId from [HomeWorkWeek15].[dbo].[Persons] where Email IS NULL

--N5

select * from [HomeWorkWeek15].[dbo].[Persons] where Country='Spain' or Country ='Turkey' and Salary between 1000 and 3000 

--N6

select WorkPlace from [HomeWorkWeek15].[dbo].[Persons] where WorkPlace Like '%LLC%'or WorkPlace Like '%PC%'or WorkPlace Like'%LLP%';

--N7


declare @tocount varchar(20)
set @tocount = '.'
select (len(Email) - len(replace(Email,@tocount,''))) / LEN(@tocount),
Case 
	When (len(Email) - len(replace(Email,@tocount,''))) / LEN(@tocount)>2 then 'more than 2 dots '
	Else 'less than 2 dots'
	end as CountingDots
from [HomeWorkWeek15].[dbo].[Persons]


--N8
Select * From [HomeWorkWeek15].[dbo].[Persons]
Where PINcode LIKE '%51'

--N9

select Country,count(*)from [HomeWorkWeek15].[dbo].[Persons]
group by Country  



select country AS Country, sum(Salary),count(Country ) ,
Case
		When count(Country)>1 then sum(Salary)/count(Country )
		Else sum(Salary)

		End  as AverageSalary
from [HomeWorkWeek15].[dbo].[Persons]

group by country