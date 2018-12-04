using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba.Administrador
{
    public partial class MenuAdministrador : Form
    {
        int id_usuario = 0;
        public MenuAdministrador(int id)
        {
            id_usuario = id;
            InitializeComponent();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
