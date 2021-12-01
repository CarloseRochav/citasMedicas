using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoEquipo3_1.Models;
using ProyectoEquipo3_1.DAO;

namespace ProyectoEquipo3_1.Controllers
{
    class MedicoController
    {
        Medico med;
        MedicoDAO dao = new MedicoDAO();


        public string Inserccion(string paterno, string materno, string nombre, string genero, string fecha, string correo, string contrasenia,string esp)
        {

            char gen = genero.ToCharArray()[0];//Conversion de String a Char

            try
            {
                med = new Medico(paterno, materno, nombre, gen, fecha, correo, contrasenia,esp);
                return dao.insertarMedico(med);//Le pasamos nuestro objeto
            }
            catch
            {
                return dao.insertarMedico(med);//regresa alguna excepcion
            }


        }
    }
}
