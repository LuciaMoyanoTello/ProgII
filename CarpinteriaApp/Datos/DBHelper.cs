using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpinteriaApp.Dominio;

namespace CarpinteriaApp.Datos
{
    internal class DBHelper
    {
        //CONEXIÓN
        private SqlConnection conexion;
        public DBHelper()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-GE4ANJO\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True");
        }

        public int proximoPresupuesto()
        {
            //ABRIR CONEXIÓN
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

            //DEVUELVE COMO ENTERO
            return (int)parametro.Value;
        }

        //PARA EL COMBO DE PRODUCTO
        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;

            //CONSULTAR PRODUCTOS SE HACE CON TABLA
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            //PARA CARGAR LA TABLA
            tabla.Load(comando.ExecuteReader());

            //CIERRO CONEXIÓN
            conexion.Close();

            //RETORNAR TABLA
            return tabla;
        }

        public bool ConfirmarPresupuesto(Presupuesto oPresupuesto)
        {
            bool resultado = true;

            //TRANSACCIÓN
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                //INSERTAR MAESTRO
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t; //comando también tiene transacción
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";

                //parámetro de entrada
                comando.Parameters.AddWithValue("@cliente", oPresupuesto.Cliente);
                comando.Parameters.AddWithValue("@dto", oPresupuesto.Descuento);
                comando.Parameters.AddWithValue("@total", oPresupuesto.CalcularTotal());

                //parametro de salida
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@presupuesto_nro";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;

                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int presupuestoNro = (int)parametro.Value;

                //INSERTAR DETALLES
                int detalleNro = 1;
                SqlCommand cmdDetalle;
                foreach (DetallePresupuesto dp in oPresupuesto.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@presupuesto_nro", presupuestoNro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", dp.Producto.ProductoNro);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dp.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }

                //TERMINAR TRANSACCIÓN
                t.Commit(); //comitea los cambios
            }
            catch
            {
                //SI NO ANDUVO LO QUE ESTÁ DENTRO DEL TRY
                if(t != null) 
                    t.Rollback(); //volver al estado anterior
                resultado = false;
            }
            finally //se ejecuta siempre
            {
                if(conexion != null && conexion.State == ConnectionState.Open) //si la conexion no es nula y si está abierta
                    conexion.Close();
            }

            return resultado;
        }
        //PARA EL FORM CONSULTAR PRESUPUESTOS
        public DataTable Consultar(string nombreSP,List<Parametro> lstparametros)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            //SP CON PARÁMETROS
            comando.Parameters.Clear();
            foreach(Parametro p in lstparametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
    }
}
