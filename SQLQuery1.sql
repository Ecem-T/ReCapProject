CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)

CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)

CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)


INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2019','1200','Navigasyonlu'),
	('2','3','2020','2000','Navigasyonlu, Sunrooflu'),
	('3','1','2017','1300','Celik jan'),
	('4','3','2021','2500','Yol tutus'),
	('5','2','2018','1750','Otomatik bagaj sistemi');

INSERT INTO Colors(ColorName)
VALUES
	('Red'),
	('White'),
	('Yellow'),
	('Dark Blue'),
	('Black');


INSERT INTO Brands(BrandName)
VALUES
	('Audi'),
	('Mercedes'),
	('BMW'),
	('Fiat'),
	('VW');
