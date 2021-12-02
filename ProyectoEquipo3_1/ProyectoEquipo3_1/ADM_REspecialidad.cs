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
    public partial class ADM_REspecialidad : Form
    {
        EspecialidadController controller = new EspecialidadController();//Controlador
        public ADM_REspecialidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string descripcion = textBox2.Text;
            string mensaje;
            try
            {
                mensaje = controller.insertar(nombre, descripcion);
                MessageBox.Show(mensaje);
            }
            catch
            {
                mensaje = controller.insertar(nombre, descripcion);
                MessageBox.Show(mensaje);
            }

        }
    }
}
