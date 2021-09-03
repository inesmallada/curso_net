using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_RAZOR.Models;

namespace MVC_RAZOR.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            // Esto serviría para crear un libro: var libro = new Libro { Isbn = "1122", Titulo = "El principito", TipoLibro = "Novela" }; return View(libro);
            //Ahora montaremos una lista de libros
            var libros = new List<Libro>
            { 
                new Libro {Isbn = "1122", Titulo = "El principito", TipoLibro = "Novela" },
                new Libro {Isbn = "1133", Titulo = "Steve Jobs", TipoLibro = "Biografía" }
            };
            return View(libros);
        }
    }
}