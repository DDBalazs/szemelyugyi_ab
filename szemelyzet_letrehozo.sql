create table szemelytorzs(
szemid char(4) not null primary key,
nev varchar(45) not null,
szulhely varchar(20) not null,
szulido date not null,
fizetes int not null,
belepdatum date not null,
kilepdatum date,
beosztas char(1) not null
);

create table telephelytorzs(
tid char(4) not null primary key,
nev varchar(45) not null
);

create table szemely_telep(
id int auto_increment not null primary key,
szemid char(4) not null,
tid char(4) not null,
aktiv char(1) not null default "i",
foreign key (szemid) references szemelytorzs(szemid),
foreign key (tid) references telephelytorzs(tid)
);

-- szemelytorzs adatai
insert into szemelytorzs(szemid,nev,szulhely,szulido,fizetes, belepdatum,kilepdatum,beosztas)
values
('1234', 'Gipsz Jakab', 'Budapest', '1962-08-13', '220000', '2017-08-11',NULL, 'f'),
('1235', 'Mező Mária', 'Debrecen', '1976-12-12', '450000', '2018-08-21',NULL, 'v'),
('2345', 'Cserép Virág', 'Szeged', '1988-10-12', '320000', '2019-01-06',NULL, 's'),
('4687', 'Kis Géza', 'Debrecen', '1959-02-09', '188000', '2017-10-18', '2018-12-20', 'f'),
('4785', 'Kiss Miklós', 'Budapest', '1987-04-07', '510000', '2019-10-11',NULL, 'v'),
('7845', 'Magyar István', 'Eger', '1960-06-01', '380000', '2018-11-14',NULL, 's'),
('8541', 'Vezér Tas', 'Szeged', '1959-04-06', '250000', '2017-08-12',NULL, 'f'),
('7462', 'Nagy Emőd', 'Eger', '1990-06-12', '270000', '2019-12-01',NULL, 'f'),
('9682', 'Pintér Eszter', 'Budapest', '1982-02-17', '360000', '2018-08-14', '2019-01-19', 's'),
('9681', 'Nagy Máté', 'Szeged', '1971-10-06', '325000', '2018-12-03',NULL, 's'),
('4581', 'Bezzeg Jakab', 'Debrecen', '1970-06-08', '421000', '2019-10-12', '2019-12-03', 'v'),
('3581', 'Nagy Béla', 'Szeged', '1980-02-15', '210000', '2017-12-01',NULL, 'f'),
('4216', 'Kis Tünde', 'Eger', '1960-10-08', '220000', '2017-12-03', '2020-02-06', 'f');

-- telephelytorzs adatai
insert into telephelytorzs(tid,nev)
values
('1000', 'Budapest'),
('3200', 'Eger'),
('5000', 'Debrecen');

-- szemely_telep adatai
insert into szemely_telep(szemid,tid,aktiv)
values
('1234','1000','n'),
('1235','5000','i'),
('2345','1000','i'),
('4687','5000','n'),
('3581','3200','i'),
('4785','1000','i'),
('7845','3200','n'),
('7845','1000','i'),
('8541','5000','i'),
('7462','3200','i'),
('1234','3200','i'),
('9682','1000','n'),
('4216','3200','i'),
('9681','5000','i'),
('4581','5000','n');