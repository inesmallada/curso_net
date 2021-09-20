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
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            String genero;
            int op=0;
                switch (op)
                {
                    case 1 :
                    rdMasculino.Checked = true;
                        genero = "Masculino";
                        break;
                    case 2:
                    rdFemenino.Checked = true;
                        genero = "Femenino";
                        break;
                    case 3:
                    rdFemenino.Checked = true; 
                        genero = "Otro";
                        break;
                    default:
                        genero = "error";
                        break;
                }

            SqlCommand comando = new SqlCommand("insert into Personal(ID_Personal,Nombre,Apellidos,Genero,DNI, NSS, Localidad, Cpostal, ID_Departamento, TipoContrato, Puesto, TipoJornada, SalarioBruto, SalarioNeto) VALUES('" + this.txtID.Text + "','" + this.txtNombre.Text + "','" + this.txtApellidos.Text + "','" + genero + "','" + this.txtDNI.Text + "','" + this.txtNSS.Text + "','" + this.txtLocalidad.Text + "','" + this.txtCpostal.Text + "','" + this.txtID_Departamento.Text + "','" + this.ddlPuesto.Text + "')", conexion);
            comando.ExecuteNonQuery();
            lblConfirmacionP.Text = "Personal Laboral registrado";
            conexion.Close();
        }

        protected void btnBajaP_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from Personal where ID_Personal='" + this.txtID.Text + "'", conexion);
            int ID = comando.ExecuteNonQuery();
            if (ID == 1)
            {
                this.txtID.Text = "Se dió de baja correctamente";
            }
            else
            {
                this.txtID.Text = "No existe una persona con ese ID";
                conexion.Close();
            }
        }

        protected void btnModiP_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            
            try
            {   string genero="";
              //  comando.ExecuteNonQuery();
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
                   

                    //definimos la cadena sql y la lanzamos
                    string cadena = "Update Personal set ID_Personal ='" + ID + "', Nombre=" + nombre + "', Apellidos = " + apellidos + "', Genero = " + genero +"', DNI = '" + DNI + "', NSS = '" + NSS + "',Localidad = " + Localidad + "', Cpostal = " + Cpostal +"where id=" + ID;
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    int cant;
                    //EN CASP DE MODIFICARSE CON EXITO SE GUARDA EN LA VARIABLE CANT
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        lblConfirmacionP.Text="Se modificaron los datos del artículo";
                        txtID.Text="";
                        txtNombre.Text="";
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
                        lblConfirmacionP.Text = "No existe ninguna persona con el ID ingresado";
                        conexion.Close();
                        
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
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select ID_Personal from Personal " +
                "where ID_Personal'" + this.txtID.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.txtID.Text = registro["ID_Personal"].ToString();
            }
            else
            {
                this.txtID.Text = "No existe una persona contratada con dicho ID";
                conexion.Close();
            }
    }
    }
}