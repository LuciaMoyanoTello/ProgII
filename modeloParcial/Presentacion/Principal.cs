using modeloParcial.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeloParcial.Presentacion
{
    public partial class Principal : Form
    {
        FabricaServicio fabrica;
        public Principal(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1(fabrica).ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
