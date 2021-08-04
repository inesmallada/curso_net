Use SIMULACRO_LUNES;
Go


CREATE TABLE Departamento
(Dept_no int Primary KEY,
Nombre varchar(50) NOT NULL,
Localizacion varchar(10) NOT NULL);

Go

CREATE TABLE Empleado (
	codigo_c varchar(20) PRIMARY KEY NOT NULL,
	Nombre varchar(50) NOT NULL,
	edad int NOT NULL,
	Oficio varchar(20) NOT NULL,
	Dir varchar(20),
	Fecha_Alt DATE NOT NULL,
	Salario int NOT NULL,
	Comision int,
	Dept_no int NOT NULL,
	CONSTRAINT FK_Departamento FOREIGN KEY (Dept_no) REFERENCES Departamento(Dept_no),
	CONSTRAINT Chk_edad CHECK(edad <120),
	CONSTRAINT Chk_oficios CHECK(Oficio='Vendedor' OR Oficio='Analista' OR Oficio='Director' OR Oficio='Presidente' OR Oficio='Empleado'));


INSERT INTO Departamento 
values(10,'Desarrollo Software','LLanera'),
(20,'Analisis Sistemas','Laviana'),
(30,'Contabilidad','Avilés'),
(40,'Ventas','Manjoya');

INSERT INTO Empleado
values('281-160483-0005F','Rocha Vargas Hector',27,'Vendedor','Gijón','19830512',1200,0,40),
('281-040483-0056P','Lopez Hernandez Julio',27,'Analista','Avilés','19820714',1300,150,20),
('081130678-0004S','Esquivel José',31,'Director','Oviedo','19810605',1670,120,30),
('281-160473-0009Q','Delgado Carmen',37,'Vendedor','Gijón','19830203',1340,0,40),
('281-160493-0005F','Castillo Montes Luis',17,'vendedor','Salas','19820812',1630,100,40),
('281-160483-004Y','Esquivel Leonel Alfonso',26,'Presidente','Avilés','19810912',1500,0,30),
('281-161277-0008R','Perez Luis',32,'Empleado','Carreño','19800302',1689,0,10);



--1)
SELECT Nombre
FROM empleado
ORDER BY Nombre DESC;

--2)
SELECT Nombre, Oficio, Dir
FROM empleado
ORDER BY Nombre DESC;

--3)
SELECT Nombre
FROM empleado
WHERE Nombre Like '%o';

--4)
SELECT Nombre, Oficio
FROM empleado
WHERE dir='Salas';

--5)
SELECT Nombre,Dir, Salario
FROM empleado
WHERE salario BETWEEN 1000 AND 1300;

--6)
SELECT Nombre
FROM empleado
WHERE dir='Gijon' AND (Oficio='Analista' OR Oficio='Vendedor');

--7)
SELECT Max(Salario)
FROM empleado
WHERE Dept_no=10;

--8)
SELECT AVG(Salario)
FROM empleado

--9)
SELECT *
FROM empleado 
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
WHERE Departamento.Nombre='Contabilidad'
ORDER BY Empleado.Nombre;

--10)
SELECT Dept_no, COUNT(*)
FROM empleado
GROUP BY DEPT_NO
HAVING COUNT (*)>1;

--11)
SELECT Empleado.Nombre, Salario, Departamento.NOmbre
FROM empleado
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
WHERE Oficio =( SELECT Oficio FROM Empleado
				WHERE Nombre = 'Esquivel Leonel Alfonso');

--12)
SELECT Empleado.Nombre, Salario, Departamento.Nombre
FROM empleado
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
WHERE Oficio =( SELECT Oficio FROM Empleado
				WHERE Nombre = 'Castillo Montes Luis') AND Comision=0;

--13)
SELECT Min(Salario), Departamento.Nombre
FROM empleado
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
GROUP BY Departamento.Nombre
HAVING Departamento.Nombre='Ventas';

--14)
SELECT AVG(Salario), Departamento.Nombre
FROM empleado
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
GROUP BY Departamento.Nombre
HAVING Departamento.Nombre='Contabilidad';

--15)
SELECT COUNT(*), Empleado.Dept_no
FROM empleado
WHERE Empleado.Dept_no=10;

--16)
SELECT COUNT(*), Departamento.Nombre
FROM empleado
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
GROUP BY Departamento.Nombre
HAVING Departamento.Nombre='Ventas';

--17)
SELECT COUNT(*)
FROM empleado
WHERE Comision=0;

--18)
SELECT COUNT(*), Empleado.Nombre
FROM empleado
GROUP BY  Empleado.Nombre
HAVING Empleado.Nombre LIKE 'E%';

--19)
SELECT COUNT(*), Departamento.Nombre
FROM empleado
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
GROUP BY Departamento.Nombre;

--20)
SELECT SUM(Salario), Oficio
FROM empleado
GROUP BY Oficio
;

--21)
SELECT *
FROM empleado
WHERE Salario>(Select AVG(Salario)
			FROM Empleado);


--22)
SELECT TOP 1 Min(Salario), Nombre
FROM empleado
GROUP BY Nombre;


--23)
SELECT TOP 1 MAX(Salario), Nombre
FROM empleado
GROUP BY Nombre;

--24)
SELECT COUNT (DISTINCT Oficio)
FROM empleado


--26)
SELECT COUNT (*), Oficio
FROM empleado
INNER JOIN Departamento
ON empleado.Dept_no=Departamento.Dept_no
Group BY Oficio
HAVING COUNT(*)>1;