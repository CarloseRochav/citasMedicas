using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEquipo3_1.Controllers;

namespace ProyectoEquipo3_1
{
    public partial class ADM_RClientes : Form
    {
        public ADM_RClientes()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)//Mandar datos al Controller
        {
            string aPaterno = textBox2.Text;
            string aMaterno = textBox3.Text;
            string nombre = textBox4.Text;
            string genero = comboBox1.Text;
            string fecha = textBox6.Text;
            string correo = textBox7.Text;
            string contrasenia = textBox8.Text;

            PacienteController controller = new PacienteController();
            try
            {
                string mensaje = controller.Inserccion(aPaterno, aMaterno, nombre, genero, fecha, correo, contrasenia);
                MessageBox.Show(mensaje);
            }
            catch
            {
                string mensaje = controller.Inserccion(aPaterno, aMaterno, nombre, genero, fecha, correo, contrasenia);
                MessageBox.Show(mensaje);
            }
        }
        
    }
}
