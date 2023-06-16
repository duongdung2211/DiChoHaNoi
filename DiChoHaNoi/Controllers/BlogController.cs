using Microsoft.AspNetCore.Mvc;

namespace DiChoHaNoi.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
