namespace AutomotrizApp
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnControles = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.pnMenuPresupuesto = new System.Windows.Forms.Panel();
            this.btnNuevoPresupuesto = new System.Windows.Forms.Button();
            this.btnConsultarPresupuestos = new System.Windows.Forms.Button();
            this.btnMenuPresupuesto = new System.Windows.Forms.Button();
            this.pnMenuProductos = new System.Windows.Forms.Panel();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.btnMenuProductos = new System.Windows.Forms.Button();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnMuestra = new System.Windows.Forms.Panel();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.pnMenuPrincipal.SuspendLayout();
            this.pnControles.SuspendLayout();
            this.pnMenuPresupuesto.SuspendLayout();
            this.pnMenuProductos.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.pnMuestra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenuPrincipal
            // 
            this.pnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnMenuPrincipal.Controls.Add(this.btnSalir);
            this.pnMenuPrincipal.Controls.Add(this.pnControles);
            this.pnMenuPrincipal.Controls.Add(this.pnUsuario);
            this.pnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnMenuPrincipal.Name = "pnMenuPrincipal";
            this.pnMenuPrincipal.Size = new System.Drawing.Size(170, 540);
            this.pnMenuPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Location = new System.Drawing.Point(0, 498);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 42);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnControles
            // 
            this.pnControles.AutoScroll = true;
            this.pnControles.Controls.Add(this.btnAcercaDe);
            this.pnControles.Controls.Add(this.btnReporte);
            this.pnControles.Controls.Add(this.pnMenuPresupuesto);
            this.pnControles.Controls.Add(this.pnMenuProductos);
            this.pnControles.Location = new System.Drawing.Point(0, 155);
            this.pnControles.Name = "pnControles";
            this.pnControles.Size = new System.Drawing.Size(187, 337);
            this.pnControles.TabIndex = 2;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 294);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAcercaDe.Size = new System.Drawing.Size(187, 42);
            this.btnAcercaDe.TabIndex = 1;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.Location = new System.Drawing.Point(0, 252);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReporte.Size = new System.Drawing.Size(187, 42);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "Reporte de ventas";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // pnMenuPresupuesto
            // 
            this.pnMenuPresupuesto.Controls.Add(this.btnNuevoPresupuesto);
            this.pnMenuPresupuesto.Controls.Add(this.btnConsultarPresupuestos);
            this.pnMenuPresupuesto.Controls.Add(this.btnMenuPresupuesto);
            this.pnMenuPresupuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuPresupuesto.Location = new System.Drawing.Point(0, 126);
            this.pnMenuPresupuesto.Name = "pnMenuPresupuesto";
            this.pnMenuPresupuesto.Size = new System.Drawing.Size(187, 126);
            this.pnMenuPresupuesto.TabIndex = 4;
            // 
            // btnNuevoPresupuesto
            // 
            this.btnNuevoPresupuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnNuevoPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPresupuesto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevoPresupuesto.Location = new System.Drawing.Point(0, 84);
            this.btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            this.btnNuevoPresupuesto.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNuevoPresupuesto.Size = new System.Drawing.Size(187, 42);
            this.btnNuevoPresupuesto.TabIndex = 2;
            this.btnNuevoPresupuesto.Text = "Nuevo Presupuesto";
            this.btnNuevoPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPresupuesto.UseVisualStyleBackColor = true;
            this.btnNuevoPresupuesto.Click += new System.EventHandler(this.btnNuevoPresupuesto_Click);
            // 
            // btnConsultarPresupuestos
            // 
            this.btnConsultarPresupuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarPresupuestos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarPresupuestos.FlatAppearance.BorderSize = 0;
            this.btnConsultarPresupuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPresupuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPresupuestos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarPresupuestos.Location = new System.Drawing.Point(0, 42);
            this.btnConsultarPresupuestos.Name = "btnConsultarPresupuestos";
            this.btnConsultarPresupuestos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnConsultarPresupuestos.Size = new System.Drawing.Size(187, 42);
            this.btnConsultarPresupuestos.TabIndex = 1;
            this.btnConsultarPresupuestos.Text = "Consultar Presupuestos";
            this.btnConsultarPresupuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPresupuestos.UseVisualStyleBackColor = true;
            this.btnConsultarPresupuestos.Click += new System.EventHandler(this.btnConsultarPresupuestos_Click);
            // 
            // btnMenuPresupuesto
            // 
            this.btnMenuPresupuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnMenuPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPresupuesto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMenuPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.btnMenuPresupuesto.Name = "btnMenuPresupuesto";
            this.btnMenuPresupuesto.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuPresupuesto.Size = new System.Drawing.Size(187, 42);
            this.btnMenuPresupuesto.TabIndex = 0;
            this.btnMenuPresupuesto.Text = "Presupuesto";
            this.btnMenuPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPresupuesto.UseVisualStyleBackColor = true;
            this.btnMenuPresupuesto.Click += new System.EventHandler(this.btnMenuPresupuesto_Click);
            // 
            // pnMenuProductos
            // 
            this.pnMenuProductos.Controls.Add(this.btnNuevoProducto);
            this.pnMenuProductos.Controls.Add(this.btnConsultarProductos);
            this.pnMenuProductos.Controls.Add(this.btnMenuProductos);
            this.pnMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuProductos.Location = new System.Drawing.Point(0, 0);
            this.pnMenuProductos.Name = "pnMenuProductos";
            this.pnMenuProductos.Size = new System.Drawing.Size(187, 126);
            this.pnMenuProductos.TabIndex = 0;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevoProducto.Location = new System.Drawing.Point(0, 84);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNuevoProducto.Size = new System.Drawing.Size(187, 42);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProductos.FlatAppearance.BorderSize = 0;
            this.btnConsultarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProductos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarProductos.Location = new System.Drawing.Point(0, 42);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnConsultarProductos.Size = new System.Drawing.Size(187, 42);
            this.btnConsultarProductos.TabIndex = 1;
            this.btnConsultarProductos.Text = "Consultar Productos";
            this.btnConsultarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // btnMenuProductos
            // 
            this.btnMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuProductos.FlatAppearance.BorderSize = 0;
            this.btnMenuProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProductos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMenuProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuProductos.Location = new System.Drawing.Point(0, 0);
            this.btnMenuProductos.Name = "btnMenuProductos";
            this.btnMenuProductos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuProductos.Size = new System.Drawing.Size(187, 42);
            this.btnMenuProductos.TabIndex = 0;
            this.btnMenuProductos.Text = "Productos";
            this.btnMenuProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProductos.UseVisualStyleBackColor = true;
            this.btnMenuProductos.Click += new System.EventHandler(this.btnMenuProductos_Click);
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnUsuario.Controls.Add(this.pbUserIcon);
            this.pnUsuario.Controls.Add(this.lblUsuario);
            this.pnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(170, 155);
            this.pnUsuario.TabIndex = 1;
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Image = global::AutomotrizApp.Properties.Resources.UserIcon;
            this.pbUserIcon.Location = new System.Drawing.Point(36, 10);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(98, 98);
            this.pbUserIcon.TabIndex = 1;
            this.pbUserIcon.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(0, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblUsuario.Size = new System.Drawing.Size(170, 45);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnMuestra
            // 
            this.pnMuestra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnMuestra.Controls.Add(this.lblReloj);
            this.pnMuestra.Location = new System.Drawing.Point(180, 10);
            this.pnMuestra.Name = "pnMuestra";
            this.pnMuestra.Size = new System.Drawing.Size(770, 520);
            this.pnMuestra.TabIndex = 1;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lblReloj.Location = new System.Drawing.Point(177, 206);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(417, 108);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "00:00:00";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pnMuestra);
            this.Controls.Add(this.pnMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnMenuPrincipal.ResumeLayout(false);
            this.pnControles.ResumeLayout(false);
            this.pnMenuPresupuesto.ResumeLayout(false);
            this.pnMenuProductos.ResumeLayout(false);
            this.pnUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.pnMuestra.ResumeLayout(false);
            this.pnMuestra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuPrincipal;
        private System.Windows.Forms.Panel pnMuestra;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Panel pnControles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnMenuPresupuesto;
        private System.Windows.Forms.Button btnConsultarPresupuestos;
        private System.Windows.Forms.Button btnMenuProductos;
        private System.Windows.Forms.Panel pnMenuProductos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Panel pnMenuPresupuesto;
        private System.Windows.Forms.Button btnNuevoPresupuesto;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer tmrReloj;
    }
}

