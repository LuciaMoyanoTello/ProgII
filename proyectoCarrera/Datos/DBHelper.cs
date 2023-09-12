using proyectoCarrera.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarrera.Datos
{
    internal class DBHelper
    {
        private SqlConnection cnn;
        public DBHelper()
        {
            cnn = new SqlConnection(@"Data Source=DESKTOP-GE4ANJO\SQLEXPRESS;Initial Catalog=carrera;Integrated Security=True");
        }

        //PARA CARGAR EL COMBO DE ASIGNATURA
        public DataTable Consultar(string nombreSP)
        {
           cnn.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            cnn.Close();

            return tabla;
        }
        public bool ConfirmarCarrera(Carrera oCarrera)
        {
            bool resultado = true;

            //TRANSACCIÓN
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                //INSERTAR MAESTRO
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnn;
                comando.Transaction = t; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";

                //parámetro de entrada
                comando.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                comando.Parameters.AddWithValue("@titulo", oCarrera.Titulo);
                
                //parametro de salida
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_carrera";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;

                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int carreraNro = (int)parametro.Value;

                //INSERTAR DETALLES
                int detalleNro = 1;
                SqlCommand cmdDetalle;
                foreach (DetalleCarrera dc in oCarrera.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@carrera", carreraNro);
                    cmdDetalle.Parameters.AddWithValue("@año", dc.Anio);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", dc.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@asignatura", dc.Asignatura);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }

                //TERMINAR TRANSACCIÓN
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback(); 
                resultado = false;
            }
            finally 
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return resultado;
        }
    }
}
