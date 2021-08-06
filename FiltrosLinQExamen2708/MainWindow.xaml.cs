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

        void cargarGridFechaC(DateTime date3, DateTime date4)
        {
            string curso = ComboBox1.Text;
           CheckBox3.IsEnabled =false;

            if (CheckBox3.IsChecked == true && CheckBox2.IsChecked==true)
            {
                var listagrid = from f in filtros.DatosFiltrosLINQ where f.Curso == curso && f.Fecha_Cont >= date3 && f.Fecha_Cont <= date4 select f;
                DGV1.ItemsSource = listagrid;
            }
            else {
                MessageBox.Show("Error. Seleccione el campo por el que quiera filtrar.");
            }
        }


        void cargarGridFechas(DateTime date, DateTime date2, DateTime date3, DateTime date4)
        {
            string curso = ComboBox1.Text;
            CheckBox3.IsChecked = true; 

            var listagrid = from f in filtros.DatosFiltrosLINQ where f.Curso == curso && f.Fecha_Ins >= date && f.Fecha_Ins <= date2 && f.Fecha_Cont >= date3 && f.Fecha_Cont <= date4 select f;
            DGV1.ItemsSource = listagrid;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Fecha inscripcion ambos checkeado
            DateTime date = DatePicker1.DisplayDate;
            DateTime date2 = DatePicker2.DisplayDate;
            cargarGridFechaI(date, date2);

            //Fecha_Cont //CoNTRATACION
            DateTime date3 = DatePicker3.DisplayDate;
            DateTime date4 = DatePicker4.DisplayDate;
            cargarGridFechaC(date3, date4);




            //Método para cargar filtro por fecha de inscripción

            if (CheckBox1.IsChecked == true && CheckBox2.IsChecked == true)
                cargarGridFechaI(DatePicker1.DisplayDate, DatePicker2.DisplayDate);

            //Método para cargar filtro por fecha de contratación
            else if (CheckBox4.IsChecked == true && CheckBox5.IsChecked == true)
                cargarGridFechaC(DatePicker3.DisplayDate, DatePicker4.DisplayDate);

            //Método para cargar filtro por todas

            else if (CheckBox1.IsChecked == true && CheckBox2.IsChecked == true && CheckBox4.IsChecked == true && CheckBox5.IsChecked == true) cargarTodas(DatePicker1.DisplayDate, DatePicker2.DisplayDate, DatePicker3.DisplayDate, DatePicker4.DisplayDate);
               }
        void cargarTodas(DateTime f1, DateTime f2, DateTime f3, DateTime f4)
                {
                    var listagrid = from f in filtros.DatosFiltrosLINQ
                                    where
                                    f.Fecha_Ins >= f1 && f.Fecha_Ins <= f2 &&

                                    f.Fecha_Cont >= f3 && f.Fecha_Cont <= f4
                                    select f;
                    DGV1.ItemsSource = listagrid;
                }


        }
    }

