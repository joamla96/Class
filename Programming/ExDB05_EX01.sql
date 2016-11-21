-- 3.35
SELECT OwnerFirstname, OwnerLastname, OwnerEmail 
FROM class_PET_OWNER
WHERE OwnerID IN (
	SELECT OwnerID
	FROM class_PET
	WHERE PetType = 'Cat'
)
