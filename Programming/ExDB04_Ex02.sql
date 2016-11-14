--3.15
SELECT PetBreed 
FROM class_PET;

--3.16
SELECT Count(*)
FROM class_PET;

--3.17
SELECT OwnerLastName, OwnerFirstName, OwnerEmail
FROM class_PET_Owner
WHERE OwnerPhone IS NULL;

--3.18
SELECT PetBreed, PetType, PetDOB
FROM class_PET
WHERE PetType = 'Dog';


--3.19
SELECT *
FROM class_PET;

--3.20
SELECT OwnerLastName, OwnerFirstName, OwnerEmail
FROM class_PET_OWNER
WHERE OwnerEmail LIKE '%somewhere.com';

--3.21
SELECT PetBreed, PetType, PetDOB
FROM class_PET
WHERE PetType = 'Dog' AND PetBreed = 'Std. Poodle';

--3.22
SELECT PetName, PetBreed,PetType
FROM class_PET
WHERE PetType NOT IN ('Cat','Dog','Fish');