using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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



        protected void btnAcceso_Click(object sender, EventArgs e)
        {
            var usuarioPersonal = txtUsuario.Value;
            var passPersonal = txtPass.Value;
            var usuario = txtUsuario.Value;
            var pass = txtPass.Value;
            if (usuario == "admin" && pass == "1234")
            {
                Response.Redirect("Nomina.aspx", true);
            }
            else if (usuario != "admin" || pass != "1234")
            {
                lblConfirmacion.Text = "Usuario no existente";
            }
            else
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand("select usuario, pass from Admin " +
                    "where usuario='" + this.txtUsuario.Value + "', '" + this.txtPass.Value + "'", conexion);

                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    lblConfirmacion.Text = "usuario" + registro["usuario"] + "<br/>" + "pass" + registro["pass"];
                }
                else
                {
                    lblConfirmacion.Text = "Personal Laboral no existente";
                }
                conexion.Close();

            }
        }
    }
} 