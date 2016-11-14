-- 3.15
SELECT PetBreed
FROM class_PET;

-- 3.16
SELECT COUNT(*)
FROM class_PET;

-- 3.17
SELECT OwnerLastName, OwnerLastName, OwnerEmail
FROM class_PET_OWNER
WHERE OwnerPhone IS NULL;

-- 3.18
SELECT PetBreed, PetType, PetDOB
FROM class_PET
WHERE PetType = 'Dog';

--3.19
SELECT PetID, PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID
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
SELECT PetName, PetBreed, PetType
FROM class_PET
--WHERE PetType != 'Cat' AND PetType != 'Dog' AND PetType != 'Fish';
WHERE PetType NOT IN('Cat', 'Dog', 'Fish');


