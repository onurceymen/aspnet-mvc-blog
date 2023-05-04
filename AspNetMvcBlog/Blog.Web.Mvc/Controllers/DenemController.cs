using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Mvc.Controllers
{
    public class DenemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
