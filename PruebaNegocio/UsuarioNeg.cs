using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PruebaDatos;

namespace PruebaNegocio
{
    public class UsuarioNeg
    {
        private Usuario usuario = new Usuario();

        public DataTable mostrarUsua()
        {
            DataTable tabla = new DataTable();
            tabla = usuario.MostrarUsuario();
            return tabla;
        }

        public void Insertar(int RUT, string DV, string NOMBRE, string EMAIL, int TELEFONO, string PASSWORD,  int ROL_ID)
        {
            usuario.InsertarUsuario(RUT,DV,NOMBRE,EMAIL,TELEFONO,PASSWORD,ROL_ID);
        }

        public void Editar(int ID_USUARIO, string EMAIL, int TELEFONO, int ROL_ID)
        {
            usuario.ActualizarUsuario(ID_USUARIO, EMAIL, TELEFONO, ROL_ID);
        }

        public int login(string EMAIL, string PASSWORD)
        {
            int rol = usuario.login(EMAIL, PASSWORD);
            return rol;
        }

        public int id_usuario(string EMAIL, string PASSWORD)
        {
            int idUsuario = usuario.id_usuario(EMAIL, PASSWORD);
            return idUsuario;
        }

        public void eliminarUsuario(int id_usuario)
        {
            usuario.EliminarUsuario(id_usuario);
        }


    }
}
