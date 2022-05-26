USE AlimentaraBD

CREATE TABLE _admin (
	ID int primary key identity(1, 1),
	username varchar(50),
	fname varchar(50),
	lname varchar(50),
	passHash binary(64)
);


CREATE TABLE _user (
	ID int primary key identity(1, 1),
	username varchar(50),
	fname varchar(50),
	lname varchar(50),
	passHash binary(64)
);




--PROCEDURA adauga Admin
GO
CREATE PROCEDURE addAdmin
	@username varchar(50),
	@fname varchar(50),
	@lname varchar(50),
	@pass varchar(50)
AS
	BEGIN
		insert into _admin(username, fname, lname, passHash)
		values(@username, @fname, @lname, HASHBYTES('SHA2_512', @pass));
	END
GO

--PROCEDURA cauta Admin Dupa ID
GO
CREATE PROCEDURE getAdminByID
	@ID int
AS
	BEGIN
		select * from _admin where ID = @ID;
	END
GO


--PROCEDURA adauga User
GO
CREATE PROCEDURE addUser
	@username varchar(50),
	@fname varchar(50),
	@lname varchar(50),
	@pass varchar(50)
AS
	BEGIN
		insert into _user(username, fname, lname, passHash)
		values(@username, @fname, @lname, HASHBYTES('SHA2_512', @pass));
	END
GO


--PROCEDURA verifica daca Usernameul introdus este prezent in BD
GO
CREATE PROCEDURE checkIfExistsUser
	@username varchar(50)
AS
	BEGIN
	Declare @id INT
	Declare @ifExists INT
	set @id = 1
	set @ifExists = 0

		WHILE(@id <= (SELECT COUNT(ID) FROM _user))
		  BEGIN
			IF @username = (SELECT username FROM _user WHERE ID = @id)
				BEGIN
					SELECT 'EXISTS'
					set @ifExists = 1
				END
			SET @id = @id + 1
		  END
		IF @ifExists = 0 SELECT 'NOT_EXISTS' 
	END
GO


--PROCEDURA cauta User Dupa Username
GO
CREATE PROCEDURE GetUserByUsername
	@username varchar(50)
AS
	BEGIN
			SELECT * FROM _user WHERE username = @username 
	END
GO

--PROCEDURA cauta Admin Dupa Username
GO
CREATE PROCEDURE GetAdminByUsername
	@username varchar(50)
AS
	BEGIN
			SELECT * FROM _admin WHERE username = @username 
	END
GO



select * from _user
select * from _admin


