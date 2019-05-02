using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca
{
    class Conexion
    {
        public SqlConnection GetConnection()
        {
            try
            {
                string cadena =@"Data Source=ELE\SQLEXPRESS;Initial Catalog=libreria3;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(cadena);
                cnn.Open();
                return cnn;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
