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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string ID = TxtIDInsertar.Text;
            string nombre = TxtNombreInsertar.Text;
            string edad = TxtEdadInsertar.Text;
            string cadena = "insert into Personas(id, nombre, edad)" + "values("+ID+",'" + nombre+ "'," + edad+ ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            TxtIDInsertar.Text = "";
            TxtNombreInsertar.Text="";
            TxtEdadInsertar.Text = "";
            conexion.Close();


        }
    }
}
