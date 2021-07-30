--Consultas
--1. Devuelve un listado con todos los pedidos que se ha realizado. Los pedidos deben estar ordenados por la fecha de realización, mostrando en primer lugar los pedidos más recientes.
Select *
From Pedido
order by fecha desc

--2 Devuelve todos los datos de los dos pedidos de mayor valor (los dos mayores)
select top (2) *
from Pedido
order by cantidad desc

--3 Devuelve unn listado con los identificadores de los clientes que han realizado algún pedido. Tenga en cuenta que no debe mostrar identificadores que estén repetidos.
Select distinct id_cliente
from pedido

--4 Devuelve un listado de todos los pedidos que se realizaron durante el año 2017, cuya cantidad total sea superior a 500euros.

select  id, fecha
from Pedido
where (fecha>='20170101' and fecha<='20171230') and (cantidad>500) --También se puede hacer: where year(Fecha)=2017
--el método Year sería el más eficaz.


--5. Devuelve un listado con el nombre y los apellidos de los comerciales que tienen una comisión entre 0.05 y 0.11.

select nombre, apellido1, apellido2
from Comercial
where comision between '0.05' and '0.11'

-- 6 Devuelve el valor de la comisión de mayor valor que existe en la tabla comercial.
select top 1 comision
from comercial

--7 Devuelve el identificador, nombre y primer apellido de aquellos clientes cuyo segundo apellido NO es null. El listado deberá estar ordenado alfabéticamente por apellidos y nombre.
select id, nombre, apellido1
from Cliente
where apellido2 is not NULL
order by apellido1,apellido2, nombre;


--8 Devuelve un listado de los nombres de los clientes que empiezan por A y terminan por n y también los nombres que empiezan por P. El listado desberá estar ordenado alfabéticamente.
select nombre
from cliente
where ((nombre like 'A%' and nombre like '%n') or (nombre like 'P%'))
Order by nombre asc

--9 Devuelve un listado de los nombres de los clientes que NO empiezan por A. El listado deberá estar ordenado alfabéticamente.
select nombre
from cliente
where nombre not like 'A%'
order by nombre asc

--10 Devuelve un listado de los nombres de los comerciales que terminen por o. Tenga en cuenta que se deberán eliminar los nombres repetidos.
select distinct nombre
from comercial
where nombre like '%o'

-----------------------

--Consultas multitabla
--1 Devuelve un listado con el identificador, nombre y los apellidos de todos los clientes que han realizado a´lgún pedido. El listado debe estar ordenado alfabéticamente y se deben eliminar los elementos repetidos.

select distinct (cliente.id), cliente.nombre, cliente.apellido1, cliente.apellido2--??Por qué repite id??
from cliente inner join pedido
on cliente.id=pedido.id_cliente
order by cliente.apellido1, cliente.apellido2, cliente.nombre asc;

--2 Devuelve un lisado que muestre todos los pedidos que ha realizado cada cliente. El resultado debe mostrar todos los datos de los pedidos y del cliente. El listado debe mostrar los datos de los clientes ordenados alfabéticamente.

select distinct *
from cliente inner join pedido
on cliente.id=pedido.id_cliente
order by cliente.apellido1, cliente.apellido2, cliente.nombre asc

--3 Devuelve un listado que muestre todos los pedidos en los que ha participado un comercial. El resultado debe mostrar todos los datos de los pedidos y de los comerciales. El listado debe mostrar los datos de los pedidos y de los comerciales. El listado debe mostrar los datos de los comerciales ordenados alfabéticamente.

select *
from pedido inner join comercial
on comercial.id=pedido.id_comercial
order by apellido1, apellido2, nombre asc

--4 Devuelve un listado que muestre todos los clientes, con todos los pedidos que han realizado y con los datos de los comerciales asociados a cada pedido.
select *
from pedido 
inner join comercial 
on comercial.id=pedido.id_comercial
inner join cliente
on cliente.id=pedido.id_cliente


use SimulacroSQLMartes;
go -- estas dos indicaciones use y go se pone al inicio de las consultas para indicar la base de datos a la que estamos atacando
--5  Devuelve un listado de todos los clientes que realizaron un pedido durante el año 2017, cuya cantidad esté entre 300 y 1000 euros
select cliente.*, pedido.Fecha, pedido.cantidad
from  pedido inner join cliente
on cliente.id=pedido.id_cliente
where (pedido.fecha>'20170101' and pedido.fecha<'20180101') and (pedido.cantidad between '300' and '1000') --Year(Fecha)=2017


