USE Filmes;

INSERT INTO Generos (Nome)
VALUES				('A��o'),
					('Aventura');

INSERT INTO Generos (Nome)
VALUES				('Romance');

INSERT INTO Filmes	(Titulo, IdGenero)
VALUES				('Rambo', 1),
					('Vingadores', 1),
					('Ghost', 2),
					('Diario de uma paix�o', 2);

INSERT INTO Filmes	(Titulo)
VALUES				('Tropa de Elite'),
					('Indiona Jones');

UPDATE Generos
SET Nome = 'Romance'
WHERE IdGenero = 2;

UPDATE Generos
SET Nome = 'Aventura'
WHERE IdGenero = 5;

DELETE FROM GENEROS 
WHERE IdGenero = 3;

DELETE FROM GENEROS 
WHERE IdGenero = 4;