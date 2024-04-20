using Microsoft.AspNetCore.Mvc;

namespace AspProjectWebAppFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
