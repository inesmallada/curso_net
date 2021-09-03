using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_RAZOR.Models
{
    public class Biblioteca
    {
        public List<Libro> Libros { get; set; }

        public Biblioteca()
        {
            Libros = new List<Libro>
            {
                new Libro
                {
                    Isbn = "11122",
                    Titulo = "Los Piratas del Caribe",
                    TipoLibro = "Novela"
                },
                new Libro
                {
                    Isbn = "22211",
                    Titulo = "Los Pilares de la tierra",
                    TipoLibro = "Novela"
                },
                new Libro
                {
                    Isbn = "33311",
                    Titulo = "Steve Jobs",
                    TipoLibro = "Biografía"
                }
            };
        }
    }    
}
   