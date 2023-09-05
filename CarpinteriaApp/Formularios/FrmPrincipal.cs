using CarpinteriaApp.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoPresupuesto().ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPresupuestos frmConsultarPresupuestos = new FrmConsultarPresupuestos();
            frmConsultarPresupuestos.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmReporteProductos().ShowDialog();
        }

        private void productosPresupuestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporteProductosPresupuestados().ShowDialog();
        }
    }
}
