CREATE DATABASE DotNetCourseDatabase
GO

USE DotNetCourseDatabase
GO

CREATE SCHEMA TutorialAppSchema
GO

CREATE TABLE TutorialAppSchema.Computer
(
    --TableId INT IDENTITY(Starting,Increment By)
    ComputerId INT IDENTITY(1,1) PRIMARY KEY
    , Motherboard NVARCHAR(50)
    , CPUCores INT
    , HasWifi BIT
    , HasLTE BIT
    , ReleaseDate DATETIME
    ,Price DECIMAL(18, 4)
    , VideoCard NVARCHAR(50)
)


SELECT * FROM TutorialAppSchema.Computer WHERE 1 = 0

SET IDENTITY_INSERT TutorialAppSchema.Computer OFF

INSERT INTO TutorialAppSchema.Computer(
[Motherboard],
[CPUCores],
[HasWifi],
[HasLTE],
[ReleaseDate],
[Price],
[VideoCard]
) VALUES (
    'Sample-Motherboard',
    4,
    1,
    0,
    '2022-01-01',
    1000,
    'Sample-Videocard'
)

SELECT [ComputerId],
[Motherboard],
ISNULL([CPUCores], 4) as CPUCores,
[HasWifi],
[HasLTE],
[ReleaseDate],
[Price],
[VideoCard] FROM TutorialAppSchema.Computer
    ORDER BY HasWifi DESC, ReleaseDate DESC

DELETE FROM TutorialAppSchema.Computer WHERE ComputerId = 155

UPDATE TutorialAppSchema.Computer SET CPUCores = NULL
    WHERE ReleaseDate > '2017-01-01'