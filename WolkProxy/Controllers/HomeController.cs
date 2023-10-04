using Microsoft.AspNetCore.Mvc;

namespace Wolk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
