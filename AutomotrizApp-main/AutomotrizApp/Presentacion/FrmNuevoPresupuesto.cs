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
        private Presupuesto nuevoPresupuesto;
        private Cliente clienteNuevoPresupuesto;

        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
        }

        //Metodos
        // ================================================================================================================================= //
        //Valida si la carga de datos es correcta antes de intentar grabarlos en la base de datos
        private bool ValidarConfirmar()
        {
            if (dgvDetallesNuevoPresupuesto.RowCount == 0)
            {
                MessageBox.Show("Error\nAgregue al menos un producto...");
                return false;
            }
            if (txtDniCliente.Text == "")
            {
                MessageBox.Show("Error\nIngrese el dni de un cliente...");
                return false;
            }
            else
            {
                return ConsultarCliente();
            }
        }


        //Convierte los datos de una fila en atributos de un objeto cliente
        private bool ConsultarCliente()
        {
            List<Parametro> parametro = new List<Parametro>() { new Parametro("@input_dni_cliente", txtDniCliente.Text) };
            DataTable tClientes = DBHelper.ObtenerInstancia().ConsultarSP("SP_CONSULTAR_CLIENTES", parametro);

            if (tClientes.Rows.Count == 0)
            {
                MessageBox.Show("Error\nNo se encontro un cliente con el DNI:\n\"" + txtDniCliente.Text + "\"");
                return false;
            }
            else
            {
                if (tClientes.Rows.Count > 1)
                {
                    foreach (DataRow row in tClientes.Rows)
                    {
                        if (MessageBox.Show("El cliente que esta buscando es:\n\"" + Convert.ToString(row["Nombre Completo"]) + "\"?", "Error. Multiples clientes encontrados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            clienteNuevoPresupuesto.Id = Convert.ToInt32(row["ID"]);
                            clienteNuevoPresupuesto.NombreCompleto = Convert.ToString(row["Nombre Completo"]);
                            clienteNuevoPresupuesto.Dni = Convert.ToString(row["DNI"]);
                            clienteNuevoPresupuesto.Telefono = Convert.ToString(row["Telefono"]);
                            return true;
                        }
                    }
                }
                else
                {
                    clienteNuevoPresupuesto.Id = Convert.ToInt32(tClientes.Rows[0]["ID"]);
                    clienteNuevoPresupuesto.NombreCompleto = Convert.ToString(tClientes.Rows[0]["Nombre Completo"]);
                    clienteNuevoPresupuesto.Dni = Convert.ToString(tClientes.Rows[0]["DNI"]);
                    clienteNuevoPresupuesto.Telefono = Convert.ToString(tClientes.Rows[0]["Telefono"]);
                    return true;
                }
            }
            return false;
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
            foreach (DataGridViewRow row in dgvDetallesNuevoPresupuesto.Rows)
            {
                if (Convert.ToString(row.Cells["nombreProducto"].Value) == Convert.ToString(cboProducto.Text))
                {
                    MessageBox.Show("Error\nEl producto ya está en la lista...");
                    return false;
                }
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


        //Limpia el contenido de los controles (txt, cbo y dgv)
        private void LimpiarControles()
        {
            dtpFecha.Value = DateTime.Today;
            txtDniCliente.Text = "";
            cboProducto.SelectedIndex = -1;
            txtCantidad.Text = "1";
            lblTotalValor.Text = "0";
            dgvDetallesNuevoPresupuesto.Rows.Clear();

            nuevoPresupuesto = new Presupuesto();
            clienteNuevoPresupuesto = new Cliente();
        }

        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmNuevoPresupuesto_Load(object sender = null, EventArgs e = null)
        {
            LimpiarControles();

            CargarComboProductos();
            txtDniCliente.Text = FrmPrincipal.clienteActivo.Dni; //Carga el DNI del cliente que inicio sesion

            txtDniCliente.Focus();
        }


        //Crea un objeto producto y detalle, luego agrega sus valores al DGV
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAgregar())
            {
                Producto producto = (Producto)cboProducto.SelectedItem;
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                Detalle detalle = new Detalle(producto, cantidad);
                nuevoPresupuesto.AgregarDetalle(detalle); //Agrega el detalle al objeto

                dgvDetallesNuevoPresupuesto.Rows.Add(   detalle.ProductoDetalle.Nombre,
                                                        detalle.ProductoDetalle.Precio,
                                                        detalle.Cantidad,
                                                        detalle.CalcularSubTotal(),
                                                        "Eliminar");                    //Agrega el detalle a la grilla

                lblTotalValor.Text = Convert.ToString(nuevoPresupuesto.CalcularTotal()); //Actualiza el total del presupuesto
            }
        }


        //Evento para iniciar la carga de un nuevo presupuesto a la base de datos
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarConfirmar())
            {
                nuevoPresupuesto.ClientePresupuesto = clienteNuevoPresupuesto;
                if (DBHelper.ObtenerInstancia().Transaccion(nuevoPresupuesto))
                {
                    MessageBox.Show("El Presupuesto se cargo con exito.");
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("El Presupuesto no se pudo cargar.");
                }
                
            }
        }


        //Evento para eliminar una fila del dgv al pulsar el boton "eliminar"
        private void dgvDetallesNuevoPresupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesNuevoPresupuesto.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                // <--- Confirmacion
                if (MessageBox.Show("¿Está seguro que desea eliminar:\n\"" + Convert.ToString(dgvDetallesNuevoPresupuesto.CurrentRow.Cells["nombreProducto"].Value) + "\" del listado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nuevoPresupuesto.EliminarDetalle(dgvDetallesNuevoPresupuesto.CurrentRow.Index); //Elimina el detalle del objeto
                    dgvDetallesNuevoPresupuesto.Rows.Remove(dgvDetallesNuevoPresupuesto.CurrentRow); //Elimina el detalle de la lista

                    lblTotalValor.Text = Convert.ToString(nuevoPresupuesto.CalcularTotal()); //Actualiza el total del presupuesto
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
