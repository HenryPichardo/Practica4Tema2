using ProyectoPropuestoPractica4Tema2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPropuestoPractica4Tema2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormularioVisita()
        {
            return View();

        }
        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string correo = Request.Form["correo"].ToString();
            string comentarios = Request.Form["comentarios"].ToString();
            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, cedula, telefono, correo, comentarios);
            return View();
        }
        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewData["Libro"] = todo;
            return View();
        }
    }
}