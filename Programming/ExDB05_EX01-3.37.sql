TRUNCATE TABLE class_BREED;
DROP TABLE class_BREED;

CREATE TABLE class_BREED (
BreedID		Int				NOT NULL IDENTITY(1,1),
BreedName	NVarChar(MAX)	NOT NULL,
MinWeight	Float			NOT NULL,
MaxWeight	Float			NOT NULL,
AverageLifeExpectancy	Float	NOT NULL,

CONSTRAINT	Breed_PK	Primary Key(BreedID),
CONSTRAINT	Breed_Pet_FK	Unique(BreedName)
);
