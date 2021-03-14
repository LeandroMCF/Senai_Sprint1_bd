--DML

USE Gufi
GO

INSERT INTO TipoUsers		(TituloTipoUser)
VALUES						('Adm'),
							('Comum');
GO

INSERT INTO Users			(IdTipoUsers, NomeUsers, Email, Senha)
VALUES						(1, 'Administrador', 'adm@adm.com', 'adm123'),
							(2, 'Caique', 'caique@email.com', 'caique132'),
							(2, 'Leandro', 'leandro@gmail.com', '2602');
GO

INSERT INTO Instituicoes	(cnpj, NomeFantasia, Endereco)
VALUES						('999999999999', 'Escola Senai de Informática', 'Alameda Barão de Oliveira');
GO

INSERT INTO TiposEventos	(TituloTipoEventos)
VALUES						('C#'),
							('ReactJs'),
							('SQL');
GO

INSERT INTO Eventos			(IdTipoEventos, IdInstituicoes, NomeEvento, AcessoLivre, DataEvento, Descricao)
VALUES						(1, 1, 'Orientacao a Objeto', 1, '07/04/2021', 'Conseito sobre orientação e objeto'),
							(2, 1, 'Ciclo da Vida', 0, '08/04/2021', 'Como usar o ReactJs');
GO

INSERT INTO Presencas		(IdUsers, IdEventos, Situacao)
VALUES						(2, 1, 'Confirmado(a)');
GO