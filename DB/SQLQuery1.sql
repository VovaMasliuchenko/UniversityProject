CREATE DATABASE EvenToTheMoon
GO
use EvenToTheMoon
GO
CREATE TABLE Tours(
Id int NOT NULL PRIMARY KEY IDENTITY,
Tour varchar(30) NOT NULL,
Price int NOT NULL,
DateOfDepartue smalldatetime NOT NULL,
CityOfDepartue varchar(30) NOT NULL,
CountOfPerson int NOT NULL,
DaysAndNights int NOT NULL,
ID_Country int NOT NULL,
ID_Hotel int NOT NULL,
ID_Discount int NOT NULL,
ID_Nutrition int NOT NULL,
ID_Tour_Categories int NOT NULL,

)
GO
CREATE TABLE Discount(
Id int NOT NULL PRIMARY KEY IDENTITY,
NameOfDiscount varchar(30) NOT NULL,
Size int NOT NULL
)
GO
CREATE TABLE Nutrition(
Id int NOT NULL PRIMARY KEY IDENTITY,
TypeNutrition varchar(30) NOT NULL,
)
GO
CREATE TABLE Hotel(
Id int NOT NULL PRIMARY KEY IDENTITY,
HotelName varchar(30) NOT NULL,
HotelType varchar(30) NOT NULL,
HotelClass varchar(30) NOT NULL,
)
GO
CREATE TABLE Country(
Id int NOT NULL PRIMARY KEY IDENTITY,
CountryName varchar(30) NOT NULL
)
GO
CREATE TABLE TourCatrgories(
Id int NOT NULL PRIMARY KEY IDENTITY,
TourCategorie varchar(30) NOT NULL
)
GO
CREATE TABLE Clients(
Id int NOT NULL PRIMARY KEY IDENTITY,
FullName varchar(30) NOT NULL,
PhoneNumber varchar(30) NOT NULL,
Email varchar(30) NOT NULL
)
GO
CREATE TABLE Reviews(
Id int NOT NULL PRIMARY KEY IDENTITY,
ID_Clients int NOT NULL,
ID_Tour int NOT NULL,
Review varchar(30) NOT NULL
)
GO
CREATE TABLE Sells(
Id int NOT NULL PRIMARY KEY IDENTITY,
DateOfSale smalldatetime NOT NULL,
SellsCount int NOT NULL,
ID_Clients int NOT NULL,
ID_Employee int NOT NULL,
ID_Tour int NOT NULL,
)
GO
CREATE TABLE Employee(
Id int NOT NULL PRIMARY KEY IDENTITY,
FullName varchar(30) NOT NULL,
PhoneNumber varchar(30) NOT NULL
)
GO

ALTER TABLE Tours
ADD
FOREIGN KEY(ID_Country) REFERENCES Country(Id),
FOREIGN KEY(ID_Hotel) REFERENCES Hotel(Id),
FOREIGN KEY(ID_Discount) REFERENCES Discount(Id),
FOREIGN KEY(ID_Nutrition) REFERENCES Nutrition(Id),
FOREIGN KEY(ID_Tour_Categories) REFERENCES TourCatrgories(Id)
GO

ALTER TABLE Reviews
ADD
FOREIGN KEY(ID_Clients) REFERENCES Clients(Id),
FOREIGN KEY(ID_Tour) REFERENCES Tours(Id)
GO

ALTER TABLE Sells
ADD
FOREIGN KEY(ID_Clients) REFERENCES Clients(Id),
FOREIGN KEY(ID_Employee) REFERENCES Employee(Id),
FOREIGN KEY(ID_Tour) REFERENCES Tours(Id)
GO
