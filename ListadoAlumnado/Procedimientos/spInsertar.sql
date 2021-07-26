Create procedure spInsertarAlumnado
@Nombre nvarchar (30),
@DNI  nvarchar (30),
@Turno nvarchar (10),
@Género nvarchar (10),
@Repetidor bit,
@Módulo nvarchar (10),
@Especialidad nvarchar(25)
AS
Insert into ListadoAlumnado (Nombre, DNI, Turno, Género, Repetidor, Módulo, Especialidad)
VALUES (@Nombre, @DNI, @Turno, @Género, @Repetidor, @Módulo, @Especialidad)