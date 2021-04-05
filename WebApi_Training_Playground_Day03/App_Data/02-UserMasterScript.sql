
USE [WebApiTrainingDb]

CREATE TABLE UserMaster
(
  Id INT PRIMARY KEY,
  UserName VARCHAR(50),
  [Password] VARCHAR(50),
  Roles VARCHAR(500),
  EmailId VARCHAR(100),
)
GO
INSERT INTO UserMaster VALUES(101, 'Anurag', '123456', 'Admin', 'Anurag@g.com')
INSERT INTO UserMaster VALUES(102, 'Priyanka', 'abcdef', 'User', 'Priyanka@g.com')
INSERT INTO UserMaster VALUES(103, 'Sambit', '123pqr', 'SuperAdmin', 'Sambit@g.com')
INSERT INTO UserMaster VALUES(104, 'Pranaya', 'abc123', 'Admin, User', 'Pranaya@g.com')
GO