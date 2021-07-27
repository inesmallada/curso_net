--Buscar por código
Create procedure spBuscar1
@Código int
as
select *
from ListadoAlumnado
where Código=@Código