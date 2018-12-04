using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaNegocio;


namespace Prueba.Cliente
{
    
    public partial class ModificarCliente : Form
    {
        UsuarioNeg usuario = new UsuarioNeg();
        int id_usuario = 0;
        public ModificarCliente(int id)
        {
            id_usuario = id;
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = id_usuario;
                int rol = 1;
                usuario.Editar(id_usuario, txtEmail.Text, Convert.ToInt32(txtTelefono.Text), rol);
                MessageBox.Show("Se Modifico Correctamente el usuario");
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al ingresar el usuario");
            }

        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
