USE OnlineCinoteatr

GO
EXEC sp_addrole 'Administrator'
EXEC sp_addrole 'ClientOC'

GO
GRANT DELETE, INSERT, UPDATE, SELECT ON Actor TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON Builder TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON Film TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON FilmActor TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON FilmBuilder TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON FilmZhanr TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON Podpiska TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON UserPodpiska TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON Users TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON ViewsFilmsUsers TO Administrator
GRANT DELETE, INSERT, UPDATE, SELECT ON Zhanr TO Administrator

GO
GRANT SELECT ON Actor TO ClientOC
GRANT SELECT ON Film TO ClientOC
GRANT SELECT ON Builder TO ClientOC
GRANT SELECT ON Podpiska TO ClientOC
GRANT SELECT ON Zhanr TO ClientOC

GO
EXEC sp_addlogin 'Krukov_Admin', 'Krukov_Admin', 'OnlineCinoteatr'
USE OnlineCinoteatr
EXEC sp_adduser 'Krukov_Admin', 'Krukov_Admin'
EXEC sp_addrolemember 'Administrator', 'Krukov_Admin'

GO
EXEC sp_addlogin 'Godovikov_Client', 'Godovikov_Client', 'OnlineCinoteatr'
USE OnlineCinoteatr
EXEC sp_adduser 'Godovikov_Client', 'Godovikov_Client'
EXEC sp_addrolemember 'ClientOC', 'Godovikov_Client'