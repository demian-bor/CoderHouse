using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class DB_Connection
    {
        private string connectionString = "Server=.; DataBase=coderhouse; Trusted_Connection=True; TrustServerCertificate=True";

        public SqlConnection NewConnection()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            return conexion;
        }
    }
}
