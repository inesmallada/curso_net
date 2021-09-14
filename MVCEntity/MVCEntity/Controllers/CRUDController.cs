using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEntity.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult Index()
        {
            return View();
        }

        // GET: CRUD/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CRUD/Create
        public ActionResult Create()
        {
            return View();
        }
        //specify the type of attribute i.e
        //it will add the record to the database


        // POST: CRUD/Create
        [HttpPost]
        public ActionResult Create(Student model)
        {
           //to open a connection to the database using (var context = new demo)
        }

        // GET: CRUD/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CRUD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
