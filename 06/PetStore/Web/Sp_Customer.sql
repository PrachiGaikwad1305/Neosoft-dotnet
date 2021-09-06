create table customer
(
Id int identity(1,1) primary key,
Name varchar(50),
Zipcode varchar(10),
Email varchar(50)
)

create table login
(
loginId int identity(1,1) primary key,
Id int Foreign key references customer(Id),
username varchar(20),
password varchar(20)
)

create procedure AddDetails
@Id int out,@Name varchar(50),@Zipcode varchar(10),@Email varchar(50),@loginId int out,@UserName varchar(20),@Password varchar(20)
as 
begin
	Insert into customer(Name,Zipcode,Email) values(@Name,@Zipcode,@Email);
	select @Id = SCOPE_IDENTITY();
	Insert into login(Id,username,password) values(@Id,@UserName,@Password);
	select @loginId = SCOPE_IDENTITY();
end

drop procedure AddDetails

select * from customer;
select * from login;