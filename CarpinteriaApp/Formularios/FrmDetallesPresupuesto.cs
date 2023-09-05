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
    public partial class FrmDetallesPresupuesto : Form
    {
        //PARA QUE APAREZCA EL NÚMERO DEL ID QUE TOCO DESDE LA GRILLA DE CONNSULTAR PRESUPUESTO
        public FrmDetallesPresupuesto(int presupuestoNro)
        {
            InitializeComponent();
            this.Text += presupuestoNro.ToString();
        }
        public int presupuestoNro { get; set; }

        private void FrmDetallesPresupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
