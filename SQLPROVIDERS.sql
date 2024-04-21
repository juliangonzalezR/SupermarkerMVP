use Supermarker
create table Providers
(
 Providers_Id int identity (100000,1) primary key,
 Providers_Name nvarchar (50) not null,
 Providers_Observation nvarchar (50) not null,
)
go
insert into Providers values('CocaCola Company', 'Providers the Drinks non alcoholics')
insert into Providers values('jhonson and Jhonsons', 'Providers the personal care')
