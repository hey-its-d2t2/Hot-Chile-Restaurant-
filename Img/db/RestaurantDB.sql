create database Resturant;
use Resturant;
create table Item
(
	iid int,
    Name varchar(250) not null,
    Category varchar(250) not null,
    Price bigint not null
);
describe Item;
'Name,Category,Price
Select *from Items'