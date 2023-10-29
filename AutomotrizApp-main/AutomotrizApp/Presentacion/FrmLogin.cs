using AutomotrizApp.Datos;
using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@input_usuario", txtUser.Text));
            parametros.Add(new Parametro("@input_pass", txtPassword.Text));

            DataTable tabla = DBHelper.ObtenerInstancia().ConsultarSP("SP_Consultar_Login", parametros);

            if (tabla.Rows.Count != 1)
            {
                lblLoginError.Text = "Usuario o contraseña incorrectos";
            }
            else
            {
                Cliente cliente = new Cliente(  
                                                tabla.Rows[0]["Nombre Completo"].ToString(),
                                                tabla.Rows[0]["DNI"].ToString(),
                                                tabla.Rows[0]["Telefono"].ToString()
                                             );
                FrmPrincipal.clienteActivo = cliente;
                this.Close();
            }


        }

        private void TextBoxEvento(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == tb.Tag.ToString())
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
            else
            {
                if (tb.Text == "")
                {
                    tb.Text = tb.Tag.ToString();
                    tb.ForeColor = Color.Gray;
                }
            }
        }
    }
}
