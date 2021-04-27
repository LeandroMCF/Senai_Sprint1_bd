USE Hroads;
GO

INSERT INTO TipoUsuarios		(TipoUsuarios)
VALUES							('Jogador'),
								('Administrador');
GO

INSERT INTO Usuarios			(IdTipoUsuarios, Nome, Email, Senha)
VALUES							( 1, 'Jogador', 'jogador@gmail.com', 'jogador123'),
								( 2, 'Administrador', 'admin@gmail.com', 'adm123');
GO	

INSERT INTO TipoHabilidades		(TipoHabilidades)
VALUES							('Ataque'),
								('Defesa'),
								('Cura'),
								('Magia');
GO

INSERT INTO	Habilidades			(Habilidades, IdTipoHabilidades)
VALUES							('Lança Mortal', 1),
								('Escudo Supremo', 2),
								('Recuperar Vida', 3);
GO

INSERT INTO Classes				(Classes, IdHabilidades)
VALUES							
								('Bárbaro', 1),
								('Bárbaro', 2),
								('Cruzado', 2),
								('Caçadora de Demônios', 1),
								('Monge', 3),
								('Monge', 2),
								('Necromante', NULL),
								('Feiticeiro', 3),
								('Arcanista', NULL);
GO
								

INSERT INTO Personagens			(Nome, IdClasses, CapacidadeMaxVida, CapacidadeMaxMana, DataDeAtt, DataDeCriacao)
VALUES							('DeuBug', 1, 100, 80, '01/03/2021', '18/01/2019'),
								('BitBug', 4, 70, 100, '01/03/2021', '17/03/2016'),
								('Fer7', 7, 75, 60, '01/03/2021', '18/03/2018');
GO