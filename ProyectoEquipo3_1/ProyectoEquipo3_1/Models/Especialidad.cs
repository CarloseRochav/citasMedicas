using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEquipo3_1.Models
{
    class Especialidad
    {
        public int id { get; set; }
        public string especialidad { get; set; }
        public string descripcion { get; set; }

        public Especialidad(string espe,string descr)
        {
            this.especialidad = espe;
            this.descripcion = descr;
        }

        //getters y setters
        public string getEspecialidad()
        {
            return especialidad;
        }
        public void  setEspecialidad(string esp)
        {
            this.especialidad = esp;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
        public void setDescrip(string descrip)
        {
            this.descripcion = descrip;
        }
    }
}
