using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844_2
{
    class Persona
    {
        // atributos
        protected string nombre;
        protected string empresa;

        // propiedades
        public string Pnombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Pempresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
   
        //constructor
        public Persona(string str_nombre, string str_empresa)
        {
            nombre = str_nombre;
            empresa = str_empresa;
        }
        public Persona() { }

        //metodo Imprimir Persona
        public void ImprimirPersona()
        {
            // muestra los datos del objeto
            Console.Clear();
            Console.WriteLine("Datos de la persona:");
            Console.WriteLine(Pnombre);
            Console.WriteLine(Pempresa);
            Console.ReadLine();
        }//fin metodo imprimir
    }//fin class
}//fin namespace

