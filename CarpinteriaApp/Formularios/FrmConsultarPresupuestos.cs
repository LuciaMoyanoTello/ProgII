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
    public partial class FrmConsultarPresupuestos : Form
    {
        public FrmConsultarPresupuestos()
        {
            InitializeComponent();
        }

        private void FrmConsultarPresupuestos_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            dtpHasta.Value = DateTime.Now;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //VALIDAR
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", dtpDesde.Value.ToString("yyyyMMdd"))); //Fecha sea año / mes /día
            lst.Add(new Parametro("@fecha_hasta", dtpHasta.Value.ToString("yyyyMMdd")));
            lst.Add(new Parametro("@cliente", txtCliente.Text));

            DataTable tabla = new DBHelper().Consultar("SP_CONSULTAR_PRESUPUESTOS",lst);

            //CARGAR GRILLA CON DATATABLE
            dgvPresupuestos.Rows.Clear();
            foreach (DataRow fila in tabla.Rows) 
            {
                dgvPresupuestos.Rows.Add(new object[] { fila["presupuesto_nro"].ToString(),
                                                        fila["fecha"].ToString(),
                                                        fila["cliente"].ToString(),
                                                        fila["total"].ToString()});
            }
        }

        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPresupuestos.CurrentCell.ColumnIndex == 4)
            {
                //int nro = int.Parse(dgvPresupuestos.CurrentRow.Cells["ColNro"].Value.ToString());
                int nro = Convert.ToInt32(dgvPresupuestos.CurrentRow.Cells["ColPresupuestoNro"].Value);

                //LLAMADA AL CONSTRUCTOR DE DETALLES CON PARÁMETROS
                FrmDetallesPresupuesto detalle = new FrmDetallesPresupuesto(nro);
                detalle.presupuestoNro = nro;   
                
                detalle.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
