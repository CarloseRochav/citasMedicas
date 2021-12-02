using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoEquipo3_1.Models;
using ProyectoEquipo3_1.DAO;

namespace ProyectoEquipo3_1.Controllers
{
    class PacienteController
    {
        Paciente paciente;
        PacienteDAO dao=new PacienteDAO();
        public string Inserccion(string paterno, string materno, string nombre, string genero, string fecha, string correo, string contrasenia)
        {

            char gen = genero.ToCharArray()[0];//Conversion de String a Char

            try
            {
                paciente = new Paciente(paterno, materno, nombre, gen, fecha, correo, contrasenia);
                return dao.insertarPaciente(paciente);//Le pasamos nuestro objeto
            }
            catch
            {
                return dao.insertarPaciente(paciente);//regresa alguna excepcion
            }


        }
    }
}
