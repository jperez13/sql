using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaDatos;

namespace PruebaNegocio
{
    public class CanchaNeg
    {
        private Cancha cancha = new Cancha();

        public DataTable mostrarCancha()
        {
            DataTable tabla = new DataTable();
            tabla = cancha.MostrarCancha();
            return tabla;
        }

        public void InsertarCancha(string direccion, int precio_hora, int horario_apertura,
                                  int horario_cierre,, string descripcion, int estado, int id_usuario)
        {
            cancha.InsertarCancha(direccion,precio_hora,horario_apertura,horario_cierre,descripcion,estado,id_usuario);
        }

        public void Editar(int id_cancha,string direccion, int precio_hora, int horario_apertura,
                                  int horario_cierre, string descripcion, int estado, int id_usuario)
        {
            cancha.ActualizarCancha(id_cancha,direccion, precio_hora, horario_apertura, horario_cierre, descripcion, estado, id_usuario);
        }


        public void Eliminar(int id_cancha)
        {
            cancha.EliminarCancha(id_cancha);
        }
    }
}
