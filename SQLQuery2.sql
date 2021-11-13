--Select
--ANSI
Select ContactName Adi,CompanyName Sirket,City Şehir from Customers

Select * from Customers where City = 'London'

--case insensitive
select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >=10

select * from Products where CategoryID = 1 order by UnitPrice desc ---asc artan desc azalan

select count(*) Adet from Products

select CategoryID,count(*) from Products group by CategoryID

select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

--DTO Data Transformation Object

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null