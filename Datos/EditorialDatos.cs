using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;




namespace BibliotecaApp.Datos
{
    internal class EditorialDatos
    {
        public static DataTable ListarEditoriales()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "SELECT id_editorial, nombre, pais FROM Editoriales";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
            }

            return tabla;

        }

        public static void RegistrarEditorial(string nombre, string pais)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = @"INSERT INTO Editoriales (nombre, pais)
                            VALUES (@nombre, @pais)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@pais", pais);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void EditarEditorial(int idEditorial, string nombre, string pais)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = @"UPDATE Editoriales
                            SET nombre = @nombre,
                                pais = @pais
                            WHERE id_editorial = @idEditorial";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idEditorial", idEditorial);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@pais", pais);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void EliminarEditorial(int idEditorial)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                conexion.Open();

                string consulta = @"DELETE FROM Editoriales
                            WHERE id_editorial = @idEditorial";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idEditorial", idEditorial);
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}
