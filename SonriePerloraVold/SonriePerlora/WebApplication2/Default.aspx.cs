using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
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

                SqlCommand comando = new SqlCommand("SELECT Nombre, Apellidos, Mail FROM Cliente WHERE Nombre='" + this.txtName.Text + "', Nombre='" + this.txtSurname.Text + "' AND Mail='" + this.txtEmail.Text + "'", conexion);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                        Response.Redirect("Cliente.aspx", true);
                }
                else
                {
                    lblConfirmacion0.Text = "Ha surgido algún error";
                }
                conexion.Close();
            }
            catch
            {
                lblConfirmacion0.Text = "Ha surgido algún error";
            }
        }

        protected void btnAcceso_Click(object sender, EventArgs e)
        {
            logear();
        }
    }
}