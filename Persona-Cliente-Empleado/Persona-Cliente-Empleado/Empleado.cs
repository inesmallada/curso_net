using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Cliente_Empleado
{
    class Empleado : Persona
    {
        //classe de Empleado que hereda de clase personas
       
            public int sueldo;         //Atributo sueldo del empleado
                                        //se añadiría el nombre y la edad de Persona
            public int Psueldo
            {
                get { return sueldo; }
                set { sueldo = value; }
            }

            public string tipoContrato;         

            public string PtipoContrato
            {
            get { return tipoContrato; }
            set { tipoContrato = value; }
            }
        //Hay que hacer un constructor para el empleado  lo hacemos como base
        public Empleado (String tipoContrato, int sueldo) : Persona (String Pnombres, String Papellidos, String PDNI)//cláusula base donde se ataca a un objeto
        { //Inicializamos cada trabajador en base al constructor de Persona
            sueldo = Psueldo;           

        }

           
        public void calcularSueldo()
        {
          System.Console.WriteLine("Imprimir sueldo: " + sueldo);
        }
        
    }
}
