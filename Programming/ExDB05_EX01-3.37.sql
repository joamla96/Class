TRUNCATE TABLE class_BREED;
DROP TABLE class_BREED;

CREATE TABLE class_BREED (
BreedName	NVarChar(25)	NOT NULL,
MinWeight	Float			NULL,
MaxWeight	Float			NULL,
AverageLifeExpectancy	Float	NULL,

CONSTRAINT	Breed_PK	Primary Key(BreedName),
CONSTRAINT	Breed_UNQ	Unique(BreedName)
);

INSERT INTO class_BREED (BreedName, MinWeight, MaxWeight, AverageLifeExpectancy) VALUES
('Border Collie', 15.0, 22.5, 20),
('Cashmere', 10.0, 15.0, 12),
('Collie Mix', 17.5, 25.0, 18),
('Std. Poddle', 22.5, 30.0, 18),
('Unknown', null, null, null);