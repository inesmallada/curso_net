using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844
{
    class vehiculo
    {
        // atributos
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreVehiculo;
       
        // propiedades
        public double PprecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        public double PcostoFabrica
        {
            get { return costoFabrica; }
            set { costoFabrica = value; }
        }

        public string PnombreVehiculo
        {
            get { return nombreVehiculo; }
            set { nombreVehiculo = value; }
        }

        //constructor
        public vehiculo(double dbl_precioVenta, double dbl_costoFabrica, string str_nombreVehiculo)
        {
            precioVenta = dbl_precioVenta;
            costoFabrica = dbl_costoFabrica;
            nombreVehiculo = str_nombreVehiculo;
    
        }
        public vehiculo() { }

        //metodos
    }
}
