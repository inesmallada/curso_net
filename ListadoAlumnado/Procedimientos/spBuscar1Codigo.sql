--Buscar por c�digo
Create procedure spBuscar1
@C�digo int
as
select *
from ListadoAlumnado
where C�digo=@C�digo