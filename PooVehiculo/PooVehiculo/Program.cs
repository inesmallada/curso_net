using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVehiculo
{
    /// <summary>
    /// CLASE PRINCIPAL PROGRAM
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Selección para escoger si será MOTO O COCHE
            string seleccion, str_marca, str_modelo;
            int int_ID, int_KM;
            double dbl_precio;
            bool boo_airbag, boo_sidecar;
            coche co = new coche();
            moto mo = new moto();

            //Switch para escoger entre MOTO O COCHE
            do
            {
                Console.Clear();
                Console.WriteLine("1) CREAR COCHE \n2)CREAR MOTO \n3) LISTAR DATOS DEL COCHE \n4)LISTAR DATOS DE LA MOTO \n5) SALIR");
                seleccion = Console.ReadLine();
                switch (seleccion)
                {
                    //Creación y entrada de datos de cliente
                    //int ID, string Marca, string Modelo, int KM, double Precio, bool airbag

                    //contructor public coche(int int_ID, string str_marca, string str_modelo, int int_KM, double dbl_precio, bool boo_airbag) : base(int_ID, str_marca, str_modelo, int_KM, dbl_precio)
                    case "1":
                        //Recordar que tengo que incluir el constructor
                        Console.WriteLine("Introduce el ID");
                        int_ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Marca");
                        str_marca = Console.ReadLine();
                        Console.WriteLine("Introduce el Modelo");
                        str_modelo = Console.ReadLine();
                        Console.WriteLine("Introduce los KM");
                        int_KM = int.Parse(Console.ReadLine());
                       //se pregunta por el airbag. BOOL
                        Console.WriteLine("Tiene airbag: s/n");
                        string resp = Console.ReadLine();

                        if (resp == "s" || resp == "S")
                        { boo_airbag = true;}
                        else {boo_airbag = false;}
                        Console.WriteLine("Introduce la precio");
                        dbl_precio = double.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    //Creación y entrada de datos de moto
                    case "2":
                        Console.WriteLine("Introduce el ID");
                        int_ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Marca");
                        str_marca = Console.ReadLine();
                        Console.WriteLine("Introduce el Modelo");
                        str_modelo = Console.ReadLine();
                        Console.WriteLine("Introduce los KM");
                        int_KM = int.Parse(Console.ReadLine());
                  
                        //se pregunta por el airbag. BOOL
                        Console.WriteLine("Tiene sidecar: s/n");
                        string respu = Console.ReadLine();
                        if (respu == "s" || respu == "S")
                        { boo_sidecar = true; }
                        else { boo_sidecar = false; }
                        Console.WriteLine("Introduce la precio");
                        dbl_precio = double.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    case "3":
                        co.PrecioAirbag();
                        co.listarCoche();
                        Console.Clear();
                        break;
                  
                    case "4":
                        mo.PrecioSidecar();
                        mo.listarMoto();
                        Console.Clear();
                        break;

                    //Salir de la app
                    case "5":
                        Console.WriteLine("Saliendo");
                        break;
                }
            } while (seleccion != "5");
           
        }//FIN MAIN
    }//FIN CLASE
}//FIN NAMESPACE
