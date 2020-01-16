Create database Test5
Go
use Test5
Go
CREATE TABLE dbo.Person5
(
    Id int primary key identity(1,1),
    FName nvarchar(50) ,
	LName nvarchar(50),
	TelNumber nvarchar(50),
	MobileNumber nvarchar(50),
	Addresss nvarchar(50),
	Email nvarchar(50),
	

);