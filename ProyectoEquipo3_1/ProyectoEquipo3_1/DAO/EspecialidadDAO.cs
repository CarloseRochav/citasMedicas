using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoEquipo3_1.Models;
using ProyectoEquipo3_1.Connection;
using System.Data.SqlClient;

namespace ProyectoEquipo3_1.DAO
{
    class EspecialidadDAO
    {
        Conexion conexion = new Conexion();
        string sql_insertar = "INSERT INTO ESPECIALIDAD VALUES (@especialidad,@descripcion)";

        public string insertarEspecialidad(Especialidad esp)
        {
            SqlConnection conn = null;
            SqlCommand stmt = null;
            try
            {
                conn = conexion.getConnection();
                conn.Open();
                stmt = new SqlCommand(sql_insertar, conn);
                stmt.Parameters.AddWithValue("@especialidad", esp.getEspecialidad());
                stmt.Parameters.AddWithValue("@descripcion", esp.getDescripcion());                
                stmt.ExecuteNonQuery();
                conn.Close();
                return "Inserccion Exitosta desde el DAO";
            }
            catch (Exception ex)
            {
                return ex.ToString();//Regresa la excepcion
            }
        }
    }
}
