Create procedure spInsertarAlumnado
@Nombre nvarchar (30),
@DNI  nvarchar (30),
@Turno nvarchar (10),
@G�nero nvarchar (10),
@Repetidor bit,
@M�dulo nvarchar (10),
@Especialidad nvarchar(25)
AS
Insert into ListadoAlumnado (Nombre, DNI, Turno, G�nero, Repetidor, M�dulo, Especialidad)
VALUES (@Nombre, @DNI, @Turno, @G�nero, @Repetidor, @M�dulo, @Especialidad)