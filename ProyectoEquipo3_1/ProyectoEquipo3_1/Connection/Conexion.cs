using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Libreria para poder hacer la conexion con SQL Server

namespace ProyectoEquipo3_1.Connection
{
    class Conexion
    {
        private static string stringConexion = "server=LAPTOP-E0ORA0CH;database=CitasMedicas2;Trusted_Connection=true";//Linea de conexion a la base de datos
        private SqlConnection sql_conexion = new SqlConnection(stringConexion);

        public SqlConnection sql_getConnection()//Metodo para obetener conexion
        {
            return sql_conexion;
        }
    }
}
