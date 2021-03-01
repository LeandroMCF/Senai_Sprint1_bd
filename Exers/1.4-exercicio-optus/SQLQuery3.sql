USE Optus

ALTER TABLE Permissao DROP COLUMN Comum;

ALTER TABLE Permissao DROP COLUMN Adimistrador;

ALTER TABLE Permissao ADD Permissao VARCHAR(200) NOT NULL;

INSERT INTO Permissao	(Permissao)
VALUES					('Adm'),
						('Comum');

INSERT INTO Usuario		(Nome, Email, Senha, IdPermissao)
VALUES					('Usuario1', 'Usuario1@gmail.com', 'Usuario1', 1),
						('Usuario2', 'Usuario2@gmail.com', 'Usuario2', 2),
						('Usuario3', 'Usuario3@gmail.com', 'Usuario3', 2),
						('Usuario4', 'Usuario4@gmail.com', 'Usuario4', 1);

INSERT INTO Artista		(Nome)
VALUES					('Daft Punk'),
						('Black Sabbath'),
						('Justin Timberlake'),
						('Beatles');

INSERT INTO Estilos		(Nome)
VALUES					('Eletronica'),
						('Heavy Metal'),
						('Pop'),
						('Pop Rock');

INSERT INTO Album		(IdArtista, IdEstilos, Titulo, DataDeLanc, Localizacao, Minutos, AtivoNao)
VALUES					(1, 1, 'Discovery', '13/03/2001', 'França', '1h1', 'Ativo'),
						(2, 2, 'Black Sabbath', '13/02/11970', 'Reino Unido', '42min', 'Ativo'),
						(3, 3, 'FutureSex / LoveSounds', '15/09/2006', 'Inglaterra', '1h6', 'Desativado'),
						(4, 4, 'Abbey Road', '25/06/1969', 'Inglaterra', '2h13', 'Desativado');