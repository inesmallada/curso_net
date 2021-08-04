--SCRIPT CONSULTAS

--CONSULTAS SENCILLAS
--1.	Obtener todos los datos del articulo cuyo nombre del producto es "Teclado”.
SELECT *
FROM Articulos
WHERE Nombre='Teclado'; --Ahora ya no funciona porque fui modificado en un procedimiento almacenado


--2.	Obtener todos los datos de las Memorias RAM y memorias USB .
SELECT *
FROM Articulos
WHERE (Nombre LIKE '%RAM') OR (Nombre LIKE '%USB');


--3.	Obtener todos los datos de los artículos que empiezan con 'M'. 
SELECT *
FROM Articulos
WHERE Nombre LIKE 'M%';

--4.	Obtener el nombre de los productos donde el precio sea € 100.
SELECT Nombre
FROM Articulos
WHERE Precio=100;

--5.	Obtener el nombre de los productos donde el precio sea mayor a € 200. 
SELECT Nombre
FROM Articulos
WHERE Precio>200;

--6.	Obtener todos los datos de los artículos cuyo precio este entre € 100 Y € 350. 
SELECT *
FROM Articulos
WHERE Precio BETWEEN 100 AND 350
ORDER BY Precio;

--7.	Obtener el precio medio de todos los productos.
SELECT AVG(Precio)
FROM Articulos;

--8.	Obtener el precio medio de los artículos cuyo código de fabricante sea 2.
SELECT AVG(Precio)
FROM Articulos
WHERE Clave_fabricante=2;

--9.	Obtener el nombre y precio de los artículos ordenados por Nombre 
SELECT Precio, Nombre
FROM Articulos
ORDER BY Nombre;

--10.	Obtener todos los datos de los productos ordenados descendentemente por Precio.
SELECT *
FROM Articulos
ORDER BY Precio DESC;


--CONSULTA MULTITABLA Y SUBCONSULTAS (2 puntos)
--11.	Obtener el nombre y precio de los artículos donde el fabricante sea Logitech ordenarlos alfabéticamente por nombre del producto.
SELECT Articulos.Nombre, Articulos.Precio
FROM Fabricantes, Articulos
WHERE Fabricantes.Nombre = 'Longitech' AND
Articulos.Clave_fabricante=Fabricantes.Clave_fabricante
Order BY Articulos.Nombre;

--12.	Obtener el nombre, precio y nombre de fabricante de los productos que NO son marca Lexar o Kingston ordenados descendentemente por precio.
SELECT Articulos.Nombre, Precio, Fabricantes.Nombre
FROM Fabricantes
INNER JOIN Articulos
ON Articulos.Clave_fabricante = Fabricantes.Clave_fabricante
WHERE Fabricantes.Nombre!='Lexar' AND Fabricantes.Nombre!= 'Kingston'
ORDER BY Precio DESC;

--13.	Obtener el nombre de fabricante y precio de los artículos cuyo precio sea mayor a € 250 Y ordenarlos descendentemente por precio y luego ascendentemente por nombre de Fabricante.

--Descendentemente por precio.
SELECT Fabricantes.Nombre, Precio
FROM Fabricantes
INNER JOIN Articulos
ON Articulos.Clave_fabricante = Fabricantes.Clave_fabricante
WHERE Precio > 250
ORDER BY Precio DESC;

--Ascendentemente por nombre de Fabricante.
SELECT Fabricantes.Nombre, Precio
FROM Fabricantes
INNER JOIN Articulos
ON Articulos.Clave_fabricante = Fabricantes.Clave_fabricante
WHERE Precio > 250
ORDER BY Fabricantes.Nombre ASC;


--14.Listar los nombres de fabricantes de todos los artículos de tipo “Rom” (Ojo utilizando subconsulta, no utilizar INNER JOIN). 
SELECT Fabricantes.Nombre
FROM Fabricantes
WHERE Fabricantes.Clave_fabricante =(SELECT Articulos.Nombre FROM Articulos WHERE Articulos.Nombre LIKE'%ROM');


--15.	Obtener la clave de producto, nombre del producto y nombre del fabricante de todos los productos en venta cuyo precio es inferior a la media de todos los precios (subconsulta).
SELECT Clave_articulo, Articulos.Nombre, Fabricantes.Nombre
FROM Fabricantes
INNER JOIN Articulos
ON Articulos.Clave_fabricante = Fabricantes.Clave_fabricante
WHERE Precio <(SELECT AVG(Precio) FROM Articulos)


--PROCEDIMIENTOS ALMACENADOS (2 puntos)
--1.Añade un nuevo producto mediante procedimiento almacenado (y haz la comprobación): 
				--Clave del producto 11 Altavoces  € 20 del fabricante 2
--ALTAS
CREATE PROCEDURE SP_ALTAPRODUCTO
@Clave_articulo int,
@Nombre varchar(30),
@Precio int,
@Clave_fabricante int
AS
INSERT INTO Articulos(Clave_articulo,Nombre,Precio,Clave_fabricante)
VALUES(@Clave_articulo,@Nombre,@Precio,@Clave_fabricante);

GO
--ESTA LÍNEA PARA PROBAR EL PROCEDIMIENTO
EXECUTE SP_ALTAPRODUCTO 11, 'Altavoces', 20, 2

--2.Cambia el nombre de un producto que pasamos por parámetro a 'Impresora 3D'. 

--MODIFICACIÓN
CREATE PROCEDURE SP_MODIFICAPRODUCTO
@Clave_articulo int,
@Nombre varchar(30),
@Precio int,
@Clave_fabricante int
AS
UPDATE Articulos
SET
Clave_articulo = @Clave_articulo,
Nombre = @Nombre,
Precio = @Precio,
Clave_fabricante = @Clave_fabricante
WHERE Clave_articulo = @Clave_articulo

--ESTA LÍNEA PARA PROBAR EL PROCEDIMIENTO
--Previamente seleccionamos en delete rule y update rule la opción: CASCADE
EXECUTE SP_MODIFICAPRODUCTO 1,'Impresora 3D',100,3


--3.Aplicar un descuento del 10% a todos los productos. 

UPDATE Articulos SET Precio = Precio*0.10

--4.Aplicar un descuento que pasamos como parámetro a todos los productos cuyo precio sea mayor o igual a € 300. 

UPDATE Articulos SET Precio = Precio - 5 --El descuento será de 5 euros
WHERE Precio>=300

--5.Borra el producto con un número suministrado.

DELETE FROM Articulos Where Clave_articulos=6