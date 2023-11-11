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
    public partial class FrmNuevoProducto : Form
    {
        private int idNuevoProducto;
        private Producto producto;
        public FrmNuevoProducto(Producto oProducto = null)
        {
            InitializeComponent();

            producto = oProducto;
        }



        //Metodos
        // ================================================================================================================================= //
        //Limpia el contenido de los controles (txt, cbo y dgv)
        private void LimpiarControles()
        {
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "0";
            cboTipoProducto.Items.Clear();
            dgvConsultarProductos.Rows.Clear();
        }


        //Valida los campos de creacion
        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_CONSULTAR_TIPOS");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_CONSULTAR_PRODUCTOS");

            //Define si el formulario dira de ser usado para editar o crear un presupuesto
            if (producto != null)
            {
                lblTitulo.Text = "Editar Producto (N" + producto.Id + ")";

                txtNombreProducto.Text = producto.Nombre;
                txtPrecioProducto.Text = Convert.ToString(producto.Precio);
                cboTipoProducto.Text = producto.Tipo;
            }
            else
            {
                int proximaId = 99; // ---> Consultar proximo id para producto ([SP_PROXIMO_ID_PRODUCTO]) y asignarlo a idNuevoProducto
                idNuevoProducto = proximaId;
                lblTitulo.Text += " (N" + idNuevoProducto + ")";
            }
        }


        //Valida el ingreso de datos de los campos del form
        private bool ValidarConfirmar()
        {
            if(txtNombreProducto.Text == "")
            {
                MessageBox.Show("Error\nIngrese el nombre del producto...");
                return false;
            }
            if (txtPrecioProducto.Text == "" || Convert.ToInt32(txtPrecioProducto.Text) <= 0)
            {
                MessageBox.Show("Error\nIngrese un precio valido...");
                return false;
            }
            if(cboTipoProducto.SelectedIndex == -1) 
            {
                MessageBox.Show("Error\nIngrese el tipo de producto...");
                return false;
            }
            return true;
        }


        //Inicia insert o update con la base de datos, el camino se toma dependiendo si "producto" es null o no
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarConfirmar())
            {
                string nombreSP;
                List<Parametro> lista = new List<Parametro>();

                if (producto != null)
                {
                    nombreSP = "SP_ACTUALIZAR_PRODUCTOS";
                }
                else
                {
                    nombreSP = "SP_INSERTAR_PRODUCTOS";
                }
                
                lista.Add(new Parametro("@input_id_producto", Convert.ToString(idNuevoProducto)));
                lista.Add(new Parametro("@input_nombre", txtNombreProducto.Text));
                lista.Add(new Parametro("@input_precio", txtPrecioProducto.Text));
                lista.Add(new Parametro("@input_id_tipo", cboTipoProducto.SelectedValue));

                DBHelper.ObtenerInstancia().ConsultarSP(nombreSP, lista);
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
