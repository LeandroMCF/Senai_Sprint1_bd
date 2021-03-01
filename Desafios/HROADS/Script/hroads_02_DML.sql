USE Hroads;

INSERT INTO TipoHabilidades	(TipoHabilidades)
VALUES							('Ataque'),
								('Defesa'),
								('Cura'),
								('Magia');

INSERT INTO	Habilidades			(Habilidades, IdTipoHabilidades)
VALUES							('Lan�a Mortal', 1),
								('Escudo Supremo', 2),
								('Recuperar Vida', 3);

INSERT INTO Classes				(Classes, IdHabilidades)
VALUES							
								('B�rbaro', 1),
								('B�rbaro', 2),
								('Cruzado', 2),
								('Ca�adora de Dem�nios', 1),
								('Monge', 3),
								('Monge', 2),
								('Necromante', NULL),
								('Feiticeiro', 3),
								('Arcanista', NULL);
								

INSERT INTO Personagens			(Nome, IdClasses, CapacidadeMaxVida, CapacidadeMaxMana, DataDeAtt, DataDeCriacao)
VALUES							('DeuBug', 1, 100, 80, '01/03/2021', '18/01/2019'),
								('BitBug', 4, 70, 100, '01/03/2021', '17/03/2016'),
								('Fer8', 7, 75, 60, '01/03/2021', '18/03/2018');


UPDATE Personagens
SET Nome = 'Fer7'
WHERE IdPersonagens = 3;