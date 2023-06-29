-- Создание базы данных с названием "OnlineCinoteatr"
-- CREATE DATABASE OnlineCinoteatr
USE OnlineCinoteatr

-- Создание таблицы Film
CREATE TABLE Film (
	ID_Filma INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FilmName VARCHAR(100) NOT NULL,
	DataVihoda DATE DEFAULT GETDATE() NOT NULL,
	Country VARCHAR(50) NOT NULL,
	AgeRestriction VARCHAR(5) NOT NULL,
	FilmDescription VARCHAR(1000) NOT NULL,
	Repertuar VARCHAR(25) NOT NULL, CHECK(Repertuar IN ('фильм', 'мультфильм', 'сериал', 'короткометражка')),
);

-- Создание таблицы Zhanr
CREATE TABLE Zhanr (
	ID_Zhanra INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ZhanrName VARCHAR(50) NOT NULL,
);

-- Создание таблицы Actor
CREATE TABLE ACTOR (
	ID_Actor INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Surname VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	KolichestvoFilmov INT, CHECK (KolichestvoFilmov > 0),
	Birthday DATETIME DEFAULT GETDATE(),
);

-- Создание таблицы Builder
CREATE TABLE Builder (
	ID_Builder INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Surname VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	KolichestvoFilmov INT, CHECK (KolichestvoFilmov > 0),
	Birthday DATETIME DEFAULT GETDATE(),
	PhoneNumber VARCHAR(12), CHECK (PhoneNumber LIKE '+[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Post VARCHAR(50) NOT NULL,
);

-- Создание таблицы User
CREATE TABLE Users (
	ID_Usera INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Surname VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	UserLogin VARCHAR(50) NOT NULL,
	UserPassword VARCHAR(50) NOT NULL,
	Birthday DATETIME DEFAULT GETDATE(),
	Email VARCHAR(50) NOT NULL,
);

-- Создание таблицы Podpiska
CREATE TABLE Podpiska (
	ID_Podpiska INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NamePodpiska VARCHAR(50) NOT NULL,
	Price DECIMAL(10,2),
);

-- Создание ассоциативных таблиц и опредление связей между таблицами

-- Создание таблицы FilmZhanr
CREATE TABLE FilmZhanr (
	ID_FilmZhanr INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_Filma INT NOT NULL,
	ID_Zhanra INT NOT NULL,
	CONSTRAINT fk_FilmZhanr_Film FOREIGN KEY (ID_Filma) References Film
	ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_FilmZhanr_Zhanr FOREIGN KEY (ID_Zhanra) References Zhanr
	ON UPDATE CASCADE ON DELETE CASCADE,
);

-- Создание таблицы FilmActor
CREATE TABLE FilmActor (
	ID_FilmActor INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_Filma INT NOT NULL,
	ID_Actora INT NOT NULL,
	CONSTRAINT fk_FilmActor_Film FOREIGN KEY (ID_Filma) References Film
	ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_FilmActor_Actor FOREIGN KEY (ID_Actora) References Actor
	ON UPDATE CASCADE ON DELETE CASCADE,
);

-- Создание таблицы FilmBuilder
CREATE TABLE FilmBuilder (
	ID_FilmBuilder INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_Filma INT NOT NULL,
	ID_Builder INT NOT NULL,
	CONSTRAINT fk_FilmBuilder_Film FOREIGN KEY (ID_Filma) References Film
	ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_FilmBuilder_Builder FOREIGN KEY (ID_Builder) References Builder
	ON UPDATE CASCADE ON DELETE CASCADE,
);

-- Создание таблицы ViewsFilmsUsers
CREATE TABLE ViewsFilmsUsers (
	ID_Views INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_Filma INT NOT NULL,
	ID_Usera INT NOT NULL,
	DataProsmotra DATETIME DEFAULT GETDATE() NOT NULL,
	CONSTRAINT fk_ViewsFilmsUsers_Film FOREIGN KEY (ID_Filma) References Film
	ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_ViewsFilmsUsers_Users FOREIGN KEY (ID_Usera) References Users
	ON UPDATE CASCADE ON DELETE CASCADE,
);

-- Создание таблицы UserPodpiska
CREATE TABLE UserPodpiska (
	ID_UserPodpiska INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_Usera INT NOT NULL,
	ID_Podpiska INT NOT NULL,
	SrokDeistvia VARCHAR(50), CHECK (SrokDeistvia IN ('неделя','месяц','год','неограничено')),
	CONSTRAINT fk_UserPodpiska_Podpiska FOREIGN KEY (ID_Podpiska) References Podpiska
	ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_UserPodpiska_Users FOREIGN KEY (ID_Usera) References Users
	ON UPDATE CASCADE ON DELETE CASCADE,
);