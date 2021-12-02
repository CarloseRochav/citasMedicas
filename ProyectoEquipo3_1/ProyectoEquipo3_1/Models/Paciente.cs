using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEquipo3_1.Models
{
    class Paciente
    {
        //        Create Table Paciente(
        //IdPaciente int primary key not null,
        //ApellidoPaterno varchar(30)not null,
        //ApellidoMaterno varchar(30)not null,
        //Nombre varchar(30)not null,
        //Genero varchar(15)not null,
        //FechaNacimiento datetime not null,
        //CorreoElectronico varchar(30) not null,
        //Contraseña varchar(30) not null,
        //)

        public int id { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string nombre { get; set; }
        public char genero { get; set; }//Para que solo almacene un valor
        public string fechaNac { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }


        //Insertar Datos
        public Paciente(string paterno, string materno, string nombre, char genero, string fechaNac, string correo, string contrasenia)
        {
            this.aPaterno = paterno;
            this.aMaterno = materno;
            this.nombre = nombre;
            this.genero = genero;
            this.fechaNac = fechaNac;
            this.correo = correo;
            this.contrasenia = contrasenia;
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
    }
}
