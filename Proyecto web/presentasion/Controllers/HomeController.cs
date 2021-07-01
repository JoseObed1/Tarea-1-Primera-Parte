using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.App_Data;
using System.Net;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        DBTest testeo = new DBTest();
        db_a7664c_tarea1Entities db = new db_a7664c_tarea1Entities();

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

        [HttpPost]
        public ActionResult GuardarPost(Foro datos)
        {
            if (db.Foro.Any(x => x.Nombre == datos.Nombre))
            { //Si existe en la db, dale patra
                ViewBag.Notification = "Ya existe ese foro";
                return RedirectToAction("nuevoPost", "Home");
            }
            else
            { //Si el foro no existe en la DB, lo creamos xD                
                testeo.NuevoForo(datos);
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult ForosPublicados()
        {
            return View(db.Foro.ToList());
        }

        public ActionResult VerForo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Foro foros = db.Foro.Find(id);
            if (foros == null)
            {
                return HttpNotFound();
            }
            return View(foros);
        }

        public ActionResult LoginRegister(string error)
        {
            return View();
        }        

        [HttpPost]
        public ActionResult Registro(Cuentas dato)
        {
            if(db.Cuentas.Any(x=> x.Correo == dato.Correo))
            { //Si existe en la db, dale patra
                ViewBag.Notification = "Ya existe esta cuenta";
                return RedirectToAction("LoginRegister", "Home");
            }
            else
            { //Si el usuario no existe en la DB, lo creamos xD                
                testeo.NuevoUsuario(dato);
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public ActionResult InicioSesion(Cuentas datoss)
        {
            var existe = db.Cuentas.Where(y => y.Correo.Equals(datoss.Correo) && y.Password.Equals(datoss.Password)).FirstOrDefault();

            if (existe != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Notification = "Email o contraseña incorrecta";
                return RedirectToAction("LoginRegister", "Home");
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