using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace BibliotecaApp.Negocio
{
    internal class Libro

    //declaramos propiedades 
    {
        public int IdLibro { get; set; }
        public string CodigoLibro { get; set; } = "";
        public string Titulo { get; set; } = "";
        public string ISBN { get; set; } = "";
        public string Categoria { get; set; } = "";
        public int Cantidad { get; set; }
        public int CantidadDisponible { get; set; }

        //PRIMER BOB EL CONSTRUCTOR
        public Libro()
        {
            Cantidad = 0;
            CantidadDisponible = 0;

        }

        // SEGUNDO CONSTRUCTOR

        public Libro(string codigo, string titulo, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new ArgumentException("Este espacio no puede quedar vacío.");
            } 

            if(string.IsNullOrWhiteSpace(titulo))
            {
                throw new ArgumentException("Este espacio no puede quedar vacío.");
            }

            if (cantidad < 0)
            {
                throw new ArgumentException("La cantidad no puede ser negativa.");
            }

            CodigoLibro = codigo;
            Titulo = titulo;
            Cantidad = cantidad;
            CantidadDisponible = cantidad;
        }

        public void PrestarLibro()
        {
            if (CantidadDisponible > 0)
            {
                CantidadDisponible--;
            }
            else
            {
                throw new InvalidOperationException("libros no disponibles para prestar.");
            }
        }

        public void DevolverLibro()
        {
            if (CantidadDisponible < Cantidad)
            {
                CantidadDisponible++;
            }
            else
            {
                throw new InvalidOperationException("No tiene libros activos para devolver.");
            }
        }

    }

}






