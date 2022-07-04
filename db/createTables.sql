CREATE TABLE [dbo].[refUsers]
(
    [id] INT NOT NULL PRIMARY KEY,
    [userFirstName] VARCHAR(50) NOT NULL,
    [userSecondName] VARCHAR(50) NOT NULL,
    [userThirdName] VARCHAR(50),
    [userBDate] DATE NOT NULL,
    [userSex] VARCHAR(5) NOT NULL,
    [userDocument] VARCHAR(50) NOT NULL,
    [userEmail] VARCHAR(50) NOT NULL,
    [userLogin] VARCHAR(50) NOT NULL,
    [userPassword] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[refTrains]
(
    [id] INT NOT NULL PRIMARY KEY,
    [trainType] VARCHAR(50) NOT NULL,
    [trainNumber] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[refStations]
(
    [id] INT NOT NULL PRIMARY KEY,
    [stationName] VARCHAR(150) NOT NULL
)

CREATE TABLE [dbo].[refTimetable]
(
    [id] INT NOT NULL PRIMARY KEY,
    [startDate] SMALLDATETIME NOT NULL,
    [endDate] SMALLDATETIME NOT NULL,
    [price] FLOAT NOT NULL,
    [idStation] INT NOT NULL,
    [idTrain] INT NOT NULL
)

CREATE TABLE [dbo].[refTickets]
(
    [id] INT NOT NULL PRIMARY KEY,
    [sellDate] SMALLDATETIME NOT NULL,
    [idUsers] INT NOT NULL,
    [idStations] INT NOT NULL,
    [idTrains] INT NOT NULL
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