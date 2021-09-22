using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Nomina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            String genero="";

            if (rdMasculino.Checked == true) {
                genero = "Masculino";
            } else if (rdFemenino.Checked == true) {
                genero = "Femenino";
            } else if (rdOtro.Checked == true) {
                genero = "Otro";
            }
             
            SqlCommand comando = new SqlCommand("insert into Personal(ID_Personal,Nombre,Apellidos,Genero,DNI, NSS, Localidad, Cpostal, ID_Departamento, TipoContrato, Puesto, TipoJornada, SalarioBruto, SalarioNeto) VALUES('" + this.txtID.Text + "','" + this.txtNombre.Text + "','" + this.txtApellidos.Text + "','" + genero + "','" + this.txtDNI.Text + "','" + this.txtNSS.Text + "','" + this.txtLocalidad.Text + "','" + this.txtCpostal.Text + "','" + this.txtID_Departamento.Text + "','" + 0 + "','" + this.ddlPuesto.Text + "','" + 0 + "','" + 0 + "','" + 0 + "')", conexion); 
            comando.ExecuteNonQuery();
            SqlCommand comando2 = new SqlCommand("insert into Admin(usuario,pass, tipo)VALUES('" + this.txtUsuario.Text + "','" + this.txtPass.Text + "','"+"Personal"+"')", conexion);
            lblConfirmacionP.Text = "Personal Laboral registrado.";
            conexion.Close();
        }

        protected void btnBajaP_Click(object sender, EventArgs e)
        {   string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            RequiredFieldValidator13.Enabled = false;
            RequiredFieldValidator10.Enabled = false;
            RequiredFieldValidator9.Enabled = false;
            RequiredFieldValidator8.Enabled = false;
            RequiredFieldValidator7.Enabled = false;
            RequiredFieldValidator6.Enabled = false;
            RequiredFieldValidator5.Enabled = false;
            RequiredFieldValidator4.Enabled = false;
            RequiredFieldValidator3.Enabled = false;
            
            
            SqlCommand comando = new SqlCommand("delete from Personal where Nombre='" + this.ddlConsulta.Text + "'", conexion);
            int Nombre = comando.ExecuteNonQuery();
            if (Nombre == 1)
            {
                this.txtNombre.Text = "Se dió de baja correctamente.";
            }
            else
            {
                this.txtNombre.Text = "No existe una persona con ese Nombre.";
                conexion.Close();
            }
        }

        protected void btnModiP_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            
            try
            {
                //si algun textbox está en blanco no funcionaría en if
                if (txtID.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" || txtDNI.Text == "" || txtNSS.Text == "" || txtLocalidad.Text == "" || txtCpostal.Text == "" || txtID_Departamento.Text == "" || ddlPuesto.Text == "")
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
                    //definimos la cadena sql y la lanzamos
                    string cadena = "Update Personal set ID_Personal ='" + ID + "', Nombre=" + nombre + "', Apellidos = " + apellidos + "', Genero = " + genero + "', DNI = '" + DNI + "', NSS = '" + NSS + "',Localidad = " + Localidad + "', Cpostal = " + Cpostal + "', where id=" + ID;
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    int cant;

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
                    }
                    else
                    {
                        lblConfirmacionP.Text = "No existe ninguna persona con el Nombre ingresado.";
                        conexion.Close();

                    }
                }//FIN IF
            } //FIN try
            catch
            {
                lblConfirmacionP.Text = "Ha habido algún error.";
            }
            conexion.Close();
        }//FIN método

        protected void btnConsultaP_Click (object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Nombre from Personal " +
                "where Nombre'" + this.ddlConsulta.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.txtNombre.Text = registro["Nombre"].ToString();
            }
            else
            {
                this.txtNombre.Text = "No existe una persona contratada con dicho Nombre";
                conexion.Close();
            }
        }
    }
}