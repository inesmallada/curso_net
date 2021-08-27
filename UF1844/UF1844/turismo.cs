using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844
{
    class turismo : vehiculo
    {
        // atributos
        protected bool clasico;

        // propiedades
        public bool Pclasico
        {
            get { return clasico; }
            set { clasico = value; }
        }
        // constructor

        public turismo() { }

        public turismo(double dbl_precioVenta, double dbl_costoFabrica, string str_nombreVehiculo, bool bln_clasico) : base(dbl_precioVenta, dbl_costoFabrica, str_nombreVehiculo)
        {
            clasico = bln_clasico;
        }
        //metodo Imprimir
        public void ImprimirTurismo()
        {
            string x;
            if (clasico == true) { x = "SI"; } else { x = "NO"; }

            // muestra los datos del objeto
            Console.Clear();
            Console.WriteLine("Datos del turismo:");
            Console.WriteLine(PprecioVenta);
            Console.WriteLine(PnombreVehiculo);
            Console.WriteLine("Clasico: " + x);
            Console.ReadLine();
        }//fin metodo imprimir


    }//fin class
}//fin namespace
