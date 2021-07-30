
namespace FormularioLinQLambda
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCat = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.Categoría = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrec = new System.Windows.Forms.TextBox();
            this.TxtProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuevo Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.TxtCat);
            this.groupBox1.Controls.Add(this.TxtStock);
            this.groupBox1.Controls.Add(this.Categoría);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPrec);
            this.groupBox1.Controls.Add(this.TxtProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVO PRODUCTO";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(135, 134);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 23);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(10, 134);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 23);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Añadir";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCat
            // 
            this.TxtCat.Location = new System.Drawing.Point(136, 97);
            this.TxtCat.Name = "TxtCat";
            this.TxtCat.Size = new System.Drawing.Size(100, 20);
            this.TxtCat.TabIndex = 8;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(10, 97);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(100, 20);
            this.TxtStock.TabIndex = 7;
            // 
            // Categoría
            // 
            this.Categoría.AutoSize = true;
            this.Categoría.Location = new System.Drawing.Point(133, 80);
            this.Categoría.Name = "Categoría";
            this.Categoría.Size = new System.Drawing.Size(74, 13);
            this.Categoría.TabIndex = 6;
            this.Categoría.Text = "Precio Unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidades En Stock";
            // 
            // TxtPrec
            // 
            this.TxtPrec.Location = new System.Drawing.Point(135, 49);
            this.TxtPrec.Name = "TxtPrec";
            this.TxtPrec.Size = new System.Drawing.Size(100, 20);
            this.TxtPrec.TabIndex = 4;
            // 
            // TxtProd
            // 
            this.TxtProd.Location = new System.Drawing.Point(9, 49);
            this.TxtProd.Name = "TxtProd";
            this.TxtProd.Size = new System.Drawing.Size(100, 20);
            this.TxtProd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio Unidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre del Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(315, 59);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 12;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(442, 57);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 23);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar Producto";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(23, 222);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(519, 182);
            this.GridDatos.TabIndex = 13;
            this.GridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatos_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 425);
            this.Controls.Add(this.GridDatos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FORMULARIO CON LINQ";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCat;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label Categoría;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrec;
        private System.Windows.Forms.TextBox TxtProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView GridDatos;
    }
}

