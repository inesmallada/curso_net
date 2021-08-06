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
using System.Windows.Shapes;

namespace EntityFrameworkDatabaseFirst
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ProfesoresEntities DbEntityes = new ProfesoresEntities();
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Botón Insertar
            {
                //int id = MyDataGrid.Items.Count + 1;
                Profesores MyProfe = new Profesores()
                {
                    Id = int.Parse(TxtID.Text),
                    Nombre = TxtNombre.Text,
                    Especialidad = cmbEspec.Text
                };
                DbEntityes.Profesores.Add(MyProfe);
                DbEntityes.SaveChanges();
                MainWindow.ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
                this.Hide();
            }
        }
    }
}
