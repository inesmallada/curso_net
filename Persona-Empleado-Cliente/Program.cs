using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Cliente_Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir persona y llamamos a sus propiedades y sus métodos.

            Persona p1 = new Persona();
            Console.WriteLine("Introduzca un Nombre");
            String texto1;
            texto1 = Console.ReadLine();
            Console.WriteLine("Introduzca un Apellidos");
            String texto2;
            texto2 = Console.ReadLine();
            Console.WriteLine("Introduzca un DNI");
            String texto3;
            texto3 = Console.ReadLine();


            Console.WriteLine(texto1 + " " + texto2 + " "+ texto3);
            p1.Imprimir();


            //definir empleado y llamar propiedades y métodos
            //creamos un objeto de tipo empleado
            Empleado e1 = new Empleado();
            
            Console.WriteLine("Introduzca Tipo de Contrato: F o T");
            String result;
           
            if (result == F)
            {
                result = sueldo + 300;
            }
            else {
                result = sueldo + 250;
            }
            result = Console.ReadLine();

            Console.WriteLine("Introduzca su sueldo");
            String texto4;
            texto4 = Console.ReadLine();
            
            Console.WriteLine(result + " " + sueldo + " ");
            //llama método redefinido
           
            e1.imprimirsueldo();

            Console.ReadLine();

        }
    }
}
