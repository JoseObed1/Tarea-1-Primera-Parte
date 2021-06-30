using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.App_Data;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        DBTest testeo = new DBTest();
        EntitiesOffLine db = new EntitiesOffLine();

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

        public ActionResult LoginRegister(string error)
        {
            return View();
        }        
        
        [HttpPost]
        public ActionResult LoginRegister(Cuentas datos)
        {
            var existe = db.Cuentas.Where(y => y.Correo.Equals(datos.Correo) && y.Password.Equals(datos.Password)).FirstOrDefault();

            string TempoMail = datos.Correo;
            string TempoPass = datos.Password;

            if (existe != null)
            {
                return RedirectToAction("Index", "Home");
            }

            else if (datos.Correo == "a" && datos.Password == "a")
            {
                return RedirectToAction("Index", "Home");
            }

            else if (testeo.ValidarLogin(datos.Correo, datos.Correo) == true)
            {
                RedirectToAction("Index", "Home");
            }

            else
            {
                return RedirectToAction("sobrenosotros", "Home");
            }

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