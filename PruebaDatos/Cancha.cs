using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDatos
{
    public class Cancha
    {
        public int ID_CANCHA { get; set; }
        public string DIRECCION { get; set; }
        public int PRECIO_HORA { get; set; }
        public int HORARIO_APERTURA { get; set; }
        public int HORARIO_CIERRE { get; set; }
        public string DESCRIPCION { get; set; }
        public bool ESTADO { get; set; }
        public int USUARIO_ID { get; set; }

        public Cancha()
        {
        }

        public Cancha(int ID_CANCHA,
                      string DIRECCION,
                      int PRECIO_HORA,
                      int HORARIO_APERTURA,
                      int HORARIO_CIERRE,
                      string DESCRIPCION,
                      bool ESTADO,
                      int USUARIO_ID)
        {
            ID_CANCHA = ID_CANCHA;
            DIRECCION = DIRECCION;
            PRECIO_HORA = PRECIO_HORA;
            HORARIO_APERTURA = HORARIO_APERTURA;
            HORARIO_CIERRE = HORARIO_CIERRE;
            DESCRIPCION = DESCRIPCION;
            ESTADO = ESTADO;
            USUARIO_ID = USUARIO_ID;
        }

        private ConexionDB conexion = new ConexionDB();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand com = new SqlCommand();

        public DataTable MostrarCancha()
        {
            com.Connection = conexion.Abrir();
            com.CommandText = "SP_TODOS_CANCHA";
            com.CommandType = CommandType.StoredProcedure;
            leer = com.ExecuteReader();
            tabla.Load(leer);
            conexion.Cerrar();
            return tabla;
        }

        public void InsertarCancha(string DIRECCION,
                                    int PRECIO_HORA,
                                    int HORARIO_APERTURA,
                                    int HORARIO_CIERRE,
                                    string DESCRIPCION,
                                    bool ESTADO,
                                    int USUARIO_ID)
        {
            ConexionDB objConexion = new ConexionDB();
            SqlConnection cn = objConexion.getConexion();
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_INGRESAR_CANCHA";

            cmd.Parameters.Add("@P_DIRECCION", SqlDbType.VarChar, 255).Value = DIRECCION;
            cmd.Parameters["@P_DIRECCION"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_PRECIO_HORA", SqlDbType.Int).Value = PRECIO_HORA;
            cmd.Parameters["@P_PRECIO_HORA"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_HORARIO_APERTURA", SqlDbType.Int).Value = HORARIO_APERTURA;
            cmd.Parameters["@P_HORARIO_APERTURA"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_HORARIO_CIERRE", SqlDbType.Int).Value = HORARIO_CIERRE;
            cmd.Parameters["@P_HORARIO_CIERRE"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_DESCRIPCION", SqlDbType.VarChar, 255).Value = DESCRIPCION;
            cmd.Parameters["@P_DESCRIPCION"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_ESTADO", SqlDbType.Bit).Value = ESTADO;
            cmd.Parameters["@P_ESTADO"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_USUARIO_ID", SqlDbType.Int).Value = USUARIO_ID;
            cmd.Parameters["@P_USUARIO_ID"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ActualizarCancha(int ID_USUARIO,
                                      string DIRECCION,
                                      int PRECIO_HORA,
                                      int HORARIO_APERTURA,
                                      int HORARIO_CIERRE,
                                      string DESCRIPCION,
                                      bool ESTADO,
                                      int USUARIO_ID)
        {


            ConexionDB objConexion = new ConexionDB();
            SqlConnection cn = objConexion.getConexion();
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_ACTUALIZAR_CANCHA";

            cmd.Parameters.Add("@P_ID_CANCHA", SqlDbType.Int).Value = ID_CANCHA;
            cmd.Parameters["@P_ID_CANCHA"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_DIRECCION", SqlDbType.VarChar, 255).Value = DIRECCION;
            cmd.Parameters["@P_DIRECCION"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_PRECIO_HORA", SqlDbType.Int).Value = PRECIO_HORA;
            cmd.Parameters["@P_PRECIO_HORA"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_HORARIO_APERTURA", SqlDbType.Int).Value = HORARIO_APERTURA;
            cmd.Parameters["@P_HORARIO_APERTURA"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_HORARIO_CIERRE", SqlDbType.Int).Value = HORARIO_CIERRE;
            cmd.Parameters["@P_HORARIO_CIERRE"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_DESCRIPCION", SqlDbType.VarChar, 255).Value = DESCRIPCION;
            cmd.Parameters["@P_DESCRIPCION"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_ESTADO", SqlDbType.Bit).Value = ESTADO;
            cmd.Parameters["@P_ESTADO"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@P_USUARIO_ID", SqlDbType.Int).Value = USUARIO_ID;
            cmd.Parameters["@P_USUARIO_ID"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        public void EliminarCancha(int ID_CANCHA)
        {
            ConexionDB objConexion = new ConexionDB();
            SqlConnection cn = objConexion.getConexion();
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_ELIMINAR_CANCHA";
            cmd.Parameters.Add("@P_ID_CANCHA", SqlDbType.Int).Value = ID_CANCHA;
            cmd.Parameters["@P_ID_CANCHA"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }



    }
}