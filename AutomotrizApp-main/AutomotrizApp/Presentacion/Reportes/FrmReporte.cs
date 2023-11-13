using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.Presentacion.Reportes
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

            this.rvVentas.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            SqlConnection cnn = new SqlConnection(@"Data Source=AGUSTINA_MENTA\SQLEXPRESS;Initial Catalog=AutomotrizApp;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("VentasPorTipo", cnn);
            cmd.Parameters.AddWithValue("@FechaInicio", dtpDesde.Value);
            cmd.Parameters.AddWithValue("@FechaFin", dtpHasta.Value);
            cmd.CommandType =CommandType.StoredProcedure;
            DataTable tabla= new DataTable();
            tabla.Load(cmd.ExecuteReader());

            rvVentas.LocalReport.DataSources.Clear();
            rvVentas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",tabla));
            rvVentas.RefreshReport();

            cnn.Close();
        }
    }
}
