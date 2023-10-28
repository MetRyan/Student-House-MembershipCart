CREATE DATABASE StudentHouseMembership
GO
USE StudentHouseMembership
GO
--Customer table 
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] PRIMARY KEY IDENTITY(1,1),
	[dateCreated] [date] NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[phone] [varchar](20) NULL,
	[dob] [date] NULL,
	[sex] [bit] NULL,
	[Status] [varchar](20) NULL

);
--Service table
Create table [dbo].[Service](
	ServiceID int PRIMARY KEY,
	ServiceName nvarchar(50) NOT NULL,
	CreateDate date,
	AmountOfTime INT,
	Price float,
	Status varchar(10)
);
--Order table
CREATE TABLE [dbo].[Order](
	OrderID int PRIMARY KEY IDENTITY(1,1),
	CustomerID int NOT NULL,
	ServiceID int NOT NULL,
	Price float,
	Description nvarchar(50),
	Status varchar(10),

	FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
	FOREIGN KEY (ServiceID) REFERENCES Service(ServiceID)
);

CREATE TABLE OrderDetails(
	OrderID int FOREIGN KEY REFERENCES [dbo].[Order](OrderID),
	ServiceID int FOREIGN KEY REFERENCES [dbo].[Service](ServiceID),
	ServiceName nvarchar(50),
	Price float,
	CreateDate date,
	EndDate date,
	Address nvarchar(50),
	PaymentMethod varchar(20)
)
CREATE TABLE Staff(
	StaffID int PRIMARY KEY,
	StaffName nvarchar(50) NOT NULL,
	Email nvarchar(50),
	Phone varchar(13),
	dob date,
	sex varchar(5),
	status varchar(10),
	ServiceID int FOREIGN KEY REFERENCES [dbo].[Service](ServiceID)
)
CREATE TABLE Admin(
	AdminID int PRIMARY KEY,
	AdminName nvarchar(50) NOT NULL,
	Email nvarchar(50),
	Phone varchar(13),
	dob date,
	sex varchar(5),
	status varchar(10)
)
CREATE TABLE AdminServices(
	AdminID int FOREIGN KEY REFERENCES Admin(AdminID),
	ServiceID int FOREIGN KEY REFERENCES Service(ServiceID),
	LatestUpdate date
)
CREATE TABLE Payment(
	PaymentID int PRIMARY KEY,
	OrderID int FOREIGN KEY REFERENCES [dbo].[Order](OrderID),
	PaymentType varchar(10),
	Price float
)
CREATE TABLE StaffOrder(
	StaffID int FOREIGN KEY REFERENCES [dbo].[Staff](StaffID),
	OrderID int FOREIGN KEY REFERENCES [dbo].[Order](OrderID),
	WorkDate date,
	Status varchar(10)
)




