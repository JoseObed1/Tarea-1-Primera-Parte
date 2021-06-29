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
            if (ModelState.IsValid)
            {
                string tempomail = datos.Correo;
                string tempopass = datos.Password;

                if (testeo.ValidarLogin(tempomail, tempopass) == true)
                {
                    RedirectToAction("Index");
                    return View("Index");
                }

                else
                {
                    @ViewBag.Notification = "Ese usuario no existe!";
                    return View("LoginRegister");
                }
            }

            else
            {
                ViewBag.Mensaje = "xD";
                return View("LoginRegister");
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