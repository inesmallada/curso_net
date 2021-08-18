using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Cliente_Empleado
{
    public class Persona
    {
        /// <summary>
        /// CLASE PERSONA
        /// </summary>
        /// NOMBRE, APELLIDO, DOCUMENTO
        //ATRIBUTOS
        //protected para que las otras clases puedan utilizar sus propiedades
        //Las clases heredadas
        protected string nombres;//defino los campos interiores
        protected string apellidos;
        protected string documento;
    }

    /// <summary>
    /// Constructor para la clase Persona
    /// </summary>
    public Persona()
    { }
    public String Pnombres //Propiedades edad para cargar el nombre
    {
        get { return nombres; }
        set { nombres = value; }
    }
    public String Papellidos //Propiedades apellidos para cargar el nombre
    {
        get { return apellidos; }
        set { apellidos = value; }
    }
    public String PDNI //Propiedades documento para cargar el nombre
    {
        get { return documento; }
        set { documento = value; }
    }

    //Constructor Persona
    //public Persona (String Pnombres, String Papellidos, String PDNI);


}
