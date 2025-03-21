--CREATE DATABASE
USE master

IF EXISTS (SELECT * FROM sys.databases WHERE name ='RegistrationDB')
DROP DATABASE RegistrationDB
CREATE DATABASE RegistrationDB

USE RegistrationDB

--CREATE TABLE
CREATE TABLE Student (
	StudentID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] VARCHAR (250) NOT NULL,
	Surname VARCHAR (250) NOT NULL,
	email VARCHAR (250) NOT NULL
);

--INSERT VALUES
INSERT INTO Student ([Name], Surname, Email)
VALUES ('Cindy', 'Morca', 'cmorcas@gmail.com')

SELECT * FROM Student