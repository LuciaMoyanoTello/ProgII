using AutomotrizApp.Datos;
using System;
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
    public partial class FrmConsultarProductos : Form
    {
        public FrmConsultarProductos()
        {
            InitializeComponent();
        }

        //Metodos
        // ================================================================================================================================= //
        //Limpia el contenido de los controles (txt y cbo)
        private void LimpiarControles()
        {
            txtNombreProducto.Text = "";
            txtPrecioProductoMin.Text = "";
            txtPrecioProductoMax.Text = "";
            cboTipoProducto.SelectedIndex = -1;
        }
        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmConsultarProductos_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            txtNombreProducto.Focus();
            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_CONSULTAR_TIPOS");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_CONSULTAR_PRODUCTOS");
        }


        //Carga y filtra el contenido del dgv
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Parametro> lista = new List<Parametro>();

            if (txtNombreProducto.Text != "")
            {
                lista.Add(new Parametro("@input_nombre", txtNombreProducto.Text));
            }
            if (txtPrecioProductoMin.Text != "")
            {
                lista.Add(new Parametro("@input_precio_min", txtPrecioProductoMin.Text));
            }
            if (txtPrecioProductoMax.Text != "")
            {
                lista.Add(new Parametro("@input_precio_max", txtPrecioProductoMax.Text));
            }
            if (cboTipoProducto.SelectedItem != null)
            {
                lista.Add(new Parametro("@input_id_tipo", cboTipoProducto.SelectedValue));
            }

            dgvConsultarProductos.Rows.Clear();
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, lista, "SP_CONSULTAR_PRODUCTOS");
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void dgvConsultarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarProductos.CurrentCell.OwningColumn.Name == "Editar")
            {
                
                int idProducto = Convert.ToInt32(dgvConsultarProductos.CurrentRow.Cells["idProducto"].Value);
                MessageBox.Show("ID: " + idProducto.ToString()); //Esto es solo para pruebas
                FrmPrincipal.instancia.CambiarFormulario(new FrmNuevoProducto(idProducto));
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

        // ================================================================================================================================= //
    }
}
