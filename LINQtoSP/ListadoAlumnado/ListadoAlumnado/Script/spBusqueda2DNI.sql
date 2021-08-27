Create procedure spBuscar2
@DNI nvarchar(30)
AS
select *
from ListadoAlumnado
where DNI=@DNI