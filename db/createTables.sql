CREATE TABLE [dbo].[refUsers]
(
    [id] INT NOT NULL PRIMARY KEY,
    [userFirstName] VARCHAR(50) NOT NULL,
    [userSecondName] VARCHAR(50) NOT NULL,
    [userThirdName] VARCHAR(50),
    [userBDate] DATE NOT NULL,
    [userSex] VARCHAR(5) NOT NULL,
    [userDocument] VARCHAR(50) NOT NULL,
    [userEmail] VARCHAR(50),
    [userLogin] VARCHAR(50),
    [userPassword] VARCHAR(50),
    [deleted] INT NOT NULL
)

CREATE TABLE [dbo].[refTrains]
(
    [id] INT NOT NULL PRIMARY KEY,
    [trainType] VARCHAR(50) NOT NULL,
    [trainNumber] VARCHAR(50) NOT NULL,
	[deleted] INT NOT NULL
)

CREATE TABLE [dbo].[refStations]
(
    [id] INT NOT NULL PRIMARY KEY,
    [stationName] VARCHAR(150) NOT NULL,
	[GroupCode] VARCHAR(50),
	[deleted] INT NOT NULL
)

CREATE TABLE [dbo].[refTimetable]
(
    [id] INT NOT NULL PRIMARY KEY,
    [startDate] SMALLDATETIME NOT NULL,
    [endDate] SMALLDATETIME NOT NULL,
    [price] FLOAT NOT NULL,
    [idRoute] INT NOT NULL,
    [idTrain] INT NOT NULL,
	[deleted] INT NOT NULL
)

CREATE TABLE [dbo].[refTickets]
(
    [id] INT NOT NULL PRIMARY KEY,
    [sellDate] SMALLDATETIME NOT NULL,
    [idUsers] INT NOT NULL,
    [idTimetable] INT NOT NULL,
	[deleted] INT NOT NULL
)

CREATE TABLE [dbo].[refRoutes]
(
    [id] INT NOT NULL PRIMARY KEY,
    [firstStation] VARCHAR(150) NOT NULL,
    [lastStation] VARCHAR(150) NOT NULL,
    [Code] VARCHAR(50) NOT NULL,
    [idStation]
)

ALTER TABLE refTickets
ADD FOREIGN KEY (idUsers) REFERENCES refUsers(id);

ALTER TABLE refTickets
ADD FOREIGN KEY (idStations) REFERENCES refStations(id);

ALTER TABLE refTickets
ADD FOREIGN KEY (idTrains) REFERENCES refTrains(id);

ALTER TABLE refTimetables
ADD FOREIGN KEY (idStations) REFERENCES refStations(id);

ALTER TABLE refTimetables
ADD FOREIGN KEY (idTrains) REFERENCES refTrains(id);