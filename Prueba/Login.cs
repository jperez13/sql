using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaNegocio;
using PruebaDatos;

namespace Prueba
{
    public partial class Login : Form
    {
        private UsuarioNeg us = new UsuarioNeg();

        public Login()
        {
            InitializeComponent();
        }

        public void Loguear(string mail, string pass)
        {
            try
            {
                int rol = us.login(txtEmail.Text, txtPass.Text);
                if (rol <= 0)
                {
                    MessageBox.Show("Usuario no encontrado");
                }
                else
                {
                    this.Hide();
                    if (rol == 1)
                    {
                        Ejecutivo.MenuEjecutivo m = new Ejecutivo.MenuEjecutivo();
                        m.Show();
                    }
                    else if (rol == 2)
                    {
                        int id = us.id_usuario(txtEmail.Text, txtPass.Text);
                        Administrador.MenuAdministrador me = new Administrador.MenuAdministrador(id);
                        me.Show();

                    }
                    else if (rol == 3)
                    {
                        int id = us.id_usuario(txtEmail.Text, txtPass.Text);
                        Cliente.MenuCliente ce = new Cliente.MenuCliente(id);
                        ce.Show();
                    }

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show(this, "");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loguear(txtEmail.Text, txtPass.Text);
        }
    }
}
