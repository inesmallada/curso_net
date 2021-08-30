using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844_2
{
    class RepartidorGlovo : Persona
    {
        // atributos
        protected double propinas;
        protected int desplazamientos;
        protected double precioDesplazamiento;

        // propiedades
        public double Ppropinas
        {
            get { return propinas; }
            set { propinas = value; }
        }
        public int Pdesplazamientos
        {
            get { return desplazamientos; }
            set { desplazamientos = value; }
        }
        public double PprecioDesplazamiento
        {
            get { return precioDesplazamiento; }
            set { precioDesplazamiento = value; }
        }

        // constructor

        public RepartidorGlovo() { }

        public RepartidorGlovo(string str_nombre, string str_empresa, double dbl_propinas, int int_desplazamientos, double dbl_precioDesplazamiento) : base(str_nombre, str_empresa)
        {
            propinas = dbl_propinas;
            desplazamientos = int_desplazamientos;
            precioDesplazamiento = dbl_precioDesplazamiento;
        }
        //metodo Imprimir
        public void ImprimirRepartidorGlovo()
        {
            // muestra los datos del objeto
            Console.Clear();
            Console.WriteLine("Datos del Repartidor de Glovo:");
            Console.WriteLine(Pnombre);
            Console.WriteLine(Pempresa);
            Console.WriteLine(Ppropinas);
            Console.WriteLine(Pdesplazamientos);
            Console.WriteLine(PprecioDesplazamiento);
            SueldoRepartidorGlovo();
            Console.ReadLine();
        }//fin metodo imprimir

        //metodo para calcular el sueldo del repartidos de glovo
        public void SueldoRepartidorGlovo()
        {
            double sueldoTotal;
            Console.WriteLine("El salario es:");
            Console.WriteLine(sueldoTotal = Pdesplazamientos * PprecioDesplazamiento + Ppropinas);
            Console.ReadLine();
        }//fin metodo sueldo
    }//fin class
}//fin namespace
