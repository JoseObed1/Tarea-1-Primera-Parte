using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        DBTest testeo = new DBTest();

        //private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public ActionResult Index()
        {
            //testeo.VisualizarDatos("1");
            return View();
        }

        public ActionResult sobrenosotros()
        {
            return View();
        }

        public ActionResult nuevoPost()
        {
            return View();
        }

        public ActionResult LoginRegister()
        {
            return View();
        }


        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Contactos()
        {
            return View();
        }
    }
}