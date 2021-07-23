create procedure BuscarNombre
@Nombres varchar(30)
AS
select*
from Cliente
where Nombres like '%' +@Nombres+'%'