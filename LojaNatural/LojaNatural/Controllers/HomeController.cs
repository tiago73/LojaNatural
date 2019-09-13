using Microsoft.AspNetCore.Mvc;

namespace LojaNatural.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}