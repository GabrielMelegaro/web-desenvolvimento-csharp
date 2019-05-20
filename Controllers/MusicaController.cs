using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome, int vezes = 1) 
        {
            ViewData["Nome"] = nome;
            ViewData["Repeticoes"] = vezes;

            return View();
        }
    }
}