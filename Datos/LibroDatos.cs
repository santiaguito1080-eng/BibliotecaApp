using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Transactions;
using Microsoft.Data.SqlClient;


namespace BibliotecaApp.Datos
{
    internal class LibroDatos
    {
        public static DataTable ListarLibros()
            {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "SELECT id_libro,codigo_libro,titulo,ISBN,fecha_publicacion,categoria,id_editorial,cantidad,cantidad_disponible FROM Libros";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);

                }
            }
            return tabla;
    
         }
    
       public static DataTable BuscarLibros(string busqueda)

        {
            DataTable tabla = new DataTable();
            
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "SELECT DISTINCT L.id_libro, L.codigo_libro, L.titulo, L.ISBN, L.fecha_publicacion, L.categoria, L.id_editorial, L.cantidad, L.cantidad_disponible FROM Libros L LEFT JOIN LibroAutor LA ON L.id_libro = LA.id_libro LEFT JOIN Autores A ON LA.id_autor = A.id_autor WHERE L.codigo_libro LIKE @busqueda OR L.titulo LIKE @busqueda OR A.nombre LIKE @busqueda OR A.apellido LIKE @busqueda";
                using (SqlCommand comando = new SqlCommand(consulta,conexion))

                {
                 comando.Parameters.AddWithValue("@busqueda","%" + busqueda + "%");
                 conexion.Open();
                 SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                 adaptador.Fill(tabla);
                }
            }
            return tabla;

        }

        public static void RegistrarLibro(string codigo, string titulo, string isbn, DateTime fechaPublicacion, string categoria, int idEditorial, int cantidad, List<int> autores)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                conexion.Open();

                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string consulta = @"INSERT INTO Libros
                       (codigo_libro, titulo, ISBN, fecha_publicacion, categoria,
                        id_editorial, cantidad, cantidad_disponible)
                        VALUES
                        (@codigo, @titulo, @isbn, @fechaPublicacion, @categoria,
                        @idEditorial, @cantidad, @cantidadDisponible);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        int idLibro;

                        using (SqlCommand comando = new SqlCommand(consulta, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@codigo", codigo);
                            comando.Parameters.AddWithValue("@titulo", titulo);
                            comando.Parameters.AddWithValue("@isbn",
                                string.IsNullOrWhiteSpace(isbn) ? DBNull.Value : (object)isbn);
                            comando.Parameters.AddWithValue("@fechaPublicacion", fechaPublicacion);
                            comando.Parameters.AddWithValue("@categoria", categoria);
                            comando.Parameters.AddWithValue("@idEditorial", idEditorial);
                            comando.Parameters.AddWithValue("@cantidad", cantidad);
                            comando.Parameters.AddWithValue("@cantidadDisponible", cantidad);

                            idLibro = (int)comando.ExecuteScalar();
                        }

                        foreach (int idAutor in autores)
                        {
                            string consultaAutor = @"INSERT INTO LibroAutor
                (id_libro, id_autor)
                VALUES (@idLibro, @idAutor)";

                            using (SqlCommand comandoAutor = new SqlCommand(consultaAutor, conexion, transaccion))
                            {
                                comandoAutor.Parameters.AddWithValue("@idLibro", idLibro);
                                comandoAutor.Parameters.AddWithValue("@idAutor", idAutor);

                                comandoAutor.ExecuteNonQuery();
                            }
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

        }

        public static DataTable ListarAutores()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = "SELECT id_autor, nombre, apellido FROM Autores";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public static DataTable ListarAutoresPorLibro(int idLibro)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetConnection())
            {
                string consulta = @"SELECT id_autor
                            FROM LibroAutor
                            WHERE id_libro = @idLibro";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idLibro", idLibro);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public static void EditarLibro(int idLibro, string codigo, string titulo, string isbn, DateTime fechaPublicacion, string categoria, int idEditorial, int cantidad, List<int> autores)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                conexion.Open();

                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string consultaPrestamos = @"SELECT COUNT(*)
                                             FROM Prestamos
                                             WHERE id_libro = @idLibro
                                             AND ESTADO = 'ACTIVO'";

                        int prestamosActivos;

                        using (SqlCommand comando = new SqlCommand(consultaPrestamos, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@idLibro", idLibro);
                            prestamosActivos = (int)comando.ExecuteScalar();
                        }

                        if (cantidad < prestamosActivos)
                        {
                            throw new Exception("La cantidad total no puede ser menor que los libros que están prestados.");
                        }
                        int cantidadDisponible = cantidad - prestamosActivos;
                        string consulta = @"UPDATE Libros
                        SET codigo_libro = @codigo,
                       titulo = @titulo,
                       ISBN = @isbn,
                       fecha_publicacion = @fechaPublicacion,
                       categoria = @categoria,
                       id_editorial = @idEditorial,
                       cantidad = @cantidad,
                       cantidad_disponible = @cantidadDisponible
                       WHERE id_libro = @idLibro";
                        using (SqlCommand comando = new SqlCommand(consulta, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@codigo", codigo);
                            comando.Parameters.AddWithValue("@titulo", titulo);
                            comando.Parameters.AddWithValue("@isbn",
                            string.IsNullOrWhiteSpace(isbn) ? DBNull.Value : (object)isbn);
                            comando.Parameters.AddWithValue("@fechaPublicacion", fechaPublicacion);
                            comando.Parameters.AddWithValue("@categoria",
                            string.IsNullOrWhiteSpace(categoria) ? DBNull.Value : (object)categoria);
                            comando.Parameters.AddWithValue("@idEditorial", idEditorial);
                            comando.Parameters.AddWithValue("@cantidad", cantidad);
                            comando.Parameters.AddWithValue("@cantidadDisponible", cantidadDisponible);
                            comando.Parameters.AddWithValue("@idLibro", idLibro);
                            comando.ExecuteNonQuery();
                        }
                        string eliminarAutores = "DELETE FROM LibroAutor WHERE id_libro = @idLibro";
                        using (SqlCommand comandoEliminar = new SqlCommand(eliminarAutores, conexion, transaccion))
                        {
                            comandoEliminar.Parameters.AddWithValue("@idLibro", idLibro);
                            comandoEliminar.ExecuteNonQuery();
                        }
                        foreach (int idAutor in autores)
                        {
                            string insertarAutor = "INSERT INTO LibroAutor (id_libro, id_autor) VALUES (@idLibro, @idAutor)";
                            using (SqlCommand comandoAutor = new SqlCommand(insertarAutor, conexion, transaccion))
                            {
                                comandoAutor.Parameters.AddWithValue("@idLibro", idLibro);
                                comandoAutor.Parameters.AddWithValue("@idAutor", idAutor);
                                comandoAutor.ExecuteNonQuery();
                            }
                            
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
        }

        public static void EliminarLibro(int idLibro)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                conexion.Open();

                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string consultaPrestamos = @"SELECT COUNT(*)
                                             FROM Prestamos
                                             WHERE id_libro = @idLibro";

                        using (SqlCommand comando = new SqlCommand(consultaPrestamos, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@idLibro", idLibro);

                            int prestamos = (int)comando.ExecuteScalar();

                            if (prestamos > 0)
                            {
                                throw new Exception("No se puede eliminar este libro porque tiene historial de préstamos.");
                            }
                        }

                        string eliminarAutores = "DELETE FROM LibroAutor WHERE id_libro = @idLibro";

                        using (SqlCommand comando = new SqlCommand(eliminarAutores, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@idLibro", idLibro);
                            comando.ExecuteNonQuery();
                        }

                        string eliminarLibro = "DELETE FROM Libros WHERE id_libro = @idLibro";

                        using (SqlCommand comando = new SqlCommand(eliminarLibro, conexion, transaccion))
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
        }

    }
}




