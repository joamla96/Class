DELETE class_PET;
DELETE class_PET_OWNER;
DELETE class_BREED;

DROP TABLE class_PET;
DROP TABLE class_PET_OWNER;
DROP TABLE class_BREED;

CREATE TABLE class_BREED (
BreedName	NVarChar(25)	NOT NULL,
MinWeight	Float			NULL,
MaxWeight	Float			NULL,
AverageLifeExpectancy	Float	NULL,

CONSTRAINT	Breed_PK	Primary Key(BreedName),
);


CREATE TABLE class_PET_OWNER (
	OwnerID			Int				NOT NULL IDENTITY(1,1),
	OwnerLastName	NVarChar(25)	NOT NULL,
	OwnerFirstName	NVarChar(25)	NOT NULL,
	OwnerPhone		NVarChar(25)	NULL,
	OwnerEmail		NVarChar(50)		NOT NULL UNIQUE,
	CONSTRAINT		PETOWNR_PK	PRIMARY KEY(OwnerID)
);

CREATE TABLE class_PET (
	PetID			Int			NOT NULL IDENTITY(1,1),
	PetName			NVarChar(25)	NOT NULL,
	PetType			NVarChar(25)	NOT NULL,
	PetBreed		NVarChar(25)	NOT NULL,
	PetDOB			Date		NULL,
	PetWeight		Float		NOT NULL,
	OwnerID			Int			NOT NULL,
	CONSTRAINT		PetMaxWeight_Chk CHECK (PetWeight < 250),
	CONSTRAINT		PET_PK		PRIMARY KEY(PetID),

	CONSTRAINT		PET_POWNER_FK	FOREIGN KEY(OwnerID)
					REFERENCES class_PET_OWNER(OwnerID),

	CONSTRAINT		PET_BREED_FK	Foreign Key(PetBreed)
					REFERENCES class_BREED(BreedName)
);
