-- 3.35
SELECT OwnerFirstname, OwnerLastname, OwnerEmail 
FROM class_PET_OWNER
WHERE OwnerID IN (
	SELECT OwnerID
	FROM class_PET
	WHERE PetType = 'Cat'
);

-- 3.35 Alternative Approach with Join
SELECT DISTINCT OwnerFirstName, OwnerLastName, OwnerEmail
FROM class_PET_OWNER AS o
JOIN class_PET  AS p ON p.OwnerID = o.OwnerID
WHERE p.PetType = 'Cat';


-- 3.36
SELECT OwnerFirstname, OwnerLastname, OwnerEmail 
FROM class_PET_OWNER
WHERE OwnerID IN (
	SELECT OwnerID
	FROM class_PET
	WHERE	PetType = 'Cat'
	AND		PetName = 'Teddy'	
);

-- 3.36 Alternative Approach with Join
SELECT DISTINCT OwnerFirstName, OwnerLastName, OwnerEmail
FROM class_PET_OWNER AS o
JOIN class_PET  AS p ON p.OwnerID = o.OwnerID
WHERE	p.PetType = 'Cat'
AND		p.PetName = 'Teddy';





