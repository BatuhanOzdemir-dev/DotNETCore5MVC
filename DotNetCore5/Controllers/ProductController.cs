using Microsoft.AspNetCore.Mvc;

namespace DotNetCore5.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
    }
}
