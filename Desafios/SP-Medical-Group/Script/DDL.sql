USE SPMedicalGroup;
GO

--Teste
SELECT TipoUsuario.TipoUsuario FROM Usuario
INNER JOIN TipoUsuario
ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario;

SELECT * FROM Clinica;

SELECT * FROM Prontuario;

SELECT * FROM Medicos;

SELECT * FROM Situacao;

SELECT * FROM Consultas;

SELECT * FROM Especialidades;
--FimTeste

--Especialidades
SELECT Nome FROM Especialidades
--FimEspecialidades

--M�dicos
SELECT Medicos.CRM, Medicos.Nome, Usuario.Email, Especialidades.Nome AS Especialidade, C.Clinica, C.CNPJ AS Cnpj, C.RazaoSocial AS Raz�o_Social, C.Endereco AS Endere�o
FROM Medicos
INNER JOIN Usuario
ON Usuario.IdUsuario = Medicos.IdUsuario
INNER JOIN Especialidades
ON Especialidades.IdEspecialidades = Medicos.IdEspecialidades
INNER JOIN Clinica C
ON C.IdClinica = Medicos.IdClinica;
GO
--FimM�dicos

--Prontu�rio
SELECT P.Nome, U.Email, P.DataDeNascimento, P.RG, P.CPF, P.Endereco  
FROM Prontuario P
INNER JOIN Usuario U
ON U.IdUsuario = P.IdUsuario;
GO
--FimProntu�rio

--Consultas
SELECT P.Nome AS Paciente, M.Nome AS M�dico, C.DataConsulta AS Data_da_Consulta, S.Situacao AS Situa��o
FROM Consultas C
INNER JOIN Prontuario P
ON P.IdProntuario = C.IdProntuario
INNER JOIN Medicos M
ON M.IdMedicos = C.IdMedicos
INNER JOIN Situacao S
ON S.IdSituacao = C.IdSituacao;
GO
--FimConsultas

--Idade
SELECT dbo.Idade('Ligia')AS [Nome]
--FimIdade

SELECT * FROM Prontuario
Where CPF = '94839859000';