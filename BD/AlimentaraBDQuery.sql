CREATE DATABASE AlimentaraBD
USE AlimentaraBD

CREATE TABLE Magazin(
	ID_Magazin int primary key identity(1, 1),
	Adresa varchar(70),
	Telefon varchar(70) default '+373-77-777-777',
	Localitatea varchar(70) default 'Chisinau'
);

CREATE TABLE Producator(
	ID_Producator int primary key identity(100, 1),
	Denumirea varchar(70),
	Adresa varchar(70),
	Telefon varchar(70),
	Localitatea varchar(70)
);


CREATE TABLE Produs(
	ID_Produs int primary key identity(1000, 1),
	Denumire varchar(70),
	Cantitate float,
	Tip_Cantitate varchar(2) default 'KG',
	Pret float,
	Data_Valabilitate date,
	ID_Producator int foreign key references Producator(ID_Producator),
	ID_Magazin int foreign key references Magazin(ID_Magazin)
);