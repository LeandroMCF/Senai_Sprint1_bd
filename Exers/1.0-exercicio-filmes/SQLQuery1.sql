-- Criando um banco de dados 
CREATE DATABASE Filmes;

-- Define o banco de dados Filme como o que será utilizado
USE Filmes;

CREATE TABLE Generos
(
	IdGenero	INT PRIMARY KEY IDENTITY,
	Nome		VARCHAR(200) NOT NULL,
)

CREATE TABLE Filmes
(
	IdFilme		INT PRIMARY KEY IDENTITY,
	IdGenero	INT FOREIGN KEY REFERENCES Generos (IdGenero),
	Titulo		VARCHAR(150) NOT NULL,
)