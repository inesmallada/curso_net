create procedure [Modificar Cliente]
@IDCliente varchar (5),
@Apellidos varchar (30),
@Nombres varchar (30)
AS
UPDATE Cliente
SET
IDCliente=@IDCliente, Apellidos=@Apellidos, Nombres=@Nombres
WHERE Nombres=@Nombres