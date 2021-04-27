USE Filmes;

INSERT INTO Generos (Nome)
VALUES				('Suspense')

INSERT INTO Generos (Nome)
VALUES				('Romance');

INSERT INTO Filmes	(Titulo, IdGenero)
VALUES				('Rambo', 1),
					('Vingadores', 1),
					('Ghost', 2),
					('Diario de uma paixão', 2);

INSERT INTO Filmes	(Titulo)
VALUES				('Tropa de Elite'),
					('Indiona Jones');

INSERT INTO Usuarios (Email, Senha, Permissoes)
VALUES				('adm@adm.com', 'adm123', 'Administrador'),
					('cmm@cmm.com', 'cmm123', 'Comum');

UPDATE Generos
SET Nome = 'Romance'
WHERE IdGenero = 2;

UPDATE Generos
SET Nome = 'Aventura'
WHERE IdGenero = 5;

DELETE FROM GENEROS 
WHERE IdGenero = 5;

DELETE FROM GENEROS 
WHERE IdGenero = 4;

DROP TABLE Usuarios;