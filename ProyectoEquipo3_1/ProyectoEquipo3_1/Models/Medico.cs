using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEquipo3_1.Models
{
    class Medico
    {        
        public int id { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string nombre { get; set; }
        public char genero { get; set; }//Para que solo almacene un valor
        public string fechaNac { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }

        public string especialidad { get; set; }

        public Medico(string paterno, string materno, string nombre, char genero, string fechaNac, string correo, string contrasenia,string especialidad)
        {
            this.aPaterno = paterno;
            this.aMaterno = materno;
            this.nombre = nombre;
            this.genero = genero;
            this.fechaNac = fechaNac;
            this.correo = correo;
            this.contrasenia = contrasenia;
            this.especialidad = especialidad;
        }

        //ID
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        //Apellido Paterno
        public string getPaterno()
        {
            return aPaterno;
        }
        public void setPaterno(string paterno)
        {
            this.aPaterno = paterno;
        }
        //Apellido Materno
        public string getMaterno()
        {
            return aMaterno;
        }
        public void setMaterno(string materno)
        {
            this.aMaterno = materno;
        }
        //Nombre
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        //Genero
        public char getGenero()
        {
            return genero;
        }
        public void setGenero(char gen)
        {
            this.genero = gen;
        }
        //Fecha de Nacimiento
        public string getFecha()
        {
            return fechaNac;
        }
        public void setFecha(string fecha)
        {
            this.fechaNac = fecha;
        }

        //Correo
        public string getCorreo()
        {
            return correo;
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        }

        //Contraseña
        public string getContrasenia()
        {
            return contrasenia;
        }
        public void setContrasenia(string contrasenia)
        {
            this.contrasenia = contrasenia;
        }

        //Especialidad
        public string getEspecialidad()
        {
            return especialidad;
        }
        public void setEspecialidad(string esp)
        {
            this.especialidad = esp;
        }
    }
}
