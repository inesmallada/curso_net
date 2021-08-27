using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVehiculo
{
    /// <summary>
    /// CLASE coche HEREDADA de vehiculo
    /// </summary>
    /// int ID, string Marca, string Modelo, int KM, double Precio, bool airbag
    /// metodo Modificar precio: sí airbag precio+200
    class coche : vehiculo
    {
        //ATRIBUTO DE LA CLASE COCHE
        protected bool airbag;
        //PROPIEDADES DE LA CLASE COCHE
        public bool Pairbag
        {
            set { airbag = value; }
            get { return airbag; }
        }

        // contructor
        public coche(int int_ID, string str_marca, string str_modelo, int int_KM, double dbl_precio, bool boo_airbag) : base (int_ID, str_marca, str_modelo, int_KM, dbl_precio)
        { this.airbag = boo_airbag; }
        public coche() {}

        /// <summary>
        /// Método calcular precio
        /// </summary>
        /// <param name="precio">De tipo Double el precio del coche</param>

        public void PrecioAirbag ()
        {
            if (this.airbag == true) {this.precio = precio + 200;}
         
        }//FIN DE METODO

        public void listarCoche()
        {
            string air = "No";
            if (Pairbag == true) { air = "Si"; }
            Console.WriteLine("ID :" + PID + "\n" + "Marca: " + Pmarca + "\n" + "Modelo: " + Pmodelo + "\n" + "KM: " + PKM + "\n" + "Precio: " + Pprecio + "\n" + "airbag: " + Pairbag);
            Console.ReadKey();
        }//FIN METODO
    }//FIN CLASE
}//FIN NAMESPACE
