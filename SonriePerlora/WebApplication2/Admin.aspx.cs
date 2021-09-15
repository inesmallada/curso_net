using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into usuarios(nombre,clave,mail) VALUES('" + this.txtNombre.Text + "','" + this.txtClave.Text + "','" + this.txtNombre.Text + "')", conexion);
            comando.ExecuteNonQuery();
            lblConfirmacion.Text = "Se registro el usuario";
            conexion.Close();
        }
    }
}