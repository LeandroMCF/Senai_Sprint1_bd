USE Filmes;

INSERT INTO Generos (Nome)
VALUES				('A��o'),
					('Aventura');

INSERT INTO Filmes	(Titulo, IdGenero)
VALUES				('Rambo', 1),
					('Vingadores', 1),
					('Ghost', 2),
					('Diario de uma paix�o', 2);

UPDATE Generos
SET Nome = 'Romance'
WHERE IdGenero = 2;

DELETE FROM GENEROS 
WHERE IdGenero = 3;

DELETE FROM GENEROS 
WHERE IdGenero = 4;