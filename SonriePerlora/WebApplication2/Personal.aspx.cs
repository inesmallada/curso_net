using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication2
{
    public partial class Personal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAltaC_Click(object sender, EventArgs e)
        {
            if (txtID_Cliente.Text == "" || txtNombreC.Text == "" || txtApellidosC.Text == "" || txtDNIC.Text == "" || txtLocalidadC.Text == "" || txtCpostalC.Text == "")
            {
                lblConfirmacionC.Text = "FALTA ALGÚN DATO POR RELLENAR";
            }
            else
            {

                string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                string genero = "";
                if (rdMasculinoC.Checked == true)
                {
                    genero = "Masculino";
                }
                else if (rdFemeninoC.Checked == true)
                {
                    genero = "Femenino";
                }
                else if (rdOtroC.Checked == true)
                {
                    genero = "Otro";
                }
                SqlCommand comando = new SqlCommand("insert into Cliente(ID_Cliente,Nombre,Apellidos,Genero, DNI, Edad, Localidad, NumPersonas, Animales, Habitacion, Precio, FechaInicio, FechaFin,PackCamp, Dieta, Alergias,DiversidadFuncional,ID_Departamento) VALUES('" + txtID_Cliente.Text + "','" + this.txtNombreC.Text + "','" + this.txtApellidosC.Text + "', " + genero + " , '" + this.txtDNIC.Text + "', '" + 0 + "', '" + this.txtLocalidadC.Text + "','" + 0+ "','" + this.cblActividades.Text + "','" + "" + "',"' + "" + '")", conexion);
                comando.ExecuteNonQuery();
                SqlCommand comando2 = new SqlCommand("insert into Admin(usuario,pass, tipo)VALUES('" + this.txtUsuarioC.Text + "','" + this.txtPassC.Text + "','" + "Personal" + "')", conexion);
                lblConfirmacionC.Text = "Registro hecho correctamente.";
                Response.Redirect("Personal.aspx", true);
                conexion.Close();

            }

          
           //SqlCommand comando1 = new SqlCommand("insert into Cliente(ID_Cliente,Nombre,Apellidos,Genero, DNI, Edad, Localidad, NumPersonas, Animales, Habitacion, Precio, FechaInicio, FechaFin,PackCamp, Dieta, Alergias,DiversidadFuncional,ID_Departamento)" +
           //    "VALUES('" + this.txtID_Cliente.Text + "','" + this.txtNombreC.Text + "','" + this.txtApellidosC.Text + "', "+ genero + " , '" + this.txtDNIC.Text + "', '" +0+ "', '" + this.txtLocalidadC.Text + "','" + this.txtNumPersonas.Valu + "','" + this.cblActividades.Text + "',"+ alergias+","+alojamiento+ ")", conexion);
           // //'" + this.calAnio.Text + "',*/'" + this.txtNumPersonas.Text + "','"+ this.ddlDieta.Value +"' OJOOOOOOOOOOOOO
           // SqlCommand comando2 = new SqlCommand("insert into Admin(usuario,pass, tipo)VALUES('" + this.txtUsuarioC.Text + "','" + this.txtPassC.Text + "','" + "Cliente" + "')", conexion);
        }

        protected void btnBajaC_Click(object sender, EventArgs e)
        {

        }

        protected void btnModiC_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            try
            {
                string genero = "";
                //  comando.ExecuteNonQuery();
                //si algun textbox está en blanco no funcionaría en if
                if (txtID_Cliente.Text == "" || txtNombreC.Text == "" || txtApellidosC.Text == "" || txtDNIC.Text == "" || txtLocalidadC.Text == "" || txtCpostalC.Text == "")
                {
                    string ID = txtID_Cliente.Text;
                    string nombre = txtNombreC.Text;
                    string apellidos = txtApellidosC.Text;
                    string DNI = txtDNIC.Text;
                    string Localidad = txtLocalidadC.Text;
                    string Cpostal = txtCpostalC.Text;
                    string ID_Departamento = cblActividades.SelectedValue;
                    //definimos la cadena sql y la lanzamos
                    string cadena = "Update Cliente set ID_Cliente='" + ID + "', Nombre=" + nombre + "', Apellidos = " + apellidos + "', Genero = " + genero + "', DNI = '" + DNI + "', Localidad = " + Localidad + "', Cpostal = " + Cpostal + "', where Actividad=" + ID_Departamento;     
                        lblConfirmacionC.Text="Se modificaron los datos correctamente.";
                     
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    int cant;
                    //EN CASP DE MODIFICARSE CON EXITO SE GUARDA EN LA VARIABLE CANT
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        lblConfirmacionC.Text = "Se modificaron los datos correctamente.";
                        txtID_Cliente.Text = "";
                        txtNombreC.Text = "";
                        txtApellidosC.Text = "";
                        txtDNIC.Text = "";
                        txtLocalidadC.Text = "";
                        txtCpostalC.Text = "";
                        cblActividades.SelectedValue = "";
                    }

                    //    if (cblActividades.SelectedValue == "1")
                    //    {
                    //        ID_Departamento = "1";
                    //        Departamento = "Deportes Acuáticos";
                    //    }else if (cblActividades.SelectedValue == "2")
                    //    {
                    //        ID_Departamento = "2";
                    //        Departamento = "Senderismo";
                    //    }
                    //    else if (cblActividades.SelectedValue == "3")
                    //    {
                    //        ID_Departamento = "3";
                    //        Departamento = "Meditacion";
                    //    }
                    //    else if (cblActividades.SelectedValue == "4")
                    //    {
                    //        ID_Departamento = "4";
                    //        Departamento = "Bici";
                    //    }
                    //    else if (cblActividades.SelectedValue == "5")
                    //    {
                    //        ID_Departamento = "5";
                    //        Departamento = "Corporal";
                    //    }
                    //    else if (cblActividades.SelectedValue == "6")
                    //    {
                    //        ID_Departamento = "6";
                    //        Departamento = "Arte";
                    //    }
                    //}
                    else
                    {
                        lblConfirmacionC.Text = "No existe ninguna persona con el Nombre ingresado.";
                        conexion.Close();

                    }
                }//FIN IF
            } //FIN try
            catch
            {
                lblConfirmacionC.Text = "Ha habido algún error.";
            }
            conexion.Close();
        }//FIN método

        protected void btnConsultaC_Click(object sender, EventArgs e)
        {

        }
    }
}


