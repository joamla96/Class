USE [EJL76_DB]
GO

ALTER PROCEDURE [db_owner].[usp_InsertPet] AS
BEGIN
INSERT INTO class_PET (PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID) VALUES
('TestPet', 'Dog', 'Std. Poodle', '1996-02-29', 25.0, 3);
END