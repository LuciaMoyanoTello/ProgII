using proyectoCarrera.Datos;
using proyectoCarrera.Entidades;
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

namespace proyectoCarrera
{
    public partial class FrmNuevaCarrera : Form
    {
        DBHelper gestor;
        Carrera nueva;
        public FrmNuevaCarrera()
        {
            InitializeComponent();
            gestor = new DBHelper();
            nueva = new Carrera();
        }

        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            txtCarrera.Text = "Tecnicatura en Programación";
            txtTitulo.Text = "Tecnico en Programación";
            txtAño.Text = "1";
            txtCuatrimestre.Text = "1";
            cargarAsignatura();
        }

        private void cargarAsignatura()
        {
            DataTable tabla = gestor.Consultar("SP_CONSULTAR_ASIGNATURA");
            cboAsignatura.DataSource = tabla;
            cboAsignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SI HAY ASIGNATURA
            if (cboAsignatura.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una asinatura...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                //POR CADA FILA BUSCO EL NOMBRE DEL PRODUCTO Y LO COMPARO CON EL COMBO
                if (row.Cells["ColAsignatura"].Value.ToString().Equals(cboAsignatura.Text))
                {
                    MessageBox.Show("Asignatura ya aparece...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            
            DataRowView item = (DataRowView)cboAsignatura.SelectedItem;

            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();

            Asignatura p = new Asignatura(nro, nom);

            int anio = Convert.ToInt32(txtAño.Text);
            int cuatri = Convert.ToInt32(txtCuatrimestre.Text);

            DetalleCarrera detalle = new DetalleCarrera(p,anio,cuatri);

            nueva.AgregarDetalle(detalle);

            dgvDetalles.Rows.Add(new object[] { nro, anio, cuatri, nom, "Quitar" });

        }
        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarrera.Text))
            {
                MessageBox.Show("Debe ingresar una carrera...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un detalle...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar el título de la carrera...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrabarCarrera();
        }

        private void GrabarCarrera()
        {
            nueva.Nombre = txtCarrera.Text;
            nueva.Titulo = txtTitulo.Text;

            if (gestor.ConfirmarCarrera(nueva))
            {
                MessageBox.Show("Se registró con éxito la carrera...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
                return;
            }
            else
            {
                MessageBox.Show("No se pudo registrar la carrera...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
