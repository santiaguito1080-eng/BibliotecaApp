
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BibliotecaApp.Datos;

internal class ReporteDatos
{
    public static DataTable ConsultarReporte(string tipoReporte)
    {
        DataTable tabla = new DataTable();

        string consulta = "";

        switch (tipoReporte)
        {
            case "Listado de libros":
                consulta =
                    "SELECT l.codigo_libro, l.titulo, l.ISBN, " +
                    "l.categoria, e.nombre AS Editorial, " +
                    "l.cantidad, l.cantidad_disponible " +
                    "FROM Libros l " +
                    "INNER JOIN Editoriales e " +
                    "ON l.id_editorial = e.id_editorial";
                break;

            case "Listado de autores":
                consulta =
                    "SELECT id_autor, nombre, apellido, nacionalidad " +
                    "FROM Autores";
                break;

            case "Listado de editoriales":
                consulta =
                    "SELECT id_editorial, nombre, pais " +
                    "FROM Editoriales";
                break;

            case "Listado de usuarios":
                consulta =
                    "SELECT id_usuarios, NOMBRES, APELLIDOS, " +
                    "DOCUMENTO, TELEFONO, CORREO " +
                    "FROM Usuarios";
                break;

            case "Préstamos activos":
                consulta =
                    "SELECT p.id_prestamo, " +
                    "u.NOMBRES + ' ' + u.APELLIDOS AS Usuario, " +
                    "l.titulo AS Libro, " +
                    "p.FECHA_DE_PRESTAMO, " +
                    "p.FECHA_ESTIMADA_DEVOL, p.ESTADO " +
                    "FROM Prestamos p " +
                    "INNER JOIN Usuarios u ON p.id_usuarios = u.id_usuarios " +
                    "INNER JOIN Libros l ON p.id_libro = l.id_libro " +
                    "WHERE p.ESTADO = 'ACTIVO'";
                break;

            case "Préstamos devueltos":
                consulta =
                    "SELECT p.id_prestamo, " +
                    "u.NOMBRES + ' ' + u.APELLIDOS AS Usuario, " +
                    "l.titulo AS Libro, " +
                    "p.FECHA_DE_PRESTAMO, " +
                    "p.FECHA_ESTIMADA_DEVOL, " +
                    "p.FECHA_DEVOLUCION, p.ESTADO " +
                    "FROM Prestamos p " +
                    "INNER JOIN Usuarios u ON p.id_usuarios = u.id_usuarios " +
                    "INNER JOIN Libros l ON p.id_libro = l.id_libro " +
                    "WHERE p.ESTADO = 'DEVUELTO'";
                break;

            case "Historial de préstamos":
                consulta =
                    "SELECT p.id_prestamo, " +
                    "u.NOMBRES + ' ' + u.APELLIDOS AS Usuario, " +
                    "l.titulo AS Libro, " +
                    "p.FECHA_DE_PRESTAMO, " +
                    "p.FECHA_ESTIMADA_DEVOL, " +
                    "p.FECHA_DEVOLUCION, p.ESTADO " +
                    "FROM Prestamos p " +
                    "INNER JOIN Usuarios u ON p.id_usuarios = u.id_usuarios " +
                    "INNER JOIN Libros l ON p.id_libro = l.id_libro";
                break;

            default:
                throw new InvalidOperationException(
                    "Selecciona un tipo de reporte válido.");
        }

        using (SqlConnection conexion = Conexion.GetConnection())
        {
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
        }

        return tabla;
    }
}

