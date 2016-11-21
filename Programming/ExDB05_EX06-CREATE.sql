USE [EJL76_DB]

GO CREATE PROCEDURE usp_GetOwnerByLastName (
	@LastName NVarChar(25)
) AS
BEGIN
	SELECT * 
	FROM class_PET_OWNER
	WHERE OwnerLastName LIKE '%'+@LastName+'%'
END



GO CREATE PROCEDURE usp_GetOwnerByEmail (
	@Firstname NVarChar(25),
	@Email NVarChar(50)
) AS
BEGIN
	SELECT OwnerFirstName, OwnerEmail
	FROM class_PET_OWNER
	WHERE OwnerFirstName = @Firstname
		AND OwnerEmail = @Email
END



GO CREATE PROCEDURE usp_GetInfomation (
	@OwnerID Int
) AS
BEGIN
	SELECT 
		o.OwnerFirstName + ' ' + o.OwnerLastName AS OwnerName,
		p.PetName,
		p.PetType,
		p.PetBreed,
		b.AverageLifeExpectancy
	FROM class_PET_OWNER AS o
		JOIN class_PET AS p ON o.OwnerID = p.OwnerID
		JOIN class_BREED AS  b ON b.BreedName = p.PetBreed
	WHERE o.OwnerID = @OwnerID
END