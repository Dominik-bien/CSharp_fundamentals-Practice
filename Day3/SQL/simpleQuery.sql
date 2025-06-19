

Select Id, FirstName, LastName, PhoneNumber as [Number Phone]
From Clients 
Where id > 0
ORDER BY id DESC 

Select COUNT(*) FROM Clients 
where id > 0

SELECT City, COUNT(City) AS Ilosc, MAX(FirstName)
From Clients 
Group by City

Select * From BorrowBooks bb
INNER JOIN Book b ON b.Id = bb.id
LEFT JOIN Clients c ON c.Id = bb.Clientid