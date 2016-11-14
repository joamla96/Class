/*
SELECT
FROM 
WHERE
GROUP BY
ORDER BY
*/

-- 3.24
SELECT DISTINCT PetBreed
FROM class_PET;

-- 3.26
SELECT PetName, PetBreed
FROM class_PET
ORDER BY PetName ASC;

-- 3.29
SELECT COUNT(DISTINCT PetBreed)
FROM class_PET;

-- 3.31
SELECT MIN(PetWeight), MAX(PetWeight), AVG(PetWeight)
FROM class_PET
WHERE PetType = 'Dog';

-- 3.32
SELECT AVG(PetWeight)
FROM class_PET
GROUP BY PetBreed;

-- 3.33
SELECT AVG(PetWeight)
FROM class_PET
GROUP BY PetBreed
HAVING Count(*) > 1;

-- 3.34
SELECT AVG(PetWeight)
FROM class_PET
WHERE PetBreed <> 'Unknown';
-- ALT METHOD: WHERE PetBreed != 'Unknown'