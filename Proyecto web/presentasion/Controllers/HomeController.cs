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

        [HttpGet]
        public ActionResult LoginRegister()
        {
            return View();


        }        
        
        [HttpPost]
        public ActionResult LoginRegister(Cuentas datos)
        {
            if (ModelState.IsValid)
            {
                /*string tempomail = datos.Correo;
                string tempopass = datos.Password;
                if (Logeador.ValidarLogin(tempomail, tempopass) == true)
                {
                    TempData["Usuario"] = tempomail;
                    RedirectToAction("Login", new { data = data });
                    return View("Index", new { data });
                }

                else
                {
                    ViewBag.Mensaje = "Ese usuario no existe!";
                    return View();
                }*/

                return View();
            }

            else
            {
                ViewBag.Mensaje = "xD";
                return View();
            }
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