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
using System.Threading;
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

        //Metodos
        // ================================================================================================================================= //
        //Crea un objeto cliente con una tabla como parametro de entrada
        private Cliente CrearCliente(DataTable tabla)
        {
            Cliente cliente = new Cliente(
                                            tabla.Rows[0]["Nombre Completo"].ToString(),
                                            tabla.Rows[0]["DNI"].ToString(),
                                            tabla.Rows[0]["Telefono"].ToString()
                                         );

            return cliente;
        }
        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


        //Consultar cliente con el user y pass de txtbox: (existe) = crea cliente, lo carga y cierra, (no existe) = avisa error
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblLoginError.Text = "";

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@input_usuario", txtUser.Text));
            parametros.Add(new Parametro("@input_pass", txtPassword.Text));

            DataTable tabla = DBHelper.ObtenerInstancia().ConsultarSP("SP_CONSULTAR_LOGIN", parametros);

            if (tabla.Rows.Count != 1)
            {
                Thread.Sleep(100);
                lblLoginError.Text = "Usuario o contraseña incorrectos";
            }
            else
            {
                FrmPrincipal.clienteActivo = CrearCliente(tabla);
                this.Close();
            }
        }


        //Muestra contenido a introducir en los txt + condicional de mostrar caracteres de la password
        private void TextBoxEvento(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == tb.Tag.ToString())
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
                if(tb.Tag.ToString() == "Contraseña" && !(cbPassword.Checked))
                {
                    tb.UseSystemPasswordChar = true;
                }
            }
            else
            {
                if (tb.Text == "")
                {
                    tb.Text = tb.Tag.ToString();
                    tb.ForeColor = Color.Gray;
                    if (tb.Tag.ToString() == "Contraseña")
                    {
                        tb.UseSystemPasswordChar = false;
                    }
                }
            }
        }


        //Controla si debe mostrar o no los caracteres de la password
        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassword.Tag.ToString())
            {
                if (cbPassword.Checked)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
        }

        // ================================================================================================================================= //

    }
}
