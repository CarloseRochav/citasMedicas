using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEquipo3_1.Models
{
    class Admin
    {
        //Propiedades del modelo
        public int id { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }

        //Constructores - >

        //Inserccion
        public Admin(string _correo,string _contrasenia)
        {

            this.correo = _correo;
            this.contrasenia = _contrasenia;
        }

        //Actualizar
        public Admin(int _id,string _correo, string _contrasenia)
        {
            this.id = _id;
            this.correo = _correo;
            this.contrasenia = _contrasenia;
        }

        //Obtener id de objeto
        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            this.id = _id;
        }

        //Correo
        public string getCorreo()
        {
            return correo;
        }

        public void setCorreo(string _correo)
        {
            this.correo = _correo;
        }
        //Cortraseña
        public string getContrasenia()
        {
            return contrasenia;
        }
        public void setContrasenia(string _contrasenia)
        {
            this.contrasenia = _contrasenia;
        }


    }
}
