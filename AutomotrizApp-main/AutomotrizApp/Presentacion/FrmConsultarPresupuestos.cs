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
        private void FrmConsultarPresupuestos_Load(object sender = null, EventArgs e = null)
        {
            LimpiarControles();

            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarPresupuestos, null, "SP_CONSULTAR_PRESUPUESTOS");

            txtDniCliente.Focus();
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
            btnFiltrar_Click(sender, e);
        }


        private void dgvConsultarPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarPresupuestos.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el presupuesto de:\n\"" + Convert.ToString(dgvConsultarPresupuestos.CurrentRow.Cells["nombreCliente"].Value) + "\" por un total de $" + Convert.ToString(dgvConsultarPresupuestos.CurrentRow.Cells["totalPresupuesto"].Value) + " del listado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPresupuesto = Convert.ToInt32(dgvConsultarPresupuestos.CurrentRow.Cells["idPresupuesto"].Value);
                    List<Parametro> parametro = new List<Parametro>() { new Parametro("@input_id_presupuesto", idPresupuesto) };

                    DBHelper.ObtenerInstancia().ConsultarSP("[SP_ELIMINAR_PRESUPUESTOS]", parametro); //Elimina de la base de datos
                    dgvConsultarPresupuestos.Rows.Remove(dgvConsultarPresupuestos.CurrentRow); //Elimina del listado
                }
            }
        }


        //Veriica si la tecla presionada es un numero o un "backspace", si no lo es, se ignora
        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
