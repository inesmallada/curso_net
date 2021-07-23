create procedure [insertarCliente]
@IDCliente varchar (5),
@Apellidos varchar (30),
@Nombres varchar (30)
AS
insert into Cliente(IDCliente, Apellidos,Nombres)
values (@IDCliente, @Apellidos,@Nombres)