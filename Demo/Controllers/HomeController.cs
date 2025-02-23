using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] //Get:BaseUrl/Home/Index
        public IActionResult Index()
        {
            //There is 4 overload of View
            return View();
          /// return View("Index");
          /// return View("Index", new Employee());
          /// return View(new Employee());    
        }
        [HttpGet] //Get:BaseUrl/Home/AboutUS
        public IActionResult AboutUs()
        {
            return View();
        }
        [HttpGet] //Get:BaseUrl/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet] //Get:BaseUrl/Home/ConcatUs
        public IActionResult ConcatUs()
        {
            return View();
        }
    }
}
