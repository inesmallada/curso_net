using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadoAlumnado
{
    /// <summary>
    /// iNSERTAR, BORRAR, ELIMINAR DATOS
    /// </summary>
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=ASATA401\\SQLEXPRESSINES;Initial Catalog=ListadoAlumnado;Persist Security Info=True;User ID=sa; Password=1234");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string nombre = TxtNombre.Text;
            string DNI = TxtDNI.Text;
            string Turno = cbTurno.Text;
            string genero = TxtGenero.Text;
            bool Repetidor;
            string modulo = cbModulo.Text;
            string especialidad = cbEspecialidad.Text;
            string cadena = "insert into ListadoAlumnado (, , nombre, DNI, Turno, genero, modulo, especialidad, )" + "values(" + ID + ",'" + nombre + "'," + edad + ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            TxtNombre.Text = "";
            TxtDNI.Text = "";
            cbTurno.Text = "";
            TxtGenero.Text = "";
            conexion.Close();
        }
    }
}
