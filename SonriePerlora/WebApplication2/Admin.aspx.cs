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
            var usuario = txtUsuario.Value;
            var pass = txtPass.Value;
            if (usuario == "admin" && pass == "1234")
            {
                Response.Redirect("Nomina.aspx", true);
            }
            else
            {
                lblConfirmacion.Text = "Usuario no existente";
            }
        }
    }
} 