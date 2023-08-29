namespace CarpinteriaApp.Formularios
{
    partial class FrmNuevoPresupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPresupuestoNro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresupuestoNro
            // 
            this.lblPresupuestoNro.AutoSize = true;
            this.lblPresupuestoNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuestoNro.Location = new System.Drawing.Point(13, 23);
            this.lblPresupuestoNro.Name = "lblPresupuestoNro";
            this.lblPresupuestoNro.Size = new System.Drawing.Size(143, 20);
            this.lblPresupuestoNro.TabIndex = 0;
            this.lblPresupuestoNro.Text = "Presupuesto N°: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "% Descuento:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(181, 64);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(141, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(181, 98);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(255, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(181, 132);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(141, 20);
            this.txtDescuento.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(279, 176);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(157, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(17, 178);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(247, 21);
            this.cboProducto.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregar.Location = new System.Drawing.Point(461, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColProducto,
            this.ColPrecio,
            this.ColCantidad,
            this.ColAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(12, 215);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(549, 150);
            this.dgvDetalles.TabIndex = 10;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 205;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sub Total $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total $";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(461, 379);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(461, 413);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAceptar.Location = new System.Drawing.Point(189, 443);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.Location = new System.Drawing.Point(287, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevoPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 478);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPresupuestoNro);
            this.Name = "FrmNuevoPresupuesto";
            this.Text = "Nuevo Presupuesto";
            this.Load += new System.EventHandler(this.FrmNuevoPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresupuestoNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}