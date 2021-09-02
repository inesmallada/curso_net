namespace EFMigrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EFMigrations.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EFMigrations.Models.ContextoEmpleados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFMigrations.Models.ContextoEmpleados context)
        {
            context.Empleados.AddOrUpdate(z => z.Nombre, 
                new Empleado
            { 
                IdEmpleado = 1,
                Nombre = "David",
                Apellidos = "Fernández Huertas",
                Direccion = "Calle Atlético de Madrid",
                Email = "david@mail.com"
            }
            );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
