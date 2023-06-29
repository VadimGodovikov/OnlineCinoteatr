USE OnlineCinoteatr
--GO
--CREATE FUNCTION dbo.KolvoUserBuyPodpiska
--(@idPodpiska INT)
--RETURNS INT
--BEGIN
--RETURN (SELECT COUNT(1)
--	FROM Users us, Podpiska p, UserPodpiska up
--	WHERE us.ID_Usera = up.ID_Usera AND
--	  p.ID_Podpiska = up.ID_Podpiska AND
--	  p.ID_Podpiska = @idPodpiska)
--END

GO
SELECT dbo.KolvoUserBuyPodpiska(1) 'Кол-во пользователей'