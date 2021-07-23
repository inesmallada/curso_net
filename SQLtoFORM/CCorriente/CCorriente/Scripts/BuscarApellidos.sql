create procedure BuscarApellidos
@Apellidos varchar(30)
AS
select*
from Cliente
where Apellidos like '%' +@Apellidos+'%'