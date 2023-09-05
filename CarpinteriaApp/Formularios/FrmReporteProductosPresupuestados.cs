using CarpinteriaApp.Datos;
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
    public partial class FrmReporteProductosPresupuestados : Form
    {
        public FrmReporteProductosPresupuestados()
        {
            InitializeComponent();
        }

        private void FrmReporteProductosPresupuestados_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@fecha_desde", dtpFechaDesde.Value));
            lista.Add(new Parametro("@fecha_hasta", dtpFechaHasta.Value));

            DataTable tabla = new DBHelper().Consultar("SP_REPORTE_PRODUCTOS",lista);

            this.dTProductosBindingSource.DataSource = tabla;

            this.reportViewer1.RefreshReport();
        }
    }
}
