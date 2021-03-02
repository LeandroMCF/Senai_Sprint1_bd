USE Hroads;

SELECT IdPersonagens AS ID, Nome FROM Personagens;


SELECT IdClasses AS ID, Classes FROM Classes;


SELECT Classes FROM Classes;


SELECT IdHabilidades AS ID, Habilidades FROM Habilidades;


SELECT IdTipoHabilidades AS ID, TipoHabilidades AS Tipos_de_Habilidades FROM TipoHabilidades;


SELECT COUNT(DISTINCT Habilidades) FROM Habilidades;


SELECT IdHabilidades AS ID FROM Habilidades;


SELECT TipoHabilidades FROM TipoHabilidades;


SELECT Habilidades, TipoHabilidades AS Tipo FROM Habilidades
INNER JOIN TipoHabilidades
ON Habilidades.IdTipoHabilidades = TipoHabilidades.IdTipoHabilidades;


SELECT Nome AS Personagem, Classes AS Classe FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasses = Classes.IdClasses;


SELECT Nome AS Personagens, Classes AS Classe FROM Personagens
RIGHT JOIN Classes
ON Personagens.IdClasses = Classes.IdClasses;


SELECT Classes, Habilidades FROM Classes
INNER JOIN Habilidades
ON Classes.IdHabilidades = Habilidades.IdHabilidades;


SELECT Classes, Habilidades FROM Classes
LEFT JOIN Habilidades
ON Classes.IdHabilidades = Habilidades.IdHabilidades;