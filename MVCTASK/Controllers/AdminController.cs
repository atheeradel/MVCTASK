using Microsoft.AspNetCore.Mvc;

namespace MVCTASK.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }

    }
}
