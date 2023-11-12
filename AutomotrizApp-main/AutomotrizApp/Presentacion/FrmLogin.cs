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
                                            NombreCompleto: Convert.ToString(tabla.Rows[0]["Nombre Completo"]),
                                            Dni: Convert.ToString(tabla.Rows[0]["DNI"]),
                                            Telefono: Convert.ToString(tabla.Rows[0]["Telefono"])
                                         );

            return cliente;
        }


        //El cambio del CheckBox se realiza de forma manual para validar cuando sea necesario que se presione
        private void CambioCheck(CheckBox cb)
        {
            if(cb.Checked )
            {
                cb.Checked = false;
            }
            else
            {
                cb.Checked = true;
            }
        }
        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmLogin_Load(object sender = null, EventArgs e = null)
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
        private void cbPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassword.Tag.ToString())
            {
                CambioCheck(cbPassword);
                if (cbPassword.Checked)
                {
                    txtPassword.UseSystemPasswordChar = false;
                    cbPassword.Image = Properties.Resources.PassShowIcon;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                    cbPassword.Image = Properties.Resources.PassHideIcon;
                }
            }
        }


        //Evento para cerrar el Login y cortar el programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // ================================================================================================================================= //

    }
}
