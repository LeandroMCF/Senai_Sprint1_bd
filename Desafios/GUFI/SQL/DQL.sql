-- DQL

USE Gufi
GO

SELECT * FROM TipoUsers;
SELECT * FROM Users;
SELECT * FROM Instituicoes;
SELECT * FROM TiposEventos;
SELECT * FROM Eventos;
SELECT * FROM Presencas;

SELECT IdUsers, TituloTipoUser, NomeUsers, Email 
FROM Users
INNER JOIN TipoUsers
ON Users.IdTipoUsers = TipoUsers.IdTipoUsers;

SELECT NomeFantasia, IdEventos, TituloTipoEventos, NomeEvento, AcessoLivre, DataEvento, Descricao 
FROM Eventos
INNER JOIN TiposEventos
ON Eventos.IdTipoEventos = TiposEventos.IdTipoEventos
INNER JOIN Instituicoes
ON Eventos.IdInstituicoes = Instituicoes.IdInstituicoes;

SELECT NomeUsers, Email, NomeEvento, TituloTipoEventos, DataEvento
FROM Users U
INNER JOIN Presencas P
ON P.IdUsers = U.IdUsers
INNER JOIN Eventos E
ON P.IdEventos = E.IdEventos
INNER JOIN  TiposEventos T
ON E.IdTipoEventos = T.IdTipoEventos;

