using CarpinteriaApp.Datos;
using CarpinteriaApp.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaApp.Formularios
{
    public partial class FrmNuevoPresupuesto : Form
    {
        //CLASE DBHELPER
        DBHelper gestor = null;
        //CUANDO PONGA ACEPTAR CREA UN NUEVO PRESUPUESTO
        Presupuesto nuevo;
        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
            nuevo = new Presupuesto();
            gestor = new DBHelper();
        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            //SOLO MUESTRE LA FECHA
            txtFecha.Text = DateTime.Today.ToShortDateString();
            //LO QUE DICE POR DEFECTO
            txtCliente.Text = "Consumidor Final";
            txtDescuento.Text = "0";
            txtCantidad.Text = "1";

            //MÉTODOS
            lblPresupuestoNro.Text = lblPresupuestoNro.Text + " " + gestor.proximoPresupuesto().ToString();
            cargarProductos();
        }

        private void cargarProductos()
        {
            //CARGAR COMBO
            DataTable tabla = gestor.Consultar("SP_CONSULTAR_PRODUCTOS");
            cboProducto.DataSource = tabla;
            cboProducto.ValueMember = tabla.Columns[0].ColumnName;
            cboProducto.DisplayMember = tabla.Columns[1].ColumnName;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SI HAY PRODUCTO Y CANTIDAD
            if(cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //VERIFICA SI ESTA VACÍO O NO TIENE NÚMEROS
            if((txtCantidad.Text is null) || !(int.TryParse(txtCantidad.Text,out _)))
            {
                MessageBox.Show("Debe ingresar una cantidad válida...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //FIJARSE SI PRODUCTO ESTÁ CARGADO EN LA GRILLA
            //Busco una fila en mi grilla
            foreach (DataGridViewRow row in dgvDetalles.Rows) 
            {
                //POR CADA FILA BUSCO EL NOMBRE DEL PRODUCTO Y LO COMPARO CON EL COMBO
                if (row.Cells["ColProducto"].Value.ToString().Equals(cboProducto.Text))
                {
                    MessageBox.Show("Producto ya está presupuestado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            //PRODUCTOS QUE SACO DEL COMBO PARA LLENAR LA GRILLA
            DataRowView item = (DataRowView)cboProducto.SelectedItem;
            //EL ITEM DE PRODUCTO 0 ES INT // COLUMNA 0
            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            //COLUMNA 1 EN STRING
            string nom = item.Row.ItemArray[1].ToString();
            //COLUMNA 2 EN DOUBLE
            double pre = Convert.ToDouble(item.Row.ItemArray[2]);

            Producto p = new Producto(nro, nom, pre);

            //CANTIDAD SACO DEL TXT
            int cant = Convert.ToInt32(txtCantidad.Text);

            DetallePresupuesto detalle = new DetallePresupuesto(p, cant);

            //NUEVO ES NUEVO PRESUPUESTO
            nuevo.AgregarDetalle(detalle);

            //MOSTRAR EN LA GRILLA: 2 FORMAS DE HACERLO
            /*dgvDetalles.Rows.Add(new object[] {detalle.Producto.ProductoNro,
                                                detalle.Producto.Nombre,
                                                detalle.Producto.Precio,
                                                detalle.Cantidad,
                                                "Quitar"});*/
            dgvDetalles.Rows.Add(new object[] {nro, nom, pre, cant,"Quitar"});

            calcularTotales();
        }

        private void calcularTotales()
        {
            txtSubtotal.Text = nuevo.CalcularTotal().ToString();

            if (!string.IsNullOrEmpty(txtDescuento.Text) && int.TryParse(txtDescuento.Text, out _))
            {
                //TOTAL CON DESCUENTO
                double desc = nuevo.CalcularTotal() * Convert.ToDouble(txtDescuento.Text) / 100;
                //RESTAR DESCUENTO AL TOTAL
                txtTotal.Text = (nuevo.CalcularTotal() - desc).ToString();
            } 
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //VER SI ESTA EN LA QUINTA COLUMNA //EMPIEZAN DESDE 0 LAS COLUMNAS
            if(dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                //QUITA EL PRESUPUESTO PERO NO DE LA GRILLA
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //SACAR DE LA GRILLA
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                //SE VUELVE A ACTUALIZAR EL PRECIO
                calcularTotales();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //VALIDAR
            if(string.IsNullOrEmpty(txtCliente.Text))
            {
                MessageBox.Show("Debe ingresar un cliente...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un detalle...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //CONFIRMAR O GRABAR
            GrabarPresupuesto();
        }

        private void GrabarPresupuesto()
        {
            //presupuesto
            nuevo.Fecha = Convert.ToDateTime(txtFecha.Text);
            nuevo.Cliente = txtCliente.Text;
            nuevo.Descuento = Convert.ToDouble(txtDescuento.Text);

            if (gestor.ConfirmarPresupuesto(nuevo))//pasar por parámetro el presupuesto
            {
                MessageBox.Show("Se registró con éxito el presupuesto...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose(); //CIERRA Y VUELVE AL FORM PRINCIPAL
                return;
            }
            else
            {
                MessageBox.Show("No se pudo registrar el presupuesto...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
