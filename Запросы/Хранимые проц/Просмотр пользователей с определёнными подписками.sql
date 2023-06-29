USE OnlineCinoteatr

GO
CREATE PROCEDURE CheckUserPodpiska
	@idPodpiska INT
AS
BEGIN
SELECT us.Surname '�������', us.FirstName '���', us.UserLogin '�����', p.NamePodpiska '�������� ��������', up.SrokDeistvia '���� �������� ��������' 
FROM Users us, Podpiska p, UserPodpiska up 
WHERE us.ID_Usera = up.ID_Usera AND
	  p.ID_Podpiska = up.ID_Podpiska AND
	  p.ID_Podpiska = @idPodpiska
END

GO
EXEC CheckUserPodpiska 2