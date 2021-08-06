using System;
using System.Collections.Generic;
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

namespace EntityFrameworkDatabaseFirst
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Aquí definimos la entidad Profesor
        ProfesoresEntities DbEntityes = new ProfesoresEntities();

        public static DataGrid ControlDatagrid;//objeto control del datagrid

        public MainWindow()
        {
         //Cargamos el Datagrid con los datos
            InitializeComponent();
            MyDG.ItemsSource = DbEntityes.Profesores.ToList(); //apuntando a la tabla de Profesores
            ControlDatagrid = MyDG;
        }

        private void Button_Click(object sender, RoutedEventArgs e)//Botón para que se muestre ventana de insertar
        {
            // El primer botón llama al cuadro Insertar
            Window2 Vinsertar = new
            Window2();
            Vinsertar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//Botón para que se muestre ventana de modificar
        {
            // El segundo botón llama al cuadro Modificar
            int id = (MyDG.SelectedItem as Profesores).Id;

            Window1 Vcambiar = new
            Window1();
            Vcambiar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Botón Eliminar
        {
            int id = (MyDG.SelectedItem as Profesores).Id;
            var deleteProfe = DbEntityes.Profesores.Where(m => m.Id == id).Single();
            DbEntityes.Profesores.Remove(deleteProfe);
            DbEntityes.SaveChanges();
            ControlDatagrid.ItemsSource =
            DbEntityes.Profesores.ToList();
        }

    }//Fin del public parcial class MainWindow
}//Fin namespace

