using Microsoft.AspNetCore.Mvc;

namespace TurcellgelecegiYazanlar.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NoLayout()
        {
            return View();
        }
    }
}
