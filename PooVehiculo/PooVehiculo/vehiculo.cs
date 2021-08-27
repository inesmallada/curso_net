using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVehiculo
{
    /// <summary>
    /// CLASE vehiculo
    /// </summary>
    ///  int ID, string Marca, string Modelo, int KM, double Precio 
    class vehiculo
    {
        //ATRIBUTOS protected para que las otras clases puedan utilizar sus propiedades
        //Las clases heredadas
        //Cuando una variable empieza por _ es privada
        protected int ID;
        protected string marca;
        protected string modelo;
        protected int KM;
        protected double precio;
        /// <summary>
        /// Constructor de la clase vehiculo
        /// </summary>
        //Para poder generar una clase por defecto y accedes a sus propiedades
        public vehiculo() {}
        //constructor sobrecargado para pasarle parámetros
        public vehiculo(int int_ID, string str_marca, string str_modelo, int int_KM, double dbl_precio)
        {
            this.ID = int_ID;
            this.marca = str_marca;
            this.modelo = str_modelo;
            this.KM = int_KM;
            this.precio = dbl_precio;
        }

        public int PID
        {
            set { ID = value; }
            get { return ID; } //para que solo sea de lectura y no se pueda modificar nos quedaríamos únicamente con el get
        }
        public string Pmarca
        {
            set { marca = value; }
            get { return marca; }
        }
        public string Pmodelo
        {
            set { modelo = value; }
            get { return modelo; }
        }
        public int PKM
        {
            set { KM = value; }
            get { return KM; }
        }
        public double Pprecio
        {
            set { precio = value; }
            get { return precio; }
        }


    }
}
