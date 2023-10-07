using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarCarpinteria.Formularios
{
    public partial class FrmDetallePresupuesto : Form
    {
        public FrmDetallePresupuesto(int presupuestoNro)
        {
            InitializeComponent();
            this.Text += presupuestoNro.ToString();
        }
        public int presupuestoNro { get; set; }

        private void FrmDetallePresupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
