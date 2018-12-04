using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba.Ejecutivo
{
    public partial class MenuEjecutivo : Form
    {
        public MenuEjecutivo()
        {
            InitializeComponent();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuarios m = new ModificarUsuarios();
            m.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEjecutivo m = new MenuEjecutivo();
            m.Close();
        }

        private void listadoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuario a = new AgregarUsuario();
            a.Show();
        }
    }
}
