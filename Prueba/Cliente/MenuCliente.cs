using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba.Cliente
{
    public partial class MenuCliente : Form
    {
        int id_usuario = 0;
        public MenuCliente(int id)
        {
            id_usuario = id;
            InitializeComponent();
            label1.Text = Convert.ToString(id_usuario);
        }

        private void listarCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoCanchas f = new ListadoCanchas(id_usuario);
            f.Show();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCliente m = new ModificarCliente(id_usuario);
        }
    }
}
