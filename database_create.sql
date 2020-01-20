USE master

GO

CREATE DATABASE wt_14_16_zrodlo;

GO

USE wt_14_16_zrodlo;

GO

CREATE TABLE miasto
(
	id_miasta BIGINT IDENTITY(1,1) NOT NULL,
	nazwa VARCHAR(MAX) NOT NULL
);
GO

ALTER TABLE miasto ADD CONSTRAINT PK_miasto PRIMARY KEY(id_miasta);

GO

CREATE TABLE uzytkownik
(
	id_uzytkownika BIGINT IDENTITY(1,1) NOT NULL,
	imie VARCHAR(20) NOT NULL,
	nazwisko VARCHAR(50) NOT NULL,
	adres VARCHAR(MAX) NOT NULL,
	id_miasta BIGINT NOT NULL,
	kod_pocztowy VARCHAR(6),
	telefon VARCHAR(10)
);

GO

ALTER TABLE uzytkownik ADD CONSTRAINT PK_uzytkownik PRIMARY KEY(id_uzytkownika);

GO

ALTER TABLE uzytkownik ADD CONSTRAINT FK_id_miasta FOREIGN KEY(id_miasta) REFERENCES miasto(id_miasta);

GO

USE master

GO

CREATE DATABASE wt_14_16_cel;

GO

USE wt_14_16_cel;

GO

CREATE TABLE miasto
(
	id_miasta BIGINT IDENTITY(1,1) NOT NULL,
	nazwa VARCHAR(MAX) NOT NULL
);
GO

ALTER TABLE miasto ADD CONSTRAINT PK_miasto PRIMARY KEY(id_miasta);

GO

CREATE TABLE uzytkownik
(
	id_uzytkownika BIGINT IDENTITY(1,1) NOT NULL,
	imie VARCHAR(20) NOT NULL,
	nazwisko VARCHAR(50) NOT NULL,
	adres VARCHAR(MAX) NOT NULL,
	id_miasta BIGINT NOT NULL,
	kod_pocztowy VARCHAR(6),
	telefon VARCHAR(10)
);

GO

ALTER TABLE uzytkownik ADD CONSTRAINT PK_uzytkownik PRIMARY KEY(id_uzytkownika);

GO

ALTER TABLE uzytkownik ADD CONSTRAINT FK_id_miasta FOREIGN KEY(id_miasta) REFERENCES miasto(id_miasta);

GO

  INSERT INTO [wt_14_16_zrodlo].[dbo].[miasto] VALUES ('£ódŸ'),('Warszawa'),('L¹dek Zdrój'),('Kieszonkowo')

	INSERT INTO [wt_14_16_zrodlo].[dbo].[uzytkownik]([imie],[nazwisko],[adres],[id_miasta],[kod_pocztowy],[telefon]) 
		VALUES('Marcin','Kopernik','K¹towa 12, m. 44',1,'92-213','brak')
	INSERT INTO [wt_14_16_zrodlo].[dbo].[uzytkownik]([imie],[nazwisko],[adres],[id_miasta],[kod_pocztowy],[telefon]) 
		VALUES('Miko³aj','Kopernik','brak',2,'brak','brak')
	INSERT INTO [wt_14_16_zrodlo].[dbo].[uzytkownik]([imie],[nazwisko],[adres],[id_miasta],[kod_pocztowy],[telefon]) 
		VALUES('Roman','Zanzibar','K¹towa 46, m. 44',1,'88-813','765125545')
	INSERT INTO [wt_14_16_zrodlo].[dbo].[uzytkownik]([imie],[nazwisko],[adres],[id_miasta],[kod_pocztowy],[telefon]) 
		VALUES('Marcin','Kopernik','brak',4,'brak','555232443')



