USE OnlineCinoteatr

GO
CREATE PROCEDURE CheckUserPodpiska
	@idPodpiska INT
AS
BEGIN
SELECT us.Surname 'Фамилия', us.FirstName 'Имя', us.UserLogin 'Логин', p.NamePodpiska 'Название подписки', up.SrokDeistvia 'Срок действия подписки' 
FROM Users us, Podpiska p, UserPodpiska up 
WHERE us.ID_Usera = up.ID_Usera AND
	  p.ID_Podpiska = up.ID_Podpiska AND
	  p.ID_Podpiska = @idPodpiska
END

GO
EXEC CheckUserPodpiska 2