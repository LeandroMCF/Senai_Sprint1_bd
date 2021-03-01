USE Clinica;

SELECT * FROM Clinica;

SELECT * FROM Dono;

SELECT * FROM Pet;

SELECT * FROM Veterinario;

SELECT * FROM Aniversario;

SELECT IdPet, Pet.Nome, Raca AS Raça, Dono.Nome AS Dono FROM Pet
LEFT JOIN Dono
ON Pet.IdDono = Dono.IdDono;