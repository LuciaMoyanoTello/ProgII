namespace ProductosConInterface
{
    partial class FrmProducto
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.rbtSuelto = new System.Windows.Forms.RadioButton();
            this.rbtPack = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMedidaCantidad = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(26, 357);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(126, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar Producto";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPO";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(354, 22);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(341, 303);
            this.lstProductos.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // rbtSuelto
            // 
            this.rbtSuelto.AutoSize = true;
            this.rbtSuelto.Checked = true;
            this.rbtSuelto.Location = new System.Drawing.Point(116, 12);
            this.rbtSuelto.Name = "rbtSuelto";
            this.rbtSuelto.Size = new System.Drawing.Size(55, 17);
            this.rbtSuelto.TabIndex = 4;
            this.rbtSuelto.TabStop = true;
            this.rbtSuelto.Text = "Suelto";
            this.rbtSuelto.UseVisualStyleBackColor = true;
            this.rbtSuelto.CheckedChanged += new System.EventHandler(this.rbtSuelto_CheckedChanged);
            // 
            // rbtPack
            // 
            this.rbtPack.AutoSize = true;
            this.rbtPack.Location = new System.Drawing.Point(199, 12);
            this.rbtPack.Name = "rbtPack";
            this.rbtPack.Size = new System.Drawing.Size(50, 17);
            this.rbtPack.TabIndex = 5;
            this.rbtPack.Text = "Pack";
            this.rbtPack.UseVisualStyleBackColor = true;
            this.rbtPack.CheckedChanged += new System.EventHandler(this.rbtPack_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(42, 242);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(42, 13);
            this.lblMedida.TabIndex = 9;
            this.lblMedida.Text = "Medida";
            this.lblMedida.Click += new System.EventHandler(this.lblMedida_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(116, 183);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(133, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtMedidaCantidad
            // 
            this.txtMedidaCantidad.Location = new System.Drawing.Point(118, 235);
            this.txtMedidaCantidad.Name = "txtMedidaCantidad";
            this.txtMedidaCantidad.Size = new System.Drawing.Size(133, 20);
            this.txtMedidaCantidad.TabIndex = 12;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(206, 357);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 23);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar Total";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "TOTAL $";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(543, 360);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 426);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtMedidaCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtPack);
            this.Controls.Add(this.rbtSuelto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Name = "FrmProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rbtSuelto;
        private System.Windows.Forms.RadioButton rbtPack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMedidaCantidad;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

