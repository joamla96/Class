USE [EJL76_DB]
GO

CREATE PROCEDURE usp_InsertPet AS
BEGIN
INSERT INTO class_PET (PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID) VALUES
('TestPet', 'Dog', 'Std. Poodle', '1996-02-29', 25.0, 3);
END

GO

CREATE PROCEDURE usp_InsertOwner (
	@OwnerLastName NVarChar(25),
	@OwnerFirstName NVarChar(25),
	@OwnerPhone NVarChar(25) = NULL,
	@OwnerEmail NVarChar(50)
) AS
BEGIN
INSERT INTO class_PET_OWNER (OwnerLastName, OwnerFirstName, OwnerPhone, OwnerEmail) VALUES
	(@OwnerLastName, @OwnerFirstName, @OwnerPhone, @OwnerEmail)
END

GO

CREATE PROCEDURE usp_InsertBreed (
	@BreedName nvarchar(25),
	@MinWeight float = NULL,
	@MaxWeight float = NULL,
	@AvgLife	float = NULL
)AS
BEGIN
INSERT INTO class_BREED (BreedName, MinWeight, MaxWeight, AverageLifeExpectancy) VALUES
	(@BreedName, @MinWeight, @MaxWeight, @AvgLife)
END

--EXEC usp_InsertPet;

