GO
CREATE VIEW Data.viewFilms AS
SELECT imdb AS 'IMDb Key', name AS 'Title',  timeMin AS 'Runtime', director AS 'Director'
FROM Data.Film
GO

GO
CREATE VIEW Data.viewSessions AS
SELECT Data.Session.id AS 'ID', name AS 'Film', startDay AS 'Premiere', noWeeks AS 'No Weeks' 
FROM Data.Session 
JOIN Data.Film ON filmId=imdb 
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
CREATE VIEW Management.viewRooms AS
SELECT num AS 'Num', nSeats AS 'Capacity' 
FROM Management.Room 
GO