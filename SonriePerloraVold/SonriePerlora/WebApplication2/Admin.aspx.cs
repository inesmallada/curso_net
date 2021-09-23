using System;
using System.Collections.Generic;
using System.Data;
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
        public void logear()
        {
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("SELECT nombre, pass FROM Admin WHERE nombre='" + this.txtUsuario.Text + "' AND pass='" + this.txtPass.Text + "'", conexion);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    string tipo = this.dllTipo.Text;
                    if (tipo == "administrador" && this.txtUsuario.Text == "admin" && this.txtPass.Text == "1234")
                    {
                        Response.Redirect("Nomina.aspx", true);
                    }
                    else if (tipo == "personal")
                    {
                        Response.Redirect("Personal.aspx", true);
                    }
                    else if (tipo == "cliente")
                    {
                        Response.Redirect("Cliente.aspx", true);
                    }
                }
                else
                {
                    lblConfirmacion.Text = "El usuario o la contraseña son erróneos";
                }
                 conexion.Close();
            }
            catch
            {
                lblConfirmacion.Text = "El usuario o la contraseña son erróneos";
            }
        }
        public void btnAcceso_Click(object sender, EventArgs e)
        {
            logear();
            }
       
    }//fin class
}