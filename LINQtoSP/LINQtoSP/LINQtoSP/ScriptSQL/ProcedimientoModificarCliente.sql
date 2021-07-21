
--Procedimiento para modificar

create procedure ModificarCliente
@Nombre varchar (50),
@Apellido1 varchar (50),
@Apellido2 varchar (50),
@Telefno varchar (50)
as
update Clientes
SET
Nombre=@Nombre, Apellido1=@Apellido1, Apellido2=@Apellido2, Telefno=@Telefno
where Nombre=@Nombre

------------------
exec ModificarCliente 'Pepe','GANDALF', 'ElGRIS', 'XXXXXX';

