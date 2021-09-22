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

        protected void btnBajaP_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from Personal where Nombre='" + this.ddlConsulta.SelectedItem.ToString() + "'", conexion);
             
             
               int Nombre = comando.ExecuteNonQuery();
               if (Nombre == 1)
                {
                    lblConfirmacionP.Text = "Se dió de baja correctamente";
                }
                else
                {
                    lblConfirmacionP.Text = "No existe una persona con ese Nombre";
                }
         conexion.Close();   
        }
        protected void btnModiP_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            
            try
            {   
                //si algun textbox está en blanco no funcionaría en if
                if (txtID.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" || txtDNI.Text == "" || txtNSS.Text == "" || txtLocalidad.Text == "" || txtCpostal.Text == "" || txtID_Departamento.Text == "" || ddlPuesto.Text == "")
                {   string genero="";
                    string ID = txtID.Text;
                    string nombre = txtNombre.Text;
                    string apellidos = txtApellidos.Text;
                    string DNI = txtDNI.Text;
                    string NSS = txtNSS.Text;
                    string Localidad = txtLocalidad.Text;
                    string Cpostal = txtCpostal.Text;
                    string ID_Departamento = txtID_Departamento.Text;
                    string Puesto = ddlPuesto.Text;
                    if (rdMasculino.Checked == true)
                    {
                        genero = "Masculino";
                    }
                    else if (rdFemenino.Checked == true)
                    {
                        genero = "Femenino";
                    }
                    else
                    {
                        genero = "Otro";
                    }

                    //definimos la cadena sql y la lanzamos
                    string cadena = "Update Personal set ID_Personal ='" + ID + "', Nombre=" + nombre + "', Apellidos = " + apellidos + "', Genero = " + genero +"', DNI = '" + DNI + "', NSS = '" + NSS + "',Localidad = " + Localidad + "', Cpostal = " + Cpostal +"where id=" + ID;
                    
                    
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    int cant;
                    //EN CASP DE MODIFICARSE CON EXITO SE GUARDA EN LA VARIABLE CANT
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        lblConfirmacionP.Text="Se modificaron los datos del artículo";
                    }
                    else
                    {
                        lblConfirmacionP.Text = "No existe ninguna persona con el ID ingresado";
                    }
                }//FIN IF
            } //FIN try
            catch
            {
                lblConfirmacionP.Text = "Ha habido algún error";
            }
            conexion.Close();
        }//FIN método

        protected void btnConsultaP_Click (object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Nombre from Personal " +
                "where Nombre'" + this.txtNombre.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.txtNombre.Text = registro["Nombre"].ToString();
            }
            else
            {
                this.txtNombre.Text = "No existe una persona contratada con dicho Nombre";
            }
            conexion.Close();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
                    SqlConnection conexion = new SqlConnection(s);
                    conexion.Open();
            
            if (rdFemenino.Checked == false || rdMasculino.Checked == false || rdOtro.Checked == false || txtID.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" || txtDNI.Text == "" || txtNSS.Text == "" || txtLocalidad.Text == "" || txtCpostal.Text == "" || txtID_Departamento.Text == "" || ddlPuesto.Text == "")
                {
                    lblConfirmacionP.Text = "Faltan campos por cubrir";
                }
                else
                {
                    string genero;
                    if (rdMasculino.Checked == true)
                    {
                        genero = "Masculino";
                    }
                    else if (rdFemenino.Checked == true)
                    {
                        genero = "Femenino";
                    }
                    else
                    {
                        genero = "Otro";
                    }
                    SqlCommand comando = new SqlCommand("insert into Personal(ID_Personal,Nombre,Apellidos,Genero,DNI, NSS, Localidad, Cpostal, ID_Departamento,Puesto) VALUES('" + this.txtID.Text + "','" + this.txtNombre.Text + "','" + this.txtApellidos.Text + "','" + genero + "','" + this.txtDNI.Text + "','" + this.txtNSS.Text + "','" + this.txtLocalidad.Text + "','" + this.txtCpostal.Text + "','" + this.txtID_Departamento.Text + "','" + this.ddlPuesto.Text + "')", conexion);
                    SqlCommand comando2 = new SqlCommand("insert into Admin(usuario, pass) VALUES('" + this.txtUsuario.Text + "','" + this.txtPass.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    comando2.ExecuteNonQuery();
                    lblConfirmacionP.Text = "Personal Laboral registrado";
                }
                 conexion.Close();    
        }
    
    }
}