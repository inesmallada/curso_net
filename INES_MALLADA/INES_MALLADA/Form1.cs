using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INES_MALLADA
{
    public partial class EXAMEN : Form
    {
        public EXAMEN()
        {
            InitializeComponent();
        }
        //DEFINIMOS LA CLASE
        DataClasses1DataContext dbEXAMEN = new DataClasses1DataContext();

        private void EXAMEN_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarGrid();
        }
        //CON LINQ HACEMOS UNA CONSULTA PARA QUE CARGUE EL GRID CON TODOS LOS PRODUCTOS
        void CargarGrid()
        {
            var cargarGrid = from p in dbEXAMEN.PRODUCTOS select p;
            dataGridView1.DataSource = cargarGrid;
        }
        //CON LINQ HACEMOS UNA CONSULTA PARA QUE CARGUE EL COMBObOX CON TODOS LOS PRODUCTOS
        void CargarCombo()
        {
            var CargarCombo = from p in dbEXAMEN.PRODUCTOS
                              select p.NombreProducto;
            cbSeleccion.DataSource = CargarCombo;
        }

        //BOTON PARA BUSCAR UN REGISTRO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
                try
                {
                    //COMPRUEBA QUE EL CUADRO DE BÚSQUEDA NO ESTÁ EN BLANCO
                    if (txtBusqueda.Text != "")
                    {
                        //SI NO ESTÁ EN BLANCO. si TENEMOS ALGO INTRODUCIDO. sE LE HACE UN LAMBDA CON LINQ
                        //OBTENEMOS LOS VALORES QUE CONTENGAN LA CADENA DE BÚSQUEDA.
                        //LA CADENA BUSCAR CON CONTAINS
                        PRODUCTOS MyProducto = dbEXAMEN.PRODUCTOS.Single(P =>P.NombreProducto.Contains(txtBusqueda.Text));

                        //CON ESTO CARGAMOS LOS TEXTBOX DE ABAJO PARA PODER MODIFICAR SUS VALORES EN CASO DE PEDIRLO
                        
                        txtNombre.Text = MyProducto.NombreProducto;
                        txtPrecio.Text = MyProducto.PrecioUnidad.ToString();
                        txtStock.Text = MyProducto.UnidadStock.ToString();
                        

                        //CON LINQ CARGAMOS EL GRID CON EL NOMBRE/CONTENIDO FILTRADO
                        //FILTRADO Y REFRESCAMOS
                        var buscarNombre = from PRODUCTOS in dbEXAMEN.PRODUCTOS where PRODUCTOS.NombreProducto.Contains(txtBusqueda.Text) select PRODUCTOS;

                        //CARGAMOS EL DATAGRID CON EL NOMBRE FILTRADO Y REFRESCAMOS EL GRID
                        dataGridView1.DataSource = buscarNombre;
                    }
                    //CARGAMOS TODO EL GRID CON TODOS LOS REGISTROS
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

        //BOTON PARA DAR DE ALTA UN REGISTRO NUEVO
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //CONTROLA QUE ESTÉN TODOS LOS DATOS INTRODUCIDOS
            try
                {
                if (txtNombre.Text != "" && txtPrecio.Text != "" && txtStock.Text != "")
                {
                    //DEFINIMOS UN OBJETO TIPO USUARIO
                    PRODUCTOS MyProductos = new PRODUCTOS();

                    MyProductos.NombreProducto = txtNombre.Text;
                    MyProductos.PrecioUnidad = int.Parse(txtPrecio.Text);
                    MyProductos.UnidadStock = short.Parse(txtStock.Text);

                    //INSERTONSUBMIT LO QUE ES AÑADIR EL REGISTRO EN LA DDBB
                    dbEXAMEN.PRODUCTOS.InsertOnSubmit(MyProductos);

                    //SUBMITCHANGES HACE EL COMMIT (CONFIRMACIÓN)
                    dbEXAMEN.SubmitChanges();
                
                    //CARGAMOS EL GRID Y comboBox
                    CargarGrid();
                    CargarCombo();
                }

            }//FIN TRY
                catch
                {
                if (txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "") MessageBox.Show("Faltan datos");
                }
        }//FIN BOTON ANADIR

        //BOTON PARA DAR DE BAJA UN REGISTRO NUEVO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
               try
                {
                    //DENTRO DEL TRY CREAMOS UN OBJETO DE TIPO USUARIO
                    //CON LAMBDA Y LOS OBTENEMOS DE LA DDBB DONDE COINDIDA EL NOMBRE DEL PRODUCTO
                    PRODUCTOS MyProduct = dbEXAMEN.PRODUCTOS.Single(u => u.NombreProducto == cbSeleccion.SelectedItem.ToString());
                    //DELETEONSUBMIT LO QUE ES ELIMINAR EL REGISTRO EN LA DDBB
                    dbEXAMEN.PRODUCTOS.DeleteOnSubmit(MyProduct);
                    //SUBMITCHANGES HACE EL COMMIT (CONFIRMACIÓN)
                    dbEXAMEN.SubmitChanges();
                    //CARGAMOS EL GRID Y comboBox
                    CargarGrid();
                    CargarCombo();
            }//FIN TRY
                catch
                {
                    if (cbSeleccion.Text == "") MessageBox.Show("INTRODUCE EL NOMBRE DEL PRODUCTO A ELIMINAR");
                }
        }//FIN ELIMINAR

        //BOTON PARA MODIFICAR UN REGISTRO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //TRY PARA PROBAR QUE TODOS LOS CAMPOS ESTÁN RELLENADOS
            //Y EL NOMBRE EXISTE
                try
                {
                    //LAMBDA PARA SACAR EL REGISTRO BUSCADO
                    PRODUCTOS MyProdu = dbEXAMEN.PRODUCTOS.Single(u => u.NombreProducto == cbSeleccion.SelectedItem.ToString());
                    MyProdu.PrecioUnidad = Int32.Parse(txtPrecio.Text);
                    MyProdu.UnidadStock = Int32.Parse(txtStock.Text);
                    //SUBMITCHANGES HACE EL COMMIT (CONFIRMACIÓN)
                    //ACTUALIZANDO LOS DATOS
                    dbEXAMEN.SubmitChanges();
                    //CARGAMOS EL GRID Y comboBox
                    CargarGrid();
                 }//FIN TRY
                catch
                {
                    if (txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "") MessageBox.Show("Faltan datos");
                }
        }//FIN BTN MODIFICAR
    }//FIN CLASS EXAMEN
}//FIN INES_MALLADA

