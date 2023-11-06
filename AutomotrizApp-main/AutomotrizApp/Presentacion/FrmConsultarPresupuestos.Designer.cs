namespace AutomotrizApp.Presentacion
{
    partial class FrmConsultarPresupuestos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReiniciarFiltros = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.dgvConsultarPresupuestos = new System.Windows.Forms.DataGridView();
            this.txtTotalMax = new System.Windows.Forms.TextBox();
            this.txtTotalMin = new System.Windows.Forms.TextBox();
            this.dtpFechaMin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaMax = new System.Windows.Forms.DateTimePicker();
            this.idPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.Location = new System.Drawing.Point(561, 126);
            this.btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            this.btnReiniciarFiltros.Size = new System.Drawing.Size(107, 23);
            this.btnReiniciarFiltros.TabIndex = 15;
            this.btnReiniciarFiltros.Text = "Reiniciar Filtros";
            this.btnReiniciarFiltros.UseVisualStyleBackColor = true;
            this.btnReiniciarFiltros.Click += new System.EventHandler(this.btnReiniciarFiltros_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(683, 126);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 25);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Listado de Presupuestos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotal.Location = new System.Drawing.Point(58, 126);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFecha.Location = new System.Drawing.Point(51, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreProducto.Location = new System.Drawing.Point(64, 56);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(28, 15);
            this.lblNombreProducto.TabIndex = 12;
            this.lblNombreProducto.Text = "DNI";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDniCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDniCliente.Location = new System.Drawing.Point(98, 55);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(237, 20);
            this.txtDniCliente.TabIndex = 9;
            // 
            // dgvConsultarPresupuestos
            // 
            this.dgvConsultarPresupuestos.AllowUserToAddRows = false;
            this.dgvConsultarPresupuestos.AllowUserToDeleteRows = false;
            this.dgvConsultarPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultarPresupuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarPresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPresupuesto,
            this.nombreCliente,
            this.dniCliente,
            this.fechaPresupuesto,
            this.totalPresupuesto,
            this.Eliminar});
            this.dgvConsultarPresupuestos.Location = new System.Drawing.Point(12, 162);
            this.dgvConsultarPresupuestos.Name = "dgvConsultarPresupuestos";
            this.dgvConsultarPresupuestos.ReadOnly = true;
            this.dgvConsultarPresupuestos.RowHeadersVisible = false;
            this.dgvConsultarPresupuestos.Size = new System.Drawing.Size(746, 346);
            this.dgvConsultarPresupuestos.TabIndex = 17;
            this.dgvConsultarPresupuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarPresupuestos_CellContentClick);
            // 
            // txtTotalMax
            // 
            this.txtTotalMax.Location = new System.Drawing.Point(235, 125);
            this.txtTotalMax.Name = "txtTotalMax";
            this.txtTotalMax.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMax.TabIndex = 21;
            this.txtTotalMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerico_KeyPress);
            // 
            // txtTotalMin
            // 
            this.txtTotalMin.Location = new System.Drawing.Point(98, 125);
            this.txtTotalMin.Name = "txtTotalMin";
            this.txtTotalMin.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMin.TabIndex = 20;
            this.txtTotalMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerico_KeyPress);
            // 
            // dtpFechaMin
            // 
            this.dtpFechaMin.CustomFormat = "";
            this.dtpFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMin.Location = new System.Drawing.Point(98, 90);
            this.dtpFechaMin.Name = "dtpFechaMin";
            this.dtpFechaMin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaMin.TabIndex = 22;
            // 
            // dtpFechaMax
            // 
            this.dtpFechaMax.CustomFormat = "";
            this.dtpFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMax.Location = new System.Drawing.Point(235, 90);
            this.dtpFechaMax.Name = "dtpFechaMax";
            this.dtpFechaMax.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaMax.TabIndex = 23;
            // 
            // idPresupuesto
            // 
            this.idPresupuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idPresupuesto.HeaderText = "ID";
            this.idPresupuesto.Name = "idPresupuesto";
            this.idPresupuesto.ReadOnly = true;
            this.idPresupuesto.Visible = false;
            this.idPresupuesto.Width = 24;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // dniCliente
            // 
            this.dniCliente.HeaderText = "DNI";
            this.dniCliente.Name = "dniCliente";
            this.dniCliente.ReadOnly = true;
            // 
            // fechaPresupuesto
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaPresupuesto.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaPresupuesto.HeaderText = "Fecha";
            this.fechaPresupuesto.Name = "fechaPresupuesto";
            this.fechaPresupuesto.ReadOnly = true;
            // 
            // totalPresupuesto
            // 
            this.totalPresupuesto.HeaderText = "Total";
            this.totalPresupuesto.Name = "totalPresupuesto";
            this.totalPresupuesto.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Eliminar.HeaderText = "Accion";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 65;
            // 
            // FrmConsultarPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.dtpFechaMax);
            this.Controls.Add(this.dtpFechaMin);
            this.Controls.Add(this.txtTotalMax);
            this.Controls.Add(this.txtTotalMin);
            this.Controls.Add(this.btnReiniciarFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.dgvConsultarPresupuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarPresupuestos";
            this.Text = "FrmConsultarPresupuestos";
            this.Load += new System.EventHandler(this.FrmConsultarPresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarPresupuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReiniciarFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.DataGridView dgvConsultarPresupuestos;
        private System.Windows.Forms.TextBox txtTotalMax;
        private System.Windows.Forms.TextBox txtTotalMin;
        private System.Windows.Forms.DateTimePicker dtpFechaMin;
        private System.Windows.Forms.DateTimePicker dtpFechaMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPresupuesto;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}