--6  Devuelve el nombre y los apellidos de todos los comerciales que ha participado en algún pedido realizado por María Santana Moreno.
Select distinct comercial.nombre, comercial.apellido1, comercial.apellido2
from pedido 
inner join comercial 
on comercial.id=pedido.id_comercial
inner join cliente
on cliente.id=pedido.id_cliente
where cliente.nombre='María' and cliente.apellido1='Santana' and cliente.apellido2='Moreno';

--7  Devuelve el nombre de todos los clientes que han realizado algún pedido con el comercial Daniel Saez Vega.
select distinct cliente.nombre, cliente.apellido1, cliente.apellido2
from pedido 
inner join comercial 
on comercial.id=pedido.id_comercial
inner join cliente
on cliente.id=pedido.id_cliente
where comercial.nombre='Daniel' and comercial.apellido1='Sáez' and comercial.apellido2='Vega'

--Consultas resumen

--1 Calcula la cantidad total que suman todos los pedidos que apareccen en la tabla pedido.
select sum(cantidad) as [Total de pedidos]
from pedido
--2 Calcula la cantidad media de todos los pedidos que aparecen en la tabla pedido.
select 'UN TOTAL DE:', cast(avg(cantidad) as decimal(18,2)) as [Promedio de pedidos]
from pedido

--3 Calcula el número total de comerciales distintos que aparecen en la tabla pedido.
select count( distinct id_comercial ) AS [TOTAL COMERCIALES]
from pedido


--4 Calcula el número total de clientes que aparecen en la tabla cliente.
select count(distinct (ID) )as [Número total de clientes]
from cliente


--5 Calcula cuál es la mayor cantidad que aparece en la tabla pedido.
select max(cantidad) as [Mayor cantidad]
from pedido

--6 Calcula cuál es la menor cantidad que aparece en la tabla pedido.
select min(cantidad) as [Menor cantidad]
from pedido

--7  Calcula cuál es el valor máximo de categoria para cada una de las ciudades que aparece en la tabla clente.
select max(categoria), ciudad
from cliente
group by ciudad

--8 Calcula cuál es el máximo valor de los pedidos realizados durante el mismo día para cada uno de los clientes. Es decir, el mismo cliente puede haber realizado varios pedidos de diferente cantidades el mismo día. Se pide que se calcule cuál es el pedido de máximo valor para cada uno de los días en los que un cliente ha realizado un pedido.
--Muestra el identificador del cliente, nombre, apellidos, la fecha y el valor de ls cantidad.

SELECT MAX(CANTIDAD) AS MAYOR, CLIENTE.ID, NOMBRE, APELLIDO1, APELLIDO2, FECHA
FROM CLIENTE INNER JOIN PEDIDO
ON cliente.id=pedido.id_cliente
GROUP BY FECHA, CLIENTE.ID, NOMBRE, APELLIDO1, APELLIDO2, FECHA
ORDER BY FECHA


--9 Calcula cuál es el máximo valor de los pedidos realizados durante el mismo día para cada uno de los clientes, teniendo en cuenta que sólo queremos mostrar aquellos pedidos que superen la cantidad de 2000.
SELECT MAX(CANTIDAD) AS MAYOR, CLIENTE.ID, NOMBRE, APELLIDO1, APELLIDO2, FECHA
FROM CLIENTE INNER JOIN PEDIDO
ON cliente.id=pedido.id_cliente
GROUP BY FECHA, CLIENTE.ID, NOMBRE, APELLIDO1, APELLIDO2
HAVING MAX(CANTIDAD)>2000;


--10 Calcula el máximo valor de los pedidos reallizados para cada uno de los comerciales durante la fecha 20160817. Muestra el identificador del comercial, nombre, apellidos y total.
SELECT MAX(CANTIDAD) AS MÁXIMO, COMERCIAL.ID, nombre, apellido1, apellido2
FROM COMERCIAL INNER JOIN PEDIDO
ON COMERCIAL.id=pedido.id_comercial
WHERE FECHA='20160817'
GROUP BY COMERCIAL.ID, nombre, apellido1, apellido2

