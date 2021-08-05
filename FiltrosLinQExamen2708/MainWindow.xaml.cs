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

namespace Ejercicio_Filtros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Inicializamos la clase de contexto GLOBAL
        //Siempre en la clase Main Windows si es WPF
        DatosJuevesDataContext filtros = new DatosJuevesDataContext();
        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();
            cargarGrid();
        }

        void cargarGrid()
        {
            //Método con LINQ para cargar el DataGrid
            var listagrid = from f in filtros.DatosFiltrosLINQ select f; 
            DGV1.ItemsSource = listagrid;
        }

        /// <summary>
        /// MÉTODO PARA MOSTRAR LOS REGISTROS DE UN CURSO DETERMINADO
        /// </summary>
        void cargarGridCurso()
        {
            //FILTRAMOS LOS REGISTROS DEL CURSO
            //SELECCIONADO EN EL COMBO
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosFiltrosLINQ where f.Curso == curso select f;
            DGV1.ItemsSource = listagrid;
        }

        /// <summary>
        /// Método con LINQ para filtrar con el nombre y con el curso activado.
        /// OJO CONTAINS es lo mismo que LIKE en SQL.
        /// </summary>
        /// <param name="cadena"></param>
        void cargarGridNombre(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosFiltrosLINQ where f.Curso == curso && f.Nombre.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;

        }


        /// <summary>
        /// Método con LINQ para filtrar con el apellido.
        /// OJO CONTAINS es lo mismo que LIKE en SQL.
        /// Filtra en función del Apellido y del curso.
        /// </summary>
        /// <param name="cadena"></param>
        void cargarGridApellido(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosFiltrosLINQ where f.Curso == curso && f.Apellido.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }



        /// <summary>
        /// Método con LINQ para filtrar con el apellido y nombre.
        /// OJO CONTAINS es lo mismo que LIKE en SQL.
        /// Filtra en función del Apellido y del curso.
        /// </summary>

        void cargarGridApellidoNombre(String cadena, string cadena2)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosFiltrosLINQ where f.Curso == curso && f.Nombre.Contains(cadena) && f.Apellido.Contains(cadena2) select f;
            DGV1.ItemsSource = listagrid;
        }


        /// <summary>
        /// Habilitar y deshabilitar Checkbox de las fechas
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = true;

        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = false;

        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = true;
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = false;

        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = true;
        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = false;

        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = true;
        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {

            DatePicker4.IsEnabled = true;
        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = true;
            CheckBox5.IsEnabled = true;
        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = false;
            CheckBox5.IsEnabled = false;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
                cargarGridApellidoNombre(TextBox1.Text, TextBox2.Text);
            else if (TextBox1.Text != "" && TextBox2.Text == "")
                cargarGridNombre(TextBox1.Text);
            else if (TextBox1.Text == "" && TextBox2.Text != "")
                cargarGridApellido(TextBox2.Text);
            else cargarGridCurso();


        }

        //A partir de aquí, flitrado por fecha de inscripcion

        void cargarGridFechaI(DateTime date, DateTime date2)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosFiltrosLINQ where f.Curso == curso && f.Fecha_Ins >= date && f.Fecha_Ins <= date2 select f;
            DGV1.ItemsSource = listagrid;

        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Fecha inscripcion ambos checkeado
            DateTime desde = DatePicker1.DisplayDate;
            DateTime hasta = DatePicker2.DisplayDate;
            cargarGridFechaI(desde, hasta);

        }
    }
}
