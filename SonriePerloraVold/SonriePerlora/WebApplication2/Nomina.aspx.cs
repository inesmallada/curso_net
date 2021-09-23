using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class Nomina : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" || txtDNI.Text == "" || txtNSS.Text == "" || txtLocalidad.Text == "" || txtCpostal.Text == "" || txtID_Departamento.Text == "" || ddlPuesto.Text == "")
            {
                lblConfirmacionP.Text = "FALTA ALGÚN DATO POR RELLENAR";
            }
            else
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                string genero = "";

                if (rdMasculino.Checked == true)
                {
                    genero = "Masculino";
                }
                else if (rdFemenino.Checked == true)
                {
                    genero = "Femenino";
                }
                else if (rdOtro.Checked == true)
                {
                    genero = "Otro";
                }

                SqlCommand comando = new SqlCommand("insert into Personal(ID_Personal,Nombre,Apellidos,Genero,DNI, NSS, Localidad, Cpostal, ID_Departamento, TipoContrato, Puesto, TipoJornada, SalarioBruto, SalarioNeto) VALUES('" + this.txtID.Text + "','" + this.txtNombre.Text + "','" + this.txtApellidos.Text + "','" + genero + "','" + this.txtDNI.Text + "','" + this.txtNSS.Text + "','" + this.txtLocalidad.Text + "','" + this.txtCpostal.Text + "','" + this.txtID_Departamento.Text + "','" + 0 + "','" + this.ddlPuesto.Text + "','" + 0 + "','" + 0 + "','" + 0 + "')", conexion);
                comando.ExecuteNonQuery();
                SqlCommand comando2 = new SqlCommand("insert into Admin(usuario,pass, tipo)VALUES('" + this.txtUsuario.Text + "','" + this.txtPass.Text + "','" + "Personal" + "')", conexion);
                lblConfirmacionP.Text = "Personal Laboral registrado.";
                Response.Redirect("Nomina.aspx", true);
                conexion.Close();

            }
        }

        protected void btnBajaP_Click(object sender, EventArgs e)
        { string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();


            SqlCommand comando = new SqlCommand("delete from Personal where Nombre='" + this.ddlConsulta.Text + "'", conexion);
            int Nombre = comando.ExecuteNonQuery();
            if (Nombre == 1)
            {
                this.lblConfirmacionP.Text = "Se dió de baja correctamente.";
                //TODO
                Response.Redirect("Nomina.aspx", true);
            }
            else
            {
                this.lblConfirmacionP.Text = "No existe una persona con ese Nombre.";
                conexion.Close();
            }
        }


        protected void btnModiP_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando1 = new SqlCommand("select ID_Personal, Nombre, Apellidos, DNI, NSS, Localidad, Cpostal, ID_Departamento, Puesto from Personal " +
                 "where Nombre='" + this.ddlConsulta.Text + "'", conexion);
            SqlDataReader registro = comando1.ExecuteReader();
            if (registro.Read())
            {
                this.txtNombre.Text = registro["Nombre"].ToString();
                this.txtID.Text = registro["ID_Personal"].ToString();
                this.txtApellidos.Text = registro["Apellidos"].ToString();
                this.txtDNI.Text = registro["DNI"].ToString();
                this.txtNSS.Text = registro["NSS"].ToString();
                this.txtLocalidad.Text = registro["Localidad"].ToString();
                this.txtCpostal.Text = registro["Cpostal"].ToString();
                this.txtID_Departamento.Text = registro["ID_Departamento"].ToString();
            }
            else
            {
                string ID = txtID.Text;
                string nombre = txtNombre.Text;
                string apellidos = txtApellidos.Text;
                string DNI = txtDNI.Text;
                string NSS = txtNSS.Text;
                string Localidad = txtLocalidad.Text;
                string Cpostal = txtCpostal.Text;
                string ID_Departamento = txtID_Departamento.Text;
                string Puesto = ddlPuesto.Text;
                //valor del radio button Genero
                string genero = "";
                if (rdMasculino.Checked == true)
                {
                    genero = "Masculino";
                }
                else if (rdFemenino.Checked == true)
                {
                    genero = "Femenino";
                }
                else if (rdOtro.Checked == true)
                {
                    genero = "Otro";
                }
                string cadena = "Update Personal set ID_Personal ='" + ID + "', Nombre='" + nombre + "', Apellidos = '" + apellidos + "', Genero = '" + genero + "', DNI = '" + DNI + "', NSS = '" + NSS + "', Localidad = '" + Localidad + "', Cpostal = '" + Cpostal + "', ID_Departamento = '" + ID_Departamento + "', Puesto = '" + Puesto + "', where Nombre='" + nombre;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant = 0;

                try
                {
                    //EN CASP DE MODIFICARSE CON EXITO SE GUARDA EN LA VARIABLE CANT
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        lblConfirmacionP.Text = "Se modificaron los datos correctamente.";
                        txtID.Text = "";
                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        txtDNI.Text = "";
                        txtNSS.Text = "";
                        txtLocalidad.Text = "";
                        txtCpostal.Text = "";
                        txtID_Departamento.Text = "";
                        ddlPuesto.Text = "";
                        Response.Redirect("Nomina.aspx", true);
                    }
                    else
                    {
                        lblConfirmacionP.Text = "No existe ninguna persona con el Nombre ingresado.";
                        conexion.Close();
                    }
                }//try
                catch
                {
                    // Log de exepcciones
                }
            }
        }
                protected void btnConsultaP_Click (object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select ID_Personal, Nombre, Apellidos, DNI, NSS, Localidad, CPostal, ID_Departamento, Puesto from Personal " +
                "where Nombre='" + this.ddlConsulta.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
             if (registro.Read())
            {
                this.txtNombre.Text = registro["Nombre"].ToString();
                this.txtID.Text = registro["ID_Personal"].ToString();
                this.txtApellidos.Text = registro["Apellidos"].ToString();
                this.txtDNI.Text = registro["DNI"].ToString();
                this.txtNSS.Text = registro["NSS"].ToString();
                this.txtLocalidad.Text = registro["Localidad"].ToString();
                this.txtCpostal.Text = registro["Cpostal"].ToString();
                this.txtID_Departamento.Text = registro["ID_Departamento"].ToString();
                this.ddlPuesto.Text = registro["Puesto"].ToString();
                this.txtUsuario.Text = registro["Nombre"].ToString();
                this.txtPass.Text = registro["DNI"].ToString();
            }
            else
            {
                this.lblConfirmacionP.Text = "No existe una persona contratada con dicho Nombre";
                conexion.Close();
            }
        }
    }
}