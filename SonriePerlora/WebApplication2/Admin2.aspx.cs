using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void PageLoad(object sender, EventArgs e)
        {
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            //string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            //SqlConnection conexion = new SqlConnection(s);
            //conexion.Open();
            var usuario = txtUsuario.Value;
            var pass = txtPass.Value;
            if (usuario == "admin" && pass == "1234")
            {
                lblConfirmacion.Text = "¡Hola de nuevo Admin!";
            }
            else
            {
                lblConfirmacion.Text = "Usuario no existente";
            }
            //SqlCommand comando = new SqlCommand("insert into usuarios(usuario,pass,tipo) VALUES('" + this.txtUsuario.Value + "','" + this.txtPass.Value + "')", conexion);
            //comando.ExecuteNonQuery();
            //conexion.Close();
        }
    }
}