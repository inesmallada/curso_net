using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InyeccionSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion =new SqlConnection("server = Data Source=ASATA401\\SQLEXPRESSINES;Initial Catalog=InyeccionSQL;Persist Security Info=True;User ID=sa; Password=1234");
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string ID = TxtIDEliminar.Text;
            string cadena = "select id, nombre, edad from Personas where id=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                LNombre.Content = registro["nombre"].ToString();
                LEdad.Content = registro["edad"].ToString();
                BtnBorrar.IsEnabled = true;

            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string ID = TxtIDInsertar.Text;
            string nombre = TxtNombreInsertar.Text;
            string edad = TxtEdadInsertar.Text;
            string cadena = "insert into Personas(id, nombre, edad)" + "values(" + ID + ",'" + nombre + "'," + edad + ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            TxtIDInsertar.Text = "";
            TxtNombreInsertar.Text = "";
            TxtEdadInsertar.Text = "";
            conexion.Close();
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string ID = TxtIDInsertar.Text;
            string nombre = TxtNombreInsertar.Text;
            string edad = TxtEdadInsertar.Text;
            string cadena = "Update Personas set nombre='" + nombre + "', edad=" + edad + "where id=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                TxtIDInsertar.Text = "";
                TxtNombreInsertar.Text = "";
                TxtEdadInsertar.Text = "";
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
            //desconozco cuál es el botón para IsEnabled=false
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string ID= TxtIDInsertar.Text;
            string cadena = "delete from Personas where id=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                LNombre.Content = "";
                LEdad.Content = "";
                MessageBox.Show("Se borró el artículo");
            }
            else
                MessageBox.Show("no existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string cod = TxtIDModificar.Text;
            string cadena = "select id, nombre, edad from Personas where id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombreInsertar.Text = registro["nombre"].ToString();
                TxtEdadInsertar.Text = registro["edad"].ToString();
                //no sé qué botón IsEnabled=true
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
        }
    }
}
