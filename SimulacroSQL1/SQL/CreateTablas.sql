--Crea una estructura de tabla con código.Simulacro SQL Martes.

Create table Comercial(
id int Primary Key, --el primary key ya tiene la propiedad de not null
nombre varchar (100),
apellido1 varchar (100),
apellido2 varchar (100),
ciudad varchar(100),
comision decimal (20,2) --por defecto el decimal sería (18,0)
)

Create table Cliente(
id int Primary Key,
nombre varchar (100),
apellido1 varchar (100),
apellido2 varchar (100),
ciudad varchar(100),
categoria int
)


Create table Pedido(
id int Primary Key ,
cantidad decimal ,
fecha date,
id_cliente int ,
id_comercial int 
CONSTRAINT FK_id_comercial FOREIGN KEY  (id_comercial )	REFERENCES Comercial(id),
CONSTRAINT FK_id_cliente FOREIGN KEY  (id_cliente )	REFERENCES Cliente(id)
)