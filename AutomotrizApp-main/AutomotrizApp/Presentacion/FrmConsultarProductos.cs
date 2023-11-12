using AutomotrizApp.Datos;
using AutomotrizApp.Entidades;
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
        private void FrmConsultarProductos_Load(object sender = null, EventArgs e = null)
        {
            LimpiarControles();
            
            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_CONSULTAR_TIPOS");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_CONSULTAR_PRODUCTOS");

            txtNombreProducto.Focus();
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
            btnFiltrar_Click(sender, e);
        }

        private void dgvConsultarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar un producto
            if (dgvConsultarProductos.CurrentCell.OwningColumn.Name == "Editar")
            {
                //Crear producto con los datos de la fila
                int idProducto = Convert.ToInt32(dgvConsultarProductos.CurrentRow.Cells["idProducto"].Value);
                string nombreProducto = Convert.ToString(dgvConsultarProductos.CurrentRow.Cells["nombreProducto"].Value);
                float precioProducto = Convert.ToSingle(dgvConsultarProductos.CurrentRow.Cells["precioProducto"].Value);
                string tipoProducto = Convert.ToString(dgvConsultarProductos.CurrentRow.Cells["tipoProducto"].Value);

                Producto producto = new Producto(idProducto, nombreProducto, precioProducto, tipoProducto);

                FrmPrincipal.instancia.CambiarFormulario(new FrmNuevoProducto(producto));
            }

            //Eliminar un producto
            if (dgvConsultarProductos.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                if(MessageBox.Show("¿Está seguro que desea eliminar:\n\"" + Convert.ToString(dgvConsultarProductos.CurrentRow.Cells["nombreProducto"].Value) + "\" del listado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idProducto = Convert.ToInt32(dgvConsultarProductos.CurrentRow.Cells["idProducto"].Value);
                    List<Parametro> parametro = new List<Parametro>() { new Parametro("@input_id_producto", idProducto) };

                    DBHelper.ObtenerInstancia().ConsultarSP("SP_ELIMINAR_PRODUCTOS", parametro); //Elimina de la base de datos
                    dgvConsultarProductos.Rows.Remove(dgvConsultarProductos.CurrentRow); //Elimina del listado
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

        // ================================================================================================================================= //
    }
}
