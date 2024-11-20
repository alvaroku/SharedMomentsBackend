-- Definir Roles
select Id from roles where name = 'Admin'
INSERT INTO Roles (Id, Name, IsActive, CreatedAt, UpdatedAt) VALUES 
(NEWID(), 'Admin', 1, GETDATE(), GETDATE()),
(NEWID(), 'User', 1, GETDATE(), GETDATE());
-- Definir Usuario por defecto
--ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f = 12345678
INSERT INTO Users (Id, Name, Email, PasswordHash, RoleId, PhoneNumber, DateOfBirth,IsActive,CreatedAt,UpdatedAt) VALUES 
(NEWID(), 'Alvaro Kú', 'alvaro.ku.dev@gmail.com', 'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f', (select Id from roles where name = 'Admin'), '9919596720', '2000-05-23',1, GETDATE(), GETDATE());

 