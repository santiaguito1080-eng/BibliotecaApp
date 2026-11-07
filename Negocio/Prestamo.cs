using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaApp.Negocio
{
    internal class Prestamo
    {
     public int IdPrestamo { get; set; }
     public DateTime FechaPrestamo { get; set; }
     public DateTime? FechaDevolucion { get; set; }
     public DateTime FechaEstimadaDevolucion { get; set; }
     public string Estado { get; set; } = "";
     public int IdLibro { get; set; } 
     public int IdUsuario { get; set; } 


      public Prestamo(DateTime fechaprestamo, DateTime fechaestimadadevolucion,int idLibro,int idusuario)
        {
           if(fechaestimadadevolucion < fechaprestamo)
           {
               throw new ArgumentException("La fecha estimada de devolución no puede ser anterior a la fecha de préstamo.");
           }
          
           if (idLibro <= 0)
            {
                throw new ArgumentException("El ID del libro debe ser un número positivo.");
            }

            if (idusuario <= 0)
            {
                throw new ArgumentException("El ID del usuario debe ser un número positivo.");
            }


            FechaPrestamo = fechaprestamo;
            FechaEstimadaDevolucion = fechaestimadadevolucion;
            IdLibro = idLibro;
            IdUsuario = idusuario;

            Estado = "ACTIVO";

        }

        public void DevolverPrestamo()
        {
            if (Estado == "ACTIVO")
            {
                Estado = "DEVUELTO";
                FechaDevolucion = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("El préstamo ya ha sido devuelto.");
            }
        }




    }
}
