
--Procedimiento para eliminar cliente

create procedure EliminarCliente
@nombre varchar(50)
as
Delete
from Clientes
where @Nombre=Nombre


--------------------------

exec EliminarCliente  'pepe';