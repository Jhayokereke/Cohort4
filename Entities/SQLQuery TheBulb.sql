--T-SQL - Transact SQL (Microsoft)

drop database TheBulbDB

create database DatabaseDemo

alter database DatabaseDemo modify Name = TheBulbDB

use TheBulbDB
go

create table DotnetFellows
(
Id nvarchar(17) not null primary key,
Firstname nvarchar(50) not null,
Middlename nvarchar(50) not null,
Lastname nvarchar(50) not null,
GenderId int not null,
StateId int not null
)

select * from DotnetFellows

drop table DotnetFellows

use TheBulbDB

INSERT into DotnetFellows VALUES ( '54rk-bde4', 'Chinazo', 'Ifedika', 'Olisa', 2, 5)
insert into DotnetFellows values ( '54rk-bdz5', 'Ifunnanya', 'Williams', 'Onah', 1, 3)
insert into DotnetFellows values ( '54rk-bda8', 'Uzor', 'Romanus', 'Nwachukwu', 1, 6)
insert into DotnetFellows values ( '54rk-bdc9', 'Henry', 'Ekene', 'Iwekuba', 1, 6)
insert into DotnetFellows values ( '54rk-bdd7', 'Emeka', 'Chidubem', 'Ewelike', 1, 4)
insert into DotnetFellows values ( '54rk-bda2', 'Raphael', 'Chidiebere', 'Isaac', 1, 2)
insert into DotnetFellows values ( '54rk-bdf1', 'Philip', 'Newman', 'Amadi', 1, 7)
insert into DotnetFellows values ( '54rk-bdp0', 'Chukwuemeka', 'John', 'Okereke', 1, 2)


insert into DotnetFellows values ( '54rk-bdu0', 'Ademola', 'Oluwadamilare', 'Balogun', 1, 1)
insert into DotnetFellows(Id, Firstname, Middlename, Lastname, StateId) values ( '54rk-bdi9', 'Samson', 'Aregbesola', 'Dada', 1)
insert into DotnetFellows(Id, Firstname, Middlename, Lastname, GenderId, StateId) values ( '54rk-bdb4', 'Emmanuel', 'Asafa', 'Ilivieda', 1, 2)
insert into DotnetFellows(Id, Firstname, Middlename, Lastname, GenderId, StateId) values ( '54rk-bdj5', 'Chisom', 'Progress', 'Iheme', 1, 4)

alter table DotnetFellows
add constraint DotnetFellows_GenderId_default
default 3 for GenderId

select * from DotnetFellows

select * from [State]
where [Name] like '%A%'

--'%xxx' entry that ends with xxx
--'abc%' entry that starts with abc
--'%srt%' entry that contains srt

alter table DotnetFellows
add HasGraduated bit

update DotnetFellows
set HasGraduated = 0
where Firstname in ('Samson', 'Chukwuemeka') 

delete from DotnetFellows where Firstname = 'Chukwuemeka'


create table Gender
(
Id int not null primary key,
Gender nvarchar(20)
)

select * from Gender

delete from Gender where Id = 5

insert into Gender(Gender, Id) values ('Male', 1)
insert into Gender values (2, 'female')
insert into Gender values (3, 'Other')
insert into Gender values (7, 'Trans-Male')
insert into Gender values (6, 'Trans-Female')

update tblGender
set Gender = 'Female'
where Gender = 'female'

drop table [State]

CREATE TABLE [State]
(
Id INT NOT NULL identity(1,1) PRIMARY KEY,
[Name] NVARCHAR(25) NOT NULL,
Capital NVARCHAR(25) NOT NULL,
Region NVARCHAR(25) NOT NULL
)

delete from [State] 

drop table tblState

INSERT INTO [State] values ('Ebonyi', 'Uburu', 'South-East')
INSERT INTO [State] values ('Abia', 'Umuahia', 'South-East')
INSERT INTO [State] values ('Enugu', 'Enugu', 'South-East')
INSERT INTO [State] values ('Imo', 'Owerri', 'South-East')
INSERT INTO [State] values ('Anambra', 'Awka', 'South-East')
INSERT INTO [State] values ('Delta', 'Asaba', 'South-South')
INSERT INTO [State] values ('Lagos', 'Ikeja', 'South-West')
INSERT INTO [State] values ('Osun', 'Osogbo', 'South-West')
INSERT INTO [State] values ('Plateau', 'Jos', 'North-Central')
INSERT INTO [State] values ('Kwara', 'Ilorin', 'North-Central')
INSERT INTO [State] values ('Kaduna', 'Kaduna', 'North-West')
INSERT INTO [State] values ('Borno', 'Maiduguri', 'North-East')
INSERT INTO [State] values ('Bayelsa', 'Yenogoa', 'South-South')
INSERT INTO [State] values ('Rivers', 'Port-Harcourt', 'South-South')
INSERT INTO [State] values ('Sokoto', 'Sokoto', 'North-West')
INSERT INTO [State] values ('Taraba', 'Jalingo', 'North-East')

alter table State
Add constraint unique_name 
unique([Name])

update [State]
set Capital = 'Abakaliki'
where [Name] = 'Ebonyi'

delete from tblState
where Capital = 'Uburu'

alter table DotnetFellows
add constraint DotnetFellows_GenderId_FK
foreign key (GenderId) references Gender (Id)

alter table DotnetFellows
add constraint DotnetFellows_StateId_FK
foreign key (StateId) references State (Id)


--entity relational diagram
--foreign keys
--Wild cards
--Stored procedures

create procedure spDotnetFellows_FetchAll
as
select * from DotnetFellows
go

exec spDotnetFellows_FetchAll
execute sptblDotnetClass_FetchAll
sptblDotnetClass_FetchAll

create procedure spDotnetFellows_FetchAllLike @Key nvarchar(max)
as
select * from DotnetFellows where Firstname like @Key
go

drop procedure sptblDotnetClass_FetchAllLike

spDotnetFellows_FetchAllLike @Key = '%e%'

--Join query
--Inner join
--Left outer Join
--Right outer Join

exec DotnetFellows_descriptive

update tblDotnetClass
set Middlename = 'Alfred'
where Id = '54rk-bda8'

update tblDotnetClass
set StateId = 5
where Id = '54rk-bdf1'

/*
one-to-one => For one instance of a record/entity, there is one instance of a relating entity
one-to-many => For one instance of a record/entity, there are multiple instances of a relating entity
many-to-many
*/