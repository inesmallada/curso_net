using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCorriente
{
    public partial class Form1 : Form
    {
        //Creamos la clase de acceso a SQL server
        DataClasses1DataContext Cliente = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarInfo();
        }

        void listarInfo()
        {
            GridDatos.DataSource = Cliente.spListarInfo();
        }
        private void form_Load(object sender, EventArgs e)
        {
            this.listarInfo();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            Cliente.insertarCliente(TxtIdcliente.Text, TxtApellidos.Text, TxtNombre.Text);
           
            this.listarInfo();
                TxtNombre.Text = "";
                TxtApellidos.Text = "";
                TxtIdcliente.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
                Cliente.EliminarCliente(TxtIdcliente.Text);
                this.listarInfo();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Cliente.insertarCliente(TxtIdcliente.Text, TxtApellidos.Text, TxtNombre.Text);
            this.listarInfo();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (cBoxItems.Text == "IdCliente")
            {
                GridDatos.DataSource = Cliente.BuscarCliente(TxtBuscar2.Text);
               
            }
            else if (cBoxItems.Text == "Nombres")
            {
                GridDatos.DataSource = Cliente.BuscarNombre(TxtBuscar2.Text);
                
            }
            else
            {
                GridDatos.DataSource = Cliente.BuscarApellidos(TxtBuscar2.Text);
                
            }
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtBuscar2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Cliente.ModificarCliente(TxtIdcliente.Text, TxtApellidos.Text,TxtNombre.Text);
            this.listarInfo();
        }
    }
}
