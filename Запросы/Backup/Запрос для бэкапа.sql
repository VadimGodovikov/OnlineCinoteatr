USE [master]

BACKUP DATABASE OnlineCinoteatr
TO DISK N'C:\Users\host\Desktop\Практика\Запросы\Backup\OnlineCinoteatr.bak'
WITH NOFORMAT, NOINIT, NAME = N'OnlineCinoteatr База данных BACKUP',
SKIP, NOREWIND, NOUNLOAD, STATS = 10
GO