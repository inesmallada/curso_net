create table socios( 
numero int, 
documento char(8), 
nombre varchar(30), 
domicilio varchar(30), 
primary key (numero) 
); 



create table inscritos ( 
numerosocio int not null, 
deporte varchar(20) not null, 
cuotas int default 0, constraint CK_inscritos_cuotas check (cuotas>=0 and cuotas<=10), 
primary key(numerosocio,deporte), 
constraint FK_inscritos_socio 
foreign key (numerosocio) references socios(numero) on delete cascade );



insert into socios values(1,'23333333','Alberto Paredes','Colon 111');
insert into socios values(2,'24444444','Carlos Conte','Sarmiento 755');
insert into socios values(3,'25555555','Fabian Fuentes','Caseros 987');
insert into socios values(4,'26666666','Hector Lopez','Sucre 344');
insert into inscritos values(1,'tenis',1);
insert into inscritos values(1,'basquet',2);
insert into inscritos values(1,'natacion',1);
insert into inscritos values(2,'tenis',9);
insert into inscritos values(2,'natacion',1);
insert into inscritos values(2,'basquet',default);
insert into inscritos values(2,'futbol',2);
insert into inscritos values(3,'tenis',8);
insert into inscritos values(3,'basquet',9);
insert into inscritos values(3,'natacion',0);
insert into inscritos values(4,'basquet',10);