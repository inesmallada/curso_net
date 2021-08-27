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
        DataClasses1DataContext listarAlumnado = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listaAlumnos();

        }

        void listaAlumnos()
        {
            dataGridView1.DataSource = listarAlumnado.spCargarGridAlumnado();
        }


        //Botón para insertar alumnado
        private void button1_Click(object sender, EventArgs e)
        {
            if ((TxtNombre.Text == "") || (TxtDNI.Text == "") || (cbTurno.Text == "") || (cbGenero.Text == "") || (cbModulo.Text == "") || (cbEspecialidad.Text == ""))
            {
                MessageBox.Show("Error al insertar datos");
            }
            else
            {

                conexion.Open();
                string nombre = TxtNombre.Text;
                string DNI = TxtDNI.Text;
                string Turno = cbTurno.Text;
                string genero = cbGenero.Text;
                int Repetidor;
                string modulo = cbModulo.Text;
                string especialidad = cbEspecialidad.Text;
                if (chbRepetidor.Checked == true)
                {
                    Repetidor = 1;
                }
                else
                {
                    Repetidor = 0;
                }

                string cadena = "insert into ListadoAlumnado(nombre, DNI, Turno, Género, Repetidor,Módulo, especialidad) values('" + nombre + "','" + DNI + "','" + Turno + "','" + genero + "'," + Repetidor + ",'" + modulo + "','" + especialidad + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                TxtNombre.Text = "";
                TxtDNI.Text = "";
                cbTurno.Text = "";
                cbGenero.Text = "";
                conexion.Close();
                this.listaAlumnos();
            }
        }

        //Botón para filtrar por código
        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listarAlumnado.spBuscar1(int.Parse(TxtCodigo2.Text));
        }

        //Botón para filtrar por DNI

        private void BtnDNI_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listarAlumnado.spBuscar2(TxtDNI2.Text);
        }


        //Botón Modificar
        private void button3_Click(object sender, EventArgs e)
        {
              conexion.Open();
              string codigo = TxtCodigo.Text;
              string nombre = TxtNombre.Text;
              string DNI = TxtDNI.Text;
              string Turno = cbTurno.Text;
              string genero = cbGenero.Text;
              int Repetidor;
              if (chbRepetidor.Checked == true)
              {
                    Repetidor = 1;
              }
              else
              {
                    Repetidor = 0;
              }

              string modulo = cbModulo.Text;
              string especialidad = cbEspecialidad.Text;
              string cadena = "Update ListadoAlumnado set nombre='" + nombre + "', DNI='" + DNI + "', Turno='"+Turno+"', Género='"+genero+"', Repetidor="+Repetidor+", Módulo='"+modulo+"', especialidad='"+especialidad+"' where DNI=" + DNI;
              SqlCommand comando = new SqlCommand(cadena, conexion);
              int cant;
              cant = comando.ExecuteNonQuery();
              if (cant == 1)
              {
                  MessageBox.Show("Se modificaron los datos del artículo");
                TxtNombre.Text = "";
                TxtDNI.Text = "";
                cbTurno.Text = "";
                cbGenero.Text = "";
                cbModulo.Text = "";
                cbEspecialidad.Text = "";
              }
              else
                  MessageBox.Show("No existe un artículo con el DNI ingresado");
                conexion.Close();
                this.listaAlumnos();
          }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string DNI = TxtDNI.Text;
            string cadena = "delete from ListadoAlumnado where DNI=" + DNI;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se borró el artículo");
            }
            else
                MessageBox.Show("no existe un artículo con el código ingresado");
            conexion.Close();
            this.listaAlumnos();
        }
    }

    }
