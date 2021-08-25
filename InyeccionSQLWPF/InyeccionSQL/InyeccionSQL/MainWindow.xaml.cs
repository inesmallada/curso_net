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

    {//En primer lugar definir la cedena de conexión a nuestra DDBB
        private SqlConnection conexion =new SqlConnection("Data Source=ASATA401\\SQLEXPRESSINES;Initial Catalog=InyeccionSQL;Persist Security Info=True;User ID=sa; Password=1234");
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            //Comprobamos que el id se introdujo 
            if (TxtIDEliminar.Text != "")
            {
                //Abrimos conexión
                conexion.Open();
                string ID = TxtIDEliminar.Text;
                //Definimos la cadena de sql yla ejecutamos
                string cadena = "select id, nombre, edad from Personas where id=" + ID;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();

                //Si la encuentra vuelca el registro en el datareader y pone nombre y edad en los textbox habilita el boton de modificar

                if (registro.Read())
                {
                    LNombre.Content = registro["nombre"].ToString();
                    LEdad.Content = registro["edad"].ToString();
                    BtnBorrar.IsEnabled = true;

                }
                else
                {
                    MessageBox.Show("No existe un artículo con el código ingresado");

                }//cerramos cadena de conexion
                conexion.Close();
            }//cerramos método
        }

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //controlar entrada de try catch en todas las sentencias
                //Abrimos conexion
                conexion.Open();
                string ID = TxtIDInsertar.Text;
                string nombre = TxtNombreInsertar.Text;
                string edad = TxtEdadInsertar.Text;
                //DEFINIMOS LA CADENA SQL Y LA LANZAMOS
                string cadena = "insert into Personas(id, nombre, edad)" + "values(" + ID + ",'" + nombre + "'," + edad + ")";

                SqlCommand comando = new SqlCommand(cadena, conexion); //DEFINIMOS CADENA Y LA LANZAMOS
                comando.ExecuteNonQuery();

                //sI NO PETÓ NADA LOS DATOS DEBERÁN APARECER

                MessageBox.Show("Los datos se guardaron correctamente");
                TxtIDInsertar.Text = "";
                TxtNombreInsertar.Text = "";
                TxtEdadInsertar.Text = "";
                conexion.Close();
            }//FIN TRY
            catch 
            {
                if (TxtIDInsertar.Text == "" || TxtNombreInsertar.Text == "" || TxtEdadInsertar.Text == "")
                {
                    MessageBox.Show("Faltan datos por cubrir");
                }
                
            }
        }//FIN método insertar

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            //abrimos conexion
            conexion.Open();

            try
            {
                //si algun textbox está en blanco no funcionaría en if
                if (TxtNombreModificar.Text == "" || TxtNombreModificar.Text == "" || TxtEdadModificar.Text == "")
                {
                    string ID = TxtIDModificar.Text;
                    string nombre = TxtNombreModificar.Text;
                    string edad = TxtEdadModificar.Text;

                    //definimos la cadena sql y la lanzamos
                    string cadena = "Update Personas set nombre='" + nombre + "', edad=" + edad + "where id=" + ID;
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    int cant;
                    //EN CASP DE MODIFICARSE CON EXITO SE GUARDA EN LA VARIABLE CANT
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        MessageBox.Show("Se modificaron los datos del artículo");
                        TxtIDInsertar.Text = "";
                        TxtNombreInsertar.Text = "";
                        TxtEdadInsertar.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No existe un artículo con el código ingresado");
                        conexion.Close();
                        //desconozco cuál es el botón para IsEnabled=false
                    }
                }//FIN IF
            } //FIN try
            catch
            {
                MessageBox.Show("Ha habido algún error");
            }
        }//FIN método



        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //bOTON PASRA ELIMINAR SI BUSCÓ NTERIORMENTE
                if (TxtIDEliminar.Text != "")

                {

                    //ABRIMOS CONEXION
                    conexion.Open();
                    string ID = TxtIDEliminar.Text;
                    //DEFINIR CADENA SQL PARA BORRAR EL REGISTRO Y EJECUTARLA
                    string cadena = "delete from Personas where id=" + ID;
                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    //COMPRUEBA SI SE ELLIMINÓ
                    int cant;

                    //EN CANTIDAD LO QUE GUARDAMOS ES EL NÚMERO DE LOS REGISTROS BORRADOS (CANT)
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        LNombre.Content = "";
                        LEdad.Content = "";
                        MessageBox.Show("Se borró el artículo");
                    }
                    else
                    {
                        MessageBox.Show("no existe un artículo con el código ingresado");
                        BtnBorrar.IsEnabled = true;
                    }
                    conexion.Close();
                }
            } catch 
            {
                MessageBox.Show("Ha habido algún error");
            }


        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //boton de busqueda que comprueba que el id existe
            if (TxtIDEliminar.Text != "")
            {
                conexion.Open();
                string cod = TxtIDModificar.Text;
                //DEFINIR CADENA SQL Y LA LANZAMOS
                string cadena = "select id, nombre, edad from Personas where id=" + cod;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //SE DEFINE UN SQLREADER PARA LEER EL REGISTRO BUSCADO
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    //pONE EL NOMBRE DE LA EDAD DEN LOS LABLE
                    TxtNombreModificar.Text = registro["nombre"].ToString();
                    TxtEdadModificar.Text = registro["edad"].ToString();
                    BtnBuscar.IsEnabled = true;
                }
                else {
                    MessageBox.Show("No existe un artículo con el código ingresado");
                }
                //CERRAMOS LA CONEXION UNA VEZ COMPROBADO SI EL ID EXISTE
                conexion.Close();
            }//CIERRE DEL IF
        }//CIERRE DE btnbuscar

    }
}
