USE Clinica;

INSERT INTO Dono	(Nome)
VALUES				('Dono1'),
					('Dono2'),
					('Dono3'),
					('Dono4');

INSERT INTO Pet		(Nome, Raca, IdDono)
VALUES				('Teddy','Yorkshire', 2),
					('Cleber','Border Collie', 4),
					('Rex','Pinscher', 3),
					('Joaquin','Bulldog', 1);
		
INSERT INTO Aniversario		(DataN)
VALUES						('26/02/17'),
							('01/10/20'),
							('15/04/18'),
							('21/05/16');