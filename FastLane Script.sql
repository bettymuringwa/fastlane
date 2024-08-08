
--database used--
use FastLane_DB;

--dropping tables: from last table created--
--drop table if exists Purchases ;
--drop table if exists Customers;
--drop table  if exists StockEntry;
--drop table  if exists Staff;
--drop table  if exists UserGroup;
--drop table  if exists PositionGroup;
--drop table  if exists StockCategory;


--create tables--
create table StockCategory (
categoryID varchar(10) primary key,
categoryName varchar(50),
productStatus varchar(50)
);

create table PositionGroup(
positionID varchar(10) primary key,
positionName varchar(50) ,
positionDescription varchar(50)
);

create table UserGroup(
groupID varchar(10) primary key,
groupName varchar(10) ,
groupDescription varchar(50)
);

create table Staff(
staffID varchar (10) primary key,
firstName varchar(50),
surname varchar(50),
gender varchar(6),
DateOfBirth date,
country varchar(50),
town varchar(50),
staffAddress varchar(50),
email varchar(100) unique,
cellNumber varchar (50),
positionID varchar(10) foreign key references PositionGroup(positionID),
staffStatus varchar(50),
staffPassword varchar (50),
groupID varchar(10) foreign key references UserGroup(groupID)
);

alter table Staff 
add profilePicture varchar(max);

create table StockEntry(
productCode varchar(20) primary key,
productName varchar(50),
size decimal,
categoryID varchar(10) foreign key references StockCategory(categoryID),
quantity int,
reorderLevel int,
purchasePrice decimal,
percentageMarkup decimal,
sellingPrice decimal,
datePurchased date,
productStatus varchar(50),
staffID  varchar (10) foreign key references Staff(staffID)
);

alter table StockEntry 
alter column size varchar(50);

create table Customers(
customerID varchar(30) primary key,   --customer uses their national id--
firstName varchar(50),
surname varchar(50),
gender varchar(6),
DateOfBirth date,
country varchar(50),
town varchar(50),
customerAddress varchar(50),
email varchar(100) unique,
cellNumber varchar (50),
bankName varchar(50),
accountNumber varchar(50),
customerStatus varchar(50),
customerPassword varchar (50),
groupID varchar(10) foreign key references UserGroup(groupID)
);

create table Purchases(
transactionID int identity (100,3),    
transactionDate date,
transactionTime time,
customerID varchar(30) foreign key references Customers(customerID),
product varchar(50),
quantity int,
price decimal
);



--insert fixed records--

insert into StockCategory values
('GR','Groceries','Active'),
('EL','Electricals','Active'),
('FR','Farming','Discontinued'),
('FN','Furniture','Active'),
('MT','Motoring','Discontinued'),
('CH','Chemicals','Active'),
('CL','Clothing','Active');

insert into PositionGroup values 
('SS','Sales','Monitor the trend of sales and sales analysis'),
('AA','Accountant','Monitor stock inventory, reports and analysis'),
('MM','Manager','In charge of reports and analysis'),
('IT','IT Tech','Monitor website activities');

insert into UserGroup values 
('CM','Customer','Customers'),
('SF','Staff','Staff members'),
('AD','Admin','Admin members'),
('AA','Select...','user must select');

--insert variable records--

insert into Staff values
('Betty','Muringwa','Female','1997-10-31','Botswana','Gaborone','85th block 7','betty@gmail.com','75215489','IT','Active','admin','AD');


insert into Customers values
('f4589575d','Mary','Jane','Female','1990-09-12','Botswana','Gaborone','4th district','mary@gmail.com','77458522','FNB','DD4589624','Active','customer','CM');

select * from UserGroup
where groupID = 'CM'




set identity_insert StockEntry ON 
insert into StockEntry values 
('7859','beans','49','GR','55','4','6','5','5','2022-10-05','active','7000');

select * from Customers;
insert into Purchases values
('2022-07-10','12:10:00','78524','beans','1','4','8');

select * from customers;
select * from staff;
select * from stockentry;