--11 Devuelve un listado con el identificador de cliente, nombre, apellidos y el número total de pedidos que ha realizado cada uno de los clientes. Tenga en cuenta que pueden existir clientes que no han realizado ningún pedido. Estos clientes también deben aparecer en el listado indicado que el número de pedidos realizados en 0.
SELECT CLIENTE.ID, NOMBRE, APELLIDO1, APELLIDO2, COUNT (iD_CLIENTE) AS [NÚMERO PEDIDO]
FROM CLIENTE LEFT JOIN PEDIDO 
ON CLIENTE.id=pedido.id_CLIENTE
GROUP BY CLIENTE.ID, NOMBRE, APELLIDO1, APELLIDO2

--12 Devuelve un listado con el identificador de cliente, nombre y apellidos y el número total de pedidos que ha realizado cda uno de clientes durante el año 2017

SELECT NOMBRE, APELLIDO1, APELLIDO2, COUNT (CLIENTE.ID) AS [NÚMERO PEDIDO]
FROM CLIENTE LEFT JOIN PEDIDO 
ON CLIENTE.id=pedido.id_CLIENTE
WHERE YEAR(FECHA)=2017
GROUP BY NOMBRE, APELLIDO1, APELLIDO2 


--13 Devuelve un listado que muestre el identificador de cliente, nombre, apellido1 y el valor de la máxima cantidad del pedido realizado por cada uno de los clientes. El resultadp debe mostrar aquellos clientes que no han realizado ningún pedido indicando que la máxima cantidad de sus pedidos realizados es 0. Puede hacer uso de la función IFNULL (CONVERTÍA A CERO). cOMO EN ESTA VERSIÓN DE 2008 NO FUNCIONA (FUNCIONA EN 2014 EN ADELANTE) UTILIZAMOS ESTE OTRO MÉTODO DE "IS NULL".
SELECT CLIENTE.ID, NOMBRE, APELLIDO1, APELLIDO2, MAX (CANTIDAD) AS MAXIMO
FROM CLIENTE LEFT JOIN PEDIDO 
ON CLIENTE.id=pedido.id_CLIENTE
GROUP BY NOMBRE, APELLIDO1, APELLIDO2, CLIENTE.ID, CANTIDAD
HAVING CANTIDAD IS NULL;


--14 Devuelve cuál ha sido el pedido de máximo valor que se ha realizado cada año.
select max (cantidad) as [Pedido Máximo], year(fecha) as ANIo
from Pedido
group by YEAR(fecha);



--15 Devuelve el número total de pedidos que se han realizado cada año.

select count (id) as [Numero total de pedidos], year(fecha) as ANIo
from Pedido
group by year(fecha);



--Subconsultas

-- 1 Devuelve un listado con todos los pedidos que ha realizado Adela Salas Díaz (Sin utilizar INNER JOIN)

SELECT *
FROM PEDIDO
WHERE PEDIDO.ID_CLIENTE= (SELECT ID
FROM CLIENTE
WHERE NOMBRE='ADELA' AND APELLIDO1='SALAS'
)

--2 Devuelve el número de pedidos en los que ha participado el comercial Daniel Sáez Vega (SIN UTILIZAR INNER JOIN)
SELECT COUNT(*)
FROM PEDIDO
WHERE PEDIDO.ID_COMERCIAL= (SELECT ID
FROM COMERCIAL
WHERE NOMBRE='Daniel' AND APELLIDO1='Sáez'
)


--3 Devuelve los datos del cliente que realizó el pedido más caro en el año 2019. (SIN UTILIZAR INNER JOIN)
SELECT *
FROM CLIENTE
WHERE ID = (SELECT TOP 1 ID_CLIENTE
FROM PEDIDO
WHERE YEAR(fECHA)=2019
ORDER BY CANTIDAD DESC
)

--4 Devuelve la fecha y la cantidad del pedido de menor valor realizado poer el cliente Pepe Ruiz Santana.
SELECT TOP 1 FECHA, CANTIDAD
FROM PEDIDO INNER JOIN CLIENTE
ON PEDIDO.ID_CLIENTE=CLIENTE.ID
WHERE CLIENTE.NOMBRE='pEPE' AND APELLIDO1='rUIZ'
ORDER BY CANTIDAD ASC

