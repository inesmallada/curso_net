using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_MASTER_PAGE
{
    public partial class Bajas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SimulacroSQLMartesConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select id, nombre, apellido1, apellido2, ciudad, categoria from Clientes)" + " where id = '" + int.Parse(ddlID.Text) + "'" , conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.txtNombre.Text = registro["nombre"].ToString();
                this.txtApe1.Text = registro["apellido1"].ToString();
                this.txtApe2.Text = registro["apellido2"].ToString();
                this.txtCiudad.Text = registro["ciudad"].ToString();
                this.txtCategoria.Text = registro["categoria"].ToString();
            }
            else {
                this.txtError2.Text = "No existe un usuario con dicho id";
            }

            
            conexion.Close();
        }

        protected void btnModi_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SimulacroSQLMartesConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update Clientes set " +  "nombre = '" + this.txtNombre.Text + "', Apellido1 = '" +  this.txtApe1.Text + "', Apellido2 = '" + this.txtApe2.Text + "', Ciudad = '" + this.txtCiudad.Text + "', Categoria = '" + int.Parse(txtCategoria.Text) + "' where id ='" + int.Parse(ddlID.Text) + "'", conexion);
           int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
            {
                this.txtError2.Text = "Datos Modificados";
            }
            else
            {
                this.txtError2.Text = "No existe el cliente";
            }
            conexion.Close();
        }
    }
}