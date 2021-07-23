--Pocedimiento para buscarcliente
create procedure BuscarCliente
@IDCliente varchar(5)
AS
select*
from Cliente
where IDCliente like '%' +@IDCliente+'%'

-------------------------------
exec BuscarCliente '23456';