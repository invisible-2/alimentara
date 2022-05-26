-- PROCEDURA de adaugare a unui produs in BD
GO
CREATE PROCEDURE AdaugaProdus
	@Cod varchar(10),
	@Denumire varchar(70),
	@Cantitate float,
	@Tip_Cantitate varchar(2),
	@Pret float,
	@Data_Valabilitate varchar(10),
	@ID_Departament int,
	@ID_Producator int,
	@ID_Magazin int
AS
	BEGIN
		INSERT INTO Produs(Cod, Denumire, Cantitate, Tip_Cantitate, Pret, Data_Valabilitate, ID_Departament, ID_Producator, ID_Magazin)
		VALUES(@Cod, @Denumire, @Cantitate, @Tip_Cantitate, @Pret, @Data_Valabilitate, @ID_Departament, @ID_Producator, @ID_Magazin)
	END
GO


-- PROCEDURA de cautare a unui produs in BD dupa @Cod
GO
CREATE PROCEDURE CautaProdusDupaCod
	@Cod varchar(10)
AS
	BEGIN
		SELECT * FROM Produs 
		WHERE  Produs.Cod = @Cod
	END
GO


-- PROCEDURA de cauatare a unui Departament in BD dupa @ID
GO
CREATE PROCEDURE CautaDepartamentDupaID
	@ID_Departament int
AS
	BEGIN
		SELECT Nume FROM Departament
		WHERE ID_Departament = @ID_Departament
	END
GO


-- PROCEDURA de cautare a unui Producator in BD dupa @ID
GO
CREATE PROCEDURE CautaProducatorDupaID
	@ID_Producator int
AS
	BEGIN
		SELECT Denumirea FROM Producator
		WHERE ID_Producator = @ID_Producator
	END
GO


-- PROCEDURA de cautare a unui Magzin in BD dupa @ID
GO
CREATE PROCEDURE CautaMagazinDupaID
	@ID_Magazin int
AS
	BEGIN
		SELECT Magazin.Nume FROM Magazin
		WHERE ID_Magazin = @ID_Magazin
	END
GO

-- PROCEDURA de cautare a unei Localitati in BD dupa @ID
GO
CREATE PROCEDURE CautaLocalitateDupaID
	@ID_Localitate int
AS
	BEGIN
		SELECT Nume FROM Localitate
		WHERE ID_Localitate = @ID_Localitate
	END
GO


-- PROCEDURA de cautare produselor dupa Numele Departamentului
GO
CREATE PROCEDURE GetProduse
	@Nume varchar(70)
AS
	BEGIN
		SELECT * FROM Produs
		INNER JOIN Departament
		ON Produs.ID_Departament = Departament.ID_Departament
		WHERE Departament.Nume = @Nume
	END
GO



-- PROCEDURA de actualizare a unui produs
GO
CREATE PROCEDURE ActualizeazaProdus
	@ID_Produs int,
	@Cod varchar(10),
	@Denumire varchar(70),
	@Cantitate float,
	@Tip_Cantitate varchar(10),
	@Pret float,
	@Data_Valabilitate varchar(20)
AS
	BEGIN
		UPDATE Produs SET Cod = @Cod, Denumire = @Denumire, Cantitate = @Cantitate, Tip_Cantitate = @Tip_Cantitate, Pret = @Pret, Data_Valabilitate = @Data_Valabilitate
		WHERE ID_Produs = @ID_Produs
		
		
	END
GO

-- PROCEDURA de stergere a unui produs
GO
CREATE PROCEDURE StergeProdus
	@ID_Produs int
AS
	BEGIN
		DELETE FROM Produs
		WHERE ID_Produs = @ID_Produs
		
		
	END
GO


-- PROCEDURA de adaugare a unui magazin in BD
GO
CREATE PROCEDURE AdaugaMagazin
	@Nume varchar(70),
	@Adresa varchar(70),
	@Telefon varchar(70),
	@ID_Localitate int
AS
	BEGIN
		INSERT INTO Magazin(Nume, Adresa, Telefon, ID_Localitate)
		VALUES(@Nume, @Adresa, @Telefon, @ID_Localitate)
	END
GO

-- PROCEDURA de cauate a produselor dupa NUME
GO
CREATE PROCEDURE CautaProduse
	@Denumire varchar(70)
AS
	BEGIN
		select * FROM Produs
		WHERE Produs.Denumire LIKE @Denumire + '%'	
	END
GO



-- PROCEDURA de cautare produselor dupa Numele Magazinului
GO
CREATE PROCEDURE GetProduseDinMagazin
	@ID_Magazin int
AS
	BEGIN
		SELECT * FROM Produs
		INNER JOIN Magazin
		ON Produs.ID_Magazin = Magazin.ID_Magazin
		WHERE Magazin.ID_Magazin = @ID_Magazin
	END
GO

-- PROCEDURA de cautare a unui Produs in BD dupa @ID
GO
CREATE PROCEDURE CautaProdusDupaID
	@ID_Produs int
AS
	BEGIN
		SELECT * FROM Produs
		WHERE ID_Produs = @ID_Produs
	END
GO
