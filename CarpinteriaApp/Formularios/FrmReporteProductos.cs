﻿using CarpinteriaApp.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaApp.Formularios
{
    public partial class FrmReporteProductos : Form
    {
        public FrmReporteProductos()
        {
            InitializeComponent();
        }

        private void FrmReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSProductos.T_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            //this.t_PRODUCTOSTableAdapter.Fill(this.dSProductos.T_PRODUCTOS);

            DataTable tabla = new DBHelper().Consultar("SP_CONSULTAR_PRODUCTOS");

            this.tPRODUCTOSBindingSource.DataSource = tabla;

            this.reportViewer1.RefreshReport();
        }
    }
}
