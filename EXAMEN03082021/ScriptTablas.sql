Use TIENDA; --Garantizamos atacar a la base de datos TIENDA
Go

--Creamos la primera tabla
CREATE TABLE Fabricantes (
Clave_fabricante int Primary KEY,
Nombre varchar(30) NOT NULL,
--Añadimos el Check para limitar los nombres de fabricantes
CONSTRAINT Chk_Nombre CHECK(Nombre ='Kingston' OR Nombre='Adata' OR Nombre='Logitech' OR Nombre='Lexar' OR Nombre='Seagate'));

GO
--Creamos la segunda tabla
CREATE TABLE Articulos (
Clave_articulo int Primary Key,
Nombre varchar (30),
Precio int,
Clave_fabricante int,
--Indicamos la Foreign Key
CONSTRAINT FK_Articulo FOREIGN KEY (Clave_fabricante) REFERENCES Fabricantes(Clave_fabricante),
--Añadimos el CHECK para limitar el precio de los articulos
CONSTRAINT Chk_Precio CHECK (Precio <1000));

--A continuación se insertan los datos para las tablas
Insert into Fabricantes 
VALUES(1,'Kingston'), 
(2,'Adata'), 
(3,'Logitech'), 
(4,'Lexar'), 
(5,'Seagate');


Insert into ARTICULOS VALUES (1,'Teclado GAMING',100,3), 
(2,'Disco duro 3 Tb', 500,5), 
(3,'Mouse GAMING', 80, 3), 
(4,'10 Memorias USB', 140,4), 
(5,'5 Memorias RAM', 290,1), 
(6,'Disco duro extraible 2 Tb',650,5), 
(7,'5 Memoria USB',279,1), 
(8,'DVD Rom',50,2),
(9,'CD Rom',20,2), 
(10,'Barrera Infrarojos de red',180,3);

