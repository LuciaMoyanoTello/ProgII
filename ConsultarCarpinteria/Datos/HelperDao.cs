using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsultarCarpinteria.Datos
{
    public class HelperDao
    {
        SqlConnection cnn;
        string stringCnn = @"Data Source=DESKTOP-GE4ANJO\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True";
        private static HelperDao instancia;

        public HelperDao()
        {
            cnn = new SqlConnection(stringCnn);
        }
        public static HelperDao ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }
        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            SqlParameter param = new SqlParameter(nombreParamOut,SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)param.Value;
        }
        public DataTable Consultar(string nombreSP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> lParam)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            foreach (Parametro p in lParam)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
