

--Procedimiento para eliminar cliente

create procedure EliminarCliente
@IDCliente varchar(30)
as
Delete
from Cliente
where @idCliente=idcliente


--------------------------

exec EliminarCliente  '12345';