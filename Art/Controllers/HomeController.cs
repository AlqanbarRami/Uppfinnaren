using Microsoft.AspNetCore.Mvc;

namespace Art.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
