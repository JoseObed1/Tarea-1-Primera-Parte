using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.App_Data;
using System.Net;
using System.Web.Security;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        DBTest testeo = new DBTest();
        db_a7664c_tarea1Entities db = new db_a7664c_tarea1Entities();
        string LoginError;

        public ActionResult Index()
        {
            return View(db.Foro.ToList());
        }

        public ActionResult sobrenosotros()
        {
            return View();
        }

        [Authorize]
        public ActionResult nuevoPost()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult GuardarPost(Foro datos)
        {
            var res = Request.Form["selec"];

            if (db.Foro.Any(x => x.Nombre == datos.Nombre))
            { //Si existe en la db, dale patra
                ViewBag.Notification = "Ya existe ese foro";
                return RedirectToAction("nuevoPost", "Home");
            }
            else
            { //Si el foro no existe en la DB, lo creamos xD
                datos.ID_Categoria = res.ToString();
                testeo.NuevoForo(datos);
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult ForosPublicados()
        {
            var ress = Request.Form["ForoCat"];

            return View(testeo.FiltrarForo(ress));
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

        public ActionResult LoginRegister()
        {
            ViewBag.Notification = TempData["error2"];
            ViewBag.ErrorLogin = TempData["error"];
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Cuentas dato)
        {
            if(db.Cuentas.Any(x=> x.Correo == dato.Correo))
            { //Si existe en la db, dale patra
                TempData["error2"] = "Ya existe esta cuenta";
                return RedirectToAction("LoginRegister", "Home", TempData["error2"]);
            }
            
            else
            { //Si el usuario no existe en la DB, lo creamos xD                
                testeo.NuevoUsuario(dato);
                Session["UserName"] = dato.Username.ToString();
                FormsAuthentication.SetAuthCookie(dato.Correo, true);
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InicioSesion(Cuentas datoss)
        {
            var existe = db.Cuentas.Where(y => y.Correo.Equals(datoss.Correo) && y.Password.Equals(datoss.Password)).FirstOrDefault();

            if (existe != null)
            {
                Session["UserName"] = existe.Username.ToString();
                FormsAuthentication.SetAuthCookie(datoss.Correo, true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                LoginError = "Email o contraseña incorrecta";
                TempData["error"] = "Email o contraseña incorrecta";
                return RedirectToAction("LoginRegister", "Home", TempData["error"]);
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
        public ActionResult LogOut()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}