create database SooperStore_dezv
go
use SooperStore_dezv
go

create table [User](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nume nvarchar(200) not null,
	Prenume nvarchar(200) not null,
	Email nvarchar(250) not null,
	Telefon nvarchar(30),
	RolId int)

create table [Rol](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nume nvarchar(200) not null)

create table [RolXPermisie](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	RolId int not null,
	PermisieId int not null)

create table [Permisie](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nume nvarchar(200) not null,
	Descriere nvarchar(500))

create table [Cos](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	UserId int not null,
	ProdusId int not null)

create table [Comanda](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Adresa nvarchar(500) not null,
	CosId int not null)

create table [Produs](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nume nvarchar(200) not null,
	Descriere nvarchar(500) not null,
	Stoc int default(0),
	Pret float default(0),
	FurnizorId int not null,
	CategorieId int not null)

create table [Furnizor](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nume nvarchar(200) not null,
	Oras nvarchar(50) not null,
	Contact nvarchar(30) not null)

create table [Categorie](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nume nvarchar(200) not null)

create table [Recenzie](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	NumeUtilizator nvarchar(400) not null,
	Nota float not null,
	Descriere nvarchar(500),
	ProdusId int not null)

create table [Eroare](
	Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nume nvarchar(200) not null,
	Detalii nvarchar(max) not null,
	[Data] datetime not null)


alter table RolXPermisie add constraint fk_rolxpermisie_rol foreign key (RolId) references Rol(Id)
alter table RolXPermisie add constraint fk_rolxpermisie_permisie foreign key (PermisieId) references Permisie(Id)
alter table [User] add constraint fk_user_rol foreign key (RolId) references Rol(Id)
alter table [Cos] add constraint fk_cos_user foreign key (UserId) references [User](Id)
alter table [Cos] add constraint fk_cos_produs foreign key (ProdusId) references Produs(Id)
alter table Comanda add constraint fk_comanda_cos foreign key (CosId) references [Cos](Id)
alter table Produs add constraint fk_produs_furnizor foreign key (FurnizorId) references Furnizor(Id)
alter table Produs add constraint fk_produs_categorie foreign key (CategorieId) references Categorie(Id)
alter table Recenzie add constraint fk_recenzie_produs foreign key (ProdusId) references Produs(Id)
