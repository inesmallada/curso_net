using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorMVC2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Método para vista calcular edad
        public ActionResult CalcularEdad()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcularEdad(int txtan, string txtn)
        {
            int actual = DateTime.Now.Year;
            int edad = actual - txtan;
            ViewBag.e = edad;
            ViewBag.n = txtn;
            ViewBag.an = txtan;
            return View();
        }

        //Método para una calculadora
        public ActionResult CalculaNumeros()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalculaNumeros(decimal num, decimal num2)
        {
            decimal suma = num + num2;
            decimal resta = num - num2;
            decimal multi = num * num2;
            decimal divi = num / num2;

            ViewBag.sum = suma;
            ViewBag.rest = resta;
            ViewBag.multi = multi;
            ViewBag.divi = divi;
            return View();
        }

        //Método para conversión de Celsius a Fahrenheit y pulgadas a milimetros
        public ActionResult Conversion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Conversion(decimal celsius, decimal fahren, decimal pulgadas, decimal mili)
        {
            fahren = ((9 / 5) * celsius) + 32;
            pulgadas = (1/4)*mili;
            @ViewBag.mili = pulgadas;
            @ViewBag.celsius = fahren;
            return View();
        }

        //Método para calcular los descuentos de ropa
        public ActionResult DescuentoCompra()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DescuentoCompra( decimal tarifa, decimal descuento, decimal importe)
        {
            tarifa = @ViewBag.tarifa;
            @ViewBag.descuento = tarifa * (descuento / 100);
            @ViewBag.importe =  tarifa - @ViewBag.descuento;
            return View();
        }

        //Método para calcular los descuentos de ropa
        a) El tanto por ciento de alumnos que han superado la asignatura.b) El tanto por ciento
de suspensos, aprobados, notables y sobresalientes de la asignatura.
    }
}