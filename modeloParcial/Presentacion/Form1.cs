using modeloParcial.Dominio;
using modeloParcial.Servicio;
using modeloParcial.Servicio.Interfaz;
using modeloParcial.Servicio;
using modeloParcial.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeloParcial
{
    public partial class Form1 : Form
    {
        IServicio servicio;
        OrdenRetiro nueva;
        int detalle;
        public Form1(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            nueva = new OrdenRetiro();
            detalle = 1;

            lblOrdenNro.Text += servicio.ObtenerProximaOrden();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMaterial.DataSource = servicio.ObtenerMaterial();
            dtpFecha.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea cancelar la orden?","Cancelar",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //VALIDAR
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvDetalle.CurrentRow == null)
            {
                MessageBox.Show("Debe ingresar un detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            nueva.Responsable = txtResponsable.Text;
            nueva.Fecha = dtpFecha.Value;
            if (servicio.ObtenerCrear(nueva))
            {
                MessageBox.Show("Se ingreso con éxito la orden", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo ingresar la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {
                Material m = (Material)cboMaterial.SelectedItem;

                if (r.Cells["ColMaterial"].Value.ToString() == m.Nombre)
                {
                    MessageBox.Show("Ya ingreso este material. Por favor ingrese otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                int.Parse(txtCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Material mat = (Material)cboMaterial.SelectedItem;
            int cant = int.Parse(txtCantidad.Text);
            DetalleOrden det = new DetalleOrden(detalle,mat,cant);
            nueva.AgregarDetalle(det);
            dgvDetalle.Rows.Add(new object[] { det.IdDetalle, det.MaterialDetalle.Nombre, det.MaterialDetalle.Stock, det.Cantidad, "Quitar" });
            detalle++;
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
                nueva.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                detalle--;
            } 
        }
    }
}
