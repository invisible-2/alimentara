CREATE DATABASE AlimentaraBD
USE AlimentaraBD


CREATE TABLE Departament(
	ID_Departament int primary key identity(1, 1),
	Nume varchar(70)
);


CREATE TABLE Localitate(
	ID_Localitate int primary key identity(1, 1),
	Nume varchar(70)
);

CREATE TABLE Magazin(
	ID_Magazin int primary key identity(1, 1),
	Nume varchar(70),
	Adresa varchar(70),
	Telefon varchar(70) default '+373-77-777-777',
	ID_Localitate int foreign key references Localitate(ID_Localitate)
);


CREATE TABLE Producator(
	ID_Producator int primary key identity(1, 1),
	Denumirea varchar(70),
	Adresa varchar(70),
	Telefon varchar(70),
	ID_Localitate int foreign key references Localitate(ID_Localitate)
);



CREATE TABLE Produs(
	ID_Produs int primary key identity(1, 1),
	Cod varchar(10),
	Denumire varchar(70),
	Cantitate float,
	Tip_Cantitate varchar(10) default 'KG',
	Pret float,
	Data_Valabilitate varchar(20),
	ID_Departament int foreign key references  Departament(ID_Departament),
	ID_Producator int foreign key references Producator(ID_Producator),
	ID_Magazin int foreign key references Magazin(ID_Magazin)
);



select * from Localitate
select * from Departament
select * from Producator
select * from Magazin
select * from Produs

	
	


