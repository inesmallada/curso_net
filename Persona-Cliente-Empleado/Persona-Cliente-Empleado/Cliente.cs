using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Cliente_Empleado
{
    class Cliente : Persona
    {
        //classe de Empleado que hereda de clase personas

        public string categoria;         //Atributo categoria del cliente
                                   //se añadiría la categoria y el codigo de Persona
        public string Pcategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string codigo;          

        public string Pcodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        //Hay que hacer un constructor para el empleado  lo hacemos como base
       // public Cliente (String categoria, string codigo) : Persona (String Pnombres, String Papellidos, String PDNI)//cláusula base donde se ataca a un objeto
         //Inicializamos cada trabajador en base al constructor de Persona

        public void generarCodigo()
        {
            codigo = "C" + nombres.Substring(0, 3) + documento.Substring(0, 2);
        }
    }
}
