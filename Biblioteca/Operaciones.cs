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
    class Operaciones
    {
        public bool Insertlibreria3(int Id_libro, string nombre, int precio_venta, int precio_compra, int num_pag)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "Insert into libros values ('" + Id_libro + "' ,'" + nombre + "','" + precio_venta + "','" + precio_compra + "','" + num_pag + "')";
                SqlCommand cmd = new SqlCommand(sql,cn.GetConnection());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
