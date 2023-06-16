using Microsoft.AspNetCore.Mvc;

namespace DiChoHaNoi.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Roles ="Admin")]
        [Area("Admin")]
        //[Route("admin.html", Name = "AdminIndex")]
        //[Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
