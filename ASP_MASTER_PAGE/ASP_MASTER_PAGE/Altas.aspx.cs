﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_MASTER_PAGE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAnadir_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SimulacroSQLMartesConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Cliente (id, nombre, apellido1, apellido2, ciudad, categoria) values ('" + int.Parse(txtID.Text) + "','" + txtNombre.Text + "', '" + txtApe1.Text + "' , '" + txtApe2.Text + "' ,'" + txtCiudad.Text + "', '" + int.Parse(txtCategoria.Text) + "')", conexion);
            comando.ExecuteNonQuery();
            string Error= txtError.Text = "Se registró el usuario";
            conexion.Close();
        }
    }
}