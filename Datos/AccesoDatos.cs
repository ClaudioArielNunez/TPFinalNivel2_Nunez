using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
                    
        private SqlConnection conexion = new SqlConnection("server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true");

        public SqlConnection abrir()
        {
            if(conexion.State == System.Data.ConnectionState.Closed) 
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection cerrar()
        {
            if(conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
        


    }
}
