using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSP
{
    public partial class form : Form
    {
        //Creamos la clase de acceso a SQL Server
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public form()
        {
            InitializeComponent();
            this.listarClientes(); //incluir esto permite actualizar una vez inicializado el formulario
        }
        void listarClientes()
        {
            GridDatos.DataSource = ClienteLinq.spListarClientes();//aquí lo que conseguimos es que el listado aparezca en la grid de datos
        }
        private void form_Load(object sender, EventArgs e)
        {
            this.listarClientes();
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarCliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarClientes();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.ModificarCliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarClientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
            this.listarClientes();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridDatos.DataSource = ClienteLinq.BuscarCliente(TxtBuscar.Text);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtTelefono.Text = "";
            TxtBuscar.Text = "";
        }
    }
}
