using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace MiPrimerProyectoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //localhost:4876/Home/Index
        public ActionResult Index()
        {
            ViewBag.Algo = "Soy algo";
            ViewBag.Alumnos = Alumno.Listar();
            return View();
        }
        public ActionResult Ver()
        {
            return View();
        }

        public ActionResult Guardar()
        {
            return RedirectToAction("Index");
        }

        //public ActionResult Alumno()
        //{
        //    return View();
        //}

        public ActionResult Profesores()
        {
            return View();
        }
    }
}