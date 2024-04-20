use Supermarker
create table Product
(
 Product_Id int identity (100000,1) primary key,
 Product_Name nvarchar (50) not null,
 Product_Observation nvarchar (50) not null,
)
go
insert into Product values('Water', 'Water product')
insert into Product values('Lemon', 'Lemon product')
