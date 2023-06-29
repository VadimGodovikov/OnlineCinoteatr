USE OnlineCinoteatr

/*CREATE TABLE DeleteUsers
(
	ID_DELETED INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Users_Surname VARCHAR(50) NOT NULL,
	Users_Name VARCHAR(50) NOT NULL,
	Users_Login VARCHAR(50) NOT NULL,
	Date_Deleted DATETIME
);

GO
CREATE TRIGGER UsersDelete ON Users
AFTER DELETE
AS
BEGIN
	INSERT INTO DeleteUsers(Users_Surname, Users_Name, Users_Login, Date_Deleted)
	SELECT deleted.Surname 'Фамилия', deleted.FirstName 'Имя', deleted.UserLogin 'Логин', GETDATE() AS 'Дата удаления'
	FROM deleted
END*/

DELETE FROM Users WHERE ID_Usera = 4
SELECT * FROM DeleteUsers