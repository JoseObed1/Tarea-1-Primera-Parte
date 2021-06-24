using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentacion.Models;
using System.Diagnostics;

namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult sobrenosotros()
        {
            return View();
        }

        public IActionResult nuevoPost()
        {
            return View();
        }

        public IActionResult LoginRegister()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
