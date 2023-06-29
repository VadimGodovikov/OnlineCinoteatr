USE OnlineCinoteatr

GO
CREATE VIEW UsersViews
AS
SELECT f.FilmName 'Название фильма', us.Surname 'Фамилия', us.FirstName 'Имя',
	   us.UserLogin 'Логин', vws.DataProsmotra 'Дата просмотра'
FROM Users us, Film f, ViewsFilmsUsers vws
WHERE us.ID_Usera = vws.ID_Usera AND
	  f.ID_Filma = vws.ID_Filma

GO
SELECT * FROM UsersViews