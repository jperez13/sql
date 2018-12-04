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

namespace Prueba.Ejecutivo
{
    public partial class AgregarUsuario : Form
    {
        private UsuarioNeg us = new UsuarioNeg();
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int rol = Convert.ToInt32(cmbRol.SelectedValue);
                us.Insertar(Convert.ToInt32(txtRut.Text), txtDv.Text, txtNombre.Text, txtEmail.Text, Convert.ToInt32(txtTelefono.Text), txtPass.Text, rol);
                MessageBox.Show("Se Agrego Correctamente el usuario");
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al ingresar el usuario");
            }
            
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ROL' table. You can move, or remove it, as needed.
            this.rOLTableAdapter.Fill(this.dataSet1.ROL);

        }
    }
}
