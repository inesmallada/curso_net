﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUCANET_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext baseDatos = new DataClasses1DataContext();

         void cargarGrid()
        {
            var cargarGrid = from Enfermo in baseDatos.Enfermo select Enfermo;
            GridDatos.DataSource = cargarGrid;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Enfermo MyEnfermo = new Enfermo();
            MyEnfermo.inscripcion = int.Parse(txtInscripcion.Text);
            MyEnfermo.Apellido = txtNombre.Text;
            MyEnfermo.Direccion = txtDireccion.Text;
            MyEnfermo.NSS = int.Parse(txtNSS.Text);
            MyEnfermo.Fecha_Nac = dtpNac.Value;

            if (rdMasc.Checked == true)
            {
                MyEnfermo.S = "H";
            }
            else 
            {
                MyEnfermo.S = "M";
            }
            
            baseDatos.Enfermo.InsertOnSubmit(MyEnfermo);
            baseDatos.SubmitChanges();
            cargarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Enfermo MyEnferma = baseDatos.Enfermo.Single(Enfermo => Enfermo.Cod_Hospital == txtCod_Hospital.Text);
            MyEnferma.inscripcion = int.Parse(txtInscripcion.Text);
            MyEnferma.Apellido = txtNombre.Text;
            MyEnferma.Direccion = txtDireccion.Text;
            MyEnferma.NSS = int.Parse(txtNSS.Text);
            MyEnferma.Fecha_Nac = dtpNac.Value;
            baseDatos.SubmitChanges();
            cargarGrid();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtInscripcion.Text = "";
            txtNombre.Text = "";
            txtNombre.Text = "";
            txtNSS.Text = "";
            dtpNac.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}
