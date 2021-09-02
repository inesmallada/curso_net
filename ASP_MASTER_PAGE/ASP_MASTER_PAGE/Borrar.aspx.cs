using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_MASTER_PAGE
{
    public partial class Borrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SimulacroSQLMartesConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from Clientes where id = '" + int.Parse(ddlID2.Text) + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            string Error = txtError3.Text;
            if (cantidad == 1)
                txtError3.Text = "Se borró el usuario";
            else
                this.txtError3.Text = "No existe un usuario con dicho nombre";
            conexion.Close();
        }
    }
}