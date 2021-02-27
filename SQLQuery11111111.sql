create table dbo.Brands
(
BrandId int 
PRIMARY KEY(BrandId),
BrandName nvarchar(50)

)

create table dbo.Colors
(
ColorId int,
PRIMARY KEY(ColorId),
ColorName nvarchar(50)

)

create table dbo.Cars
(
Id int,
PRIMARY KEY(Id),
DailyPrice int,
Description nvarchar(50),
ModelYear int,
BrandId int,
ColorId int,
FOREIGN KEY (BrandId) references dbo.Brands,
FOREIGN KEY (ColorId) references dbo.Colors
)
INSERT INTO  dbo.Cars (Id,BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	("1","1","2019","1200","Red Audi"),
	("1","2","2020","2000","White Mercedes"),
	("2","1","2017","1300","Yellow VW"),
	("3","3","2021","2500","Dark Blue BMW"),
	("3", "2","2018","1750","Black Fiat")

	




