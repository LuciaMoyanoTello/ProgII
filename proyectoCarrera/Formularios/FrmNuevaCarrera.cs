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
        Carrera nueva;
        public FrmNuevaCarrera()
        {
            InitializeComponent();
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
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-GE4ANJO\SQLEXPRESS;Initial Catalog=carrera;Integrated Security=True";
            cnn.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText = "SP_CONSULTAR_ASIGNATURA";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            cnn.Close();

            cboAsignatura.DataSource = tabla;
            cboAsignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboAsignatura.SelectedItem;
            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            Asignatura a = new Asignatura(nro,nom);

            int anio = Convert.ToInt32(txtAño.Text);
            int cuatri = Convert.ToInt32(txtCuatrimestre.Text);
            DetalleCarrera d = new DetalleCarrera(a,anio, cuatri);

            nueva.AgregarDetalle(d);

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
    }
}
