Create procedure spBajaAlumnado
@DNI nvarchar (30)
AS
Delete 
FROM ListadoAlumnado 
WHERE DNI=@DNI;