--5 Devuelve un listado con los datos de los clientes y los pedidos de todos lo clientes que han realizado un pedido durante el año 2017 con un valor mayor o igual al valor medio de los pedidos realizados durante ese mismo año.

SELECT *
FROM CLIENTE INNER JOIN PEDIDO
ON PEDIDO.ID_CLIENTE=CLIENTE.ID
WHERE YEAR(FECHA)=2017 AND CANTIDAD>=(
SELECT AVG(CANTIDAD)
FROM PEDIDO
WHERE YEAR(FECHA)=2017
)

--INFO PARA EXAMEN:
--------------------------------------------------------------------------------------------------------------------
						--EXPORTAR TODA LA BASE DE DATOS EN SCRIPT:
						--1. BOTÓN DERECHO SOBRE DDBB
						--2 TASK/GENERATE SCRIPTS
						--3 ASISTENTE/SCRIPTINGoPTION/ADVANCED
						--4 TYPES OF DATA TO SCRIPT:SCHEMA AND DATA/OK


						-- REPASO STORED PROCEDURES
						-- 4 PROCEDIMIENTOS: ALTAS, BAJAS, MODIFICACIONES Y CONSULTAS(UN SCRIPT CON TODOS LOS PROCEDIMIENTOS ALMACENADOS PARA EL EXAMEN)
						-- 1,5 PTOS CREATE TABLE
						-- 1,5 PTOS CONSULTAS SENCILLA
						-- 2 PTOS CONSULTAS MULTITABLA (CON INNER JOIN)/SUBCONSULTA
						-- 2 PTOS STORED PROCEDURE

--ALTAS
CREATE PROCEDURE SP_ALTACLIENTE
@id int,
@nombre varchar(100),
@apellido1 varchar(100),
@apellido2 varchar(100),
@ciudad varchar(100),
@categoria int
AS
INSERT INTO CLIENTE(id,nombre,apellido1,apellido2,ciudad,categoria)
VALUES(@id,@nombre,@apellido1,@apellido2,@ciudad,@categoria);

GO
--ESTA LÍNEA PARA PROBAR EL PROCEDIMIENTO
EXECUTE SP_ALTACLIENTE 99, 'KIKE', 'PÉREZ', 'DIAZ', 'GIJÓN', 300


---------------------------------------------------------------

--PROCEDIMIENTO ALMACENADO BAJAS
CREATE PROCEDURE SP_BAJACLIENTE
--ELIMINAR POR ID
@ID INT 
AS 
DELETE
FROM CLIENTE
WHERE ID=@ID

--ESTA LÍNEA PARA PROBAR EL PROCEDIMIENTO
EXECUTE SP_BAJACLIENTE 10;

---------------------------------------------------------------

--PROCEDIMIENTO ALMACENADO MODIFICACIÓN

CREATE PROCEDURE SP_MODIFICACLIENTE
@id int,
@nombre varchar(100),
@apellido1 varchar(100),
@apellido2 varchar(100),
@ciudad varchar(100),
@categoria int
AS
UPDATE CLIENTE
SET
id = @id,
nombre = @nombre,
apellido1 = @apellido1,
apellido2 = @apellido2,
ciudad = @ciudad,
categoria = @categoria
WHERE ID=@id

--ESTA LÍNEA PARA PROBAR EL PROCEDIMIENTO
--si tenemos en la tabla un pedido con su cliente, seleccionamos el enlace de union de las dos tablas y en propiedades clicamos en  insert and UPDATE specification seleccionamos en delete rule y update rule CASCADE
EXECUTE SP_MODIFICACLIENTE 1, 'we', 'ee', 'yy', 'hh', 200

---------------------------------------------------------------

--PROCEDIMIENTO ALMACENADO BÚSQUEDA/CONSULTA

CREATE PROCEDURE SP_CONSULTACLIENTE
--CONSULTAMOS POR ID
@ID INT
AS 
SELECT *
FROM CLIENTE
WHERE ID=@ID;
--SI LA BÚSQUEDA SE HACE POR NOMBRE: 
--@NOMBRE VARCHAR(100)
--AS 
--SELECT *
--FROM CLIENTE
--WHERE NOMBRE LIKE '%@NOMBRE%';

--ESTA LÍNEA PARA PROBAR EL PROCEDIMIENTO
EXECUTE SP_CONSULTACLIENTE 1;