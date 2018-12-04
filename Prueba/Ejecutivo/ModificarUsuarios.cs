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
    public partial class ModificarUsuarios : Form
    {
        private UsuarioNeg us = new UsuarioNeg();
        private string idUsuario = null;

        public ModificarUsuarios()
        {
            InitializeComponent();
            mostrarUsuarios();

        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ROL' table. You can move, or remove it, as needed.
            this.rOLTableAdapter.Fill(this.dataSet1.ROL);
            mostrarUsuarios();
        }

        private void mostrarUsuarios()
        {
            dataGridView1.DataSource = us.mostrarUsua();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblID.Text = dataGridView1.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
                idUsuario= dataGridView1.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                int rol = Convert.ToInt32(cmbRol.SelectedValue);
                us.Editar(Convert.ToInt32(idUsuario), txtEmail.Text, Convert.ToInt32(txtTelefono.Text), rol);
                MessageBox.Show("Se Agrego Correctamente el usuario");
                mostrarUsuarios();

            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al ingresar el usuario");
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_usuario = Convert.ToInt32(lblID.Text);
                us.eliminarUsuario(id_usuario);
                MessageBox.Show("Usuario Eliminado");
                mostrarUsuarios();
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al ingresar el usuario");
            }
            
        }
    }
}
