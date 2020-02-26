CREATE TABLE Admin (
	username NVARCHAR(25) NOT NULL,
	password NVARCHAR(25) NOT NULL
);

CREATE TABLE Measure (
	measure_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	measure_name NVARCHAR(30) NOT NULL
);

INSERT INTO Measure (measure_name) values ('MiliGram');
INSERT INTO Measure (measure_name) values ('Gram');
INSERT INTO Measure (measure_name) values ('MikroLitre');
INSERT INTO Measure (measure_name) values ('MiliLitre');
INSERT INTO Measure (measure_name) values ('Litre');

CREATE TABLE productRegister (
	product_barcod NVARCHAR(50) NOT NULL PRIMARY KEY,
	product_name NVARCHAR(100) NOT NULL,
	product_date DATETIME NOT NULL
);

CREATE TABLE productAdd (
	product_barcod NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES productRegister (product_barcod),
	product_amount FLOAT NOT NULL DEFAULT 0,
	product_date DATETIME NOT NULL
);

CREATE TABLE productSubstract (
	product_barcod NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES productRegister (product_barcod),
	product_amount INT NOT NULL DEFAULT 0,
	product_date DATETIME NOT NULL
);