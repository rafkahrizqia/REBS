create database REBS;

use REBS;

create table Users(
Id uniqueidentifier not null primary key,
AgencyId uniqueidentifier,
FirstName nvarchar(25),
LastName nvarchar(25),
[Name] nvarchar(50),
FullName nvarchar(50),
Email nvarchar(50),
Abbr nchar(10),
Phone nvarchar(15),
Color nvarchar(10),
LocaleCode nvarchar(10),
[Status] nvarchar(10),
[Text] nvarchar(100),
IsOnline bit,
UserStatus nvarchar(20),
ChatStatus bit, 
VoipStatus nvarchar(50),
VoipDevice nvarchar(20),
ProfileImage image,
[Authorization] nvarchar(50),
IsPrimary bit,
Timezone nvarchar(50),
CreatedAt datetime2(7),
TwoFactorAuthentificationEnabled bit
);

create table Notes(
Id uniqueidentifier not null primary key,
Contact nvarchar(50),
UserId uniqueidentifier,
Note nvarchar(200),
CreatedAt datetime2(7)
);

create table Company(
Id uniqueidentifier not null primary key,
[Name] nvarchar(50),
Abbr nchar(10),
CreatedAt datetime2(7),
Color nvarchar(10),
UserId uniqueidentifier,
NotesId uniqueidentifier,
CustomeFieldsId uniqueidentifier, 
ContactsId uniqueidentifier,
CustomFieldsValuesId uniqueidentifier
);
