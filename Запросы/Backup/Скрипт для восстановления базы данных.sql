USE [master]
RESTORE DATABASE [OnlineCinoteatr] 
FROM DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup\OnlineCinoteatr.bak' 
WITH FILE = 1, NOUNLOAD, STATS = 5
GO
