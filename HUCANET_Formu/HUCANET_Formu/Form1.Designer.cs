
namespace HUCANET_Formu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rdFem = new System.Windows.Forms.RadioButton();
            this.rdMasc = new System.Windows.Forms.RadioButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.txtNSS = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HUCANET, PROYECTO DE GESTIÓN DE HOSPITALES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.gbGenero);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.dtpNac);
            this.panel1.Controls.Add(this.txtNSS);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Controls.Add(this.txtInscripcion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 375);
            this.panel1.TabIndex = 2;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rdFem);
            this.gbGenero.Controls.Add(this.rdMasc);
            this.gbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbGenero.Location = new System.Drawing.Point(75, 92);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(268, 49);
            this.gbGenero.TabIndex = 15;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rdFem
            // 
            this.rdFem.AutoSize = true;
            this.rdFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rdFem.Location = new System.Drawing.Point(173, 21);
            this.rdFem.Name = "rdFem";
            this.rdFem.Size = new System.Drawing.Size(71, 17);
            this.rdFem.TabIndex = 1;
            this.rdFem.TabStop = true;
            this.rdFem.Text = "Femenino";
            this.rdFem.UseVisualStyleBackColor = true;
            // 
            // rdMasc
            // 
            this.rdMasc.AutoSize = true;
            this.rdMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rdMasc.Location = new System.Drawing.Point(70, 21);
            this.rdMasc.Name = "rdMasc";
            this.rdMasc.Size = new System.Drawing.Size(73, 17);
            this.rdMasc.TabIndex = 0;
            this.rdMasc.TabStop = true;
            this.rdMasc.Text = "Masculino";
            this.rdMasc.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(143, 158);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 14;
            // 
            // dtpNac
            // 
            this.dtpNac.Location = new System.Drawing.Point(143, 158);
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.Size = new System.Drawing.Size(200, 20);
            this.dtpNac.TabIndex = 14;
            // 
            // txtNSS
            // 
            this.txtNSS.Location = new System.Drawing.Point(143, 237);
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(202, 20);
            this.txtNSS.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(143, 195);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(202, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnInsertar);
            this.panel2.Controls.Add(this.btnLeer);
            this.panel2.Controls.Add(this.btnGrabar);
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 70);
            this.panel2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hechas las modificaciones en la base de datos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(281, 31);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(212, 31);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 30);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(143, 31);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(63, 30);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "INSERT";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeer.Location = new System.Drawing.Point(75, 31);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(63, 30);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "LEER";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrabar.FlatAppearance.BorderSize = 3;
            this.btnGrabar.Location = new System.Drawing.Point(7, 31);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(63, 30);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(143, 195);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(202, 20);
            this.txtDir.TabIndex = 11;
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Location = new System.Drawing.Point(143, 27);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.Size = new System.Drawing.Size(202, 20);
            this.txtInscripcion.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(9, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Número de la SS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(44, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(59, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(44, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(59, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre y Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(38, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inscripción";
            // 
            // GridDatos
            // 
            this.GridDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(366, 57);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(351, 375);
            this.GridDatos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 444);
            this.Controls.Add(this.GridDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de Gestión de Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rdFem;
        private System.Windows.Forms.RadioButton rdMasc;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtNSS;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

