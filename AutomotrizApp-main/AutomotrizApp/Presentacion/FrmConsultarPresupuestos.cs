using AutomotrizApp.Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.Presentacion
{
    public partial class FrmConsultarPresupuestos : Form
    {
        public FrmConsultarPresupuestos()
        {
            InitializeComponent();
        }


        //Metodos
        // ================================================================================================================================= //
        //
        private void LimpiarControles()
        {
            txtDniCliente.Text = "";
            dtpFechaMin.Value = new DateTime(2000, 1, 1);
            dtpFechaMax.Value = DateTime.Today;
            txtTotalMin.Text = "";
            txtTotalMax.Text = "";
        }


        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmConsultarPresupuestos_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            txtDniCliente.Focus();
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarPresupuestos, null, "SP_CONSULTAR_PRESUPUESTOS");
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Parametro> lista = new List<Parametro>();

            if (txtDniCliente.Text != "")
            {
                lista.Add(new Parametro("@input_dni_cliente", txtDniCliente.Text));
            }
            if (dtpFechaMin.Value < dtpFechaMax.Value)
            {
                lista.Add(new Parametro("@input_fecha_min", dtpFechaMin.Value));
                lista.Add(new Parametro("@input_fecha_max", dtpFechaMax.Value));
            }
            if (txtTotalMin.Text != "")
            {
                lista.Add(new Parametro("@input_total_min", txtTotalMin.Text));
            }
            if (txtTotalMax.Text != "")
            {
                lista.Add(new Parametro("@input_total_max", txtTotalMax.Text));
            }

            dgvConsultarPresupuestos.Rows.Clear();
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarPresupuestos, lista, "SP_CONSULTAR_PRESUPUESTOS");
        }


        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }


        private void dgvConsultarPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarPresupuestos.CurrentCell.OwningColumn.Name == "Eliminar")
            {

                int idPresupuesto = Convert.ToInt32(dgvConsultarPresupuestos.CurrentRow.Cells["idPresupuesto"].Value);
                MessageBox.Show("Se deberia eliminar el Presupuesto con el ID: " + idPresupuesto.ToString()); //Esto es solo para pruebas
                // ---> Eliminar un presupuesto del dgv y base de datos (hacer una confirmacion)
            }
        }


        //Veriica si la tecla presionada es un numero o un "control", si no lo es se ignora
        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
