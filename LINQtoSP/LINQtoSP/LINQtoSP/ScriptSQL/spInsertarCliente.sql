--Procedimiento almacenado

create procedure insertarCliente
@Nombre varchar (50),
@Apellido1 varchar (50),
@Apellido2 varchar (50),
@Telefno varchar (50)
AS
insert into Clientes(Nombre, Apellido1, Apellido2, Telefno)
values (@Nombre, @Apellido1, @Apellido2, @Telefno)


exec insertarCliente 'Pepe', 'Perez','Pernia', '443223343';
exec insertarCliente 'Lola', 'Valls', 'Azpiricueto', '698745123';



