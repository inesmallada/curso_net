

--Procedimiento para eliminar cliente

create procedure EliminarCliente
@Nombres varchar(30)
as
Delete
from Cliente
where @Nombres=Nombres


--------------------------

exec EliminarCliente  'marta';