using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos las variables
            string opcion, Nombre, x;
            bool Clasic;
            double Ton, Precio, Costo;
            // importante crear aqui objetos pero sin datos para que no dé error
            turismo Myturismo = new turismo();
            camion Mycamion = new camion();

            //creamos el menú
            do
            {
                Console.Clear();
                Console.WriteLine("1-Crear Turismo");
                Console.WriteLine("2-Crear Camion");
                Console.WriteLine("3-Listar  datos de Turismo");
                Console.WriteLine("4-Listar datos de Camion");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Introduzca Opcion:");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // crear turismo con el contructor pillo valores
                        Console.Clear();
                        Console.WriteLine("Introduzca precio del turismo:");
                        Precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca costo del turismo:");
                        Costo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca nombre del turismo:");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("¿Es un clasico?(s/n):");
                        x = Console.ReadLine();
                        if ((x == "S") || (x == "s"))
                            Clasic = true;
                        else
                            Clasic = false;
                        // ya tengo tengo los datos, creo el objeto con constructor

                        Myturismo = new turismo(Precio,Costo,Nombre, Clasic);
                        break;

                    case "2":
                        // crear camión con el contructor
                        Console.Clear();
                        Console.WriteLine("Introduzca precio del camion:");
                        Precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca costo del camion:");
                        Costo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca nombre del camion:");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("Introduzca las toneladas del camion:");
                        Ton = double.Parse(Console.ReadLine());

                        // ya tengo tengo los datos, creo el objeto pero ya al principio inicializado
                        Mycamion = new camion(Precio, Costo, Nombre, Ton);
                        break;

                    case "3":
                        // listar datos de un turismo
                        Myturismo.ImprimirTurismo();
                        break;

                    case "4":
                        // listar datos del camion
                        Mycamion.ImprimirCamion();
                        break;
                }//fin switch
            } while (opcion != "5");
        }//fin main
    }//fin class
}//
