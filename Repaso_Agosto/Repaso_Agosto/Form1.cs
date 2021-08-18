using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Agosto
{
    public partial class Form1 : Form
    {
        //AÑADIMOS EL CONTEXTO DE ENTIDADES DE CLIENTES
        REPASO_AGOSTOEntities ClienteEntity = new REPASO_AGOSTOEntities();
        public Form1()
        {
            InitializeComponent();
            //INVOCAMOS AL EVENTO DE CARGARGRID
            CargarGrid();
        }

        //DEFINIMOS UN EVENTO PARA CARGAR EL GRID
        public void CargarGrid()
        {
            dataGridView.DataSource = ClienteEntity.Cliente.ToList();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Cliente Misclientes = new Cliente()
            {
                DNI = txtDNI.Text,
                NOMBRE = txtNombre.Text,
                APELLIDOS = txtApellidos.Text,
                ESTADO_CIVIL = cbEstado.Text,
                TELEFONO = txtTlfno.Text,
                EMAIL = txtEmail.Text,
                FECHA_NACIMIENTO = dtpFecha.Value,
            };
            ClienteEntity.Cliente.Add(Misclientes);
            ClienteEntity.SaveChanges();
            CargarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String TextoDNI = txtDNI.Text;
            var deleteCliente = ClienteEntity.Cliente.Where(c => c.DNI == TextoDNI).Single();
            ClienteEntity.Cliente.Remove(deleteCliente);
            ClienteEntity.SaveChanges();
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String TextoDNI = txtDNI.Text;
            Cliente MyCliente = (from cliente in ClienteEntity.Cliente where cliente.DNI == TextoDNI select cliente).Single();

            //MyCliente.DNI = txtDNI.Text;
            MyCliente.NOMBRE = txtNombre.Text;
            MyCliente.APELLIDOS = txtApellidos.Text;
            MyCliente.ESTADO_CIVIL = cbEstado.Text;
            MyCliente.TELEFONO = txtTlfno.Text;
            MyCliente.EMAIL = txtEmail.Text;
            MyCliente.FECHA_NACIMIENTO = dtpFecha.Value;
            ClienteEntity.SaveChanges();
            CargarGrid();
        }
    }
}
