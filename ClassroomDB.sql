--CREATE DATABASE ClassroomDB;
--USE ClassroomDB;

--CREATE TABLE [User] (
--ID int Identity(1,1) NOT NULL Primary Key,
--GoogleToken NVARCHAR(600),
--GoogleName NVARCHAR(150),
--TeacherID int
--);

--INSERT INTO [User](GoogleToken, GoogleName, TeacherID)
--VALUES ('1234', 'Chelsea Pickett', 0123456789);

--SELECT * FROM [User];

--CREATE TABLE Classroom(
--ID int Identity(1,1) NOT NULL Primary Key, 
--GoogleToken NVARCHAR(600),
--ClassroomToken NVARCHAR(100),
--);

--INSERT INTO Classroom(GoogleToken, ClassroomToken)
--VALUES ('1234', '5678');

--SELECT * FROM Classroom;

--CREATE TABLE Student(
--ID int Identity(1,1) NOT NULL Primary Key, 
--StudentName NVARCHAR(70),
--StudentId int,
--Grade int,
--ClassroomToken NVARCHAR(100),
--);

--INSERT INTO Student(StudentName, StudentId, Grade, ClassroomToken)
--VALUES ('John Doe', 456789, 4, '5678'),
--('Jane Doe', 012345, 4, '5678');

--DROP TABLE Student;

SELECT * FROM Student;