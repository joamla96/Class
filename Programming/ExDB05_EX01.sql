-- 3.35
SELECT OwnerFirstname, OwnerLastname, OwnerEmail 
FROM class_PET_OWNER
WHERE OwnerID IN (
	SELECT OwnerID
	FROM class_PET
	WHERE PetType = 'Cat'
);

-- 3.36
SELECT OwnerFirstname, OwnerLastname, OwnerEmail 
FROM class_PET_OWNER
WHERE OwnerID IN (
	SELECT OwnerID
	FROM class_PET
	WHERE	PetType = 'Cat'
	AND		PetName = 'Teddy'	
);

-- 3.37 - See Seperate Files (CreatePetTable & InsertPetData)
SELECT OwnerLastName, OwnerFirstName, OwnerEmail
FROM class_PET_OWNER
WHERE OwnerID IN (
	SELECT OwnerID
	FROM class_PET
	WHERE PetBreed IN(
		SELECT BreedName
		FROM class_BREED
		WHERE AverageLifeExpectancy > 15
	)
)


-- 3.38
SELECT DISTINCT OwnerFirstName, OwnerLastName, OwnerEmail
FROM class_PET_OWNER AS o
JOIN class_PET  AS p ON p.OwnerID = o.OwnerID
WHERE p.PetType = 'Cat';

-- 3.39
SELECT DISTINCT OwnerFirstName, OwnerLastName, OwnerEmail
FROM class_PET_OWNER AS o
JOIN class_PET  AS p ON p.OwnerID = o.OwnerID
WHERE	p.PetType = 'Cat'
AND		p.PetName = 'Teddy';

-- 3.40
SELECT DISTINCT o.OwnerLastName, o.OwnerFirstName, o.OwnerEmail
FROM class_PET_OWNER AS o
JOIN class_PET AS p ON o.OwnerID = p.OwnerID
JOIN class_BREED as b ON b.BreedName = p.PetBreed
WHERE b.AverageLifeExpectancy > 15