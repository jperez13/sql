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

namespace Prueba
{
    public partial class ListadoCanchas : Form
    {
        int id_usuario = 0;
        CanchaNeg cancha = new CanchaNeg();
        public ListadoCanchas(int id)
        {
            id_usuario = id;
            InitializeComponent();
            GListadoCanchas.DataSource = cancha.mostrarCancha();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
               
        }

        private void ListadoCanchas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.CANCHA' Puede moverla o quitarla según sea necesario.
            this.cANCHATableAdapter.Fill(this.dataSet1.CANCHA);

        }
    }
}
