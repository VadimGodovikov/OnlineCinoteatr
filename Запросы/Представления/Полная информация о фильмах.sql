USE OnlineCinoteatr

GO
--CREATE VIEW AllInfoFilms
--AS
--SELECT f.FilmName '�������� ������', f.Country  '������', zh.ZhanrName '����', act.Surname '�. �����', act.FirstName '��� �����', bul.Surname '�. ���������', bul.FirstName '��� ���������', bul.Post '���������' 
--FROM Film f, Zhanr zh, Actor act, Builder bul, FilmZhanr fzh, FilmActor actFi, FilmBuilder Fb
--WHERE f.ID_Filma = fzh.ID_Filma AND
--	  f.ID_Filma = actFi.ID_Filma AND
--	  f.ID_Filma = fb.ID_Filma AND
--	  zh.ID_Zhanra = fzh.ID_Zhanra AND
--	  act.ID_Actor = actFi.ID_Actora AND
--	  bul.ID_Builder = fb.ID_Builder
GO
SELECT * FROM AllInfoFilms