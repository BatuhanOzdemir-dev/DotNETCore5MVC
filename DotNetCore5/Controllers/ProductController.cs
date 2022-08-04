using DotNetCore5.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore5.Controllers
{
    public class ProductController : Controller
    {
        //public IActionResult GetProducts()
        //{
        //    return View();
        //}
        public ViewResult ViewProducts()
        {
            return View();
        }
        public PartialViewResult PartialViewProducts()
        {
            //Client tabanlı Ajax isteklerinde kullanıma yatkındır.
            return PartialView();
        }
        public JsonResult JsonProducts()
        {
            JsonResult result = Json(new Product
            {
                Id = 5,
                ProductName = "Terlik",
                Quantity = 15
            });
            return result;
        }
        public EmptyResult Empty()
        {
            //Can also use the void return type for the same effect.
            return new EmptyResult();
        }
        public ContentResult ContentResult()
        {
            //JSON gibi bi da daha çok Ajax için kullanılır.
            ContentResult result = Content("Content Result Text!");
            return result;
        }
        public ActionResult GetProducts()
        {
            //Includes all the return types.
            return View();
        }
        public IActionResult IGetProducts()
        {
            //Can return multiple returns.
            return View();
        }
    }
}
