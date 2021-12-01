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
    class MedicoDAO
    {
        Conexion conexion = new Conexion();
        string sql_insertar = "INSERT INTO MEDICO VALUES(@paterno,@materno,@nombre,@genero,@fecha,@correo,@contrasenia,@espe)";

        public string insertarMedico(Medico med)
        {
            SqlConnection conn = null;
            SqlCommand stmt = null;

            try
            {
                conn = conexion.getConnection();
                conn.Open();
                stmt = new SqlCommand(sql_insertar, conn);
                stmt.Parameters.AddWithValue("@paterno", med.getPaterno());
                stmt.Parameters.AddWithValue("@materno", med.getMaterno());
                stmt.Parameters.AddWithValue("@nombre", med.getNombre());
                stmt.Parameters.AddWithValue("@genero", med.getGenero());
                stmt.Parameters.AddWithValue("@fecha", med.getFecha());
                stmt.Parameters.AddWithValue("@correo", med.getCorreo());
                stmt.Parameters.AddWithValue("@contrasenia", med.getContrasenia());
                stmt.Parameters.AddWithValue("@espe", med.getContrasenia());
                stmt.ExecuteNonQuery();
                conn.Close();
                return "Inserccion Exitosta desde el DAO";

            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        
    }
}
