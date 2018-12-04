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

namespace Prueba.Administrador
{
    public partial class ModificarCancha : Form
    {
        int id_usuario = 0;
        CanchaNeg cancha = new CanchaNeg();
        public ModificarCancha(int id)
        {
            InitializeComponent();
            id_usuario = id;
            InitializeComponent();
            mostrarCanchas();
        }

        public void mostrarCanchas()
        {
            GCanchas.DataSource = cancha.mostrarCancha();
        }

        private void ModificarCancha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.CANCHA' Puede moverla o quitarla según sea necesario.
            this.cANCHATableAdapter.Fill(this.dataSet1.CANCHA);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GCanchas.SelectedRows.Count > 0)
            {
                txtID.Text = GCanchas.CurrentRow.Cells["ID_CANCHA"].Value.ToString();
                txtDireccion.Text = GCanchas.CurrentRow.Cells["DIRECCION"].Value.ToString();
                txtPrecio.Text = GCanchas.CurrentRow.Cells["PRECIO_HORA"].Value.ToString();
                txtHApertura.Text = GCanchas.CurrentRow.Cells["HORARIO_APERTURA"].Value.ToString();
                txtHCierre.Text = GCanchas.CurrentRow.Cells["HORARIO_CIERRE"].Value.ToString();
                txtDescripcion.Text = GCanchas.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                txtEstado.Text = GCanchas.CurrentRow.Cells["ESTADO"].Value.ToString();
                txtID_Usuario.Text = Convert.ToString(id_usuario);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cancha.Editar(Convert.ToInt32(txtID), txtDescripcion.Text, Convert.ToInt32(txtPrecio),
                              Convert.ToInt32(txtHApertura.Text), Convert.ToInt32(txtHCierre), txtDescripcion.Text,
                              Convert.ToInt32(txtEstado), Convert.ToInt32(txtID_Usuario));
                mostrarCanchas();
                
                MessageBox.Show("Se Agrego Correctamente el usuario");

            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al ingresar el usuario");
            }
        }
    }
}
