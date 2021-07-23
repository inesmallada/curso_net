--Procedimiento almacenado que muestre toda la información a partir de un IDCUENTA


create procedure spListarInfo
as
select c.idcliente, c.idcuenta, c.saldo, c.divisa, m.idcuenta, m.IDMOVIMIENTO, m.monto, m.tipo, m.fecha
from cuenta c inner join movimiento m
on c.idcuenta=m.idcuenta
----
exec spListarInfo;