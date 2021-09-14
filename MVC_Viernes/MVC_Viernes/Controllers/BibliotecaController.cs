using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Viernes.Models;


namespace MVC_Viernes.Controllers
{
    public class BibliotecaController : Controller
    {   //creamos la clase biblioteca estatica para poder invocarla en el controlador
        static Biblioteca miBiblioteca = new Biblioteca();
        // GET: Biblioteca


        //Lanzamos ls vista para mostrar los libros
        public ActionResult Index()
        {
            return View(miBiblioteca.Libros.ToList());
        }

        // GET: Biblioteca/Details/5
        public ActionResult Details(string id)
        {
            return View(miBiblioteca.ObtenerPorIsbn(id));
        }

        // GET: Biblioteca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biblioteca/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            { // TODO: Add insert logic here
                miBiblioteca.Libros.Add(new Libro
                {
                    ISBN = (miBiblioteca.Libros.Count() + 1).ToString(),
                    Titulo = collection["Titulo"],
                    TipoLibro = collection["TipoLibro"]
                });
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Edit/5
        public ActionResult Edit(string id)
        {   
            return View(miBiblioteca.ObtenerPorIsbn (id));
        }

        // POST: Biblioteca/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {  foreach (Libro l in miBiblioteca.Libros)
                    if (l.ISBN == id)
                    {
                        l.Titulo = collection["Titulo"];
                        l.TipoLibro = collection["TipoLibro"];
                    }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          
        }

        // GET: Biblioteca/Delete/5
        public ActionResult Delete(string id)
        {
            return View(miBiblioteca.ObtenerPorIsbn(id));
        }
        //método de borrado donde buscamos el isbn del libro//        
        // POST: Biblioteca/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                foreach (Libro l in miBiblioteca.Libros)
                    {
                         if (l.ISBN == id) miBiblioteca.Libros.Remove(l);
                    }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
