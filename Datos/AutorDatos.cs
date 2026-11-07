using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    internal class AutorDatos
    {
        public static DataTable ListarAutores()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "SELECT id_autor, nombre, apellido, nacionalidad FROM Autores";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }
        public static void RegistrarAutor(string nombre, string apellido, string nacionalidad)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = @"INSERT INTO Autores (nombre, apellido, nacionalidad)
                            VALUES (@nombre, @apellido, @nacionalidad)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void EditarAutor(int idAutor, string nombre, string apellido, string nacionalidad)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = @"UPDATE Autores
                            SET nombre = @nombre,
                                apellido = @apellido,
                                nacionalidad = @nacionalidad
                            WHERE id_autor = @idAutor";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idAutor", idAutor);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarAutor(int idAutor)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                conexion.Open();

                string consulta = @"DELETE FROM Autores
                            WHERE id_autor = @idAutor";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idAutor", idAutor);
                    comando.ExecuteNonQuery();
                }
            }
        }





    }
}
