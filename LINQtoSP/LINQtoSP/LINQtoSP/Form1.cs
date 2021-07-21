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
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarCliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.ModificarCliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
