USE Optus;

SELECT * FROM Album;

SELECT * FROM Artista;

SELECT * FROM Estilos;

SELECT * FROM Permissao;

SELECT * FROM Usuario;

SELECT * FROM Permissao;

SELECT IdUsuario AS Id, Usuario.Nome, Email, Permissao AS Permissão FROM Usuario
INNER JOIN Permissao
ON Usuario.IdPermissao = Permissao.IdPermissao;

