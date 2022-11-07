Use Master
GO

If exists (Select * from sys.databases where name = 'CoMute')
Drop Database CoMute
GO

Create Database CoMute
GO

Use CoMute
GO

Create Table [User]
(
[User_ID] int primary key identity(1,1) not null,
[User_Name] varchar(50) not null,
User_Surname varchar(50) not null,
Phone_Number Varchar (15) not null,
Email varchar(50) not null,
[Password] varchar(50) not null,
)
go

Create Table Car_Pool
(
Car_Pool_ID int primary key identity(1,1) not null,
Departure_Time time not null,
Expected_Arrival_Time time not null ,
Origin varchar(50) not null,
[Days_Available] varchar(50) not null,
Destination varchar(50) not null,
Available_Seats int not null,
Notes varchar(50) not null ,
[User_ID] int references [User]([User_ID]),
Date_Created Datetime not null,
)
go

 Create Table [Status]
 (
Status_ID int primary key identity(1,1),
Status_Description varchar(50) 
 )
 go

Create Table Passenger_Pool
(
Passenger_Pool_ID int Primary Key identity(1,1)NOT NULL ,
[User_ID] int foreign key references [User] ([User_ID]),
Car_Pool_ID int foreign key references Car_Pool (Car_Pool_ID),
Status_ID int foreign key references [Status] (Status_ID),
Date_Joined Datetime,
)
go

