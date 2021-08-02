using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormuLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext baseDatos = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarBusqueda();
            cargarGrid();
        }
        void cargarBusqueda()
        {
            var cargarBusqueda = from Empleados in baseDatos.Empleados
                              select Empleados.Nombre;
            cbNombre2.DataSource = cargarBusqueda;
        }

        void cargarGrid()
        {
            var cargarGrid = from Empleados in baseDatos.Empleados select Empleados;
            GridDatos.DataSource = cargarGrid;
            int num = cargarGrid.Count();
            TxtRows.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados MyEmpleado = new Empleados();
                MyEmpleado.Id = int.Parse(TxtID.Text);
                MyEmpleado.Nombre = TxtName.Text;
                MyEmpleado.Apellido = TxtSurname.Text;
                MyEmpleado.Edad = int.Parse(TxtAge.Text);
                MyEmpleado.Casado = chkMarried.Checked;
                baseDatos.Empleados.InsertOnSubmit(MyEmpleado);
                baseDatos.SubmitChanges();
                cargarBusqueda();
                cargarGrid();
            }

            catch
            {
                MessageBox.Show("Los datos no son correctos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleados MyEmpleado = baseDatos.Empleados.Single(Empleados => Empleados.Nombre == cbNombre2.SelectedItem.ToString());
            baseDatos.Empleados.DeleteOnSubmit(MyEmpleado);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarBusqueda();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbNombre2.SelectedItem.ToString());
            Empleados MyEmpleada = baseDatos.Empleados.Single(p => p.Nombre == cbNombre2.SelectedItem.ToString());
            MyEmpleada.Id = int.Parse(TxtID.Text);
            MyEmpleada.Nombre = TxtName.Text;
            MyEmpleada.Apellido = TxtSurname.Text;
            MyEmpleada.Edad = int.Parse(TxtAge.Text);
            MyEmpleada.Casado = chkMarried.Checked;
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarBusqueda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = cbNombre2.Text;
            var busqueda = from Empleados in baseDatos.Empleados
                           where Empleados.Nombre.Contains(nom)

                           select Empleados;
                GridDatos.DataSource = busqueda;

        }
    }
}

