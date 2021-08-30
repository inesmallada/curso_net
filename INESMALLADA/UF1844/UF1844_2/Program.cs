using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion, Nombre, Empresa;
            double Propinas, PrecioDesplazamiento;
            int Desplazamientos;

            // importante crear aqui objetos pero sin datos para que no de error
            RepartidorGlovo MyGlovo = new RepartidorGlovo();

            //aunque no es necesario, incluyo un breve menú para poder salir de la aplicación sin problemas
            do
            {
                Console.Clear();
                Console.WriteLine("1-Crear Repartidor");
                Console.WriteLine("2-Salir");
                Console.WriteLine("Introduzca Opcion:");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // crear un repartidor con el contructor pillo valores
                        Console.Clear();
                        Console.WriteLine("Introduzca nombre:");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("Introduzca empresa:");
                        Empresa = Console.ReadLine();
                        Console.WriteLine("Introduzca propinas:");
                        Propinas = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca desplazamientos:");
                        Desplazamientos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Precio del desplazamiento:");
                        PrecioDesplazamiento = double.Parse(Console.ReadLine());
                      
                        // ya tengo tengo los datos, creo el objeto con constructor
                        MyGlovo = new RepartidorGlovo(Nombre, Empresa, Propinas, Desplazamientos, PrecioDesplazamiento);

                        //imprimir datos del repartidor
                        MyGlovo.ImprimirRepartidorGlovo();
                      
                        break;
                }//fin do
            } while (opcion != "2");
        }//fin main
    }//fin class
}//fin namespace
