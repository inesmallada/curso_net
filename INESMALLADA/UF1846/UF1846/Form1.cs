using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UF1846
{
    public partial class form : Form
    {
        //DEFINIMOS LA CLASE
        DataClasses1DataContext EXAMEN = new DataClasses1DataContext();

        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombo();
        }
        //CON SP HACEMOS UNA CONSULTA PARA QUE CARGUE EL GRID CON TODOS LOS PRODUCTOS
        void CargarGrid()
        {
            dataGridView1.DataSource = EXAMEN.SP_CargarGrid();
        }
        //CON SP HACEMOS UNA CONSULTA PARA QUE CARGUE EL COMBObOX CON TODOS LOS PRODUCTOS
        void CargarCombo()
        {
            cbEliminar.DataSource = EXAMEN.SP_CargarComboBox();
            cbEliminar.DisplayMember = "NombreProducto";
        }
        //BOTON PARA AÑADIR UN REGISTRO NUEVO
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //CONTROLA QUE ESTÉN TODOS LOS DATOS INTRODUCIDOS
            try
            {
                if (txtProducto.Text != "" && txtPrecio.Text != "" && txtStock.Text != "")
                {
                    //INTRODUCIMOS DATOS Y CARGAMOS EL GRID Y comboBox
                    EXAMEN.SP_INSERTAPRODUCTO(txtProducto.Text, int.Parse(txtPrecio.Text), int.Parse(txtStock.Text));
                    CargarGrid();
                    CargarCombo();
                }
            }//FIN TRY
            catch
            {
                if (txtProducto.Text == "" || txtPrecio.Text == "" || txtStock.Text == "") MessageBox.Show("Faltan datos");
            }
        }//FIN ANADIR

        //BOTON PARA DAR DE BAJA UN REGISTRO NUEVO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }//fin métoso elminar

        //BOTON PARA BUSCAR UN PRODUCTO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //COMPRUEBA QUE EL CUADRO DE BÚSQUEDA NO ESTÁ EN BLANCO
                if (txtBusqueda.Text != "")
                {
                    //CARGAMOS EL DATAGRID CON EL NOMBRE FILTRADO Y REFRESCAMOS EL GRID
                    dataGridView1.DataSource = EXAMEN.SP_CONSULTAPRODUCTO(txtBusqueda.Text);

                }
                else
                {
                    CargarGrid();
                    CargarCombo();
                }
            }//FIN TRY
            catch
            {
                //IF VALIDANDO EL TEXTBOX Y CONTROLANDO LAS RUTINAS DE CONSULTA
                MessageBox.Show("No existe");
            }
        }//FIN METODO

        //BOTON PARA MODIFICAR UN REGISTRO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EXAMEN.SP_MODPRODUCTO(txtProducto.Text, int.Parse(txtPrecio.Text), int.Parse(txtStock.Text));
                CargarCombo();
                CargarGrid();
            }//FIN TRY
            catch
            {
                if (txtProducto.Text == "" || txtPrecio.Text == "" || txtStock.Text == "") MessageBox.Show("Faltan datos");
            }
        }//FIN BTN MODIFICAR

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EXAMEN.SP_ELIMINARPRODUCTO(cbEliminar.Text);
                CargarGrid();
                CargarCombo();
            }//FIN TRY
            catch
            {
                if (cbEliminar.Text == "") MessageBox.Show("INTRODUCE EL NOMBRE DEL PRODUCTO A ELIMINAR");
            }
        }
    }//fin class
}//fin namespace
