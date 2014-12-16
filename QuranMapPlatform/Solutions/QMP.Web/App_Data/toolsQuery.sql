SELECT name, collation_name
FROM sys.databases
WHERE name = N'QMP';
GO
utf8_general_ci
--ALTER DATABASE N'QMP' COLLATE SQL_Latin1_General_CP1_CI_AS;

