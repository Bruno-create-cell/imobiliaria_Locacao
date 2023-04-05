using imobiliariaLocacao.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace imobiliariaLocacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.nome = "BRUNO ALVES";
            home.Email = "ba174375@gmail.com";
            return View(home);
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
