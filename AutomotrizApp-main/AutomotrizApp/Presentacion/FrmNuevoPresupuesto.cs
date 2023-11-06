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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomotrizApp.Presentacion
{
    public partial class FrmNuevoPresupuesto : Form
    {
        private int idNuevoPresupuesto;
        public FrmNuevoPresupuesto()
        {
            InitializeComponent();

            // ---> Consultar proximo id para presupuesto ([SP_PROXIMO_ID_PRESUPUESTO]) y asignarlo a idNuevoPresupuesto
            idNuevoPresupuesto = 99;

        }

        //Metodos
        // ================================================================================================================================= //
        //Valida si la carga de datos es correcta antes de intentar grabarlos en la base de datos
        private bool ValidarConfirmar()
        {
            if(txtDniCliente.Text == "")
            {
                MessageBox.Show("Error\nIngrese el dni de un cliente...");
                return false;
            }
            if(dgvDetallesNuevoPresupuesto.RowCount == 0) 
            {
                MessageBox.Show("Error\nAgregue al menos un producto...");
                return false;
            }

            return true;
        }


        //Valida si la carga de datos es correcta antes de agregar un detalle al dgv
        private bool ValidarAgregar()
        {
            if(cboProducto.SelectedIndex == -1) 
            {
                MessageBox.Show("Error\nSeleccione un producto...");
                return false;
            }
            if(txtCantidad.Text == "" || txtCantidad.Text == "0")
            {
                MessageBox.Show("Error\nIngrese la cantidad del producto...");
                return false;
            }
            return true;
        }


        //Guarda una lista de productos dentro del combo box para el posterior uso de datos
        private void CargarComboProductos()
        {
            DataTable tProductos = DBHelper.ObtenerInstancia().ConsultarSP("SP_CONSULTAR_PRODUCTOS");
            List<Producto> lProductos = new List<Producto>();

            foreach (DataRow row in tProductos.Rows)
            {
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = Convert.ToString(row["Nombre"]),
                    Precio = Convert.ToSingle(row["Precio"]),
                    Tipo = Convert.ToString(row["Tipo"])
                };

                lProductos.Add(producto);
            }

            cboProducto.DataSource = lProductos;
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "Id";

            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.SelectedIndex = -1;
        }


        //Limpia el contenido de los controles (txt y cbo)
        private void LimpiarControles()
        {
            dtpFecha.Value = DateTime.Today;
            txtDniCliente.Text = "";
            cboProducto.SelectedIndex = -1;
            txtCantidad.Text = "0";
        }


        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += " (N" + idNuevoPresupuesto + ")";
            LimpiarControles();
            CargarComboProductos();


        }


        //Crea un objeto producto y detalle, luego agrega sus valores al DGV
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAgregar())
            {
                Producto producto = (Producto)cboProducto.SelectedItem;
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                Detalle detalle = new Detalle(producto, cantidad);

                dgvDetallesNuevoPresupuesto.Rows.Add(   detalle.ProductoDetalle.Nombre, 
                                                        detalle.ProductoDetalle.Precio, 
                                                        detalle.Cantidad, 
                                                        "Eliminar");
            }

        }


        //Evento para iniciar la carga de un nuevo presupuesto a la base de datos
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarConfirmar())
            {
                // ---> Aqui inicia la transaccion
                MessageBox.Show("Falta por hacer");
            }
        }


        //Evento para eliminar una fila del dgv al pulsar el boton "eliminar"
        private void dgvDetallesNuevoPresupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesNuevoPresupuesto.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                int indice = Convert.ToInt32(dgvDetallesNuevoPresupuesto.CurrentRow.Index);

                foreach(DataGridViewRow fila in dgvDetallesNuevoPresupuesto.Rows) 
                {
                    if (fila.Index == indice)
                    {
                        dgvDetallesNuevoPresupuesto.Rows.Remove(fila);
                    }
                }

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
