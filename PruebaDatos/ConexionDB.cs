using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace PruebaDatos
{
   public class ConexionDB
    { 
        private SqlConnection con { get; set; }

        public SqlConnection getConexion()
        {
            if (con == null)
            {
                string conexion = ConfigurationManager.AppSettings["ConexionSQL"].ToString();
                con = new SqlConnection(conexion);
            }
            return con;
        }
    }
}
