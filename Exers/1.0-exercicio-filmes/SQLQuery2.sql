USE Filmes;

SELECT * FROM Generos;

 

SELECT * FROM Filmes;

-- ALIAS (AS)
-- INNER JOIN

SELECT IdFilme, Titulo AS Filmes, Nome AS Generos FROM Filmes
INNER JOIN Generos
ON Filmes.IdGenero = Generos.IdGenero;

-- LEFT JOIN

SELECT IdFilme, Titulo AS Filmes, Nome AS Generos FROM Filmes
LEFT JOIN Generos
ON Filmes.IdGenero = Generos.IdGenero;

-- RIGHT JOIN

SELECT IdFilme, Titulo AS Filmes, Nome AS Generos FROM Filmes
RIGHT JOIN Generos
ON Filmes.IdGenero = Generos.IdGenero;