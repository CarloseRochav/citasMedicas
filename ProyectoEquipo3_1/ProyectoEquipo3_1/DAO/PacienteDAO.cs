using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoEquipo3_1.Models;
using ProyectoEquipo3_1.Connection;

namespace ProyectoEquipo3_1.DAO
{
    class PacienteDAO
    {
        private const string sql_insertar = "INSERT INTO PACIENTE VALUES (@paterno,@materno,@nombre,@genero,@fecha,@correo,@contrasenia)";
        static Conexion conexion = new Conexion();//Estatico

        public string insertarPaciente(Paciente pac)
        {
            SqlConnection conn = null;
            SqlCommand stmt = null;

            try
            {
                conn = conexion.getConnection();
                conn.Open();
                stmt = new SqlCommand(sql_insertar, conn);
                stmt.Parameters.AddWithValue("@paterno", pac.getPaterno());
                stmt.Parameters.AddWithValue("@materno", pac.getMaterno());
                stmt.Parameters.AddWithValue("@nombre", pac.getNombre());
                stmt.Parameters.AddWithValue("@genero", pac.getGenero());
                stmt.Parameters.AddWithValue("@fecha", pac.getFecha());
                stmt.Parameters.AddWithValue("@correo", pac.getCorreo());
                stmt.Parameters.AddWithValue("@contrasenia", pac.getContrasenia());
                stmt.ExecuteNonQuery();
                conn.Close();
                return "Inserccion Exitosta desde el DAO";


            }
            catch (Exception ex)
            {
                return ex.ToString();
                //throw new HttpResponseException(HttpStatusCode.NotFound);                
                //throw new Exception("Outer", ex);//Detiene la app y muestra mensaje                
            }
        }
    }
}
