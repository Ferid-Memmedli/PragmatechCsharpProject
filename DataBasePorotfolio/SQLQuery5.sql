create table web.[Messages]
(
	MessageID int Primary Key identity(1,1),
	[Name] nvarchar(20) NOT NULL,
	Email nvarchar(100) NOT NULL check(Email like '%__@__%.__%'),
	[Text] text NOT NULL,
	CreatedDate DateTime default getdate()
)

create table web.SocialMedias
(
	MediaID int Primary Key identity(1,1),
	IconSrc nvarchar(100) NOT NULL,
	Link nvarchar(100) NOT NULL,
	IsDelete bit default 1
)

create table web.MyKnowledges
(
	KnowledgeID int Primary Key identity(1,1),
	Title nvarchar(20) not null,
	[Description] text not null,
	IsDelete bit default 1
)

create table web.MyWorks
(
	WorkID int Primary Key identity(1,1),
	Title nvarchar(20) not null,
	[Description] text not null,
	Link nvarchar(100) NOT NULL,
	ImageSrc nvarchar(100) NOT NULL,
	IsDelete bit default 1,
	CreatedDate DateTime default getdate()
)

create table web.Abouts
(
	AboutID int Primary Key identity(1,1),
	[Description] text not null,
	CVLinkSrc nvarchar(100) NOT NULL
)

create table web.Articles
(
	ArticleID int Primary Key identity(1,1),
	Title nvarchar(20) not null,
	[Description] text not null,
	Link nvarchar(100) NOT NULL,
	ImageSrc nvarchar(100) NOT NULL,
	IsDelete bit default 1,
	CreatedDate DateTime default getdate()
)

create table web.Admins
(
	AdminID int Primary Key identity(1,1),
	Email nvarchar(100) NOT NULL check(Email like '%__@__%.__%'),
	[Name] varchar(20) not null,
	Surname varchar(20) not null,
	[Password] nchar(32) NOT NULL,
	ContactNumber char(10) NOT NULL check(Len(ContactNumber) = 10),
	IsDelete bit default 1,
	CreatedDate DateTime default getdate()
)

create table web.Settings
(
	SettingID int Primary Key identity(1,1),
	LogoSrc nvarchar(100) not null,
	ImageSrc nvarchar(100) not null,
	IconSrc nvarchar(100) NOT NULL,
	WebTitle varchar(20) NOT NULL,
	MyJobTitle varchar(20) NOT NULL
)