using AutomotrizApp.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizApp.Entidades;

namespace AutomotrizApp
{
    public partial class FrmPrincipal : Form
    {
        // Instancias de Formularios y atributos
        FrmLogin Login = new FrmLogin();

        public static Cliente clienteActivo;

        public FrmPrincipal()
        {
            Login.ShowDialog();
            InitializeComponent();

            lblUsuario.Text = clienteActivo.NombreCompleto.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
