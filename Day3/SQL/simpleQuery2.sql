Select * from Clients 

INSERT INTO Clients {FirstName, LastName, PhoneNumber, City) 
VALUES ('Jan', 'Nowak', '404040404', 'Kraków')


Update Clients
SET FirstName = 'Gra¿yna', LastName = 'Kwiatkowska'
Where Id = 3

DELETE FROM Clients 
WHERE Id = 3