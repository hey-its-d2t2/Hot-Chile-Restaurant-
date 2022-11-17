create database Restaurant;
use Restaurant;
#drop database Restaurant;
SET sql_safe_updates=0;
SET FOREIGN_KEY_CHECKS=0;
SET GLOBAL FOREIGN_KEY_CHECKS=0;
#drop table Items;
#drop database restaurant;
/*
create table Category(
	CategoryName varchar(100) not null unique  primary key
    #FOREIGN KEY (CategoryName) REFERENCES Items(CategoryName)
);*/
#select * from Category;
#delete from Category;
#drop table Category;
drop table Items;
create table Items(
	Id int primary key  auto_increment,
	Name varchar(250) ,
	Category varchar(100),
	Price bigint not null default 0.00
  #  FOREIGN KEY (CategoryName) REFERENCES Category(CategoryName) ON UPDATE CASCADE
);
create table CustomerDetails(
	Id int primary key  auto_increment,
    Name varchar(30),
    Mobile varchar(15),
    Email varchar(30)
);
select * from CustomerDetails;
#Drop table Items;
#alter table yourTableName add UNIQUE(yourColumnName);
#ALTER TABLE table_name DROP CONSTRAINT constraint_name; 
#alter table Items add UNIQUE(Category);
#ALTER TABLE Items DROP CONSTRAINT UNIQUE (Category);
select * from Items;
select Category from Items;
select distinct Category from Items;
create table UserDetails(
	Id int primary key  auto_increment,
	Name varchar(250) not null,
    UserID varchar(25) not null UNIQUE,
    Password varchar(30) not null UNIQUE,
    UserType varchar(30) not null default 'Admin'
);
select * from UserDetails;
