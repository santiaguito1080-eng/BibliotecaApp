using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using BibliotecaApp.Negocio;
using System.Data;
namespace BibliotecaApp.Datos;


    internal class PrestamoDatos
    {
        public static void RegistrarPrestamo(DateTime fechaPrestamo,DateTime fechaEstimadaDevolucion,int idLibro , int idUsuario)
        {
            Prestamo nuevoPrestamo = new Prestamo(fechaPrestamo,fechaEstimadaDevolucion, idLibro, idUsuario);



            using (SqlConnection connection = Conexion.GetConnection())
            {
                connection.Open();

            using (SqlTransaction transaction = connection.BeginTransaction())

            {
             try
             {

             
                    string queryInventario = "UPDATE Libros " +
               "SET cantidad_disponible = cantidad_disponible - 1 " +
               "WHERE id_libro = @IdLibro AND cantidad_disponible > 0";

                using (SqlCommand commandInventario = new SqlCommand(queryInventario, connection, transaction))
                {
                    commandInventario.Parameters.AddWithValue("@IdLibro", idLibro);
                    int filasAfectadas = commandInventario.ExecuteNonQuery();
                    if (filasAfectadas == 0)
                    {
                        throw new InvalidOperationException("No hay disponibilidad para prestrar.");
                    }





                }

                string query = "INSERT INTO Prestamos (FECHA_DE_PRESTAMO,FECHA_ESTIMADA_DEVOL,ESTADO,id_libro,id_usuarios) " +
                    "VALUES (@FechaPrestamo, @FechaEstimadaDevolucion, @Estado, @IdLibro, @IdUsuario)";

                using(SqlCommand command = new SqlCommand(query, connection,transaction))
                
                {
                 command.Parameters.AddWithValue("@FechaPrestamo",fechaPrestamo);
                 command.Parameters.AddWithValue("@FechaEstimadaDevolucion",fechaEstimadaDevolucion);
                 command.Parameters.AddWithValue("@Estado", "ACTIVO");
                 command.Parameters.AddWithValue("@IdLibro", idLibro);
                 command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                                    command.ExecuteNonQuery();
                }
                transaction.Commit();
             }
             catch
                {

                    transaction.Rollback();
                    throw;
                }



            } 
            }
        }
    public static DataTable ListarPrestamos()
    {
        DataTable tabla = new DataTable();

        using (SqlConnection conexion = Conexion.GetConnection())
        {
            string query = "SELECT p.id_prestamo, " +
                            "p.id_usuarios, " +
                            "p.id_libro, " +
                           "u.NOMBRES + ' ' + u.APELLIDOS AS Usuario, " +
                           "l.titulo AS Libro, " +
                           "p.FECHA_DE_PRESTAMO, " +
                           "p.FECHA_ESTIMADA_DEVOL, " +
                           "p.FECHA_DEVOLUCION, " +
                           "p.ESTADO " +
                           "FROM Prestamos p " +
                           "INNER JOIN Usuarios u ON p.id_usuarios = u.id_usuarios " +
                           "INNER JOIN Libros l ON p.id_libro = l.id_libro";

            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
        }

        return tabla;
    }

    public static DataTable ListarUsuarios()
    {
        DataTable tabla = new DataTable();

        using (SqlConnection conexion = Conexion.GetConnection())
        {
            string query = "SELECT id_usuarios, NOMBRES + ' ' + APELLIDOS AS NombreCompleto FROM Usuarios";

            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
        }

        return tabla;
    }


    public static DataTable ListarLibrosDisponibles()
    {
        DataTable tabla = new DataTable();

        using (SqlConnection conexion = Conexion.GetConnection())
        {
            string query = "SELECT id_libro, titulo FROM Libros " +
                           "WHERE cantidad_disponible > 0";

            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
        }

        return tabla;
    }
    public static void RegistrarDevolucion(int idPrestamo, DateTime fechaDevolucion)
    {
        using (SqlConnection conexion = Conexion.GetConnection())
        {
            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                string consultaLibro =
                    "SELECT id_libro FROM Prestamos " +
                    "WHERE id_prestamo = @idPrestamo AND ESTADO = 'ACTIVO'";

                int idLibro;

                using (SqlCommand comando = new SqlCommand(consultaLibro, conexion, transaccion))
                {
                    comando.Parameters.AddWithValue("@idPrestamo", idPrestamo);

                    object? resultado = comando.ExecuteScalar();

                    if (resultado == null)
                    {
                        throw new InvalidOperationException(
                            "El préstamo no existe o ya fue devuelto.");
                    }

                    idLibro = Convert.ToInt32(resultado);
                }

                string actualizarPrestamo =
                    "UPDATE Prestamos SET ESTADO = 'DEVUELTO', " +
                    "FECHA_DEVOLUCION = @fecha " +
                    "WHERE id_prestamo = @idPrestamo";

                using (SqlCommand comando = new SqlCommand(actualizarPrestamo, conexion, transaccion))
                {
                    comando.Parameters.AddWithValue("@fecha", fechaDevolucion);
                    comando.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                    comando.ExecuteNonQuery();
                }

                string actualizarLibro =
                    "UPDATE Libros SET cantidad_disponible = cantidad_disponible + 1 " +
                    "WHERE id_libro = @idLibro";

                using (SqlCommand comando = new SqlCommand(actualizarLibro, conexion, transaccion))
                {
                    comando.Parameters.AddWithValue("@idLibro", idLibro);
                    comando.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
        }
    }

    public static void EliminarPrestamo(int idPrestamo)
    {
        using (SqlConnection conexion = Conexion.GetConnection())
        {
            conexion.Open();

            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                string consulta =
                    "SELECT id_libro, ESTADO FROM Prestamos " +
                    "WHERE id_prestamo = @idPrestamo";

                int idLibro = 0;
                string estado = "";

                using (SqlCommand comando = new SqlCommand(consulta, conexion, transaccion))
                {
                    comando.Parameters.AddWithValue("@idPrestamo", idPrestamo);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (!lector.Read())
                        {
                            throw new InvalidOperationException("El préstamo no existe.");
                        }

                        idLibro = Convert.ToInt32(lector["id_libro"]);
                        estado = lector["ESTADO"].ToString() ?? "";
                    }
                }

                if (estado == "ACTIVO")
                {
                    string actualizarLibro =
                        "UPDATE Libros SET cantidad_disponible = cantidad_disponible + 1 " +
                        "WHERE id_libro = @idLibro";

                    using (SqlCommand comando = new SqlCommand(actualizarLibro, conexion, transaccion))
                    {
                        comando.Parameters.AddWithValue("@idLibro", idLibro);
                        comando.ExecuteNonQuery();
                    }
                }

                string eliminar =
                    "DELETE FROM Prestamos WHERE id_prestamo = @idPrestamo";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion, transaccion))
                {
                    comando.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                    comando.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
        }
    }
    public static void ActualizarPrestamo(int idPrestamo, DateTime fechaEstimada)
    {
        using (SqlConnection conexion = Conexion.GetConnection())
        {
            conexion.Open();
            string consulta =
                "UPDATE Prestamos " +
                "SET FECHA_ESTIMADA_DEVOL = @fechaEstimada " +
                "WHERE id_prestamo = @idPrestamo AND ESTADO = 'ACTIVO'";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@fechaEstimada", fechaEstimada);
                comando.Parameters.AddWithValue("@idPrestamo", idPrestamo);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    throw new InvalidOperationException(
                        "No se pudo actualizar. Verifica que el préstamo esté activo.");
                }
            }
        }
    }




}


