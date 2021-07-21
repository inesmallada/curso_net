--Pocedimiento para buscarcliente
create procedure BuscarCliente
@Nombre varchar(50)
AS
select*
from Clientes
where Nombre like '%' +@nombre+'%'

-------------------------------
exec BuscarCliente 'Saruman';