using Microsoft.AspNetCore.Mvc;

namespace TurcellgelecegiYazanlar.Controllers
{
    public class Product2
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            var productList = new List<Product2>()
            {
                new() {Id = 1, name= "Kalem" },
                new() {Id = 2, name= "Defter" },
                new() {Id = 3, name= "Silgi" }

            };
            ViewBag.name = "Asp.Net Core";
            ViewData["age"] = 30;
            ViewBag.name = "Ahmet";
            TempData["surname"] = "Yıldız";
            //ViewBag.name = new List<string>() { "Ahmet", "Mehmet", "Hasan"};
            ViewData["names"] = new List<string>() { "Ahmet", "Mehmet", "Hasan"};
            ViewBag.person = new { Id = 1, Name = "Ahmet", Age = 23 };
            return View(productList);
        }
        public IActionResult Index2()
        {
            var SurName = TempData["surname"];
            return View();
        }

        public IActionResult Index3()
        {

            //Veritabanı işlemnleri
            return RedirectToAction("Index","Ornek");
            //return View();
        }
        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }
        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id});
        }
        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }
        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "Kalem 1", price = 100 });
        }
        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
        
    }
}
