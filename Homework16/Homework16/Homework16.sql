---TSQL 2012

--N1

select [contactname],[city],[orderdate] from Sales.Orders s
JOIN Sales.Customers sc
on s.custid=sc.custid

--N2

select [unitprice],[categoryname] from [Production].[Categories] cat
JOIN  [Production].[Products] prod
on cat.categoryid=prod.categoryid where  unitprice>20 and unitprice<40

--N3

Select [lastname],[firstname],[orderid] from [HR].[Employees] emp
join [Sales].[Orders] ord
on emp.empid=ord.empid where freight>50

--N4

Select [orderdate],[contactname],[city],[address] from [Sales].[Orders] ord
join [Sales].[Customers] cust on ord.custid=cust.custid where orderdate> '2007-01-01 00:00:00.000'

--N5

SELECT DISTINCt [shipcity]  from [Sales].[Orders] emp
join [HR].[Employees] ord on emp.empid=ord.empid where lastname='Cameron'

--N6

Select [orderid],[shipcity],[shipcountry] from [Sales].[Orders] 
where shipcountry ='Germany'or shipcountry='Austria'

--N7

Select * from [Production].[Products] prod join [Production].[Suppliers] suppl
on  prod.supplierid=suppl.supplierid where city='Tokyo' and discontinued>0

--N8

Select * from [Production].[Products] prod join [Production].[Suppliers] suppl
on prod.supplierid= suppl.supplierid
where country='Japan' and  categoryid in (select [categoryid] 
from [Production].[Categories] where categoryname='Beverages' or categoryname='Seafood' )

--N9

Select [lastname],[firstname],[companyname] 
from [HR].[Employees] empl 
join [Sales].[Orders] ord 
on empl.empid=ord.empid 
join [Sales].[Shippers] shipp on ord.shipperid= shipp.shipperid
where [companyname] in (select [companyname] from [Sales].[Shippers])
and shippeddate>'2007' and [firstname]='maria' or firstname='sara'

--N10

Select [categoryname],[productname]
from [Production].[Suppliers] suppl
join [Production].[Products] prod on suppl.supplierid=prod.supplierid
join [Production].[Categories] cat on prod.categoryid=cat.categoryid
where categoryname!='Beverages' and categoryname!='Seafood' and country='USA'

--N11

select [lastname],[firstname],[orderid],cust.city,[contactname]
from [HR].[Employees] empl join [Sales].[Orders] ord on empl.empid=ord.empid
join [Sales].[Customers] cust on ord.custid=cust.custid
where cust.city=empl.city




--N12

select distinct [contactname]
from [Sales].[Customers] cust join [Sales].[Orders] ord on cust.custid=ord.custid
join [Sales].[OrderDetails] orddt on ord.orderid=orddt.orderid
join [Production].[Products] prod on orddt.productid=prod.productid
join [Production].[Categories] cat on prod.categoryid=cat.categoryid
where categoryname='Beverages' or categoryname='Dairy Products'





--- Hardware

--N1

Select pro.Price,pro.Name
from [dbo].[Products] pro join [dbo].[Manufacturers] man
on pro.ManufacturerId=man.ManufacturerId
where man.Name='Hewlett-Packard'

--N2

Select pro.Price,pro.Name
from [dbo].[Products] pro join [dbo].[Manufacturers] man
on pro.ManufacturerId=man.ManufacturerId
where man.Name!='Fujitsu'

--N3

Select pro.Price,pro.Name
from [dbo].[Products] pro join [dbo].[Manufacturers] man
on pro.ManufacturerId=man.ManufacturerId
where man.Name in ('Sony','Fujitsu','IBM ','Intel')

--N4
Select man.Name
from [dbo].[Products] pro join [dbo].[Manufacturers] man
on pro.ManufacturerId=man.ManufacturerId
where pro.Price>200

--N5

Select pro.Price,pro.Name
from [dbo].[Products] pro join [dbo].[Manufacturers] man
on pro.ManufacturerId=man.ManufacturerId
where man.Name!='Genius' and man.Name!='Dell'

--N6

Select count(man.Name)
from [dbo].[Products] pro join [dbo].[Manufacturers] man
on pro.ManufacturerId=man.ManufacturerId
where pro.Name Like '%drive%'

--N7

Select count(pro.Name)
from [dbo].[Products] pro full join [dbo].[Manufacturers] man
on pro.ManufacturerId=man.ManufacturerId
where man.Name='Intel' and pro.Price> avg(pro.Price)






---WorldEvents

--N1
Select count(e.EventName)
from [dbo].[Event] e join [dbo].[Country] cou on e.CountryID=cou.CountryID
join [dbo].[Continent] con on cou.ContinentID=con.ContinentID
where con.ContinentName='Europe'

--N2

Select e.EventDate
from [dbo].[Event] e join [dbo].[Country] cou on e.CountryID=cou.CountryID
join [dbo].[Continent] con on cou.ContinentID=con.ContinentID
where e.EventDate=(select min(EventDate) from[dbo].[Event])

--N3

Select count(CountryName)
from [dbo].[Country] cou join [dbo].[Continent] con on cou.ContinentID=con.ContinentID
where con.ContinentName in ('South America','North America')

--N4

Select count(EventName)
from [dbo].[Event] ev join [dbo].[Category] cat
on ev.CategoryID=cat.CategoryID
where cat.CategoryName='Economy' and Month(ev.EventDate)=1 and day(ev.EventDate)=1
-- i tried to calculate on 1st of january

--N5

Select max(EventDate)
from [dbo].[Event] ev join [dbo].[Country] coun on ev.CountryID=coun.CountryID
join [dbo].[Continent] con on coun.ContinentID=con.ContinentID
where con.ContinentName='Europe'