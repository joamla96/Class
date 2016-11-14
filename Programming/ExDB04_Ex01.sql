INSERT INTO class_PET_OWNER (OwnerLastName, OwnerFirstName, OwnerPhone,	OwnerEmail) VALUES
('Downs', 'Masha', '555-537-8765', 'masha.downs@somehwere.com'),
('James', 'Richard', '555-537-7654', 'richard.james@somewhere.com'),
('Frier', 'Liz', '555-537-6543', 'liz.frier@somewhere.com'),
('Trent', 'Miles', NULL, 'miles.trent@somewhere.com');

INSERT INTO class_PET (PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID) VALUES
('King',	'Dog',	'Std. Poodle',		'2011-02-21',	25.5,	1),
('Teddy',	'Cat',	'Cashmere',			'2012-02-01',	10.5,	2),
('Fido',	'Dog',	'Std. Poodle',		'2010-07-17',	28.5,	1),
('Aj',		'Dog',	'Collie Mix',		'2011-05-05',	20.0,	3),
('Cedro',	'Cat',	'Unknown',			'2009-06-06',	9.5,	2),
('Wooly',	'Cat',	'Unknown',			NULL,			9.5,	2),
('Buster',	'Dog',	'Border Collie',	'2008-12-11',	25.0,	4);