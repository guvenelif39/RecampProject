CREATE TABLE Car(
	CarId int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (BrandId) REFERENCES Color(ColorId),
	FOREIGN KEY (ColorId) REFERENCES Brand(BrandId)
)

CREATE TABLE Color(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)

CREATE TABLE Brand(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)


INSERT INTO Car(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2012','100','Manuel Benzin'),
	('1','3','2015','150','Otomatik Dizel'),
	('2','1','2017','200','Otomatik Hybrid'),
	('3','3','2014','125','Manuel Dizel');

INSERT INTO Color(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Mavi');


INSERT INTO Brand(BrandName)
VALUES
	('Mercedes'),
	('BMW'),
	('Renault');