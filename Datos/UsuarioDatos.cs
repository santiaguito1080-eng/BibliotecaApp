using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    internal class UsuarioDatos
    {
        public static DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "SELECT id_usuarios, NOMBRES, APELLIDOS, DOCUMENTO, TELEFONO, CORREO FROM Usuarios";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public static void RegistrarUsuario(string nombres, string apellidos, string documento, string telefono, string correo)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "INSERT INTO Usuarios (NOMBRES, APELLIDOS, DOCUMENTO, TELEFONO, CORREO) VALUES (@nombres, @apellidos, @documento, @telefono, @correo)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombres", nombres);
                    comando.Parameters.AddWithValue("@apellidos", apellidos);
                    comando.Parameters.AddWithValue("@documento", documento);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@correo", correo);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }


        public static void EditarUsuario(int id, string nombres, string apellidos, string documento, string telefono, string correo)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "UPDATE Usuarios SET NOMBRES = @nombres, APELLIDOS = @apellidos, DOCUMENTO = @documento, TELEFONO = @telefono, CORREO = @correo WHERE id_usuarios = @id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombres", nombres);
                    comando.Parameters.AddWithValue("@apellidos", apellidos);
                    comando.Parameters.AddWithValue("@documento", documento);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@correo", correo);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void EliminarUsuario(int id)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "DELETE FROM Usuarios WHERE id_usuarios = @id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
