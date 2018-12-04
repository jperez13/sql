using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDatos
{
    public class Usuario
    {
        public Usuario()
        {
        }

        private ConexionDB conexion = new ConexionDB();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand com = new SqlCommand();

        public DataTable MostrarUsuario()
        {
            ConexionDB objConexion = new ConexionDB();
            SqlConnection cn = objConexion.getConexion();
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_TODOS_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }

        public void InsertarUsuario(int RUT, string DV, string NOMBRE, string EMAIL, int TELEFONO, string PASSWORD, int ROL_ID)
        {
            ConexionDB objConexion = new ConexionDB();
            SqlConnection cn = objConexion.getConexion();
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_INGRESAR_USUARIO";

            cmd.Parameters.Add("@P_RUT", SqlDbType.Int).Value = RUT;
            cmd.Parameters["@P_RUT"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_DV", SqlDbType.VarChar, 1).Value = DV;
            cmd.Parameters["@P_DV"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_NOMBRE", SqlDbType.VarChar, 50).Value = NOMBRE;
            cmd.Parameters["@P_NOMBRE"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_EMAIL", SqlDbType.VarChar, 100).Value = EMAIL;
            cmd.Parameters["@P_EMAIL"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_TELEFONO", SqlDbType.Int).Value = TELEFONO;
            cmd.Parameters["@P_TELEFONO"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_PASSWORD", SqlDbType.VarChar, 250).Value = PASSWORD;
            cmd.Parameters["@P_PASSWORD"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_ROL_ID", SqlDbType.Int).Value = ROL_ID;
            cmd.Parameters["@P_ROL_ID"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ActualizarUsuario(int ID_USUARIO, string EMAIL, int TELEFONO, int ROL_ID)
        {
            

            ConexionDB objConexion = new ConexionDB();
            SqlConnection cn = objConexion.getConexion();
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_ACTUALIZAR_USUARIO";

            cmd.Parameters.Add("@P_ID_USUARIO", SqlDbType.Int).Value = ID_USUARIO;
            cmd.Parameters["@P_ID_USUARIO"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_EMAIL", SqlDbType.VarChar, 100).Value = EMAIL;
            cmd.Parameters["@P_EMAIL"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_TELEFONO", SqlDbType.Int).Value = TELEFONO;
            cmd.Parameters["@P_TELEFONO"].Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@P_ROL_ID", SqlDbType.Int).Value = ROL_ID;
            cmd.Parameters["@P_ROL_ID"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        public void EliminarUsuario(int id_usuario)
        {
            ConexionDB objConexion = new ConexionDB();
            SqlConnection cn = objConexion.getConexion();
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_ELIMINAR_USUARIO";
            cmd.Parameters.Add("@P_ID_USUARIO", SqlDbType.Int).Value = id_usuario;
            cmd.Parameters["@P_ID_USUARIO"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        //public int AutenticarUsuario(string EMAIL, string PASSWORD)
        //{
        //    try
        //    {
        //        int id = 0;
        //        com.Connection = conexion.Abrir();
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.CommandText = "SP_AUTENTICAR_USUARIO";
        //        //com.CommandType = CommandType.StoredProcedure;
        //        //com.Parameters.AddWithValue("@P_EMAIL", EMAIL).Direction = ParameterDirection.Input;
        //        //com.Parameters.AddWithValue("@P_PASSWORD", PASSWORD).Direction = ParameterDirection.Input;
        //        com.Parameters.Add("@P_EMAIL", SqlDbType.VarChar, 100).Value = EMAIL;
        //        com.Parameters["@P_EMAIL"].Direction = ParameterDirection.Input;
        //        com.Parameters.Add("@P_PASSWORD", SqlDbType.VarChar, 250).Value = EMAIL;
        //        com.Parameters["@P_PASSWORD"].Direction = ParameterDirection.Input;
        //        SqlDataReader reader = com.ExecuteReader();
        //        leer = com.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            id = reader.GetInt16(0);
        //            return id;
        //        }

        //        //usuario.ID_USUARIO = Convert.ToInt32(dt.Rows[0][0].ToString());
        //        //usuario.RUT = Convert.ToInt32(dt.Rows[0][1].ToString());
        //        //usuario.DV = dt.Rows[0][2].ToString();
        //        //usuario.NOMBRE = dt.Rows[0][3].ToString();
        //        //usuario.EMAIL = dt.Rows[0][4].ToString();
        //        //usuario.TELEFONO = Convert.ToInt32(dt.Rows[0][5].ToString());
        //        //usuario.PASSWORD = dt.Rows[0][6].ToString();
        //        //usuario.ESTADO = Convert.ToBoolean(dt.Rows[0][7].ToString());
        //        //usuario.ROL_ID = Convert.ToInt32(dt.Rows[0][8].ToString());
        //        return id;
        //    }
        //    catch (SqlException sql)
        //    {
        //        string mensaje = sql.ToString();
        //        return 0;
        //    }


        //}

        


        public int login(string EMAIL, string PASSWORD){
            int rol = 0;    
            try
            {
                ConexionDB objConexion = new ConexionDB();
                SqlConnection cn = objConexion.getConexion();
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_AUTENTICAR_USUARIO";

                cmd.Parameters.Add("@P_EMAIL", SqlDbType.VarChar, 100).Value = EMAIL;
                cmd.Parameters["@P_EMAIL"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@P_PASSWORD", SqlDbType.VarChar, 250).Value = PASSWORD;
                cmd.Parameters["@P_PASSWORD"].Direction = ParameterDirection.Input;
 
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    rol = Convert.ToInt32(dr["ROL_ID"]);
                    
                }

                cn.Close();
                cmd.Dispose();
                objConexion = null;

                return rol;

            }
            catch (SqlException sql)
            {
                return rol;
            }
        }

        public int id_usuario(string EMAIL, string PASSWORD)
        {
            int idUsuario = 0;
            try
            {
                ConexionDB objConexion = new ConexionDB();
                SqlConnection cn = objConexion.getConexion();
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_AUTENTICAR_USUARIO";

                cmd.Parameters.Add("@P_EMAIL", SqlDbType.VarChar, 100).Value = EMAIL;
                cmd.Parameters["@P_EMAIL"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@P_PASSWORD", SqlDbType.VarChar, 250).Value = PASSWORD;
                cmd.Parameters["@P_PASSWORD"].Direction = ParameterDirection.Input;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    idUsuario = Convert.ToInt32(dr["ID_USUARIO"]);

                }

                cn.Close();
                cmd.Dispose();
                objConexion = null;

                return idUsuario;

            }
            catch (SqlException sql)
            {
                return idUsuario;
            }
        }
    }
}
