using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerASP.NET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Label1.Text);
            x++;
            Label1.Text = x.ToString();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int resultado, x1, x2;
            x1 = int.Parse(TextBox1.Text);
            x2 = int.Parse(TextBox2.Text);

            // If Item1 is selected and radioButton2 
            // is checked, click radioButton1.
            if (RadioButtonList1.Text == "sumar" && radioButton2.Checked)
            {
                radioButton1.PerformClick();
            }


            if (RadioButtonList1.SelectedItem == 1)
            {
                resultado = x1 + x2;
                Label3.Text = "La suma de los dos valores es:" + resultado;
            }
            if (2.Checked)
            {
                resultado = x1 - x2;
                Label3.Text = "La resta de los dos valores es:" + resultado;
            }
        }
    }
}