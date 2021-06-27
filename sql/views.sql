GO
CREATE VIEW Data.viewFilms AS
SELECT imdb AS 'IMDb Key', name AS 'Title',  timeMin AS 'Runtime', director AS 'Director'
FROM Data.Film
GO

GO
CREATE VIEW Operations.viewClients AS
SELECT name AS 'Name', email AS 'Email', dNasc AS 'Date Of Birth' 
FROM Operations.Client
GO

