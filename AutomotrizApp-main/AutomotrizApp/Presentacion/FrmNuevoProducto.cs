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
    public partial class FrmNuevoProducto : Form
    {
        private int idNuevoProducto;
        private bool Editar;
        public FrmNuevoProducto(int idProducto = 0)
        {
            InitializeComponent();

            LimpiarControles();
            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_CONSULTAR_TIPOS");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_CONSULTAR_PRODUCTOS");

            if (idProducto != 0)
            {
                idNuevoProducto = idProducto;
                lblTitulo.Text = "Editar Producto";
                Editar = true;
            }
            else
            {
                // ---> Consultar proximo id para producto ([SP_PROXIMO_ID_PRODUCTO]) y asignarlo a idNuevoProducto
                idNuevoProducto = 99;
                Editar = false;
            }
        }



        //Metodos
        // ================================================================================================================================= //
        //Limpia el contenido de los controles (txt, cbo y dgv)
        private void LimpiarControles()
        {
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            cboTipoProducto.Items.Clear();
            dgvConsultarProductos.Rows.Clear();
        }
        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += " (N" + idNuevoProducto + ")";
        }


        //Inicia insert o update con la base de datos
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                // ---> Inicio update usando idNuevoProducto como PK a editar
            }
            else
            {
                // ---> Inicio insert usando idNuevoProducto como PK a insertar
            }
            MessageBox.Show("Falta por hacer el insert y update");
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
