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
        //AÑADIMOS EL CONTEXTO/MODELO DE ENTIDADES DE CLIENTES
        REPASO_AGOSTOEntities ClienteEntity = new REPASO_AGOSTOEntities();
        public Form1()
        {
            InitializeComponent();
            //INVOCAMOS AL EVENTO DE CARGARGRID AL CARGAR EL FORMULARIO
            CargarGrid();
        }

        //DEFINIMOS UN EVENTO PARA CARGAR EL GRID
        public void CargarGrid()
        {
            dataGridView.DataSource = ClienteEntity.Cliente.ToList();
            //CON LINQ SERÍA: dataGridView.DataSource = FROM CLIENTE IN cLIENTEeNTITY.cLIENTE SELECT CLIENTE;; 
        }

        //BOTÓN PARA AGREGAR REGISTRO
        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                //CREAMOS UN NUEVO CLIENTE CON LOS CONTENIDOS DE LOS TEXTBOX
                Cliente Misclientes = new Cliente() //CLIENTE ES LA TABLA DE SQL
                {
                    DNI = txtDNI.Text,
                    NOMBRE = txtNombre.Text,
                    APELLIDOS = txtApellidos.Text,
                    ESTADO_CIVIL = cbEstado.Text,
                    TELEFONO = txtTlfno.Text,
                    EMAIL = txtEmail.Text,
                    FECHA_NACIMIENTO = dtpFecha.Value,
                };

                //LLAMAMOS AL CONTEXTO DE ENTIDADES: ENTITY CONTEXT. Y AÑADIMOS AL OBJETO CLIENTE
                ClienteEntity.Cliente.Add(Misclientes);

                //GUARDAR EL NUEVO REGISTRO EN LA BASE DE DATOS
                //LA SENTENCIA SAVECHANGES ES GLOBA TANTO PARA CLASES TIPO LINQ COMO PARA ENTITY
                ClienteEntity.SaveChanges();
            }
            //MOSTRAMOS MENSAJE MÁS CONCRETO DE QUÉ DATO FALTA
            catch
            {
                if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" || cbEstado.Text == "" || txtTlfno.Text == "" || txtEmail.Text == "" || dtpFecha.Text == "")
                {
                    MessageBox.Show("Falta algún campo por cubrir");
                } else 
                {
                    MessageBox.Show("El DNI está duplicado");
                }
            }

            //REFRESCAMOS DATAGRID
            CargarGrid();
        }
        //BOTON BUSCAR REGISTRO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Text == "") MessageBox.Show("TIENES QUE INTRODUCIR UN DNI");
                else
                {
                    String TextoDNI = txtDNI.Text;
                    //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
                    var BuscarCliente = ClienteEntity.Cliente.Where(c => c.DNI == TextoDNI).Single();

                    //MÉTODO LINQ PARA CONSEGUIR UN CLIENTE POR DNI QUE DEVUELVE UN SOLO REGISTRO OJOOO!!!!!
                    //TANTO EL LAMBDA COMO EL LINQ INDISTINTAMENTE. OBTENEMOS LO MISMO.
                    //Cliente MyCliente = (from cliente in ClienteEntity.Cliente where cliente.DNI == TextoDNI select cliente).Single();

                    txtNombre.Text = BuscarCliente.NOMBRE;
                    txtApellidos.Text = BuscarCliente.APELLIDOS;
                    cbEstado.Text = BuscarCliente.ESTADO_CIVIL;
                    txtTlfno.Text = BuscarCliente.TELEFONO;
                    txtEmail.Text = BuscarCliente.EMAIL;
                    dtpFecha.Text = BuscarCliente.FECHA_NACIMIENTO.ToString();
                }
            }
            catch { MessageBox.Show("Revisa los datos introducidos"); }

        }
        //BOTON ELIMINAR REGISTRO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //DEFINIMOS UNA VARIABLE QUE GUARDA EL DNI
            String TextoDNI = txtDNI.Text;
            //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
            var deleteCliente = ClienteEntity.Cliente.Where(c => c.DNI == TextoDNI).Single();

            //MÉTODO LINQ PARA CONSEGUIR UN CLIENTE POR DNI. 
            //TANTO EL LAMBDA COMO EL LINQ INDISTINTAMENTE. OBTENEMOS LO MISMO.
            //Cliente MyCliente = (from cliente in ClienteEntity.Cliente where cliente.DNI == TextoDNI select cliente).Single();

            //BORRAMOS AL CLIENTE CUYO DNI CORRESPONDE CON EL SELECCIONADO
            ClienteEntity.Cliente.Remove(deleteCliente);
            //PARA CONFIRMAR LOS CAMBIOS EN  DDBB
            ClienteEntity.SaveChanges();
            //REFRESCAMOS DATAGRID
            CargarGrid();
        }
        //BOTON MODIFICAR REGISTRO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //DEFINIMOS UNA VARIABLE QUE GUARDA EL DNI QUE OJO DEBERÍA ESTAR CONTROLADO
                if (txtDNI.Text == "") MessageBox.Show("TIENES QUE INTRODUCIR UN DNI");
                else
                {

                    String TextoDNI = txtDNI.Text;


                    //MÉTODO LAMBDA CON LINQ DENTRO CONSIGUE/BUSCA A UN CLIENTE POR SU DNI
                    Cliente MyCliente = (from cliente in ClienteEntity.Cliente where cliente.DNI == TextoDNI select cliente).Single();

                    //DEFINIMOS LOS ATRIBUTOS DEL OBJETO MyCLIENTE
                    //NO SE PUEDE MODIFICAR EL DNI
                    //MyCliente.DNI = txtDNI.Text;
                    MyCliente.NOMBRE = txtNombre.Text;
                    MyCliente.APELLIDOS = txtApellidos.Text;
                    MyCliente.ESTADO_CIVIL = cbEstado.Text;
                    MyCliente.TELEFONO = txtTlfno.Text;
                    MyCliente.EMAIL = txtEmail.Text;
                    MyCliente.FECHA_NACIMIENTO = dtpFecha.Value;

                    //HACEMOS UN SALVADO EN LA BASE DE DATOS
                    ClienteEntity.SaveChanges();
                    }//CIERRE ELSE
                   
                }
                    catch { MessageBox.Show("iNTRODUZCA UN NÚMERO CORRECTO"); }
                
                //REFRESCAMOS DATAGRID
                    CargarGrid();
         
        }
        //BOTON IR PRIMER REGISTRO
        private void btnInicio_Click(object sender, EventArgs e)
        {
             //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
            var BuscarCliente = ClienteEntity.Cliente.First(); //eliminamos el where(la condición no es necesaria porque queremos el primer registrado)

            txtDNI.Text = BuscarCliente.DNI;
            txtNombre.Text = BuscarCliente.NOMBRE;
            txtApellidos.Text = BuscarCliente.APELLIDOS;
            cbEstado.Text = BuscarCliente.ESTADO_CIVIL;
            txtTlfno.Text = BuscarCliente.TELEFONO;
            txtEmail.Text = BuscarCliente.EMAIL;
            dtpFecha.Text = BuscarCliente.FECHA_NACIMIENTO.ToString();
        }

        //BOTON IR ULTIMO REGISTRO
        private void button1_Click(object sender, EventArgs e)
        {
            //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
            var BuscarCliente = ClienteEntity.Cliente.ToList().Last(); //eliminamos el where(la condición no es necesaria porque queremos el último registrado)

            txtDNI.Text = BuscarCliente.DNI;
            txtNombre.Text = BuscarCliente.NOMBRE;
            txtApellidos.Text = BuscarCliente.APELLIDOS;
            cbEstado.Text = BuscarCliente.ESTADO_CIVIL;
            txtTlfno.Text = BuscarCliente.TELEFONO;
            txtEmail.Text = BuscarCliente.EMAIL;
            dtpFecha.Text = BuscarCliente.FECHA_NACIMIENTO.ToString();
        }

        //BOTON RETROCEDER REGISTRO
        private void btnAtras_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
                int anterior = dataGridView.CurrentRow.Index - 1;

            //NOS DESPLAZAMOS a la fila anterior
            dataGridView.CurrentCell = dataGridView.Rows[anterior].Cells[dataGridView.CurrentCell.ColumnIndex];

            //AQUÍ CARGAMOS EN EL TEXTBOX EL DNI
            txtDNI.Text = dataGridView.Rows[anterior].Cells[0].Value.ToString();
            
            txtNombre.Text = dataGridView.Rows[anterior].Cells[1].Value.ToString();
            txtApellidos.Text = dataGridView.Rows[anterior].Cells[2].Value.ToString();
            cbEstado.Text = dataGridView.Rows[anterior].Cells[3].Value.ToString();
            txtTlfno.Text = dataGridView.Rows[anterior].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView.Rows[anterior].Cells[5].Value.ToString();
            dtpFecha.Text = dataGridView.Rows[anterior].Cells[6].Value.ToString();
            }
            catch { }
        }

        //BOTON AVANZAR REGISTRO
        private void btnAlante_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
                int anterior = dataGridView.CurrentRow.Index + 1;

                //NOS DESPLAZAMOS a la fila anterior
                dataGridView.CurrentCell = dataGridView.Rows[anterior].Cells[dataGridView.CurrentCell.ColumnIndex];

                //AQUÍ CARGAMOS EN EL TEXTBOX EL DNI
                txtDNI.Text = dataGridView.Rows[anterior].Cells[0].Value.ToString();

                txtNombre.Text = dataGridView.Rows[anterior].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView.Rows[anterior].Cells[2].Value.ToString();
                cbEstado.Text = dataGridView.Rows[anterior].Cells[3].Value.ToString();
                txtTlfno.Text = dataGridView.Rows[anterior].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView.Rows[anterior].Cells[5].Value.ToString();
                dtpFecha.Text = dataGridView.Rows[anterior].Cells[6].Value.ToString();
            }
            catch { }
        }
    }
}