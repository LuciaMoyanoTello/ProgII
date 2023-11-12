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
using AutomotrizApp.Datos;
using System.Data.SqlClient;

namespace AutomotrizApp
{
    public partial class FrmPrincipal : Form
    {
        // Instancias de Formularios y atributos
        // ================================================================================================================================= //
        public FrmLogin Login = new FrmLogin();
        public FrmConsultarProductos ConsultarProductos = new FrmConsultarProductos();
        public FrmNuevoProducto NuevoProducto = new FrmNuevoProducto();
        public FrmConsultarPresupuestos ConsultarPresupuestos = new FrmConsultarPresupuestos();
        public FrmNuevoPresupuesto NuevoPresupuesto = new FrmNuevoPresupuesto();
        public FrmAcercaDe AcercaDe = new FrmAcercaDe();

        public static Cliente clienteActivo;
        public static FrmPrincipal instancia;
        // ================================================================================================================================= //

        public FrmPrincipal()
        {
            Login.ShowDialog();

            InitializeComponent();
            instancia = this;
        }

        //Metodos
        // ================================================================================================================================= //
        //Carga los formularios en el panel principal
        public void CambiarFormulario(Form Formulario)
        {
            pnMuestra.Controls.Clear();

            Formulario.TopLevel = false;
            pnMuestra.Controls.Add(Formulario);
            Formulario.Dock = DockStyle.Fill;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Show();
        }



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmPrincipal_Load(object sender = null, EventArgs e = null)
        {
            lblUsuario.Text = clienteActivo.NombreCompleto.ToString();
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            pnMenuPresupuesto.Height = 42;
            pnMenuProductos.Height = 42;
            tmrReloj.Start();
        }


        //Botones del menu
        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ConsultarProductos);
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            CambiarFormulario(NuevoProducto);
        }

        private void btnConsultarPresupuestos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ConsultarPresupuestos);
        }

        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            CambiarFormulario(NuevoPresupuesto);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Falta crear Un reporte para mostrar\n(Agus tiene que hacerlo, pasarmelo y lo agrego)");
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            CambiarFormulario(AcercaDe);
        }


        //Cierra el programa completo
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            Application.Exit();
        }


        //Expande/contrae el panel que muestra los botones de producto y cambia el color del texto
        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
            if(pnMenuProductos.Size.Height == 126) 
            {
                pnMenuProductos.Height =  42;
                btnMenuProductos.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                pnMenuProductos.Height = 126;
                btnMenuProductos.ForeColor = SystemColors.Highlight;
            }
        }


        //Expande/contrae el panel que muestra los botones de presupuesto y cambia el color del texto
        private void btnMenuPresupuesto_Click(object sender, EventArgs e)
        {
            if (pnMenuPresupuesto.Size.Height == 126)
            {
                pnMenuPresupuesto.Height = 42;
                btnMenuPresupuesto.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                pnMenuPresupuesto.Height = 126;
                btnMenuPresupuesto.ForeColor = SystemColors.Highlight;
            }
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
