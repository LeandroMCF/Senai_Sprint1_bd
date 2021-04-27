CREATE DATABASE Hroads;
GO

USE Hroads;
GO

CREATE TABLE TipoUsuarios
(
	IdTipoUsuarios		INT PRIMARY KEY IDENTITY,
	TipoUsuarios		VARCHAR(250)UNIQUE NOT NULL,
)
GO

CREATE TABLE Usuarios
(
	IdUsuarios			INT PRIMARY KEY IDENTITY,
	IdTipoUsuarios		INT FOREIGN KEY REFERENCES TipoUsuarios (IdTipoUsuarios),
	Nome				VARCHAR(250)UNIQUE NOT NULL,
	Email				VARCHAR(250)UNIQUE NOT NULL,
	Senha				VARCHAR(250) NOT NULL,
)

CREATE TABLE TipoHabilidades
(
	IdTipoHabilidades	INT PRIMARY KEY IDENTITY,
	TipoHabilidades		VARCHAR(200) NOT NULL,
)
GO

CREATE TABLE  Habilidades
(
	IdHabilidades		INT PRIMARY KEY IDENTITY,
	IdTipoHabilidades	INT FOREIGN KEY REFERENCES TipoHabilidades (IdTipoHabilidades),
	Habilidades			VARCHAR(200) NOT NULL,
)
GO

CREATE TABLE Classes
(
	IdClasses			INT PRIMARY KEY IDENTITY,
	IdHabilidades		INT FOREIGN KEY REFERENCES Habilidades (IdHabilidades),
	Classes				VARCHAR(200) NOT NULL,
)
GO

CREATE TABLE Personagens
(
	IdPersonagens		INT PRIMARY KEY IDENTITY,
	IdClasses			INT FOREIGN KEY REFERENCES Classes (IdClasses),
	Nome				VARCHAR(200) NOT NULL,
	CapacidadeMaxVida	VARCHAR(200) NOT NULL,
	CapacidadeMaxMana	VARCHAR(200) NOT NULL,
	DataDeAtt			VARCHAR(200) NOT NULL,
	DataDeCriacao		VARCHAR(200) NOT NULL,
)
GO