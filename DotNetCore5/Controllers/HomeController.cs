using Microsoft.AspNetCore.Mvc;

namespace DotNetCore5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
