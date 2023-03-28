using Microsoft.AspNetCore.Mvc;

namespace ашкые_цуи_фзз.Controllers
{
    public class ProductController : Controller
    {
        public ContentResult GetInfo()
        {
            ContentResult result = new ContentResult();
            result.Content = "Product info";
            return result;
        }



        public ViewResult Detail()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "detail";
            return result;

           // return View();
        }
    }
}
