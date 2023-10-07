using ConsultarCarpinteria.Datos;
using ConsultarCarpinteria.Entidades;
using ConsultarCarpinteria.Formularios;
using ConsultarCarpinteria.Servicio;
using ConsultarCarpinteria.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarCarpinteria
{
    public partial class FrmConsulta : Form
    {
        IServicio servicio = null;
        public FrmConsulta(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            dtpHasta.Value = DateTime.Now;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde",dtpDesde.Value.ToString("yyyyMMdd")));
            lst.Add(new Parametro("@fecha_hasta", dtpHasta.Value.ToString("yyyyMMdd")));
            lst.Add(new Parametro("@cliente",txtCliente.Text));

            List<Presupuesto> lp = servicio.ObtenerPresupuestoPorFiltros(lst);

            foreach(Presupuesto p in lp)
            {
                dgvDetalle.Rows.Add(new object[] {p.PresupuestoNro,
                                                  p.Fecha,
                                                  p.Cliente,
                                                  p.CalcularTotal(),
                                                  "Quitar"});
            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                int nro = Convert.ToInt32(dgvDetalle.CurrentRow.Cells["ColPresupuestoNro"].Value);
                FrmDetallePresupuesto detalle = new FrmDetallePresupuesto(nro);
                detalle.presupuestoNro = nro;
                detalle.ShowDialog();
            }
        }
    }
}
