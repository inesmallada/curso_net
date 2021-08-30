using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844
{
    class camion : vehiculo
    {
        // atributos
        private double toneladas;

        // propiedades
        public double Ptoneladas
        {
            get { return toneladas; }
            set { toneladas = value; }
        }

        // constructor
        public camion() { }

        public camion(double dbl_precioVenta, double dbl_costoFabrica, string str_nombreVehiculo, double dbl_toneladas) : base(dbl_precioVenta, dbl_costoFabrica, str_nombreVehiculo)
        {
            toneladas = dbl_toneladas;
        }
        //metodo Imprimir camion
        public void ImprimirCamion()
        {
            // muestra los datos del objeto
            Console.Clear();
            Console.WriteLine("Datos del camión:");
            Console.WriteLine(PprecioVenta);
            Console.WriteLine(PnombreVehiculo);
            Console.WriteLine(Ptoneladas);
            Console.ReadLine();
        }//fin metodo imprimir
    }//fin class
}//fin namespace
