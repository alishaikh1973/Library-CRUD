Create database Library
use Library

create table BookCRUD
(
Id int primary key,
Name varchar(40) not null,
Author varchar(50) not null,
Price decimal(10,2)
)