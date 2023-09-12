namespace proyectoCarrera
{
    partial class FrmNuevaCarrera
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(12, 20);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(62, 13);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "CARRERA:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(283, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TITULO:";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(92, 13);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(172, 20);
            this.txtCarrera.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(338, 17);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(219, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(170, 66);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 13);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "AÑO:";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(108, 105);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(95, 13);
            this.lblCuatrimestre.TabIndex = 5;
            this.lblCuatrimestre.Text = "CUATRIMESTRE:";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(123, 146);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(80, 13);
            this.lblAsignatura.TabIndex = 7;
            this.lblAsignatura.Text = "ASIGNATURA:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(234, 63);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(131, 20);
            this.txtAño.TabIndex = 8;
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(234, 102);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(131, 20);
            this.txtCuatrimestre.TabIndex = 9;
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(234, 143);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(217, 21);
            this.cboAsignatura.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(244, 194);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColAño,
            this.ColCuatrimestre,
            this.ColAsignatura,
            this.ColAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(33, 235);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(505, 150);
            this.dgvDetalles.TabIndex = 13;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 30;
            // 
            // ColAño
            // 
            this.ColAño.HeaderText = "Año";
            this.ColAño.Name = "ColAño";
            this.ColAño.ReadOnly = true;
            this.ColAño.Width = 80;
            // 
            // ColCuatrimestre
            // 
            this.ColCuatrimestre.HeaderText = "Cuatrimestre";
            this.ColCuatrimestre.Name = "ColCuatrimestre";
            this.ColCuatrimestre.ReadOnly = true;
            this.ColCuatrimestre.Width = 80;
            // 
            // ColAsignatura
            // 
            this.ColAsignatura.HeaderText = "Asignatura";
            this.ColAsignatura.Name = "ColAsignatura";
            this.ColAsignatura.ReadOnly = true;
            this.ColAsignatura.Width = 200;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(178, 414);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(312, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 449);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarrera);
            this.Name = "FrmNuevaCarrera";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.FrmNuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsignatura;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}

