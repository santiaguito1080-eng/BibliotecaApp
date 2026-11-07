using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    internal class Conexion
    {
        public static SqlConnection GetConnection()
        {
           string connectionString = "Server=localhost;Database=appbiblioteca;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;

        }

        public static bool TestConnection()
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                return true;
            }
        }

    }

}