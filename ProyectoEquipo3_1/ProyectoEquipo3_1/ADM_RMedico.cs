using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEquipo3_1.Models;
using ProyectoEquipo3_1.Controllers;

namespace ProyectoEquipo3_1
{
    public partial class ADM_RMedico : Form
    {

        MedicoController controller = new MedicoController();
        public ADM_RMedico()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)//Insertar Medico
        {
            string aPaterno = textBox2.Text;
            string aMaterno = textBox3.Text;
            string nombre = textBox4.Text;
            string especialidad = comboBox2.Text;
            string genero = comboBox1.Text;
            string fecha = textBox6.Text;
            string correo = textBox7.Text;
            string contrasenia = textBox8.Text;

            
            try
            {
                string mensaje = controller.Inserccion(aPaterno, aMaterno, nombre, genero, fecha, correo, contrasenia,especialidad);
                MessageBox.Show(mensaje);
            }
            catch
            {
                string mensaje = controller.Inserccion(aPaterno, aMaterno, nombre, genero, fecha, correo, contrasenia,especialidad);
                MessageBox.Show(mensaje);
            }
        }
    }
}
