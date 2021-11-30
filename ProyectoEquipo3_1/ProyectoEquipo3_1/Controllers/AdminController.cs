using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoEquipo3_1.Models;
using ProyectoEquipo3_1.DAO;

namespace ProyectoEquipo3_1.Controllers
{
    class AdminController
    {

        AdminDAO dao = new AdminDAO();

        public string insertarRegistro(Admin admin)
        {
            try
            {
                dao.insertarRegistro(admin);
                return "Inserccion Exitosa";
            }catch(Exception ex)
            {
                return ex.ToString();
            }
        }



    }
}
