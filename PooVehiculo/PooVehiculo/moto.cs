using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVehiculo
{
    /// <summary>
    /// CLASE moto QUE HEREDA DE vehiculo
    /// </summary>
    /// int ID, string Marca, string Modelo, int KM, double Precio, bool sidecar
    /// método para que modifique el precio, si tiene sidecar el precio aumentara 50.
    class moto : vehiculo
    {
        //ATRIBUTO DE LA CLASE moto
        protected bool sidecar;
        //PROPIEDADES DE LA CLASE COCHE
        public bool Psidecar
        {
            set { sidecar = value; }
            get { return sidecar; }
        }

        // contructor
        public moto(int int_ID, string str_marca, string str_modelo, int int_KM, double dbl_precio, bool boo_sidecar) : base(int_ID, str_marca, str_modelo, int_KM, dbl_precio)
        {
            this.sidecar = boo_sidecar;
        }
        public moto(){}

        /// <summary>
        /// Método calcular precio
        /// </summary>
        /// <param name="precio">De tipo Double el precio del coche</param>

        public void PrecioSidecar()
        {
            if (this.sidecar == true)
            {
                this.Pprecio = Pprecio + 50;
            }
            else {}
        }//FIN DE METODO

        public void listarMoto()
        {
            string side = "No";
            if (Psidecar == true) { side = "Si"; }
            Console.WriteLine("ID :" + PID + "\n" + "Marca: " + Pmarca + "\n" + "Modelo: " + Pmodelo + "\n" + "KM: " + PKM + "\n" + "Precio: " + Pprecio + "\n" + "Sidecar: " + Psidecar);
            Console.ReadKey();
        }//FIN METODO
    }//FIN CLASE
}//FIN NAMESPACE
