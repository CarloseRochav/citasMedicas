using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoEquipo3_1.Models;
using ProyectoEquipo3_1.DAO;

namespace ProyectoEquipo3_1.Controllers
{
    class EspecialidadController
    {
        EspecialidadDAO dao = new EspecialidadDAO();
        Especialidad esp;

        public string insertar(string nombre,string descripcion)
        {
            try
            {
                 esp = new Especialidad(nombre,descripcion);
                return dao.insertarEspecialidad(esp);//Le pasamos nuestro objeto
            }
            catch
            {
                return dao.insertarEspecialidad(esp);//regresa alguna excepcion
            }
        }
    }
}
