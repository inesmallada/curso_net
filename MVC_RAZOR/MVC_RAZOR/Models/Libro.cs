using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_RAZOR.Models
{
    public class Libro
    {
        public string Isbn { get; set;  }
        public string Titulo { get; set; }
        public string TipoLibro { get; set; }
    }
}