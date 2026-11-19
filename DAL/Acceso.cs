using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Acceso
    {
        SqlConnection cn;

        public void Abrir()
        {
            cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=JuegoDASW;Integrated Security=True;");
            cn.Open();
        }

        public void Cerrar()
        {
            cn.Close();
            cn = null;
            GC.Collect();
        }

        private SqlCommand CrearComando (string sql, List<SqlParameter> p = null)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (p != null)
            {
                cmd.Parameters.AddRange(p.ToArray());
            }

            return cmd;
        }

        public int Escribir(string sql, List<SqlParameter> p = null)
        {
            SqlCommand cmd = CrearComando(sql, p);
            int filas = 0;
            try
            {
                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            return filas;
        }

        public DataTable Leer(string sql, List<SqlParameter> p = null)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = CrearComando(sql, p);
            da.Fill(dt);
            da.Dispose();
            da = null;

            return dt;
        }

        public SqlParameter CrearParametro (string nombre, string valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Int32;
            return p;
        }
        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.DateTime;
            return p;
        }
    }
}
