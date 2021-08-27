--------------Consultas repaso SQL----------------1º Consulta que muestre aquellos domicilios de los socios que empiezan por “S”.select domiciliofrom socioswhere domicilio like 'S%'--2º Se desea saber el deporte de Alberto y su domicilio
select deporte, domicilio, nombre
from socios INNER JOIN inscritos
ON socios.numero = inscritos.numerosocio
where nombre like '%Alberto%'

--3º Consulta que muestre toda la información referente a los socios y sus subscripciones.
select *
from socios INNER JOIN inscritos
ON socios.numero = inscritos.numerosocio


--4º Contar todos los socios inscritos en Tenis. 
select count(socios.nombre)
from socios INNER JOIN inscritos
ON socios.numero = inscritos.numerosocio
where deporte like 'tenis';


--5º Emplea una subconsulta con el operador "exists" para devolver la lista de socios que se inscribieron en un determinado deporte. 
select nombre
from socios s --la s es un alias
where exists (select * from inscritos i
where deporte = 'Natacion' AND s.numero = i.numerosocio)

--6º Busca los socios que NO se han inscripto en un deporte determinado empleando "not exists". 
select nombre
from socios s --la s es un alias
where not exists (select * from inscritos i
where deporte = 'Natacion' AND s.numero = i.numerosocio)

--7º Muestra todos los datos de los socios que han pagado todas las cuotas (subconsulta). 
select *
from socios s --la s es un alias
where exists (select * from inscritos i
where cuotas = '10' AND s.numero = i.numerosocio)

--8º- Obten el mismo resultado de la consulta anterior pero esta vez emplea una combinación (join)
select *
from socios INNER JOIN inscritos
ON socios.numero = inscritos.numerosocio
where cuotas='10';

select *
from socios s
where s.numero IN (select i.numerosocio from inscritos i
where cuotas = '10')

--------------Se desean hacer los siguientes procedimientos almacenados----------------- 
--a) Un procedimiento que pueda insertar tanto un socio como un deporte vinculado a un socio 
CREATE PROCEDURE SP_INSERTASOCIO
@NUM INT,
@DOC CHAR(8),
@NOMBRE VARCHAR(30),
@DOMICILIO VARCHAR(30)
AS
INSERT INTO SOCIOS (numero, documento, nombre, domicilio)
VALUES (@NUM, @DOC, @NOMBRE, @DOMICILIO)

EXEC SP_INSERTASOCIO 5, '123', 'KIKE', 'DOMICILIO'

CREATE PROCEDURE SP_INSERTAINSCRITO
@NUMSOCIO INT,
@DEPORTE VARCHAR(20),
@CUOTAS INT
AS
INSERT INTO INSCRITOS (numerosocio, deporte, cuotas)
VALUES (@NUMSOCIO, @DEPORTE, @CUOTAS)
--b) Un procedimiento para modificar un socio o un deporte asignado (osea que se pueda cambiar el deporte de un socio)
CREATE PROCEDURE SP_MODINSCRITO
@NUMSOCIO INT,
@DEPORTE VARCHAR(20),
@CUOTAS INT
AS
UPDATE inscritos
SET deporte=@DEPORTE
WHERE @NUMSOCIO=numerosocio

--c) Un procedimiento que pueda eliminar un Socio cuyo id se introduce por teclado 
CREATE PROCEDURE SP_ELIMINARSOCIO
@IDSOCIO INT
AS
DELETE FROM SOCIOS
WHERE NUMERO = @IDSOCIO;