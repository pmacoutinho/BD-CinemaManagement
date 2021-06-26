GO
CREATE VIEW Data.viewFilms AS
SELECT imdb AS 'IMDb Key', name AS 'Title',  timeMin AS 'Runtime', director AS 'Director'
FROM Data.Film
GO

GO
CREATE VIEW Management.viewWorkers AS
SELECT id AS 'ID', Management.Employee_Type.name AS 'Function',  Management.Employee.name AS 'Name', 
		email AS 'Email', eShift AS 'Shift' 
FROM Management.Employee JOIN Management.Employee_Type ON eType=num 
WHERE Management.Employee_Type.name='Cleaning' OR Management.Employee_Type.name='Sales'
GO

GO
CREATE VIEW Management.viewManagers AS
SELECT id AS 'ID', Management.Employee_Type.name AS 'Function',  Management.Employee.name AS 'Name', 
email AS 'Email', eShift AS 'Shift' 
FROM Management.Employee JOIN Management.Employee_Type ON eType=num 
WHERE Management.Employee_Type.name='Manager' OR Management.Employee_Type.name='Deputy Manager'
GO

GO
CREATE VIEW Management.viewManagers AS
SELECT id AS 'ID', Management.Employee_Type.name AS 'Function',  Management.Employee.name AS 'Name', 
email AS 'Email', eShift AS 'Shift' 
FROM Management.Employee JOIN Management.Employee_Type ON eType=num 
WHERE Management.Employee_Type.name='Manager' OR Management.Employee_Type.name='Deputy Manager'
GO

GO
CREATE VIEW Operations.viewClients AS
SELECT name AS 'Name', email AS 'Email', dNasc AS 'Date Of Birth' 
FROM Operations.Client
GO

GO
CREATE VIEW Operations.viewTickets AS
SELECT Operations.Ticket.id AS 'ID', price AS 'Price', Operations.Client.name AS 'Client'
FROM Operations.Ticket 
JOIN Operations.Client ON Operations.Ticket.client=Operations.Client.id 
JOIN Operations.Reservation ON Operations.Ticket.reservation=Operations.Reservation.id
GO

