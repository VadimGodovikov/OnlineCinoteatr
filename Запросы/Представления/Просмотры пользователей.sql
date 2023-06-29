USE OnlineCinoteatr

GO
CREATE VIEW UsersViews
AS
SELECT f.FilmName '�������� ������', us.Surname '�������', us.FirstName '���',
	   us.UserLogin '�����', vws.DataProsmotra '���� ���������'
FROM Users us, Film f, ViewsFilmsUsers vws
WHERE us.ID_Usera = vws.ID_Usera AND
	  f.ID_Filma = vws.ID_Filma

GO
SELECT * FROM UsersViews