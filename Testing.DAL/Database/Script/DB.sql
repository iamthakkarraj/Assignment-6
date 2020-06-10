CREATE DATABASE [TestingAssignment]
GO
USE [TestingAssignment]
GO
CREATE TABLE [Login] ([AdminId] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
						[Username] NVARCHAR(52) NOT NULL, 
						[Password] NVARCHAR(18) NOT NULL)
GO
CREATE TABLE [User] ([UserId] INT PRIMARY KEY IDENTITY(1,1),
						[Name] NVARCHAR(52) NOT NULL,
						[Email] NVARCHAR(52) NOT NULL,
						[Phone] NVARCHAR(10) NOT NULL,
						[Birthdate] DATETIME NOT NULL,
						[Gender] BIT NOT NULL)

INSERT INTO [Login] VALUES('Admin', 'Admin');