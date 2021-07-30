using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormularioLinQLambda
{
   
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext baseDatos = new DataClasses1DataContext();
        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }

        void cargarCombo()
        {
            var cargarCombo = from p in baseDatos.Products
                select p.ProductName;
            cbProducto.DataSource = cargarCombo;
        }

        void cargarGrid()
        {
            var cargarGrid = from p in baseDatos.Products select p;
            GridDatos.DataSource = cargarGrid;
        }

    
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = TxtProd.Text.ToString();
            MyProduct.UnitPrice = int.Parse(TxtPrec.Text);
            MyProduct.UnitsInStock = short.Parse(TxtStock.Text);
            MyProduct.CategoryID = int.Parse(TxtCat.Text);
            baseDatos.Products.InsertOnSubmit(MyProduct);
            baseDatos.SubmitChanges();
            cargarCombo();
            cargarGrid();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            Products MyProducts = baseDatos.Products.Single(p => p.ProductName == cbProducto.SelectedItem.ToString());
            baseDatos.Products.DeleteOnSubmit(MyProducts);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbProducto.SelectedItem.ToString());
            Products MyProducto = baseDatos.Products.Single(p =>
            p.ProductName == cbProducto.SelectedItem.ToString());
            MyProducto.ProductName = cbProducto.SelectedItem.ToString();
            MyProducto.UnitPrice= int.Parse(TxtPrec.Text);
            MyProducto.UnitsInStock = short.Parse(TxtStock.Text);
            MyProducto.CategoryID = int.Parse(TxtCat.Text);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
        }



        private void GridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
