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
        //CUANDO PONGA ACEPTAR CREA UN NUEVO PRESUPUESTO
        Presupuesto nuevo;
        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
            nuevo = new Presupuesto();
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
            proximoPresupuesto();
            cargarProductos();
        }

        private void cargarProductos()
        {
            //CONEXIÓN Y COMANDO
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-GE4ANJO\SQLEXPRESS;Initial Catalog=Carpinteria_2023;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;

            //CONSULTAR PRODUCTOS SE HACE CON TABLA
            comando.CommandText = "SP_CONSULTAR_PRODUCTOS";
            DataTable tabla = new DataTable();
            //PARA CARGAR LA TABLA
            tabla.Load(comando.ExecuteReader());

            //CIERRO CONEXIÓN
            conexion.Close();

            //CARGAR COMBO
            cboProducto.DataSource = tabla;
            cboProducto.ValueMember = tabla.Columns[0].ColumnName;
            cboProducto.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void proximoPresupuesto()
        {
            //CONEXIÓN
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-GE4ANJO\SQLEXPRESS;Initial Catalog=Carpinteria_2023;Integrated Security=True";
            conexion.Open();

            //COMANDO
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure; //PROCEDIMIENTO ALMACENADO

            //PARA AGREGAR EL NÚMERO DEL PRESUPUESTO
            comando.CommandText = "SP_PROXIMO_ID"; //NOMBRE PROCEDIMIENTO EN LA BD
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next"; //NOMBRE DEL PARÁMETRO EN LA BD
            parametro.SqlDbType = SqlDbType.Int; //PARÁMETRO TIPO INT
            parametro.Direction = ParameterDirection.Output; //PARÁMETRO DE SALIDA
            comando.Parameters.Add(parametro); //PARA AGREGAR EL PARÁMETRO DE SALIDA 
            //PARA AGREGAR PARÁMETRO DE ENTRADA ES CON ADDWITHVALUE
            comando.ExecuteNonQuery(); //EJECUTO EL COMANDO

            //CIERRO CONEXIÓN
            conexion.Close();

            //AGREGO A LA LABEL
            lblPresupuestoNro.Text = lblPresupuestoNro.Text + " " + parametro.Value.ToString();
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
    }